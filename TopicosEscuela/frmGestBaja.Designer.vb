<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestBaja
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
        Me.cmbAlumnos = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvBajas = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdBaja = New System.Windows.Forms.TextBox()
        Me.txtRason = New System.Windows.Forms.TextBox()
        Me.Rason = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvBajas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbAlumnos
        '
        Me.cmbAlumnos.FormattingEnabled = True
        Me.cmbAlumnos.Location = New System.Drawing.Point(196, 133)
        Me.cmbAlumnos.Name = "cmbAlumnos"
        Me.cmbAlumnos.Size = New System.Drawing.Size(179, 24)
        Me.cmbAlumnos.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Alumno"
        '
        'dgvBajas
        '
        Me.dgvBajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBajas.Location = New System.Drawing.Point(23, 306)
        Me.dgvBajas.Name = "dgvBajas"
        Me.dgvBajas.RowHeadersWidth = 51
        Me.dgvBajas.RowTemplate.Height = 24
        Me.dgvBajas.Size = New System.Drawing.Size(631, 101)
        Me.dgvBajas.TabIndex = 4
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(524, 74)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(130, 41)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(524, 121)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(130, 41)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(524, 168)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(130, 41)
        Me.btnModificar.TabIndex = 7
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(524, 215)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(130, 41)
        Me.btnLimpiar.TabIndex = 8
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ID Baja"
        '
        'txtIdBaja
        '
        Me.txtIdBaja.Location = New System.Drawing.Point(196, 74)
        Me.txtIdBaja.Name = "txtIdBaja"
        Me.txtIdBaja.Size = New System.Drawing.Size(165, 22)
        Me.txtIdBaja.TabIndex = 11
        '
        'txtRason
        '
        Me.txtRason.Location = New System.Drawing.Point(196, 215)
        Me.txtRason.Multiline = True
        Me.txtRason.Name = "txtRason"
        Me.txtRason.Size = New System.Drawing.Size(179, 62)
        Me.txtRason.TabIndex = 12
        '
        'Rason
        '
        Me.Rason.AutoSize = True
        Me.Rason.Location = New System.Drawing.Point(76, 221)
        Me.Rason.Name = "Rason"
        Me.Rason.Size = New System.Drawing.Size(47, 16)
        Me.Rason.TabIndex = 13
        Me.Rason.Text = "Rason"
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(196, 163)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(179, 22)
        Me.dtpFecha.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Fecha"
        '
        'frmGestBaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Rason)
        Me.Controls.Add(Me.txtRason)
        Me.Controls.Add(Me.txtIdBaja)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.dgvBajas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbAlumnos)
        Me.Name = "frmGestBaja"
        Me.Text = "frmGestBaja"
        CType(Me.dgvBajas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbAlumnos As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvBajas As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdBaja As TextBox
    Friend WithEvents txtRason As TextBox
    Friend WithEvents Rason As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label3 As Label
End Class
