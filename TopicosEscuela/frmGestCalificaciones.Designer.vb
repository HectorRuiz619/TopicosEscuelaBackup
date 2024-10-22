<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestCalificaciones
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
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.txtCalificacion = New System.Windows.Forms.TextBox()
        Me.cmbAlumno = New System.Windows.Forms.ComboBox()
        Me.cmbMateria = New System.Windows.Forms.ComboBox()
        Me.cmbDocente = New System.Windows.Forms.ComboBox()
        Me.cmbPeriodo = New System.Windows.Forms.ComboBox()
        Me.dgvCalificaciones = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbParcial = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtIdCalificacion = New System.Windows.Forms.TextBox()
        Me.cmbHorario = New System.Windows.Forms.ComboBox()
        CType(Me.dgvCalificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUnidad
        '
        Me.txtUnidad.Location = New System.Drawing.Point(234, 248)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(167, 22)
        Me.txtUnidad.TabIndex = 1
        '
        'txtCalificacion
        '
        Me.txtCalificacion.Location = New System.Drawing.Point(234, 149)
        Me.txtCalificacion.Name = "txtCalificacion"
        Me.txtCalificacion.Size = New System.Drawing.Size(167, 22)
        Me.txtCalificacion.TabIndex = 2
        '
        'cmbAlumno
        '
        Me.cmbAlumno.FormattingEnabled = True
        Me.cmbAlumno.Location = New System.Drawing.Point(526, 150)
        Me.cmbAlumno.Name = "cmbAlumno"
        Me.cmbAlumno.Size = New System.Drawing.Size(167, 24)
        Me.cmbAlumno.TabIndex = 3
        '
        'cmbMateria
        '
        Me.cmbMateria.FormattingEnabled = True
        Me.cmbMateria.Location = New System.Drawing.Point(526, 195)
        Me.cmbMateria.Name = "cmbMateria"
        Me.cmbMateria.Size = New System.Drawing.Size(167, 24)
        Me.cmbMateria.TabIndex = 4
        '
        'cmbDocente
        '
        Me.cmbDocente.FormattingEnabled = True
        Me.cmbDocente.Location = New System.Drawing.Point(526, 244)
        Me.cmbDocente.Name = "cmbDocente"
        Me.cmbDocente.Size = New System.Drawing.Size(167, 24)
        Me.cmbDocente.TabIndex = 5
        '
        'cmbPeriodo
        '
        Me.cmbPeriodo.FormattingEnabled = True
        Me.cmbPeriodo.Location = New System.Drawing.Point(816, 156)
        Me.cmbPeriodo.Name = "cmbPeriodo"
        Me.cmbPeriodo.Size = New System.Drawing.Size(218, 24)
        Me.cmbPeriodo.TabIndex = 6
        '
        'dgvCalificaciones
        '
        Me.dgvCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCalificaciones.Location = New System.Drawing.Point(34, 351)
        Me.dgvCalificaciones.Name = "dgvCalificaciones"
        Me.dgvCalificaciones.RowHeadersWidth = 51
        Me.dgvCalificaciones.RowTemplate.Height = 24
        Me.dgvCalificaciones.Size = New System.Drawing.Size(1346, 244)
        Me.dgvCalificaciones.TabIndex = 8
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(824, 59)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(78, 30)
        Me.btnBuscar.TabIndex = 9
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(1121, 140)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(78, 30)
        Me.btnAgregar.TabIndex = 10
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(1121, 198)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(78, 30)
        Me.btnModificar.TabIndex = 11
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(1121, 244)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(78, 30)
        Me.btnLimpiar.TabIndex = 12
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "ID Horario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(120, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Unidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(120, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Calificacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(444, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Docente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(444, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Materia"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(444, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Alumno"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(734, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 16)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Periodo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(734, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Parcial"
        '
        'cmbParcial
        '
        Me.cmbParcial.FormattingEnabled = True
        Me.cmbParcial.Location = New System.Drawing.Point(816, 211)
        Me.cmbParcial.Name = "cmbParcial"
        Me.cmbParcial.Size = New System.Drawing.Size(218, 24)
        Me.cmbParcial.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(550, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 16)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "idCalificacion"
        '
        'txtIdCalificacion
        '
        Me.txtIdCalificacion.Location = New System.Drawing.Point(664, 63)
        Me.txtIdCalificacion.Name = "txtIdCalificacion"
        Me.txtIdCalificacion.Size = New System.Drawing.Size(112, 22)
        Me.txtIdCalificacion.TabIndex = 22
        '
        'cmbHorario
        '
        Me.cmbHorario.FormattingEnabled = True
        Me.cmbHorario.Location = New System.Drawing.Point(234, 200)
        Me.cmbHorario.Name = "cmbHorario"
        Me.cmbHorario.Size = New System.Drawing.Size(167, 24)
        Me.cmbHorario.TabIndex = 24
        '
        'frmGestCalificaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1416, 664)
        Me.Controls.Add(Me.cmbHorario)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtIdCalificacion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbParcial)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.dgvCalificaciones)
        Me.Controls.Add(Me.cmbPeriodo)
        Me.Controls.Add(Me.cmbDocente)
        Me.Controls.Add(Me.cmbMateria)
        Me.Controls.Add(Me.cmbAlumno)
        Me.Controls.Add(Me.txtCalificacion)
        Me.Controls.Add(Me.txtUnidad)
        Me.Name = "frmGestCalificaciones"
        CType(Me.dgvCalificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUnidad As TextBox
    Friend WithEvents txtCalificacion As TextBox
    Friend WithEvents cmbAlumno As ComboBox
    Friend WithEvents cmbMateria As ComboBox
    Friend WithEvents cmbDocente As ComboBox
    Friend WithEvents cmbPeriodo As ComboBox
    Friend WithEvents dgvCalificaciones As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbParcial As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtIdCalificacion As TextBox
    Friend WithEvents cmbHorario As ComboBox
End Class
