Imports MySql.Data.MySqlClient

Public Class frmGestMaterias

    Dim conexion As New ConnexionBD() ' Instancia de la clase ConnexionBD
    Dim isNewMateria As Boolean = False ' Bandera para determinar si es un nuevo registro

    ' Carga las materias en el DataGridView cuando se abre el formulario
    Private Sub frmGestMaterias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarMaterias()
        CargarCarreras() ' Cargar las carreras en el ComboBox
    End Sub

    ' Método para cargar las materias en el DataGridView, incluyendo el nombre de la carrera
    Private Sub CargarMaterias()
        Dim query As String = "SELECT m.idMateria, m.nombre, m.unidades, c.nombre AS carrera " &
                              "FROM Materia m " &
                              "JOIN Carrera c ON m.idCarrera = c.idCarrera"

        Using command As New MySqlCommand(query, conexion.GetConnection())
            Using adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvMaterias.DataSource = table
            End Using
        End Using
    End Sub

    ' Método para cargar las carreras en el ComboBox
    Private Sub CargarCarreras()
        Dim conexion As New ConnexionBD()
        Dim conn As MySqlConnection = conexion.GetConnection()

        If conn IsNot Nothing Then
            Dim query As String = "SELECT idCarrera, nombre FROM Carrera"
            Dim command As New MySqlCommand(query, conn)

            Try
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                cmbIdCarrera.DataSource = table
                cmbIdCarrera.DisplayMember = "nombre"
                cmbIdCarrera.ValueMember = "idCarrera"
            Catch ex As MySqlException
                MessageBox.Show("Error al cargar las carreras: " & ex.Message)
            Finally
                conexion.CloseConnection(conn)
            End Try
        End If
    End Sub

    ' Botón para buscar una materia por ID
    Private Sub btnBuscarMateria_Click(sender As Object, e As EventArgs) Handles btnBuscarMateria.Click
        If String.IsNullOrWhiteSpace(txtClaveMateria.Text) Then
            MessageBox.Show("Por favor, ingresa el ID de la materia para buscar.")
            Return
        End If

        Dim query As String = "SELECT * FROM Materia WHERE idMateria = @idMateria"

        Using command As New MySqlCommand(query, conexion.GetConnection())
            command.Parameters.AddWithValue("@idMateria", txtClaveMateria.Text)

            Try
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        txtNombreMateria.Text = reader("nombre").ToString()
                        txtUnidades.Text = reader("unidades").ToString()
                        cmbIdCarrera.SelectedValue = reader("idCarrera").ToString()
                        txtClaveMateria.Enabled = False
                        btnAgregarMateria.Enabled = False
                        isNewMateria = False
                    Else
                        MessageBox.Show("Materia no encontrada.")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al buscar la materia: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Botón para agregar una nueva materia
    Private Sub btnAgregarMateria_Click(sender As Object, e As EventArgs) Handles btnAgregarMateria.Click
        If String.IsNullOrWhiteSpace(txtNombreMateria.Text) OrElse String.IsNullOrWhiteSpace(txtUnidades.Text) OrElse cmbIdCarrera.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, completa todos los campos.")
            Return
        End If

        ' Verificar si la materia ya existe
        Dim queryCheck As String = "SELECT COUNT(*) FROM Materia WHERE nombre = @nombre"

        Using commandCheck As New MySqlCommand(queryCheck, conexion.GetConnection())
            commandCheck.Parameters.AddWithValue("@nombre", txtNombreMateria.Text)

            Dim count As Integer = Convert.ToInt32(commandCheck.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("La materia ya existe. No se puede agregar un duplicado.")
                Return
            End If
        End Using

        ' Agregar la materia
        Dim query As String = "INSERT INTO Materia (nombre, unidades, idCarrera) VALUES (@nombre, @unidades, @idCarrera)"
        Using command As New MySqlCommand(query, conexion.GetConnection())
            command.Parameters.AddWithValue("@nombre", txtNombreMateria.Text)
            command.Parameters.AddWithValue("@unidades", txtUnidades.Text)
            command.Parameters.AddWithValue("@idCarrera", cmbIdCarrera.SelectedValue)

            Try
                command.ExecuteNonQuery()
                MessageBox.Show("Materia agregada exitosamente.")
                CargarMaterias() ' Actualiza el DataGridView
                LimpiarCampos() ' Limpiar todos los campos
            Catch ex As Exception
                MessageBox.Show("Error al agregar la materia: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Botón para modificar una materia existente
    Private Sub btnModificarMateria_Click(sender As Object, e As EventArgs) Handles btnModificarMateria.Click
        If String.IsNullOrWhiteSpace(txtClaveMateria.Text) OrElse String.IsNullOrWhiteSpace(txtNombreMateria.Text) OrElse String.IsNullOrWhiteSpace(txtUnidades.Text) OrElse cmbIdCarrera.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, selecciona una materia y modifica sus datos.")
            Return
        End If

        ' Verificar si otra materia ya existe con el mismo nombre, excluyendo la actual
        Dim queryCheck As String = "SELECT COUNT(*) FROM Materia WHERE nombre = @nombre AND idMateria <> @idMateria"

        Using commandCheck As New MySqlCommand(queryCheck, conexion.GetConnection())
            commandCheck.Parameters.AddWithValue("@nombre", txtNombreMateria.Text)
            commandCheck.Parameters.AddWithValue("@idMateria", txtClaveMateria.Text)

            Dim count As Integer = Convert.ToInt32(commandCheck.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("El nombre de la materia ya existe. No se puede modificar a un nombre duplicado.")
                Return
            End If
        End Using

        ' Modificar la materia actual
        Dim query As String = "UPDATE Materia SET nombre = @nombre, unidades = @unidades, idCarrera = @idCarrera WHERE idMateria = @idMateria"

        Using command As New MySqlCommand(query, conexion.GetConnection())
            command.Parameters.AddWithValue("@idMateria", txtClaveMateria.Text)
            command.Parameters.AddWithValue("@nombre", txtNombreMateria.Text)
            command.Parameters.AddWithValue("@unidades", txtUnidades.Text)
            command.Parameters.AddWithValue("@idCarrera", cmbIdCarrera.SelectedValue)

            Try
                command.ExecuteNonQuery()
                MessageBox.Show("Materia modificada exitosamente.")
                CargarMaterias() ' Actualiza el DataGridView
                LimpiarCampos() ' Limpiar todos los campos
            Catch ex As Exception
                MessageBox.Show("Error al modificar la materia: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Botón para limpiar los campos y habilitar el campo ID
    Private Sub btnLimpiarMateria_Click(sender As Object, e As EventArgs) Handles btnLimpiarMateria.Click
        LimpiarCampos()
    End Sub

    ' Función para limpiar todos los campos
    Private Sub LimpiarCampos()
        txtClaveMateria.Text = ""
        txtNombreMateria.Text = ""
        txtUnidades.Text = ""
        cmbIdCarrera.SelectedIndex = -1
        txtClaveMateria.Enabled = True
        btnAgregarMateria.Enabled = True
        isNewMateria = True
    End Sub

    ' Evento para seleccionar una materia desde el DataGridView y cargarla en los campos
    Private Sub dgvMaterias_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMaterias.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvMaterias.Rows(e.RowIndex)
            txtClaveMateria.Text = row.Cells("idMateria").Value.ToString()
            txtNombreMateria.Text = row.Cells("nombre").Value.ToString()
            txtUnidades.Text = row.Cells("unidades").Value.ToString()
            cmbIdCarrera.SelectedValue = row.Cells("carrera").Value.ToString()
            txtClaveMateria.Enabled = False
            btnAgregarMateria.Enabled = False
            isNewMateria = False
        End If
    End Sub

    ' Evento para deshabilitar el campo txtIdMateria cuando se selecciona txtNombreMateria
    Private Sub txtNombreMateria_Enter(sender As Object, e As EventArgs) Handles txtNombreMateria.Enter
        If isNewMateria Then
            txtClaveMateria.Text = "" ' Limpiar el contenido de txtIdMateria solo si es nuevo
        End If
        txtClaveMateria.Enabled = False
    End Sub

End Class
