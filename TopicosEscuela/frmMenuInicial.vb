Public Class frmMenuInicial
    Private Sub frmMenuInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomizeDesign()
    End Sub

    Private Sub CustomizeDesign()
        ' Ocultar los submenús inicialmente
        Panel4.Visible = False
    End Sub



    Private Sub showSubMenu(SubMenu As Panel)
        ' Mostrar el submenú solo si está oculto; de lo contrario, lo oculta
        If SubMenu.Visible = False Then
            SubMenu.Visible = True ' Mostrar el panel actual
        Else
            SubMenu.Visible = False ' Si ya está visible, lo ocultamos
        End If
    End Sub

    ' Mostrar el submenú de Datos


    ' Mostrar el submenú de Configuraciones
    Private Sub btnConfiguraciones_Click(sender As Object, e As EventArgs) Handles btnConfiguraciones.Click
        '   showSubMenu(Panel3)
    End Sub

    ' Mostrar el submenú de Operaciones
    Private Sub btnOperaciones_Click(sender As Object, e As EventArgs) Handles btnOperaciones.Click
        showSubMenu(Panel4)
    End Sub

    ' Abrir la interfaz de Alumnos
    Private Sub btnAlumno_Click(sender As Object, e As EventArgs)
        Dim frm As New frmGestAlumno()
        frm.Show() ' Mostrar la interfaz de Alumnos
    End Sub

    ' Abrir la interfaz de Docentes
    Private Sub btnDocente_Click(sender As Object, e As EventArgs)
        Dim frm As New frmGestDocente()
        frm.Show() ' Mostrar la interfaz de Docentes
    End Sub

    ' Abrir la interfaz de Carreras
    Private Sub btnCarrera_Click(sender As Object, e As EventArgs)
        Dim frm As New frmGestCalificaciones()
        frm.Show() ' Mostrar la interfaz de Carreras
    End Sub

    Private Sub btnOferta_Click(sender As Object, e As EventArgs) Handles btnOferta.Click
        Dim frm As New frmGestCarrera()
        frm.Show()
    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        Dim frm As New frmGestMaterias()
        frm.Show()
    End Sub

    Private Sub btncaptura_Click(sender As Object, e As EventArgs) Handles btncaptura.Click
        Dim frm As New frmGestDocente()
        frm.Show()
    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        Dim frm As New frmGestAlumno()
        frm.Show()
    End Sub

    Private Sub btnGestPeriodo_Click(sender As Object, e As EventArgs) Handles btnGestPeriodo.Click
        Dim frm As New frmGestPeriodos()
        frm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New frmGestCalificaciones()
        frm.Show()
    End Sub



    Private Sub btngestHorario_Click_1(sender As Object, e As EventArgs) Handles btngestHorario.Click
        Dim frm As New frmGestHorario
        frm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New frmGestOferta
        frm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frm As New frmGestJefeCarrera
        frm.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim frm As New frmGestBaja
        frm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New frmGestParcial
        frm.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim frm As New frmGestPeriodos
        frm.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim frm As New frmGenerarHorario
        frm.Show()
    End Sub

End Class



' Abrir la interfaz de Materias
'Private Sub btnMaterias_Click(sender As Object, e As EventArgs) Handles btnMaterias.Click
' Dim frm As New frmMateria()
'    frm.Show() ' Mostrar la interfaz de Materias
'End Sub

' Abrir la interfaz de Jefe de Carrera
'Private Sub btnJefeCarrera_Click(sender As Object, e As EventArgs) Handles btnJefeCarrera.Click
'Dim frm As New frmJefeCarrera()
'   frm.Show() ' Mostrar la interfaz de Jefe de Carrera
'End Sub

'Private Sub btnOfertaA_Click(sender As Object, e As EventArgs) Handles btnOfertaA.Click
'Dim frm As New frmOfertaAcademica()
'   frm.Show() ' Mostrar la interfaz de Oferta Academica
