<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestPeriodos
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
        Me.dgvPeriodos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdPeriodo = New System.Windows.Forms.TextBox()
        Me.btnBuscarPeriodo = New System.Windows.Forms.Button()
        Me.btnAgregarPeriodo = New System.Windows.Forms.Button()
        Me.btnModificarPeriodo = New System.Windows.Forms.Button()
        Me.btnLimpiarPeriodo = New System.Windows.Forms.Button()
        Me.txtNombrePeriodo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgvPeriodos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPeriodos
        '
        Me.dgvPeriodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPeriodos.Location = New System.Drawing.Point(128, 477)
        Me.dgvPeriodos.Name = "dgvPeriodos"
        Me.dgvPeriodos.RowHeadersWidth = 51
        Me.dgvPeriodos.RowTemplate.Height = 24
        Me.dgvPeriodos.Size = New System.Drawing.Size(963, 183)
        Me.dgvPeriodos.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(174, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID Periodo"
        '
        'txtIdPeriodo
        '
        Me.txtIdPeriodo.Location = New System.Drawing.Point(279, 85)
        Me.txtIdPeriodo.Name = "txtIdPeriodo"
        Me.txtIdPeriodo.Size = New System.Drawing.Size(204, 22)
        Me.txtIdPeriodo.TabIndex = 2
        '
        'btnBuscarPeriodo
        '
        Me.btnBuscarPeriodo.Location = New System.Drawing.Point(591, 68)
        Me.btnBuscarPeriodo.Name = "btnBuscarPeriodo"
        Me.btnBuscarPeriodo.Size = New System.Drawing.Size(123, 38)
        Me.btnBuscarPeriodo.TabIndex = 3
        Me.btnBuscarPeriodo.Text = "Buscar"
        Me.btnBuscarPeriodo.UseVisualStyleBackColor = True
        '
        'btnAgregarPeriodo
        '
        Me.btnAgregarPeriodo.Location = New System.Drawing.Point(789, 208)
        Me.btnAgregarPeriodo.Name = "btnAgregarPeriodo"
        Me.btnAgregarPeriodo.Size = New System.Drawing.Size(123, 38)
        Me.btnAgregarPeriodo.TabIndex = 4
        Me.btnAgregarPeriodo.Text = "Agregar"
        Me.btnAgregarPeriodo.UseVisualStyleBackColor = True
        '
        'btnModificarPeriodo
        '
        Me.btnModificarPeriodo.Location = New System.Drawing.Point(789, 277)
        Me.btnModificarPeriodo.Name = "btnModificarPeriodo"
        Me.btnModificarPeriodo.Size = New System.Drawing.Size(123, 38)
        Me.btnModificarPeriodo.TabIndex = 5
        Me.btnModificarPeriodo.Text = "Modificar"
        Me.btnModificarPeriodo.UseVisualStyleBackColor = True
        '
        'btnLimpiarPeriodo
        '
        Me.btnLimpiarPeriodo.Location = New System.Drawing.Point(789, 340)
        Me.btnLimpiarPeriodo.Name = "btnLimpiarPeriodo"
        Me.btnLimpiarPeriodo.Size = New System.Drawing.Size(123, 38)
        Me.btnLimpiarPeriodo.TabIndex = 6
        Me.btnLimpiarPeriodo.Text = "Limpiar"
        Me.btnLimpiarPeriodo.UseVisualStyleBackColor = True
        '
        'txtNombrePeriodo
        '
        Me.txtNombrePeriodo.Location = New System.Drawing.Point(279, 129)
        Me.txtNombrePeriodo.Name = "txtNombrePeriodo"
        Me.txtNombrePeriodo.Size = New System.Drawing.Size(209, 22)
        Me.txtNombrePeriodo.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nombre"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Location = New System.Drawing.Point(281, 244)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(262, 22)
        Me.dtpFechaInicio.TabIndex = 9
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Location = New System.Drawing.Point(281, 307)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(262, 22)
        Me.dtpFechaFin.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(176, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Fecha Inicio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(179, 312)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Fecha Fin"
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(281, 194)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(121, 24)
        Me.cmbEstado.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(176, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Estado"
        '
        'frmGestPeriodos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1170, 717)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombrePeriodo)
        Me.Controls.Add(Me.btnLimpiarPeriodo)
        Me.Controls.Add(Me.btnModificarPeriodo)
        Me.Controls.Add(Me.btnAgregarPeriodo)
        Me.Controls.Add(Me.btnBuscarPeriodo)
        Me.Controls.Add(Me.txtIdPeriodo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvPeriodos)
        Me.Name = "frmGestPeriodos"
        Me.Text = "frmGestPeriodos"
        CType(Me.dgvPeriodos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvPeriodos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdPeriodo As TextBox
    Friend WithEvents btnBuscarPeriodo As Button
    Friend WithEvents btnAgregarPeriodo As Button
    Friend WithEvents btnModificarPeriodo As Button
    Friend WithEvents btnLimpiarPeriodo As Button
    Friend WithEvents txtNombrePeriodo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label5 As Label
End Class
