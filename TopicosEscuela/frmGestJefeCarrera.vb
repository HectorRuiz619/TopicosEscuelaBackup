Imports MySql.Data.MySqlClient

Public Class frmGestJefeCarrera

    ' --- Al cargar el formulario ---
    Private Sub frmGestJefeCarrera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCarreras()
        CargarJefesCarrera()
        LimpiarCampos()
    End Sub

    ' --- Método para cargar las carreras en el ComboBox ---
    Private Sub CargarCarreras()
        Dim conexion As New ConnexionBD()
        Dim conn As MySqlConnection = conexion.GetConnection()

        If conn IsNot Nothing Then
            Dim query As String = "SELECT idCarrera, nombre FROM carrera"
            Dim command As New MySqlCommand(query, conn)

            Try
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                cmbCarrera.DataSource = table
                cmbCarrera.DisplayMember = "nombre"
                cmbCarrera.ValueMember = "idCarrera"
            Catch ex As MySqlException
                MessageBox.Show("Error al cargar las carreras: " & ex.Message)
            Finally
                conexion.CloseConnection(conn)
            End Try
        End If
    End Sub

    ' --- Método para cargar los jefes de carrera en el DataGridView ---
    Private Sub CargarJefesCarrera()
        Dim conexion As New ConnexionBD()
        Dim conn As MySqlConnection = conexion.GetConnection()

        If conn IsNot Nothing Then
            Dim query As String = "SELECT jefecarrera.idJefeCarrera, jefecarrera.nombre AS Jefe, carrera.nombre AS Carrera " &
                                  "FROM jefecarrera " &
                                  "JOIN carrera ON jefecarrera.idCarrera = carrera.idCarrera"
            Dim command As New MySqlCommand(query, conn)

            Try
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                dgvJefesCarrera.DataSource = table
            Catch ex As MySqlException
                MessageBox.Show("Error al cargar los jefes de carrera: " & ex.Message)
            Finally
                conexion.CloseConnection(conn)
            End Try
        End If
    End Sub

    ' --- Botón Agregar ---
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If ValidarCampos() Then
            Dim conexion As New ConnexionBD()
            Dim conn As MySqlConnection = conexion.GetConnection()

            If conn IsNot Nothing Then
                Dim query As String = "INSERT INTO jefecarrera (nombre, idCarrera) VALUES (@nombre, @idCarrera)"
                Dim command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@nombre", txtNombre.Text)
                command.Parameters.AddWithValue("@idCarrera", cmbCarrera.SelectedValue)

                Try
                    command.ExecuteNonQuery()
                    MessageBox.Show("Jefe de carrera agregado correctamente.")
                    CargarJefesCarrera()
                    LimpiarCampos()
                Catch ex As MySqlException
                    MessageBox.Show("Error al agregar el jefe de carrera: " & ex.Message)
                Finally
                    conexion.CloseConnection(conn)
                End Try
            End If
        End If
    End Sub

    ' --- Botón Modificar ---
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If ValidarCampos() Then
            Dim conexion As New ConnexionBD()
            Dim conn As MySqlConnection = conexion.GetConnection()

            If conn IsNot Nothing Then
                Dim query As String = "UPDATE jefecarrera SET nombre = @nombre, idCarrera = @idCarrera WHERE idJefeCarrera = @idJefeCarrera"
                Dim command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@nombre", txtNombre.Text)
                command.Parameters.AddWithValue("@idCarrera", cmbCarrera.SelectedValue)
                command.Parameters.AddWithValue("@idJefeCarrera", txtIdJefeCarrera.Text)

                Try
                    command.ExecuteNonQuery()
                    MessageBox.Show("Jefe de carrera modificado correctamente.")
                    CargarJefesCarrera()
                    LimpiarCampos()
                Catch ex As MySqlException
                    MessageBox.Show("Error al modificar el jefe de carrera: " & ex.Message)
                Finally
                    conexion.CloseConnection(conn)
                End Try
            End If
        End If
    End Sub

    ' --- Botón Buscar ---
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtIdJefeCarrera.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingrese un ID de jefe de carrera.")
            Return
        End If

        Dim conexion As New ConnexionBD()
        Dim conn As MySqlConnection = conexion.GetConnection()

        If conn IsNot Nothing Then
            Dim query As String = "SELECT * FROM jefecarrera WHERE idJefeCarrera = @idJefeCarrera"
            Dim command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@idJefeCarrera", txtIdJefeCarrera.Text)

            Try
                Dim reader As MySqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    txtNombre.Text = reader("nombre").ToString()
                    cmbCarrera.SelectedValue = reader("idCarrera")

                    btnAgregar.Enabled = False
                    btnModificar.Enabled = True
                Else
                    MessageBox.Show("No se encontró ningún jefe de carrera con ese ID.")
                    LimpiarCampos()
                End If

                reader.Close()
            Catch ex As MySqlException
                MessageBox.Show("Error al buscar el jefe de carrera: " & ex.Message)
            Finally
                conexion.CloseConnection(conn)
            End Try
        End If
    End Sub

    ' --- Botón Limpiar ---
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    ' --- Método para limpiar los campos del formulario ---
    Private Sub LimpiarCampos()
        txtIdJefeCarrera.Clear()
        txtNombre.Clear()
        cmbCarrera.SelectedIndex = -1

        btnAgregar.Enabled = True
        btnModificar.Enabled = False
    End Sub

    ' --- Método para validar que los campos no estén vacíos ---
    Private Function ValidarCampos() As Boolean
        If txtNombre.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingrese el nombre del jefe de carrera.")
            Return False
        ElseIf cmbCarrera.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, seleccione una carrera.")
            Return False
        End If

        Return True
    End Function

    ' --- Evento para seleccionar una fila del DataGridView ---
    Private Sub dgvJefesCarrera_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJefesCarrera.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvJefesCarrera.Rows(e.RowIndex)
            txtIdJefeCarrera.Text = row.Cells("idJefeCarrera").Value.ToString()
            txtNombre.Text = row.Cells("Jefe").Value.ToString()
            cmbCarrera.Text = row.Cells("Carrera").Value.ToString()

            btnAgregar.Enabled = False
            btnModificar.Enabled = True
        End If
    End Sub

End Class
