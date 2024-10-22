<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestOferta
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
        Me.txtIdOferta = New System.Windows.Forms.TextBox()
        Me.cmbEstatus = New System.Windows.Forms.ComboBox()
        Me.cmbIdPeriodo = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.dgvOfertas = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Carrera = New System.Windows.Forms.Label()
        Me.Materia = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGrupo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGrado = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbClvMateria = New System.Windows.Forms.ComboBox()
        Me.cmbClvDocente = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbClvCarrera = New System.Windows.Forms.ComboBox()
        CType(Me.dgvOfertas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIdOferta
        '
        Me.txtIdOferta.Location = New System.Drawing.Point(392, 45)
        Me.txtIdOferta.Name = "txtIdOferta"
        Me.txtIdOferta.Size = New System.Drawing.Size(123, 22)
        Me.txtIdOferta.TabIndex = 0
        '
        'cmbEstatus
        '
        Me.cmbEstatus.FormattingEnabled = True
        Me.cmbEstatus.Location = New System.Drawing.Point(248, 249)
        Me.cmbEstatus.Name = "cmbEstatus"
        Me.cmbEstatus.Size = New System.Drawing.Size(170, 24)
        Me.cmbEstatus.TabIndex = 1
        '
        'cmbIdPeriodo
        '
        Me.cmbIdPeriodo.FormattingEnabled = True
        Me.cmbIdPeriodo.Location = New System.Drawing.Point(247, 98)
        Me.cmbIdPeriodo.Name = "cmbIdPeriodo"
        Me.cmbIdPeriodo.Size = New System.Drawing.Size(170, 24)
        Me.cmbIdPeriodo.TabIndex = 5
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(576, 40)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(127, 33)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(827, 76)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(127, 33)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(827, 135)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(127, 33)
        Me.btnModificar.TabIndex = 8
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(827, 191)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(127, 33)
        Me.btnLimpiar.TabIndex = 9
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'dgvOfertas
        '
        Me.dgvOfertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOfertas.Location = New System.Drawing.Point(49, 279)
        Me.dgvOfertas.Name = "dgvOfertas"
        Me.dgvOfertas.RowHeadersWidth = 51
        Me.dgvOfertas.RowTemplate.Height = 24
        Me.dgvOfertas.Size = New System.Drawing.Size(913, 194)
        Me.dgvOfertas.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(312, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ID Oferta"
        '
        'Carrera
        '
        Me.Carrera.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList
        Me.Carrera.AutoSize = True
        Me.Carrera.Location = New System.Drawing.Point(157, 138)
        Me.Carrera.Name = "Carrera"
        Me.Carrera.Size = New System.Drawing.Size(52, 16)
        Me.Carrera.TabIndex = 12
        Me.Carrera.Text = "Carrera"
        '
        'Materia
        '
        Me.Materia.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList
        Me.Materia.AutoSize = True
        Me.Materia.Location = New System.Drawing.Point(157, 252)
        Me.Materia.Name = "Materia"
        Me.Materia.Size = New System.Drawing.Size(51, 16)
        Me.Materia.TabIndex = 13
        Me.Materia.Text = "Estatus"
        '
        'Label5
        '
        Me.Label5.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(156, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Periodo"
        '
        'Label2
        '
        Me.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Materia"
        '
        'txtGrupo
        '
        Me.txtGrupo.Location = New System.Drawing.Point(566, 129)
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(170, 22)
        Me.txtGrupo.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(476, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Grupo"
        '
        'txtGrado
        '
        Me.txtGrado.Location = New System.Drawing.Point(566, 101)
        Me.txtGrado.Name = "txtGrado"
        Me.txtGrado.Size = New System.Drawing.Size(170, 22)
        Me.txtGrado.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(476, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Grado"
        '
        'cmbClvMateria
        '
        Me.cmbClvMateria.FormattingEnabled = True
        Me.cmbClvMateria.Location = New System.Drawing.Point(248, 165)
        Me.cmbClvMateria.Name = "cmbClvMateria"
        Me.cmbClvMateria.Size = New System.Drawing.Size(170, 24)
        Me.cmbClvMateria.TabIndex = 25
        '
        'cmbClvDocente
        '
        Me.cmbClvDocente.FormattingEnabled = True
        Me.cmbClvDocente.Location = New System.Drawing.Point(248, 205)
        Me.cmbClvDocente.Name = "cmbClvDocente"
        Me.cmbClvDocente.Size = New System.Drawing.Size(170, 24)
        Me.cmbClvDocente.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(151, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Docente"
        '
        'cmbClvCarrera
        '
        Me.cmbClvCarrera.FormattingEnabled = True
        Me.cmbClvCarrera.Location = New System.Drawing.Point(247, 135)
        Me.cmbClvCarrera.Name = "cmbClvCarrera"
        Me.cmbClvCarrera.Size = New System.Drawing.Size(170, 24)
        Me.cmbClvCarrera.TabIndex = 28
        '
        'frmGestOferta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 485)
        Me.Controls.Add(Me.cmbClvCarrera)
        Me.Controls.Add(Me.cmbClvDocente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbClvMateria)
        Me.Controls.Add(Me.txtGrado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtGrupo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Materia)
        Me.Controls.Add(Me.Carrera)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvOfertas)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.cmbIdPeriodo)
        Me.Controls.Add(Me.cmbEstatus)
        Me.Controls.Add(Me.txtIdOferta)
        Me.Name = "frmGestOferta"
        Me.Text = "frmGestOferta"
        CType(Me.dgvOfertas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIdOferta As TextBox
    Friend WithEvents cmbEstatus As ComboBox
    Friend WithEvents cmbIdPeriodo As ComboBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents dgvOfertas As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Carrera As Label
    Friend WithEvents Materia As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGrupo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGrado As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbClvMateria As ComboBox
    Friend WithEvents cmbClvDocente As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbClvCarrera As ComboBox
End Class
