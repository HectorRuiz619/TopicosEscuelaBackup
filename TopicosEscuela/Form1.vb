Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ' Cadena de conexión a la base de datos MySQL
        Dim cadenaConn As String = "Server=localhost;Database=escuela;Uid=root;Pwd=root;"

        ' Consulta SQL
        Dim queryAlumnos As String = "SELECT * FROM alumno"

        ' Conexión a la base de datos
        Dim conn As New MySqlConnection(cadenaConn)

        Try
            conn.Open() ' Abre la conexión

            ' Adaptador para llenar el DataTable con la consulta SQL
            Dim escuelaDA As New MySqlDataAdapter(queryAlumnos, conn)
            Dim escuelaDT As New DataTable
            escuelaDA.Fill(escuelaDT) ' Llena el DataTable

            ' Cierra la conexión antes de continuar
            conn.Close()

            ' Limpia y actualiza el ReportViewer con los nuevos datos
            ReportViewer1.LocalReport.DataSources.Clear()
            Dim rp As ReportDataSource = New ReportDataSource("DataSet1", escuelaDT)
            ReportViewer1.LocalReport.DataSources.Add(rp)
            ReportViewer1.RefreshReport()

        Catch ex As Exception
            ' Manejo de errores
            MessageBox.Show(ex.Message & vbCrLf & "Error en la ejecución, no se conectó", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Asegura que la conexión se cierre incluso si ocurre un error
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        ' Evento vacío, no es necesario agregar código aquí por ahora
    End Sub
End Class
