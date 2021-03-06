﻿Imports MySql.Data.MySqlClient

Public Class Main

    '//buat array untuk menampung data transaksi
    Dim indeks As Integer = 0
    Dim dataTransaksi(100) As Transaksi

    Private Sub btnItemBaru_Click(sender As Object, e As EventArgs) Handles btnItemBaru.Click
        form_add_item.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub


#Region "Function Logic Hitung"

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
                SQL = New MySqlCommand(myQuery, Database)
                Dim na As String = SQL.ExecuteScalar()
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
            Call Me.reset_field()
        End If
    End Sub

    Public Sub isi_array()
        dataTransaksi(0) = New Transaksi(Me.cmbItemTransact.Text, Me.txtJumlahItemTransact.Text, Me.txtHargaTransact.Text, Me.txtTotalTransact.Text)
        dataTransaksi(1) = New Transaksi("Kopi", "2", "3000", "6000")
        dataTransaksi(2) = New Transaksi(Me.cmbItemTransact.Text, Me.txtJumlahItemTransact.Text, Me.txtHargaTransact.Text, Me.txtTotalTransact.Text)
        dataTransaksi(3) = New Transaksi(Me.cmbItemTransact.Text, Me.txtJumlahItemTransact.Text, Me.txtHargaTransact.Text, Me.txtTotalTransact.Text)

        
        indeks = indeks + 1
    End Sub


    Public Sub add_transaksi()
        Try
            gridTransact.DataSource = dataTransaksi

            gridTransact.Columns(0).Width = 200
            gridTransact.Columns(1).Width = 75
            gridTransact.Columns(2).Width = 140
            gridTransact.Columns(3).Width = 140
            gridTransact.Columns(0).HeaderText = "Nama Menu"
            gridTransact.Columns(1).HeaderText = "Banyaknya"
            gridTransact.Columns(2).HeaderText = "Harga Satuan"
            gridTransact.Columns(3).HeaderText = "Harga Total"


        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Public Sub reset_field()
        Me.txtJumlahItemTransact.Text = ""
        Me.txtHargaTransact.Text = ""
        Me.txtTotalTransact.Text = ""
    End Sub

#End Region


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call menu_list()
    End Sub

    Private Sub btnTambahTransact_Click(sender As Object, e As EventArgs) Handles btnTambahTransact.Click
        Call Me.isi_array()
        Call Me.add_transaksi()
        Call Me.reset_field()
        Me.txtJumlahTotal.Text = indeks
    End Sub


    Private Sub txtJumlahItemTransact_TextChanged(sender As Object, e As EventArgs) Handles txtJumlahItemTransact.TextChanged
        Call harga()
        Call hitung_total()
    End Sub

    Private Sub cmbItemTransact_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbItemTransact.SelectedIndexChanged

    End Sub
End Class
