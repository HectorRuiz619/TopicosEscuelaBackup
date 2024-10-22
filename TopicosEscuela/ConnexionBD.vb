Imports MySql.Data.MySqlClient

Public Class ConnexionBD
    Private connectionString As String

    ' Constructor para inicializar la cadena de conexión
    Public Sub New()
        ' Cambiamos el nombre de la base de datos a "escuelatech"
        connectionString = "Server=localhost;Database=escuelatech;Uid=root;Pwd=root;"
    End Sub

    ' Método para obtener la conexión
    Public Function GetConnection() As MySqlConnection
        Try
            Dim conn As New MySqlConnection(connectionString)
            conn.Open() ' Intentar abrir la conexión
            Return conn
        Catch ex As MySqlException
            ' Manejo del error de conexión
            MessageBox.Show("Error al conectar a la base de datos: " & ex.Message)
            Return Nothing
        End Try
    End Function

    ' Método para cerrar la conexión
    Public Sub CloseConnection(conn As MySqlConnection)
        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
            Try
                conn.Close() ' Cerrar la conexión
            Catch ex As MySqlException
                MessageBox.Show("Error al cerrar la conexión: " & ex.Message)
            End Try
        End If
    End Sub
End Class
