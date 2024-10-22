<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestParcial
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
        Me.txtidPeriodo = New System.Windows.Forms.TextBox()
        Me.cmbIdParcial = New System.Windows.Forms.ComboBox()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dgvParciales = New System.Windows.Forms.DataGridView()
        Me.btnBuscarParcial = New System.Windows.Forms.Button()
        Me.btnAgregarParcial = New System.Windows.Forms.Button()
        Me.btnModificarParcial = New System.Windows.Forms.Button()
        Me.btnLimpiarParcial = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.cmbIdPeriodo = New System.Windows.Forms.ComboBox()
        CType(Me.dgvParciales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtidPeriodo
        '
        Me.txtidPeriodo.Location = New System.Drawing.Point(172, 127)
        Me.txtidPeriodo.Name = "txtidPeriodo"
        Me.txtidPeriodo.Size = New System.Drawing.Size(172, 22)
        Me.txtidPeriodo.TabIndex = 0
        '
        'cmbIdParcial
        '
        Me.cmbIdParcial.FormattingEnabled = True
        Me.cmbIdParcial.Location = New System.Drawing.Point(418, 74)
        Me.cmbIdParcial.Name = "cmbIdParcial"
        Me.cmbIdParcial.Size = New System.Drawing.Size(172, 24)
        Me.cmbIdParcial.TabIndex = 2
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Location = New System.Drawing.Point(220, 237)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(255, 22)
        Me.dtpFechaInicio.TabIndex = 3
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Location = New System.Drawing.Point(220, 285)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(255, 22)
        Me.dtpFechaFin.TabIndex = 4
        '
        'dgvParciales
        '
        Me.dgvParciales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParciales.Location = New System.Drawing.Point(30, 361)
        Me.dgvParciales.Name = "dgvParciales"
        Me.dgvParciales.RowHeadersWidth = 51
        Me.dgvParciales.RowTemplate.Height = 24
        Me.dgvParciales.Size = New System.Drawing.Size(915, 127)
        Me.dgvParciales.TabIndex = 5
        '
        'btnBuscarParcial
        '
        Me.btnBuscarParcial.Location = New System.Drawing.Point(617, 62)
        Me.btnBuscarParcial.Name = "btnBuscarParcial"
        Me.btnBuscarParcial.Size = New System.Drawing.Size(95, 36)
        Me.btnBuscarParcial.TabIndex = 6
        Me.btnBuscarParcial.Text = "Buscar"
        Me.btnBuscarParcial.UseVisualStyleBackColor = True
        '
        'btnAgregarParcial
        '
        Me.btnAgregarParcial.Location = New System.Drawing.Point(648, 164)
        Me.btnAgregarParcial.Name = "btnAgregarParcial"
        Me.btnAgregarParcial.Size = New System.Drawing.Size(95, 36)
        Me.btnAgregarParcial.TabIndex = 7
        Me.btnAgregarParcial.Text = "Agregar"
        Me.btnAgregarParcial.UseVisualStyleBackColor = True
        '
        'btnModificarParcial
        '
        Me.btnModificarParcial.Location = New System.Drawing.Point(648, 223)
        Me.btnModificarParcial.Name = "btnModificarParcial"
        Me.btnModificarParcial.Size = New System.Drawing.Size(95, 36)
        Me.btnModificarParcial.TabIndex = 8
        Me.btnModificarParcial.Text = "Modificar"
        Me.btnModificarParcial.UseVisualStyleBackColor = True
        '
        'btnLimpiarParcial
        '
        Me.btnLimpiarParcial.Location = New System.Drawing.Point(648, 280)
        Me.btnLimpiarParcial.Name = "btnLimpiarParcial"
        Me.btnLimpiarParcial.Size = New System.Drawing.Size(95, 36)
        Me.btnLimpiarParcial.TabIndex = 9
        Me.btnLimpiarParcial.Text = "Limpiar"
        Me.btnLimpiarParcial.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(325, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Parcial"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(127, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Fecha Inicio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(127, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Fecha Fin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(101, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Periodo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Estado"
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(172, 192)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(172, 24)
        Me.cmbEstado.TabIndex = 15
        '
        'cmbIdPeriodo
        '
        Me.cmbIdPeriodo.FormattingEnabled = True
        Me.cmbIdPeriodo.Location = New System.Drawing.Point(172, 155)
        Me.cmbIdPeriodo.Name = "cmbIdPeriodo"
        Me.cmbIdPeriodo.Size = New System.Drawing.Size(172, 24)
        Me.cmbIdPeriodo.TabIndex = 17
        '
        'frmGestParcial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 547)
        Me.Controls.Add(Me.cmbIdPeriodo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLimpiarParcial)
        Me.Controls.Add(Me.btnModificarParcial)
        Me.Controls.Add(Me.btnAgregarParcial)
        Me.Controls.Add(Me.btnBuscarParcial)
        Me.Controls.Add(Me.dgvParciales)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.cmbIdParcial)
        Me.Controls.Add(Me.txtidPeriodo)
        Me.Name = "frmGestParcial"
        Me.Text = "frmGestParcial"
        CType(Me.dgvParciales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtidPeriodo As TextBox
    Friend WithEvents cmbIdParcial As ComboBox
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents dgvParciales As DataGridView
    Friend WithEvents btnBuscarParcial As Button
    Friend WithEvents btnAgregarParcial As Button
    Friend WithEvents btnModificarParcial As Button
    Friend WithEvents btnLimpiarParcial As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents cmbIdPeriodo As ComboBox
End Class
