Imports MySql.Data.MySqlClient

Public Class frmGestCalificaciones
    ' --- Al cargar el formulario ---
    Private Sub frmGestCalificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarAlumnos()
        CargarMaterias()
        CargarDocentes()
        CargarPeriodos()
        CargarParciales()
        CargarHorarios()
        CargarCalificaciones() ' Método para cargar el DataGridView
        LimpiarCampos() ' Limpiar campos al cargar el formulario
        txtIdCalificacion.Enabled = True ' Habilitar el campo de ID al inicio
    End Sub

    ' --- Botón Buscar por ID ---
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ' Verificar si el campo txtIdCalificacion no está vacío
        If txtIdCalificacion.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingresa un ID de calificación.")
            Return
        End If

        Dim conexion As New ConnexionBD()
        Dim conn As MySqlConnection = conexion.GetConnection()

        If conn IsNot Nothing Then
            ' Consulta para buscar una calificación por su ID
            Dim query As String = "SELECT * FROM calificacion WHERE idCalificacion = @idCalificacion"
            Dim command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@idCalificacion", txtIdCalificacion.Text)

            Try
                Dim reader As MySqlDataReader = command.ExecuteReader()

                ' Si se encuentra la calificación, llenamos los campos
                If reader.Read() Then
                    txtUnidad.Text = reader("unidad").ToString()
                    cmbAlumno.SelectedValue = reader("noControl")
                    cmbMateria.SelectedValue = reader("idMateria")
                    cmbDocente.SelectedValue = reader("idDocente")
                    txtCalificacion.Text = reader("calificacion").ToString()
                    cmbHorario.SelectedValue = reader("idHorario")
                    cmbPeriodo.SelectedValue = reader("idPeriodo")
                    cmbParcial.SelectedValue = reader("idParcial")

                    ' Habilitar Modificar y deshabilitar Agregar
                    btnAgregar.Enabled = False
                    btnModificar.Enabled = True
                Else
                    MessageBox.Show("No se encontró ninguna calificación con ese ID.")
                    btnAgregar.Enabled = True
                    btnModificar.Enabled = False
                End If
                reader.Close()
            Catch ex As MySqlException
                MessageBox.Show("Error al buscar la calificación: " & ex.Message)
            Finally
                conexion.CloseConnection(conn)
            End Try
        End If
    End Sub

    ' --- Método para cargar datos en el DataGridView ---
    Private Sub CargarCalificaciones()
        Dim conexion As New ConnexionBD()
        Dim conn As MySqlConnection = conexion.GetConnection()

        If conn IsNot Nothing Then
            ' Cambiar la consulta para mostrar los nombres de los periodos y parciales
            Dim query As String = "SELECT calificacion.idCalificacion, calificacion.unidad, alumno.nombre AS Alumno, " &
                              "materia.nombre AS Materia, docente.nombre AS Docente, " &
                              "calificacion.calificacion, CONCAT(horario.dia, ' ', horario.horaInicio, '-', horario.horaFin) AS Horario, " &
                              "periodo.nombre AS Periodo, parcial.nombre AS Parcial " &
                              "FROM calificacion " &
                              "JOIN alumno ON calificacion.noControl = alumno.noControl " &  ' Cambié idNc por noControl
                              "JOIN materia ON calificacion.idMateria = materia.idMateria " &
                              "JOIN docente ON calificacion.idDocente = docente.idDocente " &
                              "JOIN horario ON calificacion.idHorario = horario.idHorario " &
                              "JOIN periodo ON calificacion.idPeriodo = periodo.idPeriodo " &
                              "JOIN parcial ON calificacion.idParcial = parcial.idParcial"

            Dim command As New MySqlCommand(query, conn)

            Try
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                If table.Rows.Count > 0 Then
                    dgvCalificaciones.DataSource = table
                Else
                    MessageBox.Show("No se encontraron registros.")
                End If
            Catch ex As MySqlException
                MessageBox.Show("Error al cargar las calificaciones: " & ex.Message)
            Finally
                conexion.CloseConnection(conn)
            End Try
        End If
    End Sub


    ' --- Evento para seleccionar una fila del DataGridView ---
    Private Sub dgvCalificaciones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCalificaciones.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvCalificaciones.Rows(e.RowIndex)

            ' Llenar los campos de texto y combo boxes con los valores de la fila seleccionada
            txtIdCalificacion.Text = row.Cells("idCalificacion").Value.ToString()
            txtUnidad.Text = row.Cells("unidad").Value.ToString()

            cmbAlumno.Text = row.Cells("Alumno").Value.ToString() ' Texto del alumno
            cmbMateria.Text = row.Cells("Materia").Value.ToString() ' Texto de la materia
            cmbDocente.Text = row.Cells("Docente").Value.ToString() ' Texto del docente
            txtCalificacion.Text = row.Cells("calificacion").Value.ToString()
            cmbHorario.Text = row.Cells("Horario").Value.ToString() ' Texto del horario
            cmbPeriodo.Text = row.Cells("Periodo").Value.ToString() ' Texto del periodo
            cmbParcial.Text = row.Cells("Parcial").Value.ToString() ' Texto del parcial

            ' Ajustar los botones
            btnAgregar.Enabled = False
            btnModificar.Enabled = True
            txtIdCalificacion.Enabled = False ' Deshabilitar el campo de ID cuando se selecciona una calificación
        End If
    End Sub


    ' --- Métodos para cargar datos en los ComboBox ---
    Private Sub CargarAlumnos()
        Dim conexion As New ConnexionBD()
        Dim conn As MySqlConnection = conexion.GetConnection()

        If conn IsNot Nothing Then
            Dim query As String = "SELECT noControl, nombre FROM alumno"  ' Cambié idNc por noControl
            Dim command As New MySqlCommand(query, conn)

            Try
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                cmbAlumno.DataSource = table
                cmbAlumno.DisplayMember = "nombre"
                cmbAlumno.ValueMember = "noControl"
            Catch ex As MySqlException
                MessageBox.Show("Error al cargar los alumnos: " & ex.Message)
            Finally
                conexion.CloseConnection(conn)
            End Try
        End If
    End Sub

    Private Sub CargarMaterias()
        Dim conexion As New ConnexionBD()
        Dim conn As MySqlConnection = conexion.GetConnection()

        If conn IsNot Nothing Then
            Dim query As String = "SELECT idMateria, nombre FROM materia"
            Dim command As New MySqlCommand(query, conn)

            Try
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                cmbMateria.DataSource = table
                cmbMateria.DisplayMember = "nombre"
                cmbMateria.ValueMember = "idMateria"
            Catch ex As MySqlException
                MessageBox.Show("Error al cargar las materias: " & ex.Message)
            Finally
                conexion.CloseConnection(conn)
            End Try
        End If
    End Sub

    Private Sub CargarDocentes()
        Dim conexion As New ConnexionBD()
        Dim conn As MySqlConnection = conexion.GetConnection()

        If conn IsNot Nothing Then
            Dim query As String = "SELECT idDocente, nombre FROM docente"
            Dim command As New MySqlCommand(query, conn)

            Try
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                cmbDocente.DataSource = table
                cmbDocente.DisplayMember = "nombre"
                cmbDocente.ValueMember = "idDocente"
            Catch ex As MySqlException
                MessageBox.Show("Error al cargar los docentes: " & ex.Message)
            Finally
                conexion.CloseConnection(conn)
            End Try
        End If
    End Sub

    ' --- Cargar Periodos desde la tabla periodo ---
    Private Sub CargarPeriodos()
        Dim conexion As New ConnexionBD()
        Dim conn As MySqlConnection = conexion.GetConnection()

        If conn IsNot Nothing Then
            Dim query As String = "SELECT idPeriodo, nombre AS periodo FROM periodo"
            Dim command As New MySqlCommand(query, conn)

            Try
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                cmbPeriodo.DataSource = table
                cmbPeriodo.DisplayMember = "periodo" ' Mostrar el nombre del periodo
                cmbPeriodo.ValueMember = "idPeriodo" ' El valor del periodo será el idPeriodo
            Catch ex As MySqlException
                MessageBox.Show("Error al cargar los periodos: " & ex.Message)
            Finally
                conexion.CloseConnection(conn)
            End Try
        End If
    End Sub


    ' --- Cargar parciales ---
    Private Sub CargarParciales()
        Dim conexion As New ConnexionBD()
        Dim conn As MySqlConnection = conexion.GetConnection()

        If conn IsNot Nothing Then
            Dim query As String = "SELECT idParcial, nombre AS parcial FROM parcial"
            Dim command As New MySqlCommand(query, conn)

            Try
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                cmbParcial.DataSource = table
                cmbParcial.DisplayMember = "parcial" ' Mostrar el nombre del parcial
                cmbParcial.ValueMember = "idParcial" ' El valor será el idParcial
            Catch ex As MySqlException
                MessageBox.Show("Error al cargar los parciales: " & ex.Message)
            Finally
                conexion.CloseConnection(conn)
            End Try
        End If
    End Sub


    ' --- Cargar horarios ---
    Private Sub CargarHorarios()
        Dim conexion As New ConnexionBD()
        Dim conn As MySqlConnection = conexion.GetConnection()

        If conn IsNot Nothing Then
            Dim query As String = "SELECT idHorario, CONCAT(dia, ' ', horaInicio, '-', horaFin) AS horario FROM horario"
            Dim command As New MySqlCommand(query, conn)

            Try
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                cmbHorario.DataSource = table
                cmbHorario.DisplayMember = "horario"
                cmbHorario.ValueMember = "idHorario"
            Catch ex As MySqlException
                MessageBox.Show("Error al cargar los horarios: " & ex.Message)
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
        ' Limpiar todos los TextBox
        txtUnidad.Clear()
        txtCalificacion.Clear()
        txtIdCalificacion.Clear()

        ' Restablecer los ComboBox
        cmbAlumno.SelectedIndex = -1
        cmbMateria.SelectedIndex = -1
        cmbDocente.SelectedIndex = -1
        cmbPeriodo.SelectedIndex = -1
        cmbParcial.SelectedIndex = -1
        cmbHorario.SelectedIndex = -1

        ' Restablecer el estado de los botones
        btnAgregar.Enabled = True
        btnModificar.Enabled = False

        ' Habilitar el campo txtIdCalificacion para nuevas búsquedas
        txtIdCalificacion.Enabled = True
    End Sub

    ' --- Método para validar que todos los campos requeridos estén llenos ---
    Private Function ValidarCampos() As Boolean
        If txtUnidad.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingresa la unidad.")
            Return False
        ElseIf txtCalificacion.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingresa la calificación.")
            Return False
        ElseIf cmbAlumno.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, selecciona un alumno.")
            Return False
        ElseIf cmbMateria.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, selecciona una materia.")
            Return False
        ElseIf cmbDocente.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, selecciona un docente.")
            Return False
        ElseIf cmbPeriodo.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, selecciona un periodo.")
            Return False
        ElseIf cmbParcial.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, selecciona un parcial.")
            Return False
        ElseIf cmbHorario.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, selecciona un horario.")
            Return False
        End If

        ' Si todos los campos están llenos, devolver True
        Return True
    End Function

    ' --- Botón Modificar ---
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        ' Primero, validar que todos los campos requeridos estén llenos
        If ValidarCampos() Then
            Dim conexion As New ConnexionBD()
            Dim conn As MySqlConnection = conexion.GetConnection()

            If conn IsNot Nothing Then
                ' Consulta de actualización
                Dim query As String = "UPDATE calificacion SET unidad = @unidad, noControl = @noControl, idMateria = @idMateria, " &
                                      "idDocente = @idDocente, idPeriodo = @idPeriodo, idParcial = @idParcial, " &
                                      "calificacion = @calificacion, idHorario = @idHorario " &
                                      "WHERE idCalificacion = @idCalificacion"
                Dim command As New MySqlCommand(query, conn)

                ' Pasar los valores de los controles a los parámetros
                command.Parameters.AddWithValue("@unidad", txtUnidad.Text)
                command.Parameters.AddWithValue("@noControl", cmbAlumno.SelectedValue)
                command.Parameters.AddWithValue("@idMateria", cmbMateria.SelectedValue)
                command.Parameters.AddWithValue("@idDocente", cmbDocente.SelectedValue)
                command.Parameters.AddWithValue("@idPeriodo", cmbPeriodo.SelectedValue)
                command.Parameters.AddWithValue("@idParcial", cmbParcial.SelectedValue)
                command.Parameters.AddWithValue("@calificacion", txtCalificacion.Text)
                command.Parameters.AddWithValue("@idHorario", cmbHorario.SelectedValue)
                command.Parameters.AddWithValue("@idCalificacion", txtIdCalificacion.Text)

                Try
                    ' Ejecutar la actualización
                    command.ExecuteNonQuery()

                    ' Mostrar un mensaje de éxito
                    MessageBox.Show("Calificación modificada correctamente.")

                    ' Recargar los datos en el DataGridView
                    CargarCalificaciones()

                    ' Limpiar los campos después de la modificación
                    LimpiarCampos()

                Catch ex As MySqlException
                    ' Mostrar mensaje de error en caso de fallos
                    MessageBox.Show("Error al modificar la calificación: " & ex.Message)
                Finally
                    ' Cerrar la conexión
                    conexion.CloseConnection(conn)
                End Try
            End If
        End If
    End Sub

    ' --- Botón Agregar ---
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ' Validar que todos los campos estén llenos
        If ValidarCampos() Then
            ' Asegurarse de que txtIdCalificacion esté vacío para una nueva inserción
            If txtIdCalificacion.Text.Trim() <> "" Then
                MessageBox.Show("El campo ID debe estar vacío para agregar una nueva calificación.")
                Return
            End If

            Dim conexion As New ConnexionBD()
            Dim conn As MySqlConnection = conexion.GetConnection()

            If conn IsNot Nothing Then
                ' Consulta para insertar una nueva calificación
                Dim query As String = "INSERT INTO calificacion (unidad, noControl, idMateria, idDocente, idPeriodo, idParcial, calificacion, idHorario) " &
                                  "VALUES (@unidad, @noControl, @idMateria, @idDocente, @idPeriodo, @idParcial, @calificacion, @idHorario)"
                Dim command As New MySqlCommand(query, conn)

                ' Pasar los valores de los controles a los parámetros
                command.Parameters.AddWithValue("@unidad", txtUnidad.Text)
                command.Parameters.AddWithValue("@noControl", cmbAlumno.SelectedValue)
                command.Parameters.AddWithValue("@idMateria", cmbMateria.SelectedValue)
                command.Parameters.AddWithValue("@idDocente", cmbDocente.SelectedValue)
                command.Parameters.AddWithValue("@idPeriodo", cmbPeriodo.SelectedValue)
                command.Parameters.AddWithValue("@idParcial", cmbParcial.SelectedValue)
                command.Parameters.AddWithValue("@calificacion", txtCalificacion.Text)
                command.Parameters.AddWithValue("@idHorario", cmbHorario.SelectedValue)

                Try
                    ' Ejecutar el comando de inserción
                    command.ExecuteNonQuery()

                    ' Mostrar mensaje de éxito
                    MessageBox.Show("Calificación agregada correctamente.")

                    ' Recargar el DataGridView
                    CargarCalificaciones()

                    ' Limpiar los campos después de agregar
                    LimpiarCampos()

                Catch ex As MySqlException
                    MessageBox.Show("Error al agregar la calificación: " & ex.Message)
                Finally
                    ' Cerrar la conexión
                    conexion.CloseConnection(conn)
                End Try
            End If
        End If
    End Sub

End Class
