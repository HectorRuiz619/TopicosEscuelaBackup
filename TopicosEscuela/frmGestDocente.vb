Imports MySql.Data.MySqlClient

Public Class frmGestDocente

    Dim conexion As New ConnexionBD() ' Instancia de la clase ConnexionBD
    Dim isNewDocente As Boolean = False ' Bandera para determinar si es un nuevo registro

    ' Carga los docentes en el DataGridView cuando se abre el formulario
    Private Sub frmGestDocente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDocentes()
    End Sub

    ' Método para cargar los docentes en el DataGridView
    Private Sub CargarDocentes()
        Dim query As String = "SELECT claveDocente, nombre, perfil, estado FROM Docente"
        Dim command As New MySqlCommand(query, conexion.GetConnection())
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        dgvDocentes.DataSource = table
    End Sub

    ' Botón para buscar un docente por claveDocente
    Private Sub btnBuscarDocente_Click(sender As Object, e As EventArgs) Handles btnBuscarDocente.Click
        If txtClaveDocente.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingresa la clave del docente para buscar.")
            Return
        End If

        Dim query As String = "SELECT * FROM Docente WHERE claveDocente = @claveDocente"
        Dim command As New MySqlCommand(query, conexion.GetConnection())

        command.Parameters.AddWithValue("@claveDocente", txtClaveDocente.Text)

        Try
            Dim reader As MySqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                txtNombreDocente.Text = reader("nombre").ToString()
                txtPerfil.Text = reader("perfil").ToString()
                cmbEstado.Text = reader("estado").ToString()
                txtClaveDocente.Enabled = False ' Deshabilita el campo de clave después de la búsqueda
                btnAgregarDocente.Enabled = False ' Deshabilita el campo de clave después de la búsqueda
                isNewDocente = False ' No es un nuevo registro
            Else
                MessageBox.Show("Docente no encontrado.")
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al buscar el docente: " & ex.Message)
        End Try
    End Sub

    ' Botón para agregar un nuevo docente
    Private Sub btnAgregarDocente_Click(sender As Object, e As EventArgs) Handles btnAgregarDocente.Click
        If txtNombreDocente.Text.Trim() = "" Or txtPerfil.Text.Trim() = "" Or cmbEstado.Text.Trim() = "" Then
            MessageBox.Show("Por favor, completa todos los campos.")
            Return
        End If

        ' Verificar si el docente ya existe
        Dim queryCheck As String = "SELECT COUNT(*) FROM Docente WHERE nombre = @nombre"
        Dim commandCheck As New MySqlCommand(queryCheck, conexion.GetConnection())
        commandCheck.Parameters.AddWithValue("@nombre", txtNombreDocente.Text)

        Dim count As Integer = Convert.ToInt32(commandCheck.ExecuteScalar())

        If count > 0 Then
            MessageBox.Show("El docente ya existe. No se puede agregar un duplicado.")
            Return
        End If

        ' Si no existe, proceder a agregar el docente
        Dim query As String = "INSERT INTO Docente (claveDocente, nombre, perfil, estado) VALUES (@claveDocente, @nombre, @perfil, @estado)"
        Dim command As New MySqlCommand(query, conexion.GetConnection())

        command.Parameters.AddWithValue("@claveDocente", txtClaveDocente.Text)
        command.Parameters.AddWithValue("@nombre", txtNombreDocente.Text)
        command.Parameters.AddWithValue("@perfil", txtPerfil.Text)
        command.Parameters.AddWithValue("@estado", cmbEstado.Text)

        Try
            command.ExecuteNonQuery()
            MessageBox.Show("Docente agregado exitosamente.")
            CargarDocentes() ' Actualiza el DataGridView
        Catch ex As Exception
            MessageBox.Show("Error al agregar el docente: " & ex.Message)
        End Try
    End Sub

    ' Botón para modificar un docente existente
    Private Sub btnModificarDocente_Click(sender As Object, e As EventArgs) Handles btnModificarDocente.Click
        If txtClaveDocente.Text.Trim() = "" Or txtNombreDocente.Text.Trim() = "" Or txtPerfil.Text.Trim() = "" Or cmbEstado.Text.Trim() = "" Then
            MessageBox.Show("Por favor, selecciona un docente y modifica sus datos.")
            Return
        End If

        ' Verificar si otro docente ya existe con el mismo nombre, excluyendo el docente actual por su claveDocente
        Dim queryCheck As String = "SELECT COUNT(*) FROM Docente WHERE nombre = @nombre AND claveDocente <> @claveDocente"
        Dim commandCheck As New MySqlCommand(queryCheck, conexion.GetConnection())
        commandCheck.Parameters.AddWithValue("@nombre", txtNombreDocente.Text)
        commandCheck.Parameters.AddWithValue("@claveDocente", txtClaveDocente.Text)

        Dim count As Integer = Convert.ToInt32(commandCheck.ExecuteScalar())

        ' Si se encuentra un nombre duplicado en otro docente, mostrar mensaje de error
        If count > 0 Then
            MessageBox.Show("El nombre del docente ya existe. No se puede modificar a un nombre duplicado.")
            Return
        End If

        ' Modificar los datos del docente
        Dim query As String = "UPDATE Docente SET nombre = @nombre, perfil = @perfil, estado = @estado WHERE claveDocente = @claveDocente"
        Dim command As New MySqlCommand(query, conexion.GetConnection())

        command.Parameters.AddWithValue("@claveDocente", txtClaveDocente.Text)
        command.Parameters.AddWithValue("@nombre", txtNombreDocente.Text)
        command.Parameters.AddWithValue("@perfil", txtPerfil.Text)
        command.Parameters.AddWithValue("@estado", cmbEstado.Text)

        Try
            command.ExecuteNonQuery()
            MessageBox.Show("Docente modificado exitosamente.")
            CargarDocentes() ' Actualiza el DataGridView
        Catch ex As Exception
            MessageBox.Show("Error al modificar el docente: " & ex.Message)
        End Try
    End Sub

    ' Botón para limpiar los campos y habilitar el campo claveDocente
    Private Sub btnLimpiarDocente_Click(sender As Object, e As EventArgs) Handles btnLimpiarDocente.Click
        txtClaveDocente.Text = ""
        txtNombreDocente.Text = ""
        txtPerfil.Text = ""
        cmbEstado.SelectedIndex = -1 ' Limpiar el estado
        txtClaveDocente.Enabled = True ' Habilita nuevamente el campo claveDocente
        btnAgregarDocente.Enabled = True ' Habilita nuevamente el botón Agregar

        ' Establecer la bandera en True, ya que estamos preparando para un nuevo registro
        isNewDocente = True
    End Sub

    ' Evento para seleccionar un docente desde el DataGridView y cargarlo en los campos
    Private Sub dgvDocentes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDocentes.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvDocentes.Rows(e.RowIndex)
            txtClaveDocente.Text = row.Cells("claveDocente").Value.ToString()
            txtNombreDocente.Text = row.Cells("nombre").Value.ToString()
            txtPerfil.Text = row.Cells("perfil").Value.ToString()
            cmbEstado.Text = row.Cells("estado").Value.ToString()

            txtClaveDocente.Enabled = False ' Deshabilita el campo de clave cuando se selecciona un docente
            btnAgregarDocente.Enabled = False ' Deshabilita el botón Agregar cuando se selecciona un docente
            isNewDocente = False ' No es un nuevo registro
        End If
    End Sub

End Class
