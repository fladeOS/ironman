Public Class Contoh

    'pertama buat sebuah array multidimensional untuk menyimpan transaksi
    Dim iniArray(2, 1) As String
    Dim iniArrayJuga() As String = {"1", "2"}

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DataGridView1.DataSource = iniArrayJuga
        Me.DataGridView1.Columns(0).HeaderText = "Kolom 1"
        Me.DataGridView1.Columns(1).HeaderText = "Kolom 2"
    End Sub

    Public Sub masukkan_array()
        iniArray(0, 0) = "0 ke 0"
        iniArray(0, 1) = "0 ke 1"
        iniArray(1, 0) = "1 ke 0"
        iniArray(1, 1) = "1 ke 1"
        iniArray(2, 0) = "2 ke 0"
        iniArray(2, 1) = "2 ke 1"
    End Sub


    Private Sub Contoh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DataGridView1.DataSource = iniArrayJuga
        Me.DataGridView1.Columns(0).HeaderText = "Kolom 1"
        Me.DataGridView1.Columns(1).HeaderText = "Kolom 2"
    End Sub
End Class