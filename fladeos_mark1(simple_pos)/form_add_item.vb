Public Class form_add_item

    Private Sub btnTambahAdd_Click(sender As Object, e As EventArgs) Handles btnTambahAdd.Click
        If Me.txtIDItemAdd.Text <> vbNullString And Me.txtNamaItemAdd.Text <> vbNullString And Me.txtHargaItemAdd.Text <> vbNullString Then
            Try
                Call Koneksi.koneksiku()
                SQL.Connection = Database
                SQL.CommandType = CommandType.Text
                SQL.CommandText = "insert into sic_produk values('" & txtIDItemAdd.Text & "','" & txtNamaItemAdd.Text & "','" & txtHargaItemAdd.Text & "')"
                SQL.ExecuteNonQuery()
                MessageBox.Show("Berhasil tambahkan " & txtNamaItemAdd.Text)
                Call Record()
                Call Main.menu_list()
                Me.txtIDItemAdd.Text = ""
                Me.txtNamaItemAdd.Text = ""
                Me.txtHargaItemAdd.Text = ""
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        Else
            MessageBox.Show("Tidak Boleh Kosong")
        End If
    End Sub

    Public Sub Record()
        Try
            Call Koneksi.koneksiku()
            Dim data As New DataSet
            Dim tabel As String = "select * from sic_produk"
            Dim gridview As New MySql.Data.MySqlClient.MySqlDataAdapter(tabel, Database)
            gridview.Fill(data, "sic_produk")
            Dim DataGridView As New DataView(data.Tables("sic_produk"))
            Me.gridAdd.DataSource = DataGridView
            Me.gridAdd.Columns(0).HeaderText = "ID Item"
            Me.gridAdd.Columns(1).HeaderText = "Nama Item"
            Me.gridAdd.Columns(2).HeaderText = "Harga Satuan"
            Me.btnEditAdd.Enabled = False
            Me.btnHapusAdd.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub form_add_item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Record()
    End Sub

    Private Sub gridAdd_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles gridAdd.MouseDoubleClick
        Try
            Me.txtIDItemAdd.Text = Me.gridAdd.SelectedCells(0).Value
            Me.txtNamaItemAdd.Text = Me.gridAdd.SelectedCells(1).Value
            Me.txtHargaItemAdd.Text = Me.gridAdd.SelectedCells(2).Value
            Me.btnEditAdd.Enabled = True
            Me.btnHapusAdd.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub btnEditAdd_Click(sender As Object, e As EventArgs) Handles btnEditAdd.Click
        Try
            Call Koneksi.koneksiku()
            SQL.Connection = Database
            SQL.CommandType = CommandType.Text
            SQL.CommandText = "UPDATE sic_produk SET nama_produk = '" & Me.txtNamaItemAdd.Text & "', harga = '" & Me.txtHargaItemAdd.Text & "'where id_produk = '" & Me.txtIDItemAdd.Text & "'"
            SQL.ExecuteNonQuery()
            Call Record()
            Me.txtIDItemAdd.Text = ""
            Me.txtNamaItemAdd.Text = ""
            Me.txtHargaItemAdd.Text = ""
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub btnHapusAdd_Click(sender As Object, e As EventArgs) Handles btnHapusAdd.Click
        Try
            Call Koneksi.koneksiku()
            SQL.Connection = Database
            SQL.CommandType = CommandType.Text
            Dim answer As DialogResult
            answer = MessageBox.Show("Yakin Ingin Hapus?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If answer = vbYes Then
                SQL.CommandText = "DELETE from sic_produk WHERE id_produk = '" & Me.txtIDItemAdd.Text & "'"
                SQL.ExecuteNonQuery()
                Call Record()
                Me.txtIDItemAdd.Text = ""
                Me.txtNamaItemAdd.Text = ""
                Me.txtHargaItemAdd.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub gridAdd_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridAdd.CellContentClick

    End Sub
End Class