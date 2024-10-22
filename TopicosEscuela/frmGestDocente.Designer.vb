<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestDocente
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
        Me.btnLimpiarDocente = New System.Windows.Forms.Button()
        Me.btnModificarDocente = New System.Windows.Forms.Button()
        Me.btnAgregarDocente = New System.Windows.Forms.Button()
        Me.btnBuscarDocente = New System.Windows.Forms.Button()
        Me.dgvDocentes = New System.Windows.Forms.DataGridView()
        Me.txtPerfil = New System.Windows.Forms.TextBox()
        Me.txtNombreDocente = New System.Windows.Forms.TextBox()
        Me.txtClaveDocente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        CType(Me.dgvDocentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLimpiarDocente
        '
        Me.btnLimpiarDocente.Location = New System.Drawing.Point(583, 170)
        Me.btnLimpiarDocente.Name = "btnLimpiarDocente"
        Me.btnLimpiarDocente.Size = New System.Drawing.Size(80, 26)
        Me.btnLimpiarDocente.TabIndex = 21
        Me.btnLimpiarDocente.Text = "Limpiar"
        Me.btnLimpiarDocente.UseVisualStyleBackColor = True
        '
        'btnModificarDocente
        '
        Me.btnModificarDocente.Location = New System.Drawing.Point(583, 126)
        Me.btnModificarDocente.Name = "btnModificarDocente"
        Me.btnModificarDocente.Size = New System.Drawing.Size(80, 26)
        Me.btnModificarDocente.TabIndex = 20
        Me.btnModificarDocente.Text = "Modificar"
        Me.btnModificarDocente.UseVisualStyleBackColor = True
        '
        'btnAgregarDocente
        '
        Me.btnAgregarDocente.Location = New System.Drawing.Point(583, 80)
        Me.btnAgregarDocente.Name = "btnAgregarDocente"
        Me.btnAgregarDocente.Size = New System.Drawing.Size(80, 26)
        Me.btnAgregarDocente.TabIndex = 19
        Me.btnAgregarDocente.Text = "Agregar"
        Me.btnAgregarDocente.UseVisualStyleBackColor = True
        '
        'btnBuscarDocente
        '
        Me.btnBuscarDocente.Location = New System.Drawing.Point(457, 39)
        Me.btnBuscarDocente.Name = "btnBuscarDocente"
        Me.btnBuscarDocente.Size = New System.Drawing.Size(99, 27)
        Me.btnBuscarDocente.TabIndex = 18
        Me.btnBuscarDocente.Text = "Buscar"
        Me.btnBuscarDocente.UseVisualStyleBackColor = True
        '
        'dgvDocentes
        '
        Me.dgvDocentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocentes.Location = New System.Drawing.Point(28, 289)
        Me.dgvDocentes.Name = "dgvDocentes"
        Me.dgvDocentes.RowHeadersWidth = 51
        Me.dgvDocentes.RowTemplate.Height = 24
        Me.dgvDocentes.Size = New System.Drawing.Size(749, 120)
        Me.dgvDocentes.TabIndex = 17
        '
        'txtPerfil
        '
        Me.txtPerfil.Location = New System.Drawing.Point(254, 154)
        Me.txtPerfil.Multiline = True
        Me.txtPerfil.Name = "txtPerfil"
        Me.txtPerfil.Size = New System.Drawing.Size(277, 98)
        Me.txtPerfil.TabIndex = 16
        '
        'txtNombreDocente
        '
        Me.txtNombreDocente.Location = New System.Drawing.Point(254, 72)
        Me.txtNombreDocente.Name = "txtNombreDocente"
        Me.txtNombreDocente.Size = New System.Drawing.Size(175, 22)
        Me.txtNombreDocente.TabIndex = 15
        '
        'txtClaveDocente
        '
        Me.txtClaveDocente.Location = New System.Drawing.Point(254, 44)
        Me.txtClaveDocente.Name = "txtClaveDocente"
        Me.txtClaveDocente.Size = New System.Drawing.Size(175, 22)
        Me.txtClaveDocente.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(134, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Perfil Docente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(134, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nombre Docente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(161, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ID Docente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(134, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Nombre Docente"
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(254, 106)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(156, 24)
        Me.cmbEstado.TabIndex = 23
        '
        'frmGestDocente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnLimpiarDocente)
        Me.Controls.Add(Me.btnModificarDocente)
        Me.Controls.Add(Me.btnAgregarDocente)
        Me.Controls.Add(Me.btnBuscarDocente)
        Me.Controls.Add(Me.dgvDocentes)
        Me.Controls.Add(Me.txtPerfil)
        Me.Controls.Add(Me.txtNombreDocente)
        Me.Controls.Add(Me.txtClaveDocente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmGestDocente"
        Me.Text = "frmGestDocente"
        CType(Me.dgvDocentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLimpiarDocente As Button
    Friend WithEvents btnModificarDocente As Button
    Friend WithEvents btnAgregarDocente As Button
    Friend WithEvents btnBuscarDocente As Button
    Friend WithEvents dgvDocentes As DataGridView
    Friend WithEvents txtPerfil As TextBox
    Friend WithEvents txtNombreDocente As TextBox
    Friend WithEvents txtClaveDocente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbEstado As ComboBox
End Class
