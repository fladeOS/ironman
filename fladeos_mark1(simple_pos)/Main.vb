Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Main

    Private Sub btnItemBaru_Click(sender As Object, e As EventArgs) Handles btnItemBaru.Click
        form_add_item.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Public Sub menu_list()
        'Call Koneksi.koneksiku()
        'data = New DataSet

        '' siapkan data adapter untuk data retrieval
        'Dim da As New SqlDataAdapter("select nama_produk from sic_produk")
        '' siapkan datatable untuk menampung data dari database
        'Dim dt As New DataTable
        '' enclose in try-catch block
        '' untuk menghindari crash jika terjadi kesalahan database
        'Try
        '    ' ambil data dari database
        '    da.Fill(dt)
        '    ' bind data ke combobox
        '    Me.cmbItemTransact.DataSource = dt
        '    Me.cmbItemTransact.ValueMember = "nama_produk"
        '    Me.cmbItemTransact.DisplayMember = "Nama Produk"
        '    ' DONE!!!
        'Catch ex As Exception
        '    MsgBox(ex.ToString())
        'End Try

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
