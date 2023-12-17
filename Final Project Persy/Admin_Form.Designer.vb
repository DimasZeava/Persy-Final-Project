<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_Form))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.panelMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnDetail = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnBarang = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.panelControl = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnMinimize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.btnClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.transitionFormP = New Guna.UI2.WinForms.Guna2Transition()
        Me.panelTambah = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dgvBarang = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.namaProduk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idProduk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnHapus = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnTambah = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numStock = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.tbxHarga = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbxProduk = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbxKategori = New Guna.UI2.WinForms.Guna2TextBox()
        Me.extendPage = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.shortenPage = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.panelRiwayat = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbRiwayatPembayaran = New System.Windows.Forms.Label()
        Me.dgvRiwayat = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.noinvoice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pelanggan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hapusRiwayat = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.panelMenu.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelControl.SuspendLayout()
        Me.panelTambah.SuspendLayout()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelRiwayat.SuspendLayout()
        CType(Me.dgvRiwayat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.Guna2Separator1)
        Me.panelMenu.Controls.Add(Me.btnLogout)
        Me.panelMenu.Controls.Add(Me.btnDetail)
        Me.panelMenu.Controls.Add(Me.btnBarang)
        Me.panelMenu.Controls.Add(Me.Guna2PictureBox1)
        Me.transitionFormP.SetDecoration(Me.panelMenu, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(46, 548)
        Me.panelMenu.TabIndex = 15
        '
        'Guna2Separator1
        '
        Me.transitionFormP.SetDecoration(Me.Guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Separator1.Location = New System.Drawing.Point(12, 383)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(164, 10)
        Me.Guna2Separator1.TabIndex = 5
        '
        'btnLogout
        '
        Me.btnLogout.Animated = True
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.transitionFormP.SetDecoration(Me.btnLogout, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogout.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogout.FillColor = System.Drawing.Color.Transparent
        Me.btnLogout.FillColor2 = System.Drawing.Color.Transparent
        Me.btnLogout.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnLogout.HoverState.FillColor = System.Drawing.Color.White
        Me.btnLogout.HoverState.FillColor2 = System.Drawing.Color.White
        Me.btnLogout.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnLogout.HoverState.Image = Global.Final_Project_Persy.My.Resources.Resources.logout
        Me.btnLogout.Image = Global.Final_Project_Persy.My.Resources.Resources.log_out
        Me.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.Location = New System.Drawing.Point(3, 417)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(202, 45)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.TextOffset = New System.Drawing.Point(10, 0)
        Me.btnLogout.UseTransparentBackground = True
        '
        'btnDetail
        '
        Me.btnDetail.Animated = True
        Me.btnDetail.BackColor = System.Drawing.Color.Transparent
        Me.btnDetail.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.transitionFormP.SetDecoration(Me.btnDetail, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDetail.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDetail.FillColor = System.Drawing.Color.Transparent
        Me.btnDetail.FillColor2 = System.Drawing.Color.Transparent
        Me.btnDetail.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.btnDetail.ForeColor = System.Drawing.Color.White
        Me.btnDetail.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnDetail.HoverState.FillColor = System.Drawing.Color.White
        Me.btnDetail.HoverState.FillColor2 = System.Drawing.Color.White
        Me.btnDetail.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnDetail.HoverState.Image = Global.Final_Project_Persy.My.Resources.Resources.transaction_detail1
        Me.btnDetail.Image = Global.Final_Project_Persy.My.Resources.Resources.transaction_detail_white
        Me.btnDetail.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDetail.Location = New System.Drawing.Point(3, 167)
        Me.btnDetail.Name = "btnDetail"
        Me.btnDetail.Size = New System.Drawing.Size(202, 45)
        Me.btnDetail.TabIndex = 2
        Me.btnDetail.Text = "Detail Transaksi"
        Me.btnDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDetail.TextOffset = New System.Drawing.Point(10, 0)
        Me.btnDetail.UseTransparentBackground = True
        '
        'btnBarang
        '
        Me.btnBarang.Animated = True
        Me.btnBarang.BackColor = System.Drawing.Color.Transparent
        Me.btnBarang.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.transitionFormP.SetDecoration(Me.btnBarang, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnBarang.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBarang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBarang.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBarang.FillColor = System.Drawing.Color.Transparent
        Me.btnBarang.FillColor2 = System.Drawing.Color.Transparent
        Me.btnBarang.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.btnBarang.ForeColor = System.Drawing.Color.White
        Me.btnBarang.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnBarang.HoverState.FillColor = System.Drawing.Color.White
        Me.btnBarang.HoverState.FillColor2 = System.Drawing.Color.White
        Me.btnBarang.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnBarang.HoverState.Image = Global.Final_Project_Persy.My.Resources.Resources.product
        Me.btnBarang.Image = Global.Final_Project_Persy.My.Resources.Resources.Barang
        Me.btnBarang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBarang.Location = New System.Drawing.Point(3, 116)
        Me.btnBarang.Name = "btnBarang"
        Me.btnBarang.Size = New System.Drawing.Size(202, 45)
        Me.btnBarang.TabIndex = 1
        Me.btnBarang.Text = "Barang"
        Me.btnBarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBarang.TextOffset = New System.Drawing.Point(10, 0)
        Me.btnBarang.UseTransparentBackground = True
        '
        'Guna2PictureBox1
        '
        Me.transitionFormP.SetDecoration(Me.Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox1.Image = Global.Final_Project_Persy.My.Resources.Resources.logo_persy
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(63, 12)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(103, 80)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'panelControl
        '
        Me.panelControl.BackColor = System.Drawing.Color.Transparent
        Me.panelControl.Controls.Add(Me.btnMinimize)
        Me.panelControl.Controls.Add(Me.btnClose)
        Me.transitionFormP.SetDecoration(Me.panelControl, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.panelControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelControl.Location = New System.Drawing.Point(0, 0)
        Me.panelControl.Name = "panelControl"
        Me.panelControl.Size = New System.Drawing.Size(918, 38)
        Me.panelControl.TabIndex = 14
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.transitionFormP.SetDecoration(Me.btnMinimize, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnMinimize.FillColor = System.Drawing.Color.Transparent
        Me.btnMinimize.IconColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnMinimize.Location = New System.Drawing.Point(841, 3)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(33, 29)
        Me.btnMinimize.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.transitionFormP.SetDecoration(Me.btnClose, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnClose.FillColor = System.Drawing.Color.Transparent
        Me.btnClose.IconColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(880, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(33, 29)
        Me.btnClose.TabIndex = 0
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND
        '
        'transitionFormP
        '
        Me.transitionFormP.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide
        Me.transitionFormP.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.transitionFormP.DefaultAnimation = Animation1
        '
        'panelTambah
        '
        Me.panelTambah.BackColor = System.Drawing.Color.Transparent
        Me.panelTambah.Controls.Add(Me.Label2)
        Me.panelTambah.Controls.Add(Me.tbxID)
        Me.panelTambah.Controls.Add(Me.dgvBarang)
        Me.panelTambah.Controls.Add(Me.btnHapus)
        Me.panelTambah.Controls.Add(Me.btnEdit)
        Me.panelTambah.Controls.Add(Me.btnTambah)
        Me.panelTambah.Controls.Add(Me.Label1)
        Me.panelTambah.Controls.Add(Me.numStock)
        Me.panelTambah.Controls.Add(Me.tbxHarga)
        Me.panelTambah.Controls.Add(Me.tbxProduk)
        Me.panelTambah.Controls.Add(Me.tbxKategori)
        Me.transitionFormP.SetDecoration(Me.panelTambah, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.panelTambah.Location = New System.Drawing.Point(63, 38)
        Me.panelTambah.Name = "panelTambah"
        Me.panelTambah.Size = New System.Drawing.Size(824, 456)
        Me.panelTambah.TabIndex = 18
        Me.panelTambah.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.transitionFormP.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ID Produk :"
        '
        'tbxID
        '
        Me.tbxID.BorderColor = System.Drawing.SystemColors.Control
        Me.tbxID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transitionFormP.SetDecoration(Me.tbxID, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tbxID.DefaultText = ""
        Me.tbxID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbxID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbxID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxID.FillColor = System.Drawing.SystemColors.Control
        Me.tbxID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxID.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tbxID.ForeColor = System.Drawing.Color.Black
        Me.tbxID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxID.Location = New System.Drawing.Point(81, 20)
        Me.tbxID.Name = "tbxID"
        Me.tbxID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbxID.PlaceholderForeColor = System.Drawing.Color.Transparent
        Me.tbxID.PlaceholderText = ""
        Me.tbxID.ReadOnly = True
        Me.tbxID.SelectedText = ""
        Me.tbxID.Size = New System.Drawing.Size(152, 16)
        Me.tbxID.TabIndex = 9
        '
        'dgvBarang
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvBarang.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBarang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvBarang.ColumnHeadersHeight = 15
        Me.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.namaProduk, Me.kategori, Me.harga, Me.stock, Me.idProduk})
        Me.transitionFormP.SetDecoration(Me.dgvBarang, Guna.UI2.AnimatorNS.DecorationType.None)
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBarang.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvBarang.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvBarang.Location = New System.Drawing.Point(300, 8)
        Me.dgvBarang.Name = "dgvBarang"
        Me.dgvBarang.RowHeadersVisible = False
        Me.dgvBarang.Size = New System.Drawing.Size(521, 445)
        Me.dgvBarang.TabIndex = 8
        Me.dgvBarang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvBarang.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvBarang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvBarang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvBarang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvBarang.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvBarang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvBarang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvBarang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvBarang.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvBarang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvBarang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvBarang.ThemeStyle.HeaderStyle.Height = 15
        Me.dgvBarang.ThemeStyle.ReadOnly = False
        Me.dgvBarang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvBarang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvBarang.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvBarang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvBarang.ThemeStyle.RowsStyle.Height = 22
        Me.dgvBarang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvBarang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'namaProduk
        '
        Me.namaProduk.HeaderText = "Nama Produk"
        Me.namaProduk.Name = "namaProduk"
        Me.namaProduk.Width = 130
        '
        'kategori
        '
        Me.kategori.HeaderText = "Kategori"
        Me.kategori.Name = "kategori"
        Me.kategori.Width = 131
        '
        'harga
        '
        Me.harga.HeaderText = "Harga"
        Me.harga.Name = "harga"
        Me.harga.Width = 130
        '
        'stock
        '
        Me.stock.HeaderText = "Stock"
        Me.stock.Name = "stock"
        Me.stock.Width = 130
        '
        'idProduk
        '
        Me.idProduk.HeaderText = "Id Produk"
        Me.idProduk.Name = "idProduk"
        Me.idProduk.Visible = False
        '
        'btnHapus
        '
        Me.btnHapus.Animated = True
        Me.btnHapus.AutoRoundedCorners = True
        Me.btnHapus.BackColor = System.Drawing.Color.Transparent
        Me.btnHapus.BorderColor = System.Drawing.Color.Red
        Me.btnHapus.BorderRadius = 20
        Me.btnHapus.BorderThickness = 1
        Me.transitionFormP.SetDecoration(Me.btnHapus, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnHapus.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnHapus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnHapus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHapus.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHapus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnHapus.FillColor = System.Drawing.Color.White
        Me.btnHapus.FillColor2 = System.Drawing.Color.White
        Me.btnHapus.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.btnHapus.ForeColor = System.Drawing.Color.Red
        Me.btnHapus.HoverState.FillColor = System.Drawing.Color.Red
        Me.btnHapus.HoverState.FillColor2 = System.Drawing.Color.Red
        Me.btnHapus.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Location = New System.Drawing.Point(8, 410)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(256, 43)
        Me.btnHapus.TabIndex = 7
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseTransparentBackground = True
        '
        'btnEdit
        '
        Me.btnEdit.Animated = True
        Me.btnEdit.AutoRoundedCorners = True
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.BorderColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnEdit.BorderRadius = 20
        Me.btnEdit.BorderThickness = 1
        Me.transitionFormP.SetDecoration(Me.btnEdit, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEdit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEdit.FillColor = System.Drawing.Color.White
        Me.btnEdit.FillColor2 = System.Drawing.Color.White
        Me.btnEdit.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.btnEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnEdit.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnEdit.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnEdit.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(8, 361)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(256, 43)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseTransparentBackground = True
        '
        'btnTambah
        '
        Me.btnTambah.Animated = True
        Me.btnTambah.AutoRoundedCorners = True
        Me.btnTambah.BackColor = System.Drawing.Color.Transparent
        Me.btnTambah.BorderColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnTambah.BorderRadius = 20
        Me.btnTambah.BorderThickness = 1
        Me.transitionFormP.SetDecoration(Me.btnTambah, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnTambah.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTambah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnTambah.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTambah.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTambah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnTambah.FillColor = System.Drawing.Color.White
        Me.btnTambah.FillColor2 = System.Drawing.Color.White
        Me.btnTambah.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.btnTambah.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnTambah.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnTambah.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnTambah.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnTambah.Location = New System.Drawing.Point(8, 312)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(256, 43)
        Me.btnTambah.TabIndex = 5
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseTransparentBackground = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.transitionFormP.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 34)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Stock Barang"
        '
        'numStock
        '
        Me.numStock.BackColor = System.Drawing.Color.Transparent
        Me.numStock.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transitionFormP.SetDecoration(Me.numStock, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.numStock.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.numStock.Location = New System.Drawing.Point(161, 175)
        Me.numStock.Name = "numStock"
        Me.numStock.Size = New System.Drawing.Size(100, 36)
        Me.numStock.TabIndex = 3
        Me.numStock.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(40, Byte), Integer))
        '
        'tbxHarga
        '
        Me.tbxHarga.BorderRadius = 5
        Me.tbxHarga.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transitionFormP.SetDecoration(Me.tbxHarga, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tbxHarga.DefaultText = ""
        Me.tbxHarga.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbxHarga.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbxHarga.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxHarga.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxHarga.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxHarga.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.tbxHarga.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxHarga.IconLeft = Global.Final_Project_Persy.My.Resources.Resources.rupiah
        Me.tbxHarga.Location = New System.Drawing.Point(5, 132)
        Me.tbxHarga.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbxHarga.Name = "tbxHarga"
        Me.tbxHarga.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbxHarga.PlaceholderText = "Harga"
        Me.tbxHarga.SelectedText = ""
        Me.tbxHarga.Size = New System.Drawing.Size(260, 36)
        Me.tbxHarga.TabIndex = 2
        '
        'tbxProduk
        '
        Me.tbxProduk.BorderRadius = 5
        Me.tbxProduk.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transitionFormP.SetDecoration(Me.tbxProduk, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tbxProduk.DefaultText = ""
        Me.tbxProduk.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbxProduk.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbxProduk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxProduk.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxProduk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxProduk.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.tbxProduk.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxProduk.IconLeft = Global.Final_Project_Persy.My.Resources.Resources.product
        Me.tbxProduk.Location = New System.Drawing.Point(5, 44)
        Me.tbxProduk.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbxProduk.Name = "tbxProduk"
        Me.tbxProduk.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbxProduk.PlaceholderText = "Nama Barang"
        Me.tbxProduk.SelectedText = ""
        Me.tbxProduk.Size = New System.Drawing.Size(260, 36)
        Me.tbxProduk.TabIndex = 1
        '
        'tbxKategori
        '
        Me.tbxKategori.BorderRadius = 5
        Me.tbxKategori.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transitionFormP.SetDecoration(Me.tbxKategori, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tbxKategori.DefaultText = ""
        Me.tbxKategori.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbxKategori.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbxKategori.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxKategori.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxKategori.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxKategori.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.tbxKategori.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxKategori.IconLeft = Global.Final_Project_Persy.My.Resources.Resources.options_lines
        Me.tbxKategori.Location = New System.Drawing.Point(5, 88)
        Me.tbxKategori.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbxKategori.Name = "tbxKategori"
        Me.tbxKategori.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbxKategori.PlaceholderText = "Kategori"
        Me.tbxKategori.SelectedText = ""
        Me.tbxKategori.Size = New System.Drawing.Size(260, 36)
        Me.tbxKategori.TabIndex = 0
        '
        'extendPage
        '
        Me.extendPage.Animated = True
        Me.extendPage.BackColor = System.Drawing.Color.Transparent
        Me.extendPage.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.transitionFormP.SetDecoration(Me.extendPage, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.extendPage.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.extendPage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.extendPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.extendPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.extendPage.FillColor = System.Drawing.Color.White
        Me.extendPage.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.extendPage.ForeColor = System.Drawing.Color.White
        Me.extendPage.Image = Global.Final_Project_Persy.My.Resources.Resources.right_arrow1
        Me.extendPage.Location = New System.Drawing.Point(24, 366)
        Me.extendPage.Name = "extendPage"
        Me.extendPage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.extendPage.Size = New System.Drawing.Size(45, 45)
        Me.extendPage.TabIndex = 17
        Me.extendPage.UseTransparentBackground = True
        '
        'shortenPage
        '
        Me.shortenPage.Animated = True
        Me.shortenPage.BackColor = System.Drawing.Color.Transparent
        Me.shortenPage.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.transitionFormP.SetDecoration(Me.shortenPage, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.shortenPage.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.shortenPage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.shortenPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.shortenPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.shortenPage.FillColor = System.Drawing.Color.White
        Me.shortenPage.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.shortenPage.ForeColor = System.Drawing.Color.White
        Me.shortenPage.Image = Global.Final_Project_Persy.My.Resources.Resources.left_arrow
        Me.shortenPage.Location = New System.Drawing.Point(182, 366)
        Me.shortenPage.Name = "shortenPage"
        Me.shortenPage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.shortenPage.Size = New System.Drawing.Size(45, 45)
        Me.shortenPage.TabIndex = 16
        Me.shortenPage.UseTransparentBackground = True
        Me.shortenPage.Visible = False
        '
        'panelRiwayat
        '
        Me.panelRiwayat.Controls.Add(Me.Guna2TextBox1)
        Me.panelRiwayat.Controls.Add(Me.lbRiwayatPembayaran)
        Me.panelRiwayat.Controls.Add(Me.dgvRiwayat)
        Me.transitionFormP.SetDecoration(Me.panelRiwayat, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.panelRiwayat.Location = New System.Drawing.Point(63, 38)
        Me.panelRiwayat.Name = "panelRiwayat"
        Me.panelRiwayat.Size = New System.Drawing.Size(843, 419)
        Me.panelRiwayat.TabIndex = 20
        Me.panelRiwayat.Visible = False
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transitionFormP.SetDecoration(Me.Guna2TextBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Poppins", 14.0!)
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(988, 59)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(314, 82)
        Me.Guna2TextBox1.TabIndex = 11
        '
        'lbRiwayatPembayaran
        '
        Me.lbRiwayatPembayaran.AutoSize = True
        Me.transitionFormP.SetDecoration(Me.lbRiwayatPembayaran, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.lbRiwayatPembayaran.Font = New System.Drawing.Font("Poppins", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRiwayatPembayaran.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lbRiwayatPembayaran.Location = New System.Drawing.Point(232, 0)
        Me.lbRiwayatPembayaran.Name = "lbRiwayatPembayaran"
        Me.lbRiwayatPembayaran.Size = New System.Drawing.Size(405, 62)
        Me.lbRiwayatPembayaran.TabIndex = 1
        Me.lbRiwayatPembayaran.Text = "Riwayat Pembayaran"
        '
        'dgvRiwayat
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvRiwayat.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRiwayat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRiwayat.ColumnHeadersHeight = 15
        Me.dgvRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvRiwayat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.noinvoice, Me.pelanggan, Me.total, Me.hapusRiwayat})
        Me.transitionFormP.SetDecoration(Me.dgvRiwayat, Guna.UI2.AnimatorNS.DecorationType.None)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRiwayat.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRiwayat.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRiwayat.Location = New System.Drawing.Point(14, 65)
        Me.dgvRiwayat.Name = "dgvRiwayat"
        Me.dgvRiwayat.RowHeadersVisible = False
        Me.dgvRiwayat.Size = New System.Drawing.Size(815, 337)
        Me.dgvRiwayat.TabIndex = 0
        Me.dgvRiwayat.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvRiwayat.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvRiwayat.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvRiwayat.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvRiwayat.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvRiwayat.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvRiwayat.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRiwayat.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dgvRiwayat.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvRiwayat.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRiwayat.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvRiwayat.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvRiwayat.ThemeStyle.HeaderStyle.Height = 15
        Me.dgvRiwayat.ThemeStyle.ReadOnly = False
        Me.dgvRiwayat.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvRiwayat.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRiwayat.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRiwayat.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvRiwayat.ThemeStyle.RowsStyle.Height = 22
        Me.dgvRiwayat.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRiwayat.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'noinvoice
        '
        Me.noinvoice.HeaderText = "Nomor Invoice"
        Me.noinvoice.Name = "noinvoice"
        '
        'pelanggan
        '
        Me.pelanggan.HeaderText = "Nama Pelanggan"
        Me.pelanggan.Name = "pelanggan"
        '
        'total
        '
        Me.total.HeaderText = "Total Pembelian"
        Me.total.Name = "total"
        '
        'hapusRiwayat
        '
        Me.hapusRiwayat.HeaderText = ""
        Me.hapusRiwayat.Name = "hapusRiwayat"
        Me.hapusRiwayat.Text = "Hapus"
        Me.hapusRiwayat.UseColumnTextForButtonValue = True
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Admin_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 506)
        Me.Controls.Add(Me.panelRiwayat)
        Me.Controls.Add(Me.extendPage)
        Me.Controls.Add(Me.shortenPage)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.panelControl)
        Me.Controls.Add(Me.panelTambah)
        Me.transitionFormP.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin_Form"
        Me.Text = "Admin_Form"
        Me.panelMenu.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelControl.ResumeLayout(False)
        Me.panelTambah.ResumeLayout(False)
        Me.panelTambah.PerformLayout()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelRiwayat.ResumeLayout(False)
        Me.panelRiwayat.PerformLayout()
        CType(Me.dgvRiwayat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents extendPage As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents shortenPage As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents panelMenu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnDetail As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnBarang As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents panelControl As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnMinimize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents transitionFormP As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents panelTambah As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents tbxProduk As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbxKategori As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbxHarga As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents numStock As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents btnTambah As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnHapus As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents dgvBarang As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents namaProduk As DataGridViewTextBoxColumn
    Friend WithEvents kategori As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents idProduk As DataGridViewTextBoxColumn
    Friend WithEvents tbxID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents panelRiwayat As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbRiwayatPembayaran As Label
    Friend WithEvents dgvRiwayat As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents noinvoice As DataGridViewTextBoxColumn
    Friend WithEvents pelanggan As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents hapusRiwayat As DataGridViewButtonColumn
End Class
