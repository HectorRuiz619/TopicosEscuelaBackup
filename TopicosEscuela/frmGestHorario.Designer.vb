<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGestHorario
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
        Me.txtIdHorario = New System.Windows.Forms.TextBox()
        Me.dgvHorarios = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtOpcion = New System.Windows.Forms.TextBox()
        Me.txtPromedio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSemestre = New System.Windows.Forms.TextBox()
        Me.txtIdOferta = New System.Windows.Forms.TextBox()
        Me.txtNControl = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvHorarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIdHorario
        '
        Me.txtIdHorario.Location = New System.Drawing.Point(403, 66)
        Me.txtIdHorario.Name = "txtIdHorario"
        Me.txtIdHorario.Size = New System.Drawing.Size(163, 22)
        Me.txtIdHorario.TabIndex = 0
        '
        'dgvHorarios
        '
        Me.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHorarios.Location = New System.Drawing.Point(44, 305)
        Me.dgvHorarios.Name = "dgvHorarios"
        Me.dgvHorarios.RowHeadersWidth = 51
        Me.dgvHorarios.RowTemplate.Height = 24
        Me.dgvHorarios.Size = New System.Drawing.Size(1127, 190)
        Me.dgvHorarios.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(311, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ID Horario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(225, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Semestre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(225, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Opcion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(225, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Promedio"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(934, 93)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(99, 43)
        Me.btnAgregar.TabIndex = 13
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(934, 161)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(99, 43)
        Me.btnModificar.TabIndex = 14
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(934, 235)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(99, 43)
        Me.btnLimpiar.TabIndex = 15
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(630, 56)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(99, 43)
        Me.btnBuscar.TabIndex = 16
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtOpcion
        '
        Me.txtOpcion.Location = New System.Drawing.Point(297, 182)
        Me.txtOpcion.Name = "txtOpcion"
        Me.txtOpcion.Size = New System.Drawing.Size(163, 22)
        Me.txtOpcion.TabIndex = 23
        '
        'txtPromedio
        '
        Me.txtPromedio.Location = New System.Drawing.Point(297, 224)
        Me.txtPromedio.Name = "txtPromedio"
        Me.txtPromedio.Size = New System.Drawing.Size(163, 22)
        Me.txtPromedio.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(526, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "ID Oferta"
        '
        'txtSemestre
        '
        Me.txtSemestre.Location = New System.Drawing.Point(297, 147)
        Me.txtSemestre.Name = "txtSemestre"
        Me.txtSemestre.Size = New System.Drawing.Size(163, 22)
        Me.txtSemestre.TabIndex = 25
        '
        'txtIdOferta
        '
        Me.txtIdOferta.Location = New System.Drawing.Point(613, 147)
        Me.txtIdOferta.Name = "txtIdOferta"
        Me.txtIdOferta.Size = New System.Drawing.Size(163, 22)
        Me.txtIdOferta.TabIndex = 26
        '
        'txtNControl
        '
        Me.txtNControl.Location = New System.Drawing.Point(613, 197)
        Me.txtNControl.Name = "txtNControl"
        Me.txtNControl.Size = New System.Drawing.Size(163, 22)
        Me.txtNControl.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(526, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 16)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "N. Control"
        '
        'frmGestHorario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1379, 553)
        Me.Controls.Add(Me.txtNControl)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtIdOferta)
        Me.Controls.Add(Me.txtSemestre)
        Me.Controls.Add(Me.txtPromedio)
        Me.Controls.Add(Me.txtOpcion)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvHorarios)
        Me.Controls.Add(Me.txtIdHorario)
        Me.Name = "frmGestHorario"
        Me.Text = "frmGestHorario"
        CType(Me.dgvHorarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIdHorario As TextBox
    Friend WithEvents dgvHorarios As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtOpcion As TextBox
    Friend WithEvents txtPromedio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSemestre As TextBox
    Friend WithEvents txtIdOferta As TextBox
    Friend WithEvents txtNControl As TextBox
    Friend WithEvents Label6 As Label
End Class
