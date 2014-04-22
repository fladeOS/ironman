<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_add_item
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtIDItemAdd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTambahAdd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNamaItemAdd = New System.Windows.Forms.TextBox()
        Me.txtHargaItemAdd = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnHapusAdd = New System.Windows.Forms.Button()
        Me.btnEditAdd = New System.Windows.Forms.Button()
        Me.gridAdd = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.gridAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIDItemAdd
        '
        Me.txtIDItemAdd.Location = New System.Drawing.Point(127, 79)
        Me.txtIDItemAdd.Name = "txtIDItemAdd"
        Me.txtIDItemAdd.Size = New System.Drawing.Size(195, 20)
        Me.txtIDItemAdd.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tambah Item Baru"
        '
        'btnTambahAdd
        '
        Me.btnTambahAdd.Location = New System.Drawing.Point(247, 181)
        Me.btnTambahAdd.Name = "btnTambahAdd"
        Me.btnTambahAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnTambahAdd.TabIndex = 2
        Me.btnTambahAdd.Text = "Tambah"
        Me.btnTambahAdd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ID Item"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nama Item"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Harga Satuan"
        '
        'txtNamaItemAdd
        '
        Me.txtNamaItemAdd.Location = New System.Drawing.Point(127, 107)
        Me.txtNamaItemAdd.Name = "txtNamaItemAdd"
        Me.txtNamaItemAdd.Size = New System.Drawing.Size(195, 20)
        Me.txtNamaItemAdd.TabIndex = 6
        '
        'txtHargaItemAdd
        '
        Me.txtHargaItemAdd.Location = New System.Drawing.Point(127, 140)
        Me.txtHargaItemAdd.Name = "txtHargaItemAdd"
        Me.txtHargaItemAdd.Size = New System.Drawing.Size(195, 20)
        Me.txtHargaItemAdd.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnHapusAdd)
        Me.GroupBox1.Controls.Add(Me.btnEditAdd)
        Me.GroupBox1.Location = New System.Drawing.Point(341, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(137, 100)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Option"
        '
        'btnHapusAdd
        '
        Me.btnHapusAdd.Location = New System.Drawing.Point(33, 54)
        Me.btnHapusAdd.Name = "btnHapusAdd"
        Me.btnHapusAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnHapusAdd.TabIndex = 10
        Me.btnHapusAdd.Text = "Hapus"
        Me.btnHapusAdd.UseVisualStyleBackColor = True
        '
        'btnEditAdd
        '
        Me.btnEditAdd.Location = New System.Drawing.Point(33, 25)
        Me.btnEditAdd.Name = "btnEditAdd"
        Me.btnEditAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnEditAdd.TabIndex = 9
        Me.btnEditAdd.Text = "Edit"
        Me.btnEditAdd.UseVisualStyleBackColor = True
        '
        'gridAdd
        '
        Me.gridAdd.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.gridAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridAdd.Location = New System.Drawing.Point(27, 221)
        Me.gridAdd.Name = "gridAdd"
        Me.gridAdd.Size = New System.Drawing.Size(451, 235)
        Me.gridAdd.TabIndex = 11
        '
        'form_add_item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 468)
        Me.Controls.Add(Me.gridAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtHargaItemAdd)
        Me.Controls.Add(Me.txtNamaItemAdd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnTambahAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIDItemAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "form_add_item"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Item Baru"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.gridAdd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIDItemAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnTambahAdd As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNamaItemAdd As System.Windows.Forms.TextBox
    Friend WithEvents txtHargaItemAdd As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gridAdd As System.Windows.Forms.DataGridView
    Friend WithEvents btnHapusAdd As System.Windows.Forms.Button
    Friend WithEvents btnEditAdd As System.Windows.Forms.Button
End Class
