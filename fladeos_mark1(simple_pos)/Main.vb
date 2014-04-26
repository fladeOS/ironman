Imports MySql.Data.MySqlClient

'Siapkan variabel array untuk menampung data transaksi sementara


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

    Public Sub harga()
        If cmbItemTransact.Text <> vbNullString Then
            Try
                Call Koneksi.koneksiku()
                Dim myQuery As String = "SELECT harga from sic_produk where nama_produk = '" & Me.cmbItemTransact.Text & "'"
                Tampilkan = New MySqlCommand(myQuery, Database)
                Dim na As String = Tampilkan.ExecuteScalar()
                Me.txtHargaTransact.Text = na
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
    End Sub

    Public Sub hitung_total()
        If txtJumlahItemTransact.Text <> vbNullString Then
            Try
                Me.txtTotalTransact.Text = CInt(Me.txtHargaTransact.Text) * CInt(Me.txtJumlahItemTransact.Text)
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        ElseIf txtJumlahItemTransact.Text = vbNullString Then
            Me.txtHargaTransact.Text = ""
            Me.txtTotalTransact.Text = ""
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call menu_list()
    End Sub

    Private Sub btnTambahTransact_Click(sender As Object, e As EventArgs) Handles btnTambahTransact.Click

    End Sub


    Private Sub txtJumlahItemTransact_TextChanged(sender As Object, e As EventArgs) Handles txtJumlahItemTransact.TextChanged
        Call harga()
        Call hitung_total()
    End Sub
End Class
