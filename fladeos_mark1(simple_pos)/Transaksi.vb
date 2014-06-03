Public Class Transaksi

    Private namaMenu As String
    Public Property nama_menu() As String
        Get
            Return NamaMenu
        End Get

        Set(ByVal value As String)
            namaMenu = value
        End Set
    End Property

    Private kuantitasMenu As String
    Public Property kuantitas_menu() As String
        Get
            Return KuantitasMenu
        End Get
        Set(ByVal value As String)
            kuantitasMenu = value
        End Set
    End Property

    Private hargaMenu As String
    Public Property harga_menu() As String
        Get
            Return HargaMenu
        End Get
        Set(ByVal value As String)
            hargaMenu = value
        End Set
    End Property

    Private totalHarga As String
    Public Property total_harga() As String
        Get
            Return totalHarga
        End Get
        Set(ByVal value As String)
            totalHarga = value
        End Set
    End Property

    Public Sub New(ByVal namaMenunya As String, ByVal kuantitasMenunya As String, ByVal hargaMenunya As String, ByVal totalHarganya As String)
        namaMenu = namaMenunya
        kuantitasMenu = kuantitasMenunya
        hargaMenu = hargaMenunya
        totalHarga = totalHarganya
    End Sub
End Class
