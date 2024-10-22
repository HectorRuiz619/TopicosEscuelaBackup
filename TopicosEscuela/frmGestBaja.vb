Imports MySql.Data.MySqlClient

Public Class frmGestBaja

    ' --- Al cargar el formulario ---
    Private Sub frmGestBaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarAlumnos()
        CargarBajas()
        LimpiarCampos()
    End Sub

    ' --- Método para cargar alumnos en el ComboBox ---
    Private Sub CargarAlumnos()
        Dim conexion As New ConnexionBD()
        Dim conn As MySqlConnection = conexion.GetConnection()

        If conn IsNot Nothing Then
            ' Modificación: Cambié idNc a noControl
            Dim query As String = "SELECT noControl, nombre FROM alumno WHERE estatus = 'Activo'"
            Dim command As New MySqlCommand(query, conn)

            Try
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                cmbAlumnos.DataSource = table
                cmbAlumnos.DisplayMember = "nombre"
                cmbAlumnos.ValueMember = "noControl"
            Catch ex As MySqlException
                MessageBox.Show("Error al cargar los alumnos: " & ex.Message)
            Finally
                conexion.CloseConnection(conn)
            End Try
        End If
    End Sub

    ' --- Método para cargar las bajas en el DataGridView ---
    Private Sub CargarBajas()
        Dim conexion As New ConnexionBD()
        Dim conn As MySqlConnection = conexion.GetConnection()

        If conn IsNot Nothing Then
            ' Modificación: Cambié idNc a noControl
            Dim query As String = "SELECT baja.idBaja, alumno.nombre AS Alumno, baja.motivo, baja.fecha " &
                                  "FROM baja JOIN alumno ON baja.noControl = alumno.noControl"
            Dim command As New MySqlCommand(query, conn)

            Try
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                dgvBajas.DataSource = table
            Catch ex As MySqlException
                MessageBox.Show("Error al cargar las bajas: " & ex.Message)
            Finally
                conexion.CloseConnection(conn)
            End Try
        End If
    End Sub

    ' --- Botón Agregar ---
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ' Validar que los campos no estén vacíos
        If ValidarCampos() Then
            Dim conexion As New ConnexionBD()
            Dim conn As MySqlConnection = conexion.GetConnection()

            If conn IsNot Nothing Then
                ' Modificación: Cambié idNc a noControl
                Dim query As String = "INSERT INTO baja (noControl, motivo, fecha) VALUES (@noControl, @motivo, @fecha)"
                Dim command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@noControl", cmbAlumnos.SelectedValue)
                command.Parameters.AddWithValue("@motivo", txtRason.Text)
                command.Parameters.AddWithValue("@fecha", dtpFecha.Value.ToString("yyyy-MM-dd"))

                Try
                    command.ExecuteNonQuery()
                    MessageBox.Show("Baja agregada correctamente.")
                    CargarBajas()
                    LimpiarCampos()
                Catch ex As MySqlException
                    MessageBox.Show("Error al agregar la baja: " & ex.Message)
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
                ' Modificación: Cambié idNc a noControl
                Dim query As String = "UPDATE baja SET noControl = @noControl, motivo = @motivo, fecha = @fecha WHERE idBaja = @idBaja"
                Dim command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@noControl", cmbAlumnos.SelectedValue)
                command.Parameters.AddWithValue("@motivo", txtRason.Text)
                command.Parameters.AddWithValue("@fecha", dtpFecha.Value.ToString("yyyy-MM-dd"))
                command.Parameters.AddWithValue("@idBaja", txtIdBaja.Text)

                Try
                    command.ExecuteNonQuery()
                    MessageBox.Show("Baja modificada correctamente.")
                    CargarBajas()
                    LimpiarCampos()
                Catch ex As MySqlException
                    MessageBox.Show("Error al modificar la baja: " & ex.Message)
                Finally
                    conexion.CloseConnection(conn)
                End Try
            End If
        End If
    End Sub

    ' --- Botón Buscar ---
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtIdBaja.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingrese un ID de baja.")
            Return
        End If

        Dim conexion As New ConnexionBD()
        Dim conn As MySqlConnection = conexion.GetConnection()

        If conn IsNot Nothing Then
            Dim query As String = "SELECT * FROM baja WHERE idBaja = @idBaja"
            Dim command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@idBaja", txtIdBaja.Text)

            Try
                Dim reader As MySqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    ' Modificación: Cambié idNc a noControl
                    cmbAlumnos.SelectedValue = reader("noControl")
                    txtRason.Text = reader("motivo").ToString()
                    dtpFecha.Value = Convert.ToDateTime(reader("fecha").ToString())

                    btnAgregar.Enabled = False
                    btnModificar.Enabled = True
                Else
                    MessageBox.Show("No se encontró ninguna baja con ese ID.")
                    LimpiarCampos()
                End If

                reader.Close()
            Catch ex As MySqlException
                MessageBox.Show("Error al buscar la baja: " & ex.Message)
            Finally
                conexion.CloseConnection(conn)
            End Try
        End If
    End Sub

    ' --- Evento para seleccionar una fila del DataGridView ---
    Private Sub dgvBajas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBajas.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvBajas.Rows(e.RowIndex)

            ' Llenar los campos de texto y combo boxes con los valores de la fila seleccionada
            txtIdBaja.Text = row.Cells("idBaja").Value.ToString()
            cmbAlumnos.Text = row.Cells("Alumno").Value.ToString() ' Mostrar el nombre del alumno
            txtRason.Text = row.Cells("motivo").Value.ToString() ' Mostrar el motivo de la baja
            dtpFecha.Value = Convert.ToDateTime(row.Cells("fecha").Value) ' Mostrar la fecha de la baja

            ' Ajustar los botones
            btnAgregar.Enabled = False
            btnModificar.Enabled = True
        End If
    End Sub

    ' --- Método para limpiar los campos del formulario ---
    Private Sub LimpiarCampos()
        txtIdBaja.Clear()
        cmbAlumnos.SelectedIndex = -1
        txtRason.Clear()
        dtpFecha.Value = DateTime.Now

        btnAgregar.Enabled = True
        btnModificar.Enabled = False
        txtIdBaja.Enabled = True
    End Sub

    ' --- Método para validar que los campos no estén vacíos ---
    Private Function ValidarCampos() As Boolean
        If cmbAlumnos.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, selecciona un alumno.")
            Return False
        ElseIf txtRason.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingresa el motivo de la baja.")
            Return False
        End If
        Return True
    End Function

End Class
