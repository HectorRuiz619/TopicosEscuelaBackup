<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestCarrera
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtNombreCarrera = New System.Windows.Forms.TextBox()
        Me.txtClaveCarrera = New System.Windows.Forms.TextBox()
        Me.btnBuscarCarrera = New System.Windows.Forms.Button()
        Me.btnAgregarCarrera = New System.Windows.Forms.Button()
        Me.btnModificarCarrera = New System.Windows.Forms.Button()
        Me.btnLimpiarCarrera = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvCarreras = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbIdJefe = New System.Windows.Forms.ComboBox()
        Me.cmbIdOferta = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbIdMateria = New System.Windows.Forms.ComboBox()
        Me.cmbIdAlumno = New System.Windows.Forms.ComboBox()
        CType(Me.dgvCarreras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombreCarrera
        '
        Me.txtNombreCarrera.Location = New System.Drawing.Point(118, 80)
        Me.txtNombreCarrera.Name = "txtNombreCarrera"
        Me.txtNombreCarrera.Size = New System.Drawing.Size(169, 22)
        Me.txtNombreCarrera.TabIndex = 0
        '
        'txtClaveCarrera
        '
        Me.txtClaveCarrera.Location = New System.Drawing.Point(118, 23)
        Me.txtClaveCarrera.Name = "txtClaveCarrera"
        Me.txtClaveCarrera.Size = New System.Drawing.Size(169, 22)
        Me.txtClaveCarrera.TabIndex = 2
        '
        'btnBuscarCarrera
        '
        Me.btnBuscarCarrera.Location = New System.Drawing.Point(317, 26)
        Me.btnBuscarCarrera.Name = "btnBuscarCarrera"
        Me.btnBuscarCarrera.Size = New System.Drawing.Size(119, 38)
        Me.btnBuscarCarrera.TabIndex = 4
        Me.btnBuscarCarrera.Text = "Buscar"
        Me.btnBuscarCarrera.UseVisualStyleBackColor = True
        '
        'btnAgregarCarrera
        '
        Me.btnAgregarCarrera.Location = New System.Drawing.Point(329, 221)
        Me.btnAgregarCarrera.Name = "btnAgregarCarrera"
        Me.btnAgregarCarrera.Size = New System.Drawing.Size(119, 38)
        Me.btnAgregarCarrera.TabIndex = 5
        Me.btnAgregarCarrera.Text = "Agregar"
        Me.btnAgregarCarrera.UseVisualStyleBackColor = True
        '
        'btnModificarCarrera
        '
        Me.btnModificarCarrera.Location = New System.Drawing.Point(454, 221)
        Me.btnModificarCarrera.Name = "btnModificarCarrera"
        Me.btnModificarCarrera.Size = New System.Drawing.Size(119, 38)
        Me.btnModificarCarrera.TabIndex = 6
        Me.btnModificarCarrera.Text = "Modificar"
        Me.btnModificarCarrera.UseVisualStyleBackColor = True
        '
        'btnLimpiarCarrera
        '
        Me.btnLimpiarCarrera.Location = New System.Drawing.Point(579, 221)
        Me.btnLimpiarCarrera.Name = "btnLimpiarCarrera"
        Me.btnLimpiarCarrera.Size = New System.Drawing.Size(119, 38)
        Me.btnLimpiarCarrera.TabIndex = 7
        Me.btnLimpiarCarrera.Text = "Limpiar"
        Me.btnLimpiarCarrera.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Clave Carrera"
        '
        'dgvCarreras
        '
        Me.dgvCarreras.ColumnHeadersHeight = 29
        Me.dgvCarreras.Location = New System.Drawing.Point(33, 265)
        Me.dgvCarreras.Name = "dgvCarreras"
        Me.dgvCarreras.RowHeadersWidth = 51
        Me.dgvCarreras.RowTemplate.Height = 24
        Me.dgvCarreras.Size = New System.Drawing.Size(665, 172)
        Me.dgvCarreras.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Estado"
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(118, 108)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(169, 22)
        Me.txtEstado.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(324, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "ID Jefe"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(324, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "ID Oferta"
        '
        'cmbIdJefe
        '
        Me.cmbIdJefe.FormattingEnabled = True
        Me.cmbIdJefe.Location = New System.Drawing.Point(404, 80)
        Me.cmbIdJefe.Name = "cmbIdJefe"
        Me.cmbIdJefe.Size = New System.Drawing.Size(169, 24)
        Me.cmbIdJefe.TabIndex = 18
        '
        'cmbIdOferta
        '
        Me.cmbIdOferta.FormattingEnabled = True
        Me.cmbIdOferta.Location = New System.Drawing.Point(404, 111)
        Me.cmbIdOferta.Name = "cmbIdOferta"
        Me.cmbIdOferta.Size = New System.Drawing.Size(169, 24)
        Me.cmbIdOferta.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "ID Materia"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 16)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "ID Alumno"
        '
        'cmbIdMateria
        '
        Me.cmbIdMateria.FormattingEnabled = True
        Me.cmbIdMateria.Location = New System.Drawing.Point(118, 171)
        Me.cmbIdMateria.Name = "cmbIdMateria"
        Me.cmbIdMateria.Size = New System.Drawing.Size(169, 24)
        Me.cmbIdMateria.TabIndex = 25
        '
        'cmbIdAlumno
        '
        Me.cmbIdAlumno.FormattingEnabled = True
        Me.cmbIdAlumno.Location = New System.Drawing.Point(118, 140)
        Me.cmbIdAlumno.Name = "cmbIdAlumno"
        Me.cmbIdAlumno.Size = New System.Drawing.Size(169, 24)
        Me.cmbIdAlumno.TabIndex = 24
        '
        'frmGestCarrera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 448)
        Me.Controls.Add(Me.cmbIdMateria)
        Me.Controls.Add(Me.cmbIdAlumno)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbIdOferta)
        Me.Controls.Add(Me.cmbIdJefe)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.dgvCarreras)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLimpiarCarrera)
        Me.Controls.Add(Me.btnModificarCarrera)
        Me.Controls.Add(Me.btnAgregarCarrera)
        Me.Controls.Add(Me.btnBuscarCarrera)
        Me.Controls.Add(Me.txtClaveCarrera)
        Me.Controls.Add(Me.txtNombreCarrera)
        Me.Name = "frmGestCarrera"
        Me.Text = "frmGestCarrera"
        CType(Me.dgvCarreras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombreCarrera As TextBox
    Friend WithEvents txtClaveCarrera As TextBox
    Friend WithEvents btnBuscarCarrera As Button
    Friend WithEvents btnAgregarCarrera As Button
    Friend WithEvents btnModificarCarrera As Button
    Friend WithEvents btnLimpiarCarrera As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvCarreras As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbIdJefe As ComboBox
    Friend WithEvents cmbIdOferta As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbIdMateria As ComboBox
    Friend WithEvents cmbIdAlumno As ComboBox
End Class
