Imports MySql.Data.MySqlClient

Public Class Main

    Private Sub btnItemBaru_Click(sender As Object, e As EventArgs) Handles btnItemBaru.Click
        form_add_item.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Public Sub menu_list()
        Try
        Call Koneksi.koneksiku()
        Dim myQuery As String = "select nama_produk from sic_produk"
        Dim myAdapter As New MySqlDataAdapter(myQuery, Database)
        Dim myDataSet As New DataSet
        myAdapter.Fill(myDataSet, "sic_produk")
        With cmbItemTransact
            .DataSource = myDataSet.Tables("sic_produk")
                .DisplayMember = "nama_produk"
                .ValueMember = "nama_produk"
            End With
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call menu_list()
    End Sub
End Class
