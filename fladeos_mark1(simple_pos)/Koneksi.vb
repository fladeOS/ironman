Imports MySql.Data.MySqlClient
Module Koneksi
    Public Database As New MySqlConnection
    Public SQL As New MySql.Data.MySqlClient.MySqlCommand
    'Public Tampil As MySql.Data.MySqlClient.MySqlDataReader
    'Public gridview As New MySql.Data.MySqlClient.MySqlDataAdapter
    'Public tabel As String
    'Public record As New BindingSource


    '//membuat subrutin
    Public Sub koneksiku()
        Try
            Database.Close()
            Database.ConnectionString = "server=127.0.0.1;" _
                & "user id=root;" _
                & "password=;" _
                & "database=sic"
            Database.Open()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
End Module
