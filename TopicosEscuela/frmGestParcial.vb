Imports MySql.Data.MySqlClient

Public Class frmGestParcial

    Dim conexion As New ConnexionBD() ' Instancia de la clase ConnexionBD
    Dim isNewParcial As Boolean = False ' Bandera para determinar si es un nuevo registro

    ' Carga los parciales en el DataGridView cuando se abre el formulario
    Private Sub frmGestParcial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarParciales()
        CargarPeriodos()
    End Sub

    ' Método para cargar los parciales en el DataGridView
    Private Sub CargarParciales()
        ' Ajusta la consulta SQL a los campos que tienes en la base de datos
        Dim query As String = "SELECT p.idParcial, p.fechaInicio, p.fechaFin, pe.nombre AS Periodo, p.estado " &
                              "FROM parcial p " &
                              "JOIN periodo pe ON p.idPeriodo = pe.idPeriodo"
        Dim command As New MySqlCommand(query, conexion.GetConnection())
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        ' Llena el DataGridView con las columnas especificadas
        adapter.Fill(table)
        dgvParciales.DataSource = table

        ' Opcionalmente, puedes ajustar los encabezados de las columnas en el DataGridView
        dgvParciales.Columns(0).HeaderText = "ID Parcial"
        dgvParciales.Columns(1).HeaderText = "Fecha de Inicio"
        dgvParciales.Columns(2).HeaderText = "Fecha de Fin"
        dgvParciales.Columns(3).HeaderText = "Periodo"
        dgvParciales.Columns(4).HeaderText = "Estado"
    End Sub

    ' Método para cargar los periodos en el ComboBox
    Private Sub CargarPeriodos()
        Dim query As String = "SELECT idPeriodo, nombre FROM periodo"
        Dim command As New MySqlCommand(query, conexion.GetConnection())
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        cmbIdParcial.DataSource = table
        cmbIdParcial.DisplayMember = "nombre"
        cmbIdParcial.ValueMember = "idPeriodo"
        cmbIdParcial.SelectedIndex = -1
    End Sub

    ' Botón para buscar un parcial por ID
    Private Sub btnBuscarParcial_Click(sender As Object, e As EventArgs) Handles btnBuscarParcial.Click
        If txtidPeriodo.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingresa el ID del parcial para buscar.")
            Return
        End If

        Dim query As String = "SELECT * FROM parcial WHERE idParcial = @idParcial"
        Dim command As New MySqlCommand(query, conexion.GetConnection())

        command.Parameters.AddWithValue("@idParcial", txtidPeriodo.Text)

        Try
            Dim reader As MySqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                dtpFechaInicio.Value = Convert.ToDateTime(reader("fechaInicio"))
                dtpFechaFin.Value = Convert.ToDateTime(reader("fechaFin"))
                cmbIdParcial.SelectedValue = reader("idPeriodo")
                cmbEstado.Text = reader("estado").ToString() ' Cargar el estado
                txtidPeriodo.Enabled = False ' Deshabilita el campo de ID después de la búsqueda
                btnAgregarParcial.Enabled = False ' Deshabilita el botón de agregar después de la búsqueda
                isNewParcial = False ' No es un nuevo registro
            Else
                MessageBox.Show("Parcial no encontrado.")
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al buscar el parcial: " & ex.Message)
        End Try
    End Sub

    ' Botón para agregar un nuevo parcial
    Private Sub btnAgregarParcial_Click(sender As Object, e As EventArgs) Handles btnAgregarParcial.Click
        ' Verificar que se hayan ingresado las fechas
        If dtpFechaInicio.Value > dtpFechaFin.Value Then
            MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha de fin.")
            Return
        End If

        ' Verificar si el parcial ya existe
        Dim queryCheck As String = "SELECT COUNT(*) FROM parcial WHERE fechaInicio = @fechaInicio AND fechaFin = @fechaFin"
        Dim commandCheck As New MySqlCommand(queryCheck, conexion.GetConnection())
        commandCheck.Parameters.AddWithValue("@fechaInicio", dtpFechaInicio.Value)
        commandCheck.Parameters.AddWithValue("@fechaFin", dtpFechaFin.Value)

        Dim count As Integer = Convert.ToInt32(commandCheck.ExecuteScalar())

        If count > 0 Then
            MessageBox.Show("El parcial ya existe. No se puede agregar un duplicado.")
            Return
        End If

        ' Si no existe, proceder a agregar el parcial
        Dim query As String = "INSERT INTO parcial (fechaInicio, fechaFin, idPeriodo, estado) VALUES (@fechaInicio, @fechaFin, @idPeriodo, @estado)"
        Dim command As New MySqlCommand(query, conexion.GetConnection())

        command.Parameters.AddWithValue("@fechaInicio", dtpFechaInicio.Value)
        command.Parameters.AddWithValue("@fechaFin", dtpFechaFin.Value)
        command.Parameters.AddWithValue("@idPeriodo", cmbIdParcial.SelectedValue)
        command.Parameters.AddWithValue("@estado", cmbEstado.Text)

        Try
            command.ExecuteNonQuery()
            MessageBox.Show("Parcial agregado exitosamente.")
            CargarParciales() ' Actualiza el DataGridView
        Catch ex As Exception
            MessageBox.Show("Error al agregar el parcial: " & ex.Message)
        End Try
    End Sub

    ' Botón para modificar un parcial existente
    Private Sub btnModificarParcial_Click(sender As Object, e As EventArgs) Handles btnModificarParcial.Click
        If txtidPeriodo.Text.Trim() = "" Then
            MessageBox.Show("Por favor, selecciona un parcial para modificar.")
            Return
        End If

        ' Si no existe un duplicado, proceder a modificar el parcial actual
        Dim query As String = "UPDATE parcial SET fechaInicio = @fechaInicio, fechaFin = @fechaFin, idPeriodo = @idPeriodo, estado = @estado WHERE idParcial = @idParcial"
        Dim command As New MySqlCommand(query, conexion.GetConnection())

        command.Parameters.AddWithValue("@idParcial", txtidPeriodo.Text)
        command.Parameters.AddWithValue("@fechaInicio", dtpFechaInicio.Value)
        command.Parameters.AddWithValue("@fechaFin", dtpFechaFin.Value)
        command.Parameters.AddWithValue("@idPeriodo", cmbIdParcial.SelectedValue)
        command.Parameters.AddWithValue("@estado", cmbEstado.Text)

        Try
            command.ExecuteNonQuery()
            MessageBox.Show("Parcial modificado exitosamente.")
            CargarParciales() ' Actualiza el DataGridView
        Catch ex As Exception
            MessageBox.Show("Error al modificar el parcial: " & ex.Message)
        End Try
    End Sub

    ' Botón para limpiar los campos y habilitar el campo ID
    Private Sub btnLimpiarParcial_Click(sender As Object, e As EventArgs) Handles btnLimpiarParcial.Click
        txtidPeriodo.Text = ""
        dtpFechaInicio.Value = DateTime.Now
        dtpFechaFin.Value = DateTime.Now
        cmbIdParcial.SelectedIndex = -1 ' Limpiar la selección de periodo
        cmbEstado.SelectedIndex = -1 ' Limpiar la selección del estado
        txtidPeriodo.Enabled = True ' Habilita nuevamente el campo de ID
        btnAgregarParcial.Enabled = True ' Habilita nuevamente el botón de agregar

        ' Establecer la bandera en True, ya que estamos preparando para un nuevo registro
        isNewParcial = True
    End Sub

    ' Evento para seleccionar un parcial desde el DataGridView y cargarlo en los campos
    Private Sub dgvParciales_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvParciales.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvParciales.Rows(e.RowIndex)

            ' Convertir el valor de la celda a los tipos correctos
            txtidPeriodo.Text = row.Cells("idParcial").Value.ToString()
            dtpFechaInicio.Value = DateTime.Parse(row.Cells("fechaInicio").Value.ToString())
            dtpFechaFin.Value = DateTime.Parse(row.Cells("fechaFin").Value.ToString())
            cmbIdParcial.SelectedIndex = cmbIdParcial.FindStringExact(row.Cells("Periodo").Value.ToString()) ' Selecciona el valor correcto del periodo
            cmbEstado.Text = row.Cells("estado").ToString() ' Llenar el estado

            txtidPeriodo.Enabled = False ' Deshabilita el campo de ID cuando se selecciona un parcial
            btnAgregarParcial.Enabled = False ' Deshabilita el botón de agregar cuando se selecciona un parcial
            isNewParcial = False ' No es un nuevo registro
        End If
    End Sub
End Class
