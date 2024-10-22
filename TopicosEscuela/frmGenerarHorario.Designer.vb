<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGenerarHorario
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
        Me.components = New System.ComponentModel.Container()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Carrera = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbClvCarrera = New System.Windows.Forms.ComboBox()
        Me.cmbSemestre = New System.Windows.Forms.ComboBox()
        Me.cmbGrupo = New System.Windows.Forms.ComboBox()
        Me.dgvAlumnos = New System.Windows.Forms.DataGridView()
        Me.dgvMaterias = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPeriodo = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Carrera
        '
        Me.Carrera.AutoSize = True
        Me.Carrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Carrera.Location = New System.Drawing.Point(117, 100)
        Me.Carrera.Name = "Carrera"
        Me.Carrera.Size = New System.Drawing.Size(78, 25)
        Me.Carrera.TabIndex = 1
        Me.Carrera.Text = "Carrera"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(117, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Grado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(117, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Grupo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(624, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Periodo"
        '
        'cmbClvCarrera
        '
        Me.cmbClvCarrera.FormattingEnabled = True
        Me.cmbClvCarrera.Location = New System.Drawing.Point(218, 100)
        Me.cmbClvCarrera.Name = "cmbClvCarrera"
        Me.cmbClvCarrera.Size = New System.Drawing.Size(168, 24)
        Me.cmbClvCarrera.TabIndex = 8
        '
        'cmbSemestre
        '
        Me.cmbSemestre.FormattingEnabled = True
        Me.cmbSemestre.Location = New System.Drawing.Point(218, 138)
        Me.cmbSemestre.Name = "cmbSemestre"
        Me.cmbSemestre.Size = New System.Drawing.Size(168, 24)
        Me.cmbSemestre.TabIndex = 9
        '
        'cmbGrupo
        '
        Me.cmbGrupo.FormattingEnabled = True
        Me.cmbGrupo.Location = New System.Drawing.Point(218, 165)
        Me.cmbGrupo.Name = "cmbGrupo"
        Me.cmbGrupo.Size = New System.Drawing.Size(168, 24)
        Me.cmbGrupo.TabIndex = 10
        '
        'dgvAlumnos
        '
        Me.dgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvAlumnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvAlumnos.ColumnHeadersHeight = 29
        Me.dgvAlumnos.Location = New System.Drawing.Point(88, 247)
        Me.dgvAlumnos.Name = "dgvAlumnos"
        Me.dgvAlumnos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvAlumnos.RowTemplate.Height = 24
        Me.dgvAlumnos.Size = New System.Drawing.Size(416, 142)
        Me.dgvAlumnos.TabIndex = 11
        '
        'dgvMaterias
        '
        Me.dgvMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvMaterias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvMaterias.ColumnHeadersHeight = 29
        Me.dgvMaterias.Location = New System.Drawing.Point(88, 485)
        Me.dgvMaterias.Name = "dgvMaterias"
        Me.dgvMaterias.RowHeadersWidth = 51
        Me.dgvMaterias.RowTemplate.Height = 24
        Me.dgvMaterias.Size = New System.Drawing.Size(803, 153)
        Me.dgvMaterias.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(370, 457)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Materias"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(370, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 25)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Alumnos"
        '
        'txtPeriodo
        '
        Me.txtPeriodo.Location = New System.Drawing.Point(730, 9)
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.Size = New System.Drawing.Size(168, 22)
        Me.txtPeriodo.TabIndex = 19
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(492, 83)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(108, 41)
        Me.btnGuardar.TabIndex = 13
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(766, 114)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(108, 40)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmGenerarHorario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 745)
        Me.Controls.Add(Me.txtPeriodo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.dgvMaterias)
        Me.Controls.Add(Me.dgvAlumnos)
        Me.Controls.Add(Me.cmbGrupo)
        Me.Controls.Add(Me.cmbSemestre)
        Me.Controls.Add(Me.cmbClvCarrera)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Carrera)
        Me.Name = "frmGenerarHorario"
        Me.Text = "frmGenerarHorario"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMaterias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents cmbClvCarrera As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Carrera As Label
    Friend WithEvents dgvMaterias As DataGridView
    Friend WithEvents dgvAlumnos As DataGridView
    Friend WithEvents cmbGrupo As ComboBox
    Friend WithEvents cmbSemestre As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPeriodo As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
End Class
