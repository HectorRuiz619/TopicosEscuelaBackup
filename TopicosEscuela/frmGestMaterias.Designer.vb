<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestMaterias
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
        Me.txtClaveMateria = New System.Windows.Forms.TextBox()
        Me.txtNombreMateria = New System.Windows.Forms.TextBox()
        Me.txtUnidades = New System.Windows.Forms.TextBox()
        Me.dgvMaterias = New System.Windows.Forms.DataGridView()
        Me.btnBuscarMateria = New System.Windows.Forms.Button()
        Me.btnModificarMateria = New System.Windows.Forms.Button()
        Me.btnAgregarMateria = New System.Windows.Forms.Button()
        Me.btnLimpiarMateria = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbIdCarrera = New System.Windows.Forms.ComboBox()
        CType(Me.dgvMaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtClaveMateria
        '
        Me.txtClaveMateria.Location = New System.Drawing.Point(173, 56)
        Me.txtClaveMateria.Name = "txtClaveMateria"
        Me.txtClaveMateria.Size = New System.Drawing.Size(169, 22)
        Me.txtClaveMateria.TabIndex = 0
        '
        'txtNombreMateria
        '
        Me.txtNombreMateria.Location = New System.Drawing.Point(173, 97)
        Me.txtNombreMateria.Name = "txtNombreMateria"
        Me.txtNombreMateria.Size = New System.Drawing.Size(169, 22)
        Me.txtNombreMateria.TabIndex = 1
        '
        'txtUnidades
        '
        Me.txtUnidades.Location = New System.Drawing.Point(173, 149)
        Me.txtUnidades.Name = "txtUnidades"
        Me.txtUnidades.Size = New System.Drawing.Size(169, 22)
        Me.txtUnidades.TabIndex = 2
        '
        'dgvMaterias
        '
        Me.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMaterias.Location = New System.Drawing.Point(12, 243)
        Me.dgvMaterias.Name = "dgvMaterias"
        Me.dgvMaterias.RowHeadersWidth = 51
        Me.dgvMaterias.RowTemplate.Height = 24
        Me.dgvMaterias.Size = New System.Drawing.Size(676, 182)
        Me.dgvMaterias.TabIndex = 3
        '
        'btnBuscarMateria
        '
        Me.btnBuscarMateria.Location = New System.Drawing.Point(416, 34)
        Me.btnBuscarMateria.Name = "btnBuscarMateria"
        Me.btnBuscarMateria.Size = New System.Drawing.Size(103, 34)
        Me.btnBuscarMateria.TabIndex = 4
        Me.btnBuscarMateria.Text = "Buscar"
        Me.btnBuscarMateria.UseVisualStyleBackColor = True
        '
        'btnModificarMateria
        '
        Me.btnModificarMateria.Location = New System.Drawing.Point(416, 109)
        Me.btnModificarMateria.Name = "btnModificarMateria"
        Me.btnModificarMateria.Size = New System.Drawing.Size(103, 34)
        Me.btnModificarMateria.TabIndex = 5
        Me.btnModificarMateria.Text = "Modificar"
        Me.btnModificarMateria.UseVisualStyleBackColor = True
        '
        'btnAgregarMateria
        '
        Me.btnAgregarMateria.Location = New System.Drawing.Point(416, 147)
        Me.btnAgregarMateria.Name = "btnAgregarMateria"
        Me.btnAgregarMateria.Size = New System.Drawing.Size(103, 34)
        Me.btnAgregarMateria.TabIndex = 6
        Me.btnAgregarMateria.Text = "Agregar"
        Me.btnAgregarMateria.UseVisualStyleBackColor = True
        '
        'btnLimpiarMateria
        '
        Me.btnLimpiarMateria.Location = New System.Drawing.Point(416, 187)
        Me.btnLimpiarMateria.Name = "btnLimpiarMateria"
        Me.btnLimpiarMateria.Size = New System.Drawing.Size(103, 34)
        Me.btnLimpiarMateria.TabIndex = 7
        Me.btnLimpiarMateria.Text = "Limpiar"
        Me.btnLimpiarMateria.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Clave Materia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nombre Materia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Unidades"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(64, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Carrera"
        '
        'cmbIdCarrera
        '
        Me.cmbIdCarrera.FormattingEnabled = True
        Me.cmbIdCarrera.Location = New System.Drawing.Point(173, 187)
        Me.cmbIdCarrera.Name = "cmbIdCarrera"
        Me.cmbIdCarrera.Size = New System.Drawing.Size(132, 24)
        Me.cmbIdCarrera.TabIndex = 13
        '
        'frmGestMaterias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 450)
        Me.Controls.Add(Me.cmbIdCarrera)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLimpiarMateria)
        Me.Controls.Add(Me.btnAgregarMateria)
        Me.Controls.Add(Me.btnModificarMateria)
        Me.Controls.Add(Me.btnBuscarMateria)
        Me.Controls.Add(Me.dgvMaterias)
        Me.Controls.Add(Me.txtUnidades)
        Me.Controls.Add(Me.txtNombreMateria)
        Me.Controls.Add(Me.txtClaveMateria)
        Me.Name = "frmGestMaterias"
        Me.Text = "frmGestMaterias"
        CType(Me.dgvMaterias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtClaveMateria As TextBox
    Friend WithEvents txtNombreMateria As TextBox
    Friend WithEvents txtUnidades As TextBox
    Friend WithEvents dgvMaterias As DataGridView
    Friend WithEvents btnBuscarMateria As Button
    Friend WithEvents btnModificarMateria As Button
    Friend WithEvents btnAgregarMateria As Button
    Friend WithEvents btnLimpiarMateria As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbIdCarrera As ComboBox
End Class
