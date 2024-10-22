<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGestAlumno
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtNombreAlumno = New System.Windows.Forms.TextBox()
        Me.txtGeneroAlumno = New System.Windows.Forms.TextBox()
        Me.txtGrupoAlumno = New System.Windows.Forms.TextBox()
        Me.txtEstatusAlumno = New System.Windows.Forms.TextBox()
        Me.btnAgregarAlumno = New System.Windows.Forms.Button()
        Me.btnModificarAlumno = New System.Windows.Forms.Button()
        Me.btnBuscarAlumno = New System.Windows.Forms.Button()
        Me.btnLimpiarAlumno = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIdAlumno = New System.Windows.Forms.TextBox()
        Me.dgvAlumnos = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbGrado = New System.Windows.Forms.ComboBox()
        Me.dtpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.cmbCarrera = New System.Windows.Forms.ComboBox()
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombreAlumno
        '
        Me.txtNombreAlumno.Location = New System.Drawing.Point(193, 154)
        Me.txtNombreAlumno.Name = "txtNombreAlumno"
        Me.txtNombreAlumno.Size = New System.Drawing.Size(180, 22)
        Me.txtNombreAlumno.TabIndex = 0
        '
        'txtGeneroAlumno
        '
        Me.txtGeneroAlumno.Location = New System.Drawing.Point(193, 201)
        Me.txtGeneroAlumno.Name = "txtGeneroAlumno"
        Me.txtGeneroAlumno.Size = New System.Drawing.Size(180, 22)
        Me.txtGeneroAlumno.TabIndex = 1
        '
        'txtGrupoAlumno
        '
        Me.txtGrupoAlumno.Location = New System.Drawing.Point(545, 148)
        Me.txtGrupoAlumno.Name = "txtGrupoAlumno"
        Me.txtGrupoAlumno.Size = New System.Drawing.Size(180, 22)
        Me.txtGrupoAlumno.TabIndex = 3
        '
        'txtEstatusAlumno
        '
        Me.txtEstatusAlumno.Location = New System.Drawing.Point(545, 185)
        Me.txtEstatusAlumno.Name = "txtEstatusAlumno"
        Me.txtEstatusAlumno.Size = New System.Drawing.Size(180, 22)
        Me.txtEstatusAlumno.TabIndex = 4
        '
        'btnAgregarAlumno
        '
        Me.btnAgregarAlumno.Location = New System.Drawing.Point(758, 154)
        Me.btnAgregarAlumno.Name = "btnAgregarAlumno"
        Me.btnAgregarAlumno.Size = New System.Drawing.Size(117, 37)
        Me.btnAgregarAlumno.TabIndex = 5
        Me.btnAgregarAlumno.Text = "Agregar"
        Me.btnAgregarAlumno.UseVisualStyleBackColor = True
        '
        'btnModificarAlumno
        '
        Me.btnModificarAlumno.Location = New System.Drawing.Point(758, 201)
        Me.btnModificarAlumno.Name = "btnModificarAlumno"
        Me.btnModificarAlumno.Size = New System.Drawing.Size(117, 37)
        Me.btnModificarAlumno.TabIndex = 6
        Me.btnModificarAlumno.Text = "Modificar"
        Me.btnModificarAlumno.UseVisualStyleBackColor = True
        '
        'btnBuscarAlumno
        '
        Me.btnBuscarAlumno.Location = New System.Drawing.Point(659, 70)
        Me.btnBuscarAlumno.Name = "btnBuscarAlumno"
        Me.btnBuscarAlumno.Size = New System.Drawing.Size(117, 37)
        Me.btnBuscarAlumno.TabIndex = 7
        Me.btnBuscarAlumno.Text = "Buscar"
        Me.btnBuscarAlumno.UseVisualStyleBackColor = True
        '
        'btnLimpiarAlumno
        '
        Me.btnLimpiarAlumno.Location = New System.Drawing.Point(758, 245)
        Me.btnLimpiarAlumno.Name = "btnLimpiarAlumno"
        Me.btnLimpiarAlumno.Size = New System.Drawing.Size(117, 37)
        Me.btnLimpiarAlumno.TabIndex = 8
        Me.btnLimpiarAlumno.Text = "Limpiar"
        Me.btnLimpiarAlumno.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Genero"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(445, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Grupo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(444, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Estado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(312, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Numero Control"
        '
        'txtIdAlumno
        '
        Me.txtIdAlumno.Location = New System.Drawing.Point(462, 85)
        Me.txtIdAlumno.Name = "txtIdAlumno"
        Me.txtIdAlumno.Size = New System.Drawing.Size(180, 22)
        Me.txtIdAlumno.TabIndex = 14
        '
        'dgvAlumnos
        '
        Me.dgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlumnos.Location = New System.Drawing.Point(71, 354)
        Me.dgvAlumnos.Name = "dgvAlumnos"
        Me.dgvAlumnos.RowHeadersWidth = 51
        Me.dgvAlumnos.RowTemplate.Height = 24
        Me.dgvAlumnos.Size = New System.Drawing.Size(921, 188)
        Me.dgvAlumnos.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(444, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 16)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Carrera"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(444, 264)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 16)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "FechaIngreso"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(85, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 16)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Grado"
        '
        'cmbGrado
        '
        Me.cmbGrado.FormattingEnabled = True
        Me.cmbGrado.Location = New System.Drawing.Point(193, 260)
        Me.cmbGrado.Name = "cmbGrado"
        Me.cmbGrado.Size = New System.Drawing.Size(180, 24)
        Me.cmbGrado.TabIndex = 23
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(545, 258)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(200, 22)
        Me.dtpFechaIngreso.TabIndex = 24
        '
        'cmbCarrera
        '
        Me.cmbCarrera.FormattingEnabled = True
        Me.cmbCarrera.Location = New System.Drawing.Point(545, 214)
        Me.cmbCarrera.Name = "cmbCarrera"
        Me.cmbCarrera.Size = New System.Drawing.Size(180, 24)
        Me.cmbCarrera.TabIndex = 25
        '
        'frmGestAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 603)
        Me.Controls.Add(Me.cmbCarrera)
        Me.Controls.Add(Me.dtpFechaIngreso)
        Me.Controls.Add(Me.cmbGrado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvAlumnos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtIdAlumno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLimpiarAlumno)
        Me.Controls.Add(Me.btnBuscarAlumno)
        Me.Controls.Add(Me.btnModificarAlumno)
        Me.Controls.Add(Me.btnAgregarAlumno)
        Me.Controls.Add(Me.txtEstatusAlumno)
        Me.Controls.Add(Me.txtGrupoAlumno)
        Me.Controls.Add(Me.txtGeneroAlumno)
        Me.Controls.Add(Me.txtNombreAlumno)
        Me.Name = "frmGestAlumno"
        Me.Text = "frmAlumno"
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombreAlumno As TextBox
    Friend WithEvents txtGeneroAlumno As TextBox
    Friend WithEvents txtGrupoAlumno As TextBox
    Friend WithEvents txtEstatusAlumno As TextBox
    Friend WithEvents btnAgregarAlumno As Button
    Friend WithEvents btnModificarAlumno As Button
    Friend WithEvents btnBuscarAlumno As Button
    Friend WithEvents btnLimpiarAlumno As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtIdAlumno As TextBox
    Friend WithEvents dgvAlumnos As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbGrado As ComboBox
    Friend WithEvents dtpFechaIngreso As DateTimePicker
    Friend WithEvents cmbCarrera As ComboBox
End Class
