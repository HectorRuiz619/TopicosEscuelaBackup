Imports MySql.Data.MySqlClient

Public Class frmGestHorario
    ' --- Al cargar el formulario ---
    Private Sub frmGestHorario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarHorarios()
        LimpiarCampos()
    End Sub

    ' --- Método para cargar horarios en el DataGridView ---
    Private Sub CargarHorarios()
        Dim conexion As New ConnexionBD()
        Dim conn As MySqlConnection = conexion.GetConnection()

        If conn IsNot Nothing Then
            Dim query As String = "SELECT idHorario, semestre, opcion, promedio, idOferta, noControl FROM horario"
            Dim command As New MySqlCommand(query, conn)

            Try
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                dgvHorarios.DataSource = table
            Catch ex As MySqlException
                MessageBox.Show("Error al cargar los horarios: " & ex.Message)
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
                Dim query As String = "INSERT INTO horario (idHorario, semestre, opcion, promedio, idOferta, noControl) " &
                                      "VALUES (@idHorario, @semestre, @opcion, @promedio, @idOferta, @noControl)"
                Dim command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@idHorario", txtIdHorario.Text)
                command.Parameters.AddWithValue("@semestre", txtSemestre.Text)
                command.Parameters.AddWithValue("@opcion", txtOpcion.Text)
                command.Parameters.AddWithValue("@promedio", txtPromedio.Text)
                command.Parameters.AddWithValue("@idOferta", txtIdOferta.Text)
                command.Parameters.AddWithValue("@noControl", txtNControl.Text)

                Try
                    command.ExecuteNonQuery()
                    MessageBox.Show("Horario agregado correctamente.")
                    CargarHorarios()
                    LimpiarCampos()
                Catch ex As MySqlException
                    MessageBox.Show("Error al agregar el horario: " & ex.Message)
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
                Dim query As String = "UPDATE horario SET semestre = @semestre, opcion = @opcion, " &
                                      "promedio = @promedio, idOferta = @idOferta, noControl = @noControl " &
                                      "WHERE idHorario = @idHorario"
                Dim command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@idHorario", txtIdHorario.Text)
                command.Parameters.AddWithValue("@semestre", txtSemestre.Text)
                command.Parameters.AddWithValue("@opcion", txtOpcion.Text)
                command.Parameters.AddWithValue("@promedio", txtPromedio.Text)
                command.Parameters.AddWithValue("@idOferta", txtIdOferta.Text)
                command.Parameters.AddWithValue("@noControl", txtNControl.Text)

                Try
                    command.ExecuteNonQuery()
                    MessageBox.Show("Horario modificado correctamente.")
                    CargarHorarios()
                    LimpiarCampos()
                Catch ex As MySqlException
                    MessageBox.Show("Error al modificar el horario: " & ex.Message)
                Finally
                    conexion.CloseConnection(conn)
                End Try
            End If
        End If
    End Sub

    ' --- Botón Buscar ---
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtIdHorario.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingresa un ID de horario.")
            Return
        End If

        Dim conexion As New ConnexionBD()
        Dim conn As MySqlConnection = conexion.GetConnection()

        If conn IsNot Nothing Then
            Dim query As String = "SELECT * FROM horario WHERE idHorario = @idHorario"
            Dim command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@idHorario", txtIdHorario.Text)

            Try
                Dim reader As MySqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    txtSemestre.Text = reader("semestre").ToString()
                    txtOpcion.Text = reader("opcion").ToString()
                    txtPromedio.Text = reader("promedio").ToString()
                    txtIdOferta.Text = reader("idOferta").ToString()
                    txtNControl.Text = reader("noControl").ToString()

                    btnAgregar.Enabled = False
                    btnModificar.Enabled = True
                Else
                    MessageBox.Show("No se encontró ningún horario con ese ID.")
                    LimpiarCampos()
                End If

                reader.Close()
            Catch ex As MySqlException
                MessageBox.Show("Error al buscar el horario: " & ex.Message)
            Finally
                conexion.CloseConnection(conn)
            End Try
        End If
    End Sub

    ' --- Evento para seleccionar una fila del DataGridView ---
    Private Sub dgvHorarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHorarios.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvHorarios.Rows(e.RowIndex)

            txtIdHorario.Text = row.Cells("idHorario").Value.ToString()
            txtSemestre.Text = row.Cells("semestre").Value.ToString()
            txtOpcion.Text = row.Cells("opcion").Value.ToString()
            txtPromedio.Text = row.Cells("promedio").Value.ToString()
            txtIdOferta.Text = row.Cells("idOferta").Value.ToString()
            txtNControl.Text = row.Cells("noControl").Value.ToString()

            btnAgregar.Enabled = False
            btnModificar.Enabled = True
        End If
    End Sub

    ' --- Método para limpiar los campos del formulario ---
    Private Sub LimpiarCampos()
        txtIdHorario.Clear()
        txtSemestre.Clear()
        txtOpcion.Clear()
        txtPromedio.Clear()
        txtIdOferta.Clear()
        txtNControl.Clear()

        btnAgregar.Enabled = True
        btnModificar.Enabled = False
    End Sub

    ' --- Método para validar los campos ---
    Private Function ValidarCampos() As Boolean
        If txtSemestre.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingresa el semestre.")
            Return False
        ElseIf txtOpcion.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingresa la opción.")
            Return False
        ElseIf txtPromedio.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingresa el promedio.")
            Return False
        ElseIf txtIdOferta.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingresa el ID de la oferta.")
            Return False
        ElseIf txtNControl.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingresa el número de control.")
            Return False
        End If

        Return True
    End Function
End Class
