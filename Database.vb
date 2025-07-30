Imports System.Data.SqlClient

Public Module Database
    Public Connection As SqlConnection

    Public Function Connect(server As String, database As String, user As String, password As String, useWindowsAuth As Boolean) As Boolean
        Try
            Dim connString As String
            If useWindowsAuth Then
                connString = $"Server={server};Database={database};Trusted_Connection=True;"
            Else
                connString = $"Server={server};Database={database};User Id={user};Password={password};TrustServerCertificate=True;"
            End If

            Connection = New SqlConnection(connString)
            Connection.Open()
            Return True
        Catch ex As Exception
            MessageBox.Show("Connection error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Sub Disconnect()
        If Connection IsNot Nothing AndAlso Connection.State = ConnectionState.Open Then
            Connection.Close()
        End If
    End Sub
End Module
