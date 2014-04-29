<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeveloperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.pnlMainLeft = New System.Windows.Forms.Panel()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.pnlLeftTop = New System.Windows.Forms.Panel()
        Me.btnTambahTransact = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnItemBaru = New System.Windows.Forms.Button()
        Me.txtTotalTransact = New System.Windows.Forms.TextBox()
        Me.txtHargaTransact = New System.Windows.Forms.TextBox()
        Me.txtJumlahItemTransact = New System.Windows.Forms.TextBox()
        Me.cmbItemTransact = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlLeftBottom = New System.Windows.Forms.Panel()
        Me.gridTransact = New System.Windows.Forms.DataGridView()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.gridResume = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.pnlMainLeft.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.pnlLeftTop.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnlLeftBottom.SuspendLayout()
        CType(Me.gridTransact, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLeft.SuspendLayout()
        CType(Me.gridResume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1356, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeveloperToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'DeveloperToolStripMenuItem
        '
        Me.DeveloperToolStripMenuItem.Name = "DeveloperToolStripMenuItem"
        Me.DeveloperToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.DeveloperToolStripMenuItem.Text = "&Developer"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1356, 712)
        Me.Panel1.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnlMainLeft)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlLeft)
        Me.SplitContainer1.Size = New System.Drawing.Size(1356, 712)
        Me.SplitContainer1.SplitterDistance = 648
        Me.SplitContainer1.TabIndex = 0
        '
        'pnlMainLeft
        '
        Me.pnlMainLeft.Controls.Add(Me.SplitContainer2)
        Me.pnlMainLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlMainLeft.Name = "pnlMainLeft"
        Me.pnlMainLeft.Size = New System.Drawing.Size(648, 712)
        Me.pnlMainLeft.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.pnlLeftTop)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer2.Panel2.Controls.Add(Me.pnlLeftBottom)
        Me.SplitContainer2.Size = New System.Drawing.Size(648, 712)
        Me.SplitContainer2.SplitterDistance = 303
        Me.SplitContainer2.TabIndex = 0
        '
        'pnlLeftTop
        '
        Me.pnlLeftTop.Controls.Add(Me.btnTambahTransact)
        Me.pnlLeftTop.Controls.Add(Me.GroupBox1)
        Me.pnlLeftTop.Controls.Add(Me.txtTotalTransact)
        Me.pnlLeftTop.Controls.Add(Me.txtHargaTransact)
        Me.pnlLeftTop.Controls.Add(Me.txtJumlahItemTransact)
        Me.pnlLeftTop.Controls.Add(Me.cmbItemTransact)
        Me.pnlLeftTop.Controls.Add(Me.Label5)
        Me.pnlLeftTop.Controls.Add(Me.Label4)
        Me.pnlLeftTop.Controls.Add(Me.Label3)
        Me.pnlLeftTop.Controls.Add(Me.Label2)
        Me.pnlLeftTop.Controls.Add(Me.Label1)
        Me.pnlLeftTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLeftTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeftTop.Name = "pnlLeftTop"
        Me.pnlLeftTop.Size = New System.Drawing.Size(648, 303)
        Me.pnlLeftTop.TabIndex = 0
        '
        'btnTambahTransact
        '
        Me.btnTambahTransact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahTransact.Location = New System.Drawing.Point(285, 237)
        Me.btnTambahTransact.Name = "btnTambahTransact"
        Me.btnTambahTransact.Size = New System.Drawing.Size(136, 27)
        Me.btnTambahTransact.TabIndex = 4
        Me.btnTambahTransact.Text = "Tambah"
        Me.btnTambahTransact.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnProses)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnItemBaru)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(436, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 195)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Option"
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(31, 153)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(136, 27)
        Me.btnProses.TabIndex = 3
        Me.btnProses.Text = "Proses"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(32, 108)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(136, 27)
        Me.btnHapus.TabIndex = 2
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(32, 65)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(136, 27)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnItemBaru
        '
        Me.btnItemBaru.Location = New System.Drawing.Point(31, 25)
        Me.btnItemBaru.Name = "btnItemBaru"
        Me.btnItemBaru.Size = New System.Drawing.Size(136, 27)
        Me.btnItemBaru.TabIndex = 0
        Me.btnItemBaru.Text = "Item Baru"
        Me.btnItemBaru.UseVisualStyleBackColor = True
        '
        'txtTotalTransact
        '
        Me.txtTotalTransact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalTransact.Location = New System.Drawing.Point(148, 199)
        Me.txtTotalTransact.Name = "txtTotalTransact"
        Me.txtTotalTransact.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotalTransact.Size = New System.Drawing.Size(273, 26)
        Me.txtTotalTransact.TabIndex = 26
        '
        'txtHargaTransact
        '
        Me.txtHargaTransact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHargaTransact.Location = New System.Drawing.Point(148, 155)
        Me.txtHargaTransact.Name = "txtHargaTransact"
        Me.txtHargaTransact.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtHargaTransact.Size = New System.Drawing.Size(273, 26)
        Me.txtHargaTransact.TabIndex = 25
        '
        'txtJumlahItemTransact
        '
        Me.txtJumlahItemTransact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJumlahItemTransact.Location = New System.Drawing.Point(148, 113)
        Me.txtJumlahItemTransact.Name = "txtJumlahItemTransact"
        Me.txtJumlahItemTransact.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtJumlahItemTransact.Size = New System.Drawing.Size(100, 26)
        Me.txtJumlahItemTransact.TabIndex = 24
        '
        'cmbItemTransact
        '
        Me.cmbItemTransact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbItemTransact.FormattingEnabled = True
        Me.cmbItemTransact.Location = New System.Drawing.Point(148, 69)
        Me.cmbItemTransact.Name = "cmbItemTransact"
        Me.cmbItemTransact.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbItemTransact.Size = New System.Drawing.Size(273, 28)
        Me.cmbItemTransact.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 20)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Harga Satuan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Banyaknya"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nama Menu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Sistem Informasi Kasir Versi 1"
        '
        'pnlLeftBottom
        '
        Me.pnlLeftBottom.Controls.Add(Me.gridTransact)
        Me.pnlLeftBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLeftBottom.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeftBottom.Name = "pnlLeftBottom"
        Me.pnlLeftBottom.Size = New System.Drawing.Size(648, 405)
        Me.pnlLeftBottom.TabIndex = 0
        '
        'gridTransact
        '
        Me.gridTransact.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridTransact.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gridTransact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridTransact.DefaultCellStyle = DataGridViewCellStyle2
        Me.gridTransact.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridTransact.Location = New System.Drawing.Point(0, 0)
        Me.gridTransact.Name = "gridTransact"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridTransact.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.gridTransact.Size = New System.Drawing.Size(648, 405)
        Me.gridTransact.TabIndex = 0
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlLeft.Controls.Add(Me.gridResume)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(704, 712)
        Me.pnlLeft.TabIndex = 1
        '
        'gridResume
        '
        Me.gridResume.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.gridResume.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridResume.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.gridResume.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridResume.DefaultCellStyle = DataGridViewCellStyle5
        Me.gridResume.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridResume.Location = New System.Drawing.Point(0, 0)
        Me.gridResume.Name = "gridResume"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridResume.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.gridResume.Size = New System.Drawing.Size(704, 712)
        Me.gridResume.TabIndex = 0
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1356, 736)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.pnlMainLeft.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.pnlLeftTop.ResumeLayout(False)
        Me.pnlLeftTop.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.pnlLeftBottom.ResumeLayout(False)
        CType(Me.gridTransact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLeft.ResumeLayout(False)
        CType(Me.gridResume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeveloperToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents pnlMainLeft As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents pnlLeftTop As System.Windows.Forms.Panel
    Friend WithEvents txtTotalTransact As System.Windows.Forms.TextBox
    Friend WithEvents txtHargaTransact As System.Windows.Forms.TextBox
    Friend WithEvents txtJumlahItemTransact As System.Windows.Forms.TextBox
    Friend WithEvents cmbItemTransact As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnItemBaru As System.Windows.Forms.Button
    Friend WithEvents btnTambahTransact As System.Windows.Forms.Button
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents pnlLeftBottom As System.Windows.Forms.Panel
    Friend WithEvents gridTransact As System.Windows.Forms.DataGridView
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents gridResume As System.Windows.Forms.DataGridView

End Class
