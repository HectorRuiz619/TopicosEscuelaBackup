Imports MySql.Data.MySqlClient

Public Class frmGenerarHorario

    ' --- Al cargar el formulario ---
    Private Sub frmGenerarHorario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCarreras() ' Cargar las carreras al iniciar el formulario
        CargarGrupos()   ' Cargar los grupos al iniciar
    End Sub

    ' --- Método para cargar carreras en el ComboBox ---
    Private Sub CargarCarreras()
        Dim connBD As New ConnexionBD()
        Dim conn As MySqlConnection = connBD.GetConnection()

        Try
            Dim query As String = "SELECT claveCarrera, Nombre FROM carrera"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            Dim carreras As New Dictionary(Of String, String)()

            While reader.Read()
                carreras.Add(reader("claveCarrera").ToString(), reader("Nombre").ToString())
            End While

            cmbClvCarrera.DataSource = New BindingSource(carreras, Nothing)
            cmbClvCarrera.DisplayMember = "Value" ' Muestra el nombre de la carrera
            cmbClvCarrera.ValueMember = "Key" ' Usa claveCarrera como valor seleccionado

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar carreras: " & ex.Message)
        Finally
            connBD.CloseConnection(conn)
        End Try
    End Sub

    ' --- Método para cargar semestres en el ComboBox después de seleccionar una carrera ---
    Private Sub CargarSemestresPorCarrera()
        If cmbClvCarrera.SelectedValue IsNot Nothing Then
            Dim connBD As New ConnexionBD()
            Dim conn As MySqlConnection = connBD.GetConnection()

            Try
                Dim carreraSeleccionada As String = cmbClvCarrera.SelectedValue.ToString()

                ' Consulta para obtener los semestres de acuerdo a la carrera seleccionada
                Dim query As String = "SELECT DISTINCT Semestre FROM alumno WHERE claveCarrera = @claveCarrera ORDER BY Semestre"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@claveCarrera", carreraSeleccionada)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                Dim semestres As New List(Of String)()

                While reader.Read()
                    semestres.Add(reader("Semestre").ToString())
                End While

                cmbSemestre.DataSource = semestres
                cmbSemestre.SelectedIndex = -1

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error al cargar semestres: " & ex.Message)
            Finally
                connBD.CloseConnection(conn)
            End Try
        End If
    End Sub

    ' --- Método para cargar grupos manualmente ---
    Private Sub CargarGrupos()
        ' Cargar manualmente los grupos
        cmbGrupo.Items.Clear()
        cmbGrupo.Items.Add("A")
        cmbGrupo.Items.Add("B")
        cmbGrupo.Items.Add("C")
        cmbGrupo.Items.Add("D")
        cmbGrupo.Items.Add("E")
        cmbGrupo.SelectedIndex = -1 ' No seleccionar nada por defecto
    End Sub

    ' --- Método para cargar alumnos por carrera, semestre y grupo seleccionados ---
    Private Sub CargarAlumnosPorSeleccion()
        If cmbClvCarrera.SelectedValue IsNot Nothing AndAlso cmbSemestre.SelectedIndex >= 0 AndAlso cmbGrupo.SelectedIndex >= 0 Then
            Dim connBD As New ConnexionBD()
            Dim conn As MySqlConnection = connBD.GetConnection()

            Try
                Dim carreraSeleccionada As String = cmbClvCarrera.SelectedValue.ToString()
                Dim semestreSeleccionado As String = cmbSemestre.SelectedItem.ToString()
                Dim grupoSeleccionado As String = cmbGrupo.SelectedItem.ToString()

                ' Consulta para cargar alumnos con carrera, semestre y grupo seleccionados
                Dim queryAlumnos As String = "SELECT noControl AS 'N.Control', Nombre AS 'Nombre Alumno' " &
                                             "FROM alumno " &
                                             "WHERE claveCarrera = @claveCarrera AND Semestre = @semestre AND Grupo = @grupo"
                Dim cmdAlumnos As New MySqlCommand(queryAlumnos, conn)
                cmdAlumnos.Parameters.AddWithValue("@claveCarrera", carreraSeleccionada)
                cmdAlumnos.Parameters.AddWithValue("@semestre", semestreSeleccionado)
                cmdAlumnos.Parameters.AddWithValue("@grupo", grupoSeleccionado)

                Dim adapterAlumnos As New MySqlDataAdapter(cmdAlumnos)
                Dim tableAlumnos As New DataTable()
                adapterAlumnos.Fill(tableAlumnos)

                ' Asignar los alumnos al DataGridView
                dgvAlumnos.DataSource = tableAlumnos

            Catch ex As Exception
                MessageBox.Show("Error al cargar alumnos: " & ex.Message)
            Finally
                connBD.CloseConnection(conn)
            End Try
        End If
    End Sub

    ' --- Método para cargar materias por carrera, semestre y grupo seleccionados ---
    Private Sub CargarMateriasPorSeleccion()
        If cmbClvCarrera.SelectedValue IsNot Nothing AndAlso cmbSemestre.SelectedIndex >= 0 AndAlso cmbGrupo.SelectedIndex >= 0 Then
            Dim connBD As New ConnexionBD()
            Dim conn As MySqlConnection = connBD.GetConnection()

            Try
                Dim carreraSeleccionada As String = cmbClvCarrera.SelectedValue.ToString()
                Dim semestreSeleccionado As String = cmbSemestre.SelectedItem.ToString()
                Dim grupoSeleccionado As String = cmbGrupo.SelectedItem.ToString()

                ' Consulta para cargar materias con carrera, semestre y grupo seleccionados
                Dim queryMaterias As String = "SELECT o.idOferta AS 'ID Oferta', m.claveMateria AS 'Clave Materia', m.Nombre AS 'Nombre Materia', " &
                                              "d.claveDocente AS 'Clave Docente', d.Nombre AS 'Nombre Docente' " &
                                              "FROM oferta o " &
                                              "JOIN materia m ON o.claveMateria = m.claveMateria " &
                                              "JOIN docente d ON o.claveDocente = d.claveDocente " &
                                              "WHERE o.claveCarrera = @claveCarrera AND o.Semestre = @semestre AND o.Grupo = @grupo"
                Dim cmdMaterias As New MySqlCommand(queryMaterias, conn)
                cmdMaterias.Parameters.AddWithValue("@claveCarrera", carreraSeleccionada)
                cmdMaterias.Parameters.AddWithValue("@semestre", semestreSeleccionado)
                cmdMaterias.Parameters.AddWithValue("@grupo", grupoSeleccionado)

                Dim adapterMaterias As New MySqlDataAdapter(cmdMaterias)
                Dim tableMaterias As New DataTable()
                adapterMaterias.Fill(tableMaterias)

                ' Asignar las materias al DataGridView
                dgvMaterias.DataSource = tableMaterias

            Catch ex As Exception
                MessageBox.Show("Error al cargar materias: " & ex.Message)
            Finally
                connBD.CloseConnection(conn)
            End Try
        End If
    End Sub

    ' --- Evento para cargar semestres cuando se selecciona una carrera ---
    Private Sub cmbClvCarrera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClvCarrera.SelectedIndexChanged
        CargarSemestresPorCarrera()
    End Sub

    ' --- Evento para cargar materias y alumnos cuando se selecciona un semestre ---
    Private Sub cmbSemestre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSemestre.SelectedIndexChanged
        CargarAlumnosPorSeleccion()
        CargarMateriasPorSeleccion()
        CargarPeriodo() ' Llamar a cargar periodo aquí
    End Sub

    ' --- Evento para cargar materias y alumnos cuando se selecciona un grupo ---
    Private Sub cmbGrupo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGrupo.SelectedIndexChanged
        CargarAlumnosPorSeleccion()
        CargarMateriasPorSeleccion()
        CargarPeriodo() ' Llamar a cargar periodo aquí también
    End Sub

    ' --- Método para cargar el periodo ---
    Private Sub CargarPeriodo()
        Dim connBD As New ConnexionBD()
        Dim conn As MySqlConnection = connBD.GetConnection()

        If conn Is Nothing Then
            MessageBox.Show("No se pudo establecer la conexión.")
            Exit Sub
        End If

        Try
            ' Obtener el idOferta de la primera materia seleccionada
            If dgvMaterias.Rows.Count > 0 Then
                Dim idOferta As Integer = CInt(dgvMaterias.Rows(0).Cells("ID Oferta").Value)

                ' Consulta para obtener el periodo
                Dim queryPeriodo As String = "SELECT p.Periodo FROM oferta o " &
                                             "JOIN periodo p ON o.idPeriodo = p.idPeriodo " &
                                             "WHERE o.idOferta = @idOferta LIMIT 1"

                Dim cmdPeriodo As New MySqlCommand(queryPeriodo, conn)
                cmdPeriodo.Parameters.AddWithValue("@idOferta", idOferta)

                ' Ejecutar la consulta y obtener el resultado
                Dim periodo As String = cmdPeriodo.ExecuteScalar()?.ToString()

                ' Mostrar el periodo en txtPeriodo
                If Not String.IsNullOrEmpty(periodo) Then
                    txtPeriodo.Text = periodo
                Else
                    txtPeriodo.Text = "No se encontró el período"
                End If
            Else
                txtPeriodo.Text = "No hay materias seleccionadas"
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar el período: " & ex.Message)
        Finally
            connBD.CloseConnection(conn)
        End Try
    End Sub

    ' Método para guardar el horario
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim connBD As New ConnexionBD()
        Dim conn As MySqlConnection = connBD.GetConnection()

        If conn Is Nothing Then
            MessageBox.Show("No se pudo establecer la conexión.")
            Exit Sub
        End If

        Try
            ' Validar si hay alumnos y materias seleccionados
            If dgvAlumnos.Rows.Count = 0 Then
                MessageBox.Show("No hay alumnos seleccionados.")
                Exit Sub
            End If

            If dgvMaterias.Rows.Count = 0 Then
                MessageBox.Show("No hay materias seleccionadas.")
                Exit Sub
            End If

            ' Recorremos las filas de alumnos para obtener sus datos
            For Each filaAlumno As DataGridViewRow In dgvAlumnos.Rows
                ' Verificamos si la fila no es nueva (es decir, ya existe)
                If filaAlumno.IsNewRow Then
                    Continue For
                End If

                ' Usamos el índice de la columna para obtener el número de control
                Dim noControl As String = filaAlumno.Cells(0).Value?.ToString()

                If String.IsNullOrEmpty(noControl) Then
                    MessageBox.Show("No se pudo obtener el número de control del alumno.")
                    Exit Sub
                End If

                ' Obtener el semestre seleccionado
                Dim semestreSeleccionado As Integer = CInt(cmbSemestre.SelectedItem)

                ' Asignar Promedio a 0, ya que no se obtiene de la tabla alumno
                Dim promedio As Decimal = 0

                ' Recorremos las filas de materias para obtener las asignaturas del alumno
                For Each filaMateria As DataGridViewRow In dgvMaterias.Rows
                    ' Verificamos si la fila no es nueva (es decir, ya existe)
                    If filaMateria.IsNewRow Then
                        Continue For
                    End If

                    Dim idOferta As Integer = CInt(filaMateria.Cells("ID Oferta").Value)

                    If idOferta = -1 Then
                        MessageBox.Show("No se pudo obtener el ID de la oferta.")
                        Exit Sub
                    End If

                    ' Insertamos un nuevo registro en la tabla horario
                    Dim queryInsert As String = "INSERT INTO horario (Semestre, Opcion, Promedio, idOferta, noControl) " &
                                            "VALUES (@semestre, @opcion, @promedio, @idOferta, @noControl)"

                    Dim cmdInsert As New MySqlCommand(queryInsert, conn)
                    cmdInsert.Parameters.AddWithValue("@semestre", semestreSeleccionado) ' Semestre seleccionado
                    cmdInsert.Parameters.AddWithValue("@opcion", "Regular") ' Puedes cambiar este valor si es necesario
                    cmdInsert.Parameters.AddWithValue("@promedio", promedio) ' Promedio asignado a 0
                    cmdInsert.Parameters.AddWithValue("@idOferta", idOferta) ' ID de la oferta
                    cmdInsert.Parameters.AddWithValue("@noControl", noControl) ' NoControl del alumno

                    cmdInsert.ExecuteNonQuery()
                Next
            Next

            MessageBox.Show("Horario guardado exitosamente.")
        Catch ex As Exception
            MessageBox.Show("Error al guardar el horario: " & ex.Message)
        Finally
            connBD.CloseConnection(conn)
        End Try
    End Sub

End Class
