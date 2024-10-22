Imports MySql.Data.MySqlClient

Public Class frmGestCarrera

    Dim conexion As New ConnexionBD() ' Instancia de la clase ConnexionBD
    Dim isNewCarrera As Boolean = False ' Bandera para determinar si es un nuevo registro

    ' Carga las carreras en el DataGridView cuando se abre el formulario
    Private Sub frmGestCarrera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCarreras()
    End Sub

    ' Método para cargar las carreras en el DataGridView
    Private Sub CargarCarreras()
        Dim query As String = "SELECT claveCarrera, nombre, estado, idJefe FROM Carrera"
        Dim command As New MySqlCommand(query, conexion.GetConnection())
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        dgvCarreras.DataSource = table
    End Sub

    ' Botón para buscar una carrera por claveCarrera
    Private Sub btnBuscarCarrera_Click(sender As Object, e As EventArgs) Handles btnBuscarCarrera.Click
        If txtClaveCarrera.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingresa la clave de la carrera para buscar.")
            Return
        End If

        Dim query As String = "SELECT * FROM Carrera WHERE claveCarrera = @claveCarrera"
        Dim command As New MySqlCommand(query, conexion.GetConnection())

        command.Parameters.AddWithValue("@claveCarrera", txtClaveCarrera.Text)

        Try
            Dim reader As MySqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                txtNombreCarrera.Text = reader("nombre").ToString()
                txtEstado.Text = reader("estado").ToString()
                cmbIdJefe.SelectedValue = reader("idJefe").ToString()
                txtClaveCarrera.Enabled = False ' Deshabilita el campo de clave después de la búsqueda
                btnAgregarCarrera.Enabled = False ' Deshabilita el campo de agregar después de la búsqueda
                isNewCarrera = False ' No es un nuevo registro
            Else
                MessageBox.Show("Carrera no encontrada.")
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al buscar la carrera: " & ex.Message)
        End Try
    End Sub

    ' Botón para agregar una nueva carrera
    Private Sub btnAgregarCarrera_Click(sender As Object, e As EventArgs) Handles btnAgregarCarrera.Click
        If txtNombreCarrera.Text.Trim() = "" Or txtEstado.Text.Trim() = "" Or cmbIdJefe.SelectedValue Is Nothing Then
            MessageBox.Show("Por favor, completa todos los campos.")
            Return
        End If

        ' Verificar si la carrera ya existe
        Dim queryCheck As String = "SELECT COUNT(*) FROM Carrera WHERE nombre = @nombre"
        Dim commandCheck As New MySqlCommand(queryCheck, conexion.GetConnection())
        commandCheck.Parameters.AddWithValue("@nombre", txtNombreCarrera.Text)

        Dim count As Integer = Convert.ToInt32(commandCheck.ExecuteScalar())

        If count > 0 Then
            MessageBox.Show("La carrera ya existe. No se puede agregar un duplicado.")
            Return
        End If

        ' Si no existe, proceder a agregar la carrera
        Dim query As String = "INSERT INTO Carrera (claveCarrera, nombre, estado, idJefe) VALUES (@claveCarrera, @nombre, @estado, @idJefe)"
        Dim command As New MySqlCommand(query, conexion.GetConnection())

        command.Parameters.AddWithValue("@claveCarrera", txtClaveCarrera.Text)
        command.Parameters.AddWithValue("@nombre", txtNombreCarrera.Text)
        command.Parameters.AddWithValue("@estado", txtEstado.Text)
        command.Parameters.AddWithValue("@idJefe", cmbIdJefe.SelectedValue)

        Try
            command.ExecuteNonQuery()
            MessageBox.Show("Carrera agregada exitosamente.")
            CargarCarreras() ' Actualiza el DataGridView
        Catch ex As Exception
            MessageBox.Show("Error al agregar la carrera: " & ex.Message)
        End Try
    End Sub

    ' Botón para modificar una carrera existente
    Private Sub btnModificarCarrera_Click(sender As Object, e As EventArgs) Handles btnModificarCarrera.Click
        If txtClaveCarrera.Text.Trim() = "" Or txtNombreCarrera.Text.Trim() = "" Or txtEstado.Text.Trim() = "" Or cmbIdJefe.SelectedValue Is Nothing Then
            MessageBox.Show("Por favor, selecciona una carrera y modifica sus datos.")
            Return
        End If

        ' Verificar si otra carrera ya existe con el mismo nombre, excluyendo la carrera actual por su clave
        Dim queryCheck As String = "SELECT COUNT(*) FROM Carrera WHERE nombre = @nombre AND claveCarrera <> @claveCarrera"
        Dim commandCheck As New MySqlCommand(queryCheck, conexion.GetConnection())
        commandCheck.Parameters.AddWithValue("@nombre", txtNombreCarrera.Text)
        commandCheck.Parameters.AddWithValue("@claveCarrera", txtClaveCarrera.Text)

        Dim count As Integer = Convert.ToInt32(commandCheck.ExecuteScalar())

        ' Si se encuentra un nombre duplicado en otra carrera, mostrar mensaje de error
        If count > 0 Then
            MessageBox.Show("El nombre de la carrera ya existe. No se puede modificar a un nombre duplicado.")
            Return
        End If

        ' Si no existe un duplicado, proceder a modificar la carrera actual
        Dim query As String = "UPDATE Carrera SET nombre = @nombre, estado = @estado, idJefe = @idJefe WHERE claveCarrera = @claveCarrera"
        Dim command As New MySqlCommand(query, conexion.GetConnection())

        command.Parameters.AddWithValue("@claveCarrera", txtClaveCarrera.Text)
        command.Parameters.AddWithValue("@nombre", txtNombreCarrera.Text)
        command.Parameters.AddWithValue("@estado", txtEstado.Text)
        command.Parameters.AddWithValue("@idJefe", cmbIdJefe.SelectedValue)

        Try
            command.ExecuteNonQuery()
            MessageBox.Show("Carrera modificada exitosamente.")
            CargarCarreras() ' Actualiza el DataGridView
        Catch ex As Exception
            MessageBox.Show("Error al modificar la carrera: " & ex.Message)
        End Try
    End Sub

    ' Botón para limpiar los campos y habilitar el campo clave
    Private Sub btnLimpiarCarrera_Click(sender As Object, e As EventArgs) Handles btnLimpiarCarrera.Click
        txtClaveCarrera.Text = ""
        txtNombreCarrera.Text = ""
        txtEstado.Text = ""
        cmbIdJefe.SelectedIndex = -1 ' Limpiar la selección de jefe de carrera
        txtClaveCarrera.Enabled = True ' Habilita nuevamente el campo de clave
        btnAgregarCarrera.Enabled = True ' Habilita nuevamente el campo de agregar

        ' Establecer la bandera en True, ya que estamos preparando para un nuevo registro
        isNewCarrera = True
    End Sub

    ' Evento para seleccionar una carrera desde el DataGridView y cargarla en los campos
    Private Sub dgvCarreras_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCarreras.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvCarreras.Rows(e.RowIndex)
            txtClaveCarrera.Text = row.Cells("claveCarrera").Value.ToString()
            txtNombreCarrera.Text = row.Cells("nombre").Value.ToString()
            txtEstado.Text = row.Cells("estado").Value.ToString()
            cmbIdJefe.SelectedValue = row.Cells("idJefe").Value.ToString() ' Cargar el jefe de carrera

            txtClaveCarrera.Enabled = False ' Deshabilita el campo de clave cuando se selecciona una carrera
            btnAgregarCarrera.Enabled = False ' Deshabilita el botón Agregar cuando se selecciona una carrera
            isNewCarrera = False ' No es un nuevo registro
        End If
    End Sub

End Class
