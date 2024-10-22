Imports MySql.Data.MySqlClient

Public Class frmGestOferta

    ' --- Al cargar el formulario ---
    Private Sub frmGestOferta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCarreras()
        CargarMaterias()
        CargarDocentes()
        CargarPeriodos()
        CargarOfertas() ' Cargar los datos en el DataGridView
        LimpiarCampos() ' Limpiar campos al cargar el formulario
    End Sub

    ' --- Método para cargar carreras en el ComboBox ---
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

                cmbClvCarrera.DataSource = table
                cmbClvCarrera.DisplayMember = "nombre"
                cmbClvCarrera.ValueMember = "idCarrera"
            Catch ex As MySqlException
                MessageBox.Show("Error al cargar las carreras: " & ex.Message)
            Finally
                conexion.CloseConnection(conn)
            End Try
        End If
    End Sub

    ' --- Método para cargar materias en el ComboBox ---
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

                cmbClvMateria.DataSource = table
                cmbClvMateria.DisplayMember = "nombre"
                cmbClvMateria.ValueMember = "idMateria"
            Catch ex As MySqlException
                MessageBox.Show("Error al cargar las materias: " & ex.Message)
            Finally
                conexion.CloseConnection(conn)
            End Try
        End If
    End Sub

    ' --- Método para cargar docentes en el ComboBox ---
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

                cmbClvDocente.DataSource = table
                cmbClvDocente.DisplayMember = "nombre"
                cmbClvDocente.ValueMember = "idDocente"
            Catch ex As MySqlException
                MessageBox.Show("Error al cargar los docentes: " & ex.Message)
            Finally
                conexion.CloseConnection(conn)
            End Try
        End If
    End Sub

    ' --- Método para cargar periodos en el ComboBox ---
    Private Sub CargarPeriodos()
        Dim conexion As New ConnexionBD()
        Dim conn As MySqlConnection = conexion.GetConnection()

        If conn IsNot Nothing Then
            Dim query As String = "SELECT idPeriodo, CONCAT(fechaInicio, ' - ', fechaFin) AS periodo FROM periodo"
            Dim command As New MySqlCommand(query, conn)

            Try
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                cmbIdPeriodo.DataSource = table
                cmbIdPeriodo.DisplayMember = "periodo"
                cmbIdPeriodo.ValueMember = "idPeriodo"
            Catch ex As MySqlException
                MessageBox.Show("Error al cargar los periodos: " & ex.Message)
            Finally
                conexion.CloseConnection(conn)
            End Try
        End If
    End Sub

    ' --- Método para cargar ofertas en el DataGridView ---
    Private Sub CargarOfertas()
        Dim conexion As New ConnexionBD()
        Dim conn As MySqlConnection = conexion.GetConnection()

        If conn IsNot Nothing Then
            Dim query As String = "SELECT oferta.idOferta, carrera.nombre AS Carrera, materia.nombre AS Materia, " &
                                  "docente.nombre AS Docente, CONCAT(periodo.fechaInicio, ' - ', periodo.fechaFin) AS Periodo " &
                                  "FROM oferta " &
                                  "JOIN carrera ON oferta.idCarrera = carrera.idCarrera " &
                                  "JOIN materia ON oferta.idMateria = materia.idMateria " &
                                  "JOIN docente ON oferta.idDocente = docente.idDocente " &
                                  "JOIN periodo ON oferta.idPeriodo = periodo.idPeriodo"

            Dim command As New MySqlCommand(query, conn)

            Try
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)

                dgvOfertas.DataSource = table
            Catch ex As MySqlException
                MessageBox.Show("Error al cargar las ofertas: " & ex.Message)
            Finally
                conexion.CloseConnection(conn)
            End Try
        End If
    End Sub

    ' --- Botón Agregar ---
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ' Verificar que los campos no estén vacíos
        If ValidarCampos() Then
            Dim conexion As New ConnexionBD()
            Dim conn As MySqlConnection = conexion.GetConnection()

            If conn IsNot Nothing Then
                ' Insertar una nueva oferta
                Dim query As String = "INSERT INTO oferta (idCarrera, idMateria, idDocente, idPeriodo, estatus, grado, grupo) " &
                                      "VALUES (@idCarrera, @idMateria, @idDocente, @idPeriodo, @estatus, @grado, @grupo)"
                Dim command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@idCarrera", cmbClvCarrera.SelectedValue)
                command.Parameters.AddWithValue("@idMateria", cmbClvMateria.SelectedValue)
                command.Parameters.AddWithValue("@idDocente", cmbClvDocente.SelectedValue)
                command.Parameters.AddWithValue("@idPeriodo", cmbIdPeriodo.SelectedValue)
                command.Parameters.AddWithValue("@estatus", cmbEstatus.Text)
                command.Parameters.AddWithValue("@grado", txtGrado.Text)
                command.Parameters.AddWithValue("@grupo", txtGrupo.Text)

                Try
                    command.ExecuteNonQuery()
                    MessageBox.Show("Oferta agregada correctamente.")
                    CargarOfertas()
                    LimpiarCampos()
                Catch ex As MySqlException
                    MessageBox.Show("Error al agregar la oferta: " & ex.Message)
                Finally
                    conexion.CloseConnection(conn)
                End Try
            End If
        End If
    End Sub

    ' --- Botón Modificar ---
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        ' Verificar que los campos no estén vacíos
        If ValidarCampos() Then
            Dim conexion As New ConnexionBD()
            Dim conn As MySqlConnection = conexion.GetConnection()

            If conn IsNot Nothing Then
                ' Actualizar una oferta existente
                Dim query As String = "UPDATE oferta SET idCarrera = @idCarrera, idMateria = @idMateria, " &
                                      "idDocente = @idDocente, idPeriodo = @idPeriodo, estatus = @estatus, " &
                                      "grado = @grado, grupo = @grupo WHERE idOferta = @idOferta"
                Dim command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@idCarrera", cmbClvCarrera.SelectedValue)
                command.Parameters.AddWithValue("@idMateria", cmbClvMateria.SelectedValue)
                command.Parameters.AddWithValue("@idDocente", cmbClvDocente.SelectedValue)
                command.Parameters.AddWithValue("@idPeriodo", cmbIdPeriodo.SelectedValue)
                command.Parameters.AddWithValue("@estatus", cmbEstatus.Text)
                command.Parameters.AddWithValue("@grado", txtGrado.Text)
                command.Parameters.AddWithValue("@grupo", txtGrupo.Text)
                command.Parameters.AddWithValue("@idOferta", txtIdOferta.Text)

                Try
                    command.ExecuteNonQuery()
                    MessageBox.Show("Oferta modificada correctamente.")
                    CargarOfertas()
                    LimpiarCampos()
                Catch ex As MySqlException
                    MessageBox.Show("Error al modificar la oferta: " & ex.Message)
                Finally
                    conexion.CloseConnection(conn)
                End Try
            End If
        End If
    End Sub

    ' --- Botón Buscar ---
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtIdOferta.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingrese un ID de oferta.")
            Return
        End If

        Dim conexion As New ConnexionBD()
        Dim conn As MySqlConnection = conexion.GetConnection()

        If conn IsNot Nothing Then
            ' Buscar una oferta por ID
            Dim query As String = "SELECT * FROM oferta WHERE idOferta = @idOferta"
            Dim command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@idOferta", txtIdOferta.Text)

            Try
                Dim reader As MySqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    cmbClvCarrera.SelectedValue = reader("idCarrera")
                    cmbClvMateria.SelectedValue = reader("idMateria")
                    cmbClvDocente.SelectedValue = reader("idDocente")
                    cmbIdPeriodo.SelectedValue = reader("idPeriodo")
                    cmbEstatus.Text = reader("estatus").ToString()
                    txtGrado.Text = reader("grado").ToString()
                    txtGrupo.Text = reader("grupo").ToString()

                    btnAgregar.Enabled = False
                    btnModificar.Enabled = True
                Else
                    MessageBox.Show("No se encontró ninguna oferta con ese ID.")
                    LimpiarCampos()
                End If

                reader.Close()
            Catch ex As MySqlException
                MessageBox.Show("Error al buscar la oferta: " & ex.Message)
            Finally
                conexion.CloseConnection(conn)
            End Try
        End If
    End Sub

    ' --- Evento para seleccionar una fila del DataGridView ---
    Private Sub dgvOfertas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOfertas.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvOfertas.Rows(e.RowIndex)

            ' Llenar los campos de texto y combo boxes con los valores de la fila seleccionada
            txtIdOferta.Text = row.Cells("idOferta").Value.ToString()
            cmbClvCarrera.Text = row.Cells("Carrera").Value.ToString()
            cmbClvMateria.Text = row.Cells("Materia").Value.ToString()
            cmbClvDocente.Text = row.Cells("Docente").Value.ToString()
            cmbIdPeriodo.Text = row.Cells("Periodo").Value.ToString()
            txtGrado.Text = row.Cells("Grado").Value.ToString()
            txtGrupo.Text = row.Cells("Grupo").Value.ToString()

            ' Ajustar los botones
            btnAgregar.Enabled = False
            btnModificar.Enabled = True
        End If
    End Sub

    ' --- Método para limpiar los campos del formulario ---
    Private Sub LimpiarCampos()
        txtIdOferta.Clear()
        cmbClvCarrera.SelectedIndex = -1
        cmbClvMateria.SelectedIndex = -1
        cmbClvDocente.SelectedIndex = -1
        cmbIdPeriodo.SelectedIndex = -1
        cmbEstatus.SelectedIndex = -1
        txtGrado.Clear()
        txtGrupo.Clear()

        btnAgregar.Enabled = True
        btnModificar.Enabled = False
        txtIdOferta.Enabled = True
    End Sub

    ' --- Método para validar que los campos no estén vacíos ---
    Private Function ValidarCampos() As Boolean
        If cmbClvCarrera.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, selecciona una carrera.")
            Return False
        ElseIf cmbClvMateria.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, selecciona una materia.")
            Return False
        ElseIf cmbClvDocente.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, selecciona un docente.")
            Return False
        ElseIf cmbIdPeriodo.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, selecciona un periodo.")
            Return False
        ElseIf String.IsNullOrWhiteSpace(cmbEstatus.Text) Then
            MessageBox.Show("Por favor, selecciona el estatus.")
            Return False
        ElseIf String.IsNullOrWhiteSpace(txtGrado.Text) Then
            MessageBox.Show("Por favor, ingresa el grado.")
            Return False
        ElseIf String.IsNullOrWhiteSpace(txtGrupo.Text) Then
            MessageBox.Show("Por favor, ingresa el grupo.")
            Return False
        End If

        Return True
    End Function

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

End Class
