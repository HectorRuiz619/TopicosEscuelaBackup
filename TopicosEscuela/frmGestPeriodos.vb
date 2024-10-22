Imports MySql.Data.MySqlClient

Public Class frmGestPeriodos

    Dim conexion As New ConnexionBD() ' Instancia de la clase ConnexionBD
    Dim isNewPeriodo As Boolean = False ' Bandera para determinar si es un nuevo registro

    ' Carga los periodos en el DataGridView cuando se abre el formulario
    Private Sub frmGestPeriodos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPeriodos()
    End Sub

    ' Método para cargar los periodos en el DataGridView
    Private Sub CargarPeriodos()
        Dim query As String = "SELECT idPeriodo, fechaInicio, fechaFin, nombre FROM periodo" ' Ajusta la consulta SQL para reflejar los campos de tu base de datos
        Dim command As New MySqlCommand(query, conexion.GetConnection())
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        dgvPeriodos.DataSource = table

        ' Ajusta los encabezados del DataGridView si es necesario
        dgvPeriodos.Columns(0).HeaderText = "ID Periodo"
        dgvPeriodos.Columns(1).HeaderText = "Fecha Inicio"
        dgvPeriodos.Columns(2).HeaderText = "Fecha Fin"
        dgvPeriodos.Columns(3).HeaderText = "Nombre Periodo"
    End Sub

    ' Botón para buscar un periodo por ID
    Private Sub btnBuscarPeriodo_Click(sender As Object, e As EventArgs) Handles btnBuscarPeriodo.Click
        If txtIdPeriodo.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingresa el ID del periodo para buscar.")
            Return
        End If

        Dim query As String = "SELECT * FROM periodo WHERE idPeriodo = @idPeriodo"
        Dim command As New MySqlCommand(query, conexion.GetConnection())

        command.Parameters.AddWithValue("@idPeriodo", txtIdPeriodo.Text)

        Try
            Dim reader As MySqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                dtpFechaInicio.Value = Convert.ToDateTime(reader("fechaInicio"))
                dtpFechaFin.Value = Convert.ToDateTime(reader("fechaFin"))
                txtNombrePeriodo.Text = reader("nombre").ToString() ' Cargar el nombre del periodo
                txtIdPeriodo.Enabled = False ' Deshabilita el campo de ID después de la búsqueda
                btnAgregarPeriodo.Enabled = False ' Deshabilita el botón de agregar después de la búsqueda
                isNewPeriodo = False ' No es un nuevo registro
            Else
                MessageBox.Show("Periodo no encontrado.")
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al buscar el periodo: " & ex.Message)
        End Try
    End Sub

    ' Botón para agregar un nuevo periodo
    Private Sub btnAgregarPeriodo_Click(sender As Object, e As EventArgs) Handles btnAgregarPeriodo.Click
        ' Verificar que se hayan ingresado las fechas y el nombre
        If dtpFechaInicio.Value > dtpFechaFin.Value Then
            MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha de fin.")
            Return
        End If

        If txtNombrePeriodo.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingresa un nombre para el periodo.")
            Return
        End If

        ' Verificar si el periodo ya existe
        Dim queryCheck As String = "SELECT COUNT(*) FROM periodo WHERE fechaInicio = @fechaInicio AND fechaFin = @fechaFin"
        Dim commandCheck As New MySqlCommand(queryCheck, conexion.GetConnection())
        commandCheck.Parameters.AddWithValue("@fechaInicio", dtpFechaInicio.Value)
        commandCheck.Parameters.AddWithValue("@fechaFin", dtpFechaFin.Value)

        Dim count As Integer = Convert.ToInt32(commandCheck.ExecuteScalar())

        If count > 0 Then
            MessageBox.Show("El periodo ya existe. No se puede agregar un duplicado.")
            Return
        End If

        ' Si no existe, proceder a agregar el periodo
        Dim query As String = "INSERT INTO periodo (fechaInicio, fechaFin, nombre) VALUES (@fechaInicio, @fechaFin, @nombre)"
        Dim command As New MySqlCommand(query, conexion.GetConnection())

        command.Parameters.AddWithValue("@fechaInicio", dtpFechaInicio.Value)
        command.Parameters.AddWithValue("@fechaFin", dtpFechaFin.Value)
        command.Parameters.AddWithValue("@nombre", txtNombrePeriodo.Text)

        Try
            command.ExecuteNonQuery()
            MessageBox.Show("Periodo agregado exitosamente.")
            CargarPeriodos() ' Actualiza el DataGridView
        Catch ex As Exception
            MessageBox.Show("Error al agregar el periodo: " & ex.Message)
        End Try
    End Sub

    ' Botón para modificar un periodo existente
    Private Sub btnModificarPeriodo_Click(sender As Object, e As EventArgs) Handles btnModificarPeriodo.Click
        If txtIdPeriodo.Text.Trim() = "" Then
            MessageBox.Show("Por favor, selecciona un periodo para modificar.")
            Return
        End If

        ' Si no existe un duplicado, proceder a modificar el periodo actual
        Dim query As String = "UPDATE periodo SET fechaInicio = @fechaInicio, fechaFin = @fechaFin, nombre = @nombre WHERE idPeriodo = @idPeriodo"
        Dim command As New MySqlCommand(query, conexion.GetConnection())

        command.Parameters.AddWithValue("@idPeriodo", txtIdPeriodo.Text)
        command.Parameters.AddWithValue("@fechaInicio", dtpFechaInicio.Value)
        command.Parameters.AddWithValue("@fechaFin", dtpFechaFin.Value)
        command.Parameters.AddWithValue("@nombre", txtNombrePeriodo.Text)

        Try
            command.ExecuteNonQuery()
            MessageBox.Show("Periodo modificado exitosamente.")
            CargarPeriodos() ' Actualiza el DataGridView
        Catch ex As Exception
            MessageBox.Show("Error al modificar el periodo: " & ex.Message)
        End Try
    End Sub

    ' Botón para limpiar los campos y habilitar el campo ID
    Private Sub btnLimpiarPeriodo_Click(sender As Object, e As EventArgs) Handles btnLimpiarPeriodo.Click
        txtIdPeriodo.Text = ""
        dtpFechaInicio.Value = DateTime.Now
        dtpFechaFin.Value = DateTime.Now
        txtNombrePeriodo.Text = "" ' Limpiar el campo de nombre del periodo
        txtIdPeriodo.Enabled = True ' Habilita nuevamente el campo de ID
        btnAgregarPeriodo.Enabled = True ' Habilita nuevamente el botón de agregar

        ' Establecer la bandera en True, ya que estamos preparando para un nuevo registro
        isNewPeriodo = True
    End Sub

    ' Evento para seleccionar un periodo desde el DataGridView y cargarlo en los campos
    Private Sub dgvPeriodos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPeriodos.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvPeriodos.Rows(e.RowIndex)
            txtIdPeriodo.Text = row.Cells(0).Value.ToString() ' ID Periodo
            dtpFechaInicio.Value = Convert.ToDateTime(row.Cells(1).Value) ' Fecha Inicio
            dtpFechaFin.Value = Convert.ToDateTime(row.Cells(2).Value) ' Fecha Fin
            txtNombrePeriodo.Text = row.Cells(3).Value.ToString() ' Nombre del periodo

            txtIdPeriodo.Enabled = False ' Deshabilita el campo de ID cuando se selecciona un periodo
            btnAgregarPeriodo.Enabled = False ' Deshabilita el botón de agregar cuando se selecciona un periodo
            isNewPeriodo = False ' No es un nuevo registro
        End If
    End Sub
End Class
