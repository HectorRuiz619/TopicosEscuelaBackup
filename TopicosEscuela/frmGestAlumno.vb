Imports MySql.Data.MySqlClient

Public Class frmGestAlumno

    Dim conexion As New ConnexionBD() ' Instancia de la clase ConnexionBD
    Dim isNewAlumno As Boolean = False ' Bandera para determinar si es un nuevo registro

    ' Carga los alumnos en el DataGridView cuando se abre el formulario
    Private Sub frmGestAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarAlumnos()
        CargarCarreras() ' Cargar las opciones de carrera en el ComboBox
        CargarSemestres() ' Cargar las opciones de semestre en el ComboBox
        txtIdAlumno.Enabled = True ' Habilita el campo ID del alumno al cargar el formulario
        btnAgregarAlumno.Enabled = True
    End Sub

    ' Método para cargar los alumnos en el DataGridView, incluyendo el nombre de la carrera
    Private Sub CargarAlumnos()
        Dim query As String = "SELECT a.noControl, a.nombre, a.genero, a.grupo, a.estatus, a.semestre, a.fecha_ingreso, c.nombre AS carrera " &
                              "FROM Alumno a " &
                              "JOIN Carrera c ON a.claveCarrera = c.claveCarrera"

        Using command As New MySqlCommand(query, conexion.GetConnection())
            Using adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvAlumnos.DataSource = table
            End Using
        End Using
    End Sub

    ' Método para cargar las carreras en el ComboBox
    Private Sub CargarCarreras()
        Dim query As String = "SELECT claveCarrera, nombre FROM Carrera"
        Dim command As New MySqlCommand(query, conexion.GetConnection())

        Using reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                cmbCarrera.Items.Add(New With {.Text = reader("nombre").ToString(), .Value = reader("claveCarrera")})
            End While
        End Using

        cmbCarrera.DisplayMember = "Text"
        cmbCarrera.ValueMember = "Value"
    End Sub

    ' Método para cargar los semestres en el ComboBox
    Private Sub CargarSemestres()
        For i As Integer = 1 To 12
            cmbGrado.Items.Add(i.ToString())
        Next
    End Sub

    ' Botón para buscar un alumno por ID (noControl)
    Private Sub btnBuscarAlumno_Click(sender As Object, e As EventArgs) Handles btnBuscarAlumno.Click
        If txtIdAlumno.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingresa el ID del alumno para buscar.")
            Return
        End If

        Dim query As String = "SELECT a.noControl, a.nombre, a.genero, a.grupo, a.estatus, a.semestre, a.fecha_ingreso, c.nombre AS carrera " &
                              "FROM Alumno a " &
                              "JOIN Carrera c ON a.claveCarrera = c.claveCarrera " &
                              "WHERE a.noControl = @noControl"
        Dim command As New MySqlCommand(query, conexion.GetConnection())
        command.Parameters.AddWithValue("@noControl", txtIdAlumno.Text)

        Try
            Dim reader As MySqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                txtNombreAlumno.Text = reader("nombre").ToString()
                txtGeneroAlumno.Text = reader("genero").ToString()
                txtGrupoAlumno.Text = reader("grupo").ToString()
                txtEstatusAlumno.Text = reader("estatus").ToString()
                cmbGrado.Text = reader("semestre").ToString()
                dtpFechaIngreso.Value = Convert.ToDateTime(reader("fecha_ingreso")) ' Usar DateTimePicker
                cmbCarrera.Text = reader("carrera").ToString() ' Mostrar el nombre de la carrera
                txtIdAlumno.Enabled = True ' Deshabilita el campo de ID después de la búsqueda
                btnAgregarAlumno.Enabled = False ' Deshabilita el botón Agregar después de la búsqueda
                isNewAlumno = False ' No es un nuevo registro
            Else
                MessageBox.Show("Alumno no encontrado.")
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al buscar el alumno: " & ex.Message)
        End Try
    End Sub

    ' Botón para agregar un nuevo alumno
    Private Sub btnAgregarAlumno_Click(sender As Object, e As EventArgs) Handles btnAgregarAlumno.Click
        If txtNombreAlumno.Text.Trim() = "" Or txtGeneroAlumno.Text.Trim() = "" Or txtGrupoAlumno.Text.Trim() = "" Or txtEstatusAlumno.Text.Trim() = "" Or cmbCarrera.Text.Trim() = "" Or cmbGrado.Text.Trim() = "" Then
            MessageBox.Show("Por favor, completa todos los campos.")
            Return
        End If

        ' Obtener la claveCarrera según el nombre de la carrera ingresado
        Dim claveCarrera As String
        Try
            claveCarrera = ObtenerClaveCarreraPorNombre(cmbCarrera.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return
        End Try

        ' Verificar si el alumno ya existe
        Dim queryCheck As String = "SELECT COUNT(*) FROM Alumno WHERE nombre = @nombre AND grupo = @grupo"
        Dim commandCheck As New MySqlCommand(queryCheck, conexion.GetConnection())
        commandCheck.Parameters.AddWithValue("@nombre", txtNombreAlumno.Text)
        commandCheck.Parameters.AddWithValue("@grupo", txtGrupoAlumno.Text)

        Dim count As Integer = Convert.ToInt32(commandCheck.ExecuteScalar())

        If count > 0 Then
            MessageBox.Show("El alumno ya existe en el grupo especificado. No se puede agregar un duplicado.")
            Return
        End If

        ' Insertar el nuevo alumno
        Dim query As String = "INSERT INTO Alumno (noControl, nombre, genero, grupo, estatus, claveCarrera, semestre, fecha_ingreso) " &
                              "VALUES (@noControl, @nombre, @genero, @grupo, @estatus, @claveCarrera, @semestre, @fecha_ingreso)"
        Dim command As New MySqlCommand(query, conexion.GetConnection())

        command.Parameters.AddWithValue("@noControl", txtIdAlumno.Text)
        command.Parameters.AddWithValue("@nombre", txtNombreAlumno.Text)
        command.Parameters.AddWithValue("@genero", txtGeneroAlumno.Text)
        command.Parameters.AddWithValue("@grupo", txtGrupoAlumno.Text)
        command.Parameters.AddWithValue("@estatus", txtEstatusAlumno.Text)
        command.Parameters.AddWithValue("@claveCarrera", claveCarrera)
        command.Parameters.AddWithValue("@semestre", cmbGrado.Text)
        command.Parameters.AddWithValue("@fecha_ingreso", dtpFechaIngreso.Value) ' Usar DateTimePicker

        Try
            command.ExecuteNonQuery()
            MessageBox.Show("Alumno agregado exitosamente.")
            CargarAlumnos() ' Actualiza el DataGridView
        Catch ex As Exception
            MessageBox.Show("Error al agregar el alumno: " & ex.Message)
        End Try
    End Sub

    ' Función para obtener la claveCarrera a partir del nombre
    Private Function ObtenerClaveCarreraPorNombre(nombreCarrera As String) As String
        Dim query As String = "SELECT claveCarrera FROM Carrera WHERE nombre = @nombre"
        Using command As New MySqlCommand(query, conexion.GetConnection())
            command.Parameters.AddWithValue("@nombre", nombreCarrera)
            Dim claveCarrera As Object = command.ExecuteScalar()
            If claveCarrera IsNot Nothing Then
                Return claveCarrera.ToString()
            Else
                Throw New Exception("Carrera no encontrada.")
            End If
        End Using
    End Function

    ' Botón para modificar un alumno existente
    Private Sub btnModificarAlumno_Click(sender As Object, e As EventArgs) Handles btnModificarAlumno.Click
        If txtIdAlumno.Text.Trim() = "" Or txtNombreAlumno.Text.Trim() = "" Or txtGeneroAlumno.Text.Trim() = "" Or txtGrupoAlumno.Text.Trim() = "" Or txtEstatusAlumno.Text.Trim() = "" Or cmbCarrera.Text.Trim() = "" Or cmbGrado.Text.Trim() = "" Then
            MessageBox.Show("Por favor, selecciona un alumno y modifica sus datos.")
            Return
        End If

        ' Obtener la claveCarrera según el nombre de la carrera ingresado
        Dim claveCarrera As String
        Try
            claveCarrera = ObtenerClaveCarreraPorNombre(cmbCarrera.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return
        End Try

        ' Verificar si otro alumno ya existe con el mismo nombre, excluyendo el alumno actual por su ID
        Dim queryCheck As String = "SELECT COUNT(*) FROM Alumno WHERE nombre = @nombre AND noControl <> @noControl"
        Dim commandCheck As New MySqlCommand(queryCheck, conexion.GetConnection())
        commandCheck.Parameters.AddWithValue("@nombre", txtNombreAlumno.Text)
        commandCheck.Parameters.AddWithValue("@noControl", txtIdAlumno.Text)

        Dim count As Integer = Convert.ToInt32(commandCheck.ExecuteScalar())

        If count > 0 Then
            MessageBox.Show("El alumno ya existe con el mismo nombre. No se puede modificar a un nombre duplicado.")
            Return
        End If

        ' Modificar los datos del alumno
        Dim query As String = "UPDATE Alumno SET nombre = @nombre, genero = @genero, grupo = @grupo, estatus = @estatus, claveCarrera = @claveCarrera, semestre = @semestre, fecha_ingreso = @fecha_ingreso WHERE noControl = @noControl"
        Dim command As New MySqlCommand(query, conexion.GetConnection())

        command.Parameters.AddWithValue("@noControl", txtIdAlumno.Text)
        command.Parameters.AddWithValue("@nombre", txtNombreAlumno.Text)
        command.Parameters.AddWithValue("@genero", txtGeneroAlumno.Text)
        command.Parameters.AddWithValue("@grupo", txtGrupoAlumno.Text)
        command.Parameters.AddWithValue("@estatus", txtEstatusAlumno.Text)
        command.Parameters.AddWithValue("@claveCarrera", claveCarrera)
        command.Parameters.AddWithValue("@semestre", cmbGrado.Text)
        command.Parameters.AddWithValue("@fecha_ingreso", dtpFechaIngreso.Value) ' Usar DateTimePicker

        Try
            command.ExecuteNonQuery()
            MessageBox.Show("Alumno modificado exitosamente.")
            CargarAlumnos() ' Actualiza el DataGridView
        Catch ex As Exception
            MessageBox.Show("Error al modificar el alumno: " & ex.Message)
        End Try
    End Sub

    ' Evento para seleccionar un alumno desde el DataGridView y cargarlo en los campos
    Private Sub dgvAlumnos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlumnos.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvAlumnos.Rows(e.RowIndex)
            txtIdAlumno.Text = row.Cells("noControl").Value.ToString()
            txtNombreAlumno.Text = row.Cells("nombre").Value.ToString()
            txtGeneroAlumno.Text = row.Cells("genero").Value.ToString()
            txtGrupoAlumno.Text = row.Cells("grupo").Value.ToString()
            txtEstatusAlumno.Text = row.Cells("estatus").Value.ToString()
            cmbGrado.Text = row.Cells("semestre").Value.ToString()

            ' Verificar si la celda contiene un valor de fecha antes de convertirlo
            If Not IsDBNull(row.Cells("fecha_ingreso").Value) AndAlso row.Cells("fecha_ingreso").Value IsNot Nothing Then
                dtpFechaIngreso.Value = Convert.ToDateTime(row.Cells("fecha_ingreso").Value)
            Else
                dtpFechaIngreso.Value = DateTime.Now ' Establecer fecha actual si no hay fecha
            End If

            cmbCarrera.Text = row.Cells("carrera").Value.ToString() ' Cargar el nombre de la carrera
            txtIdAlumno.Enabled = False ' Deshabilita el campo de ID cuando se selecciona un alumno
            btnAgregarAlumno.Enabled = False ' Deshabilita el botón Agregar cuando se selecciona un alumno
            isNewAlumno = False ' No es un nuevo registro
        End If
    End Sub

    Private Sub cmbGrado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGrado.SelectedIndexChanged

    End Sub
End Class
