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
        Dim Animation2 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_Form))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.panelMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnReport = New Guna.UI2.WinForms.Guna2GradientButton()
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
        Me.extendPage = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.shortenPage = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.panelMenu.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelControl.SuspendLayout()
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
        Me.panelMenu.Controls.Add(Me.btnReport)
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
        'btnReport
        '
        Me.btnReport.Animated = True
        Me.btnReport.BackColor = System.Drawing.Color.Transparent
        Me.btnReport.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.transitionFormP.SetDecoration(Me.btnReport, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReport.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReport.FillColor = System.Drawing.Color.Transparent
        Me.btnReport.FillColor2 = System.Drawing.Color.Transparent
        Me.btnReport.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.btnReport.ForeColor = System.Drawing.Color.White
        Me.btnReport.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnReport.HoverState.FillColor = System.Drawing.Color.White
        Me.btnReport.HoverState.FillColor2 = System.Drawing.Color.White
        Me.btnReport.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnReport.HoverState.Image = Global.Final_Project_Persy.My.Resources.Resources.report
        Me.btnReport.Image = Global.Final_Project_Persy.My.Resources.Resources.Laporan
        Me.btnReport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnReport.Location = New System.Drawing.Point(3, 218)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(202, 45)
        Me.btnReport.TabIndex = 6
        Me.btnReport.Text = "Laporan"
        Me.btnReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnReport.TextOffset = New System.Drawing.Point(10, 0)
        Me.btnReport.UseTransparentBackground = True
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
        Me.btnDetail.Text = "Menu"
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
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.transitionFormP.DefaultAnimation = Animation2
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
        'Admin_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 506)
        Me.Controls.Add(Me.extendPage)
        Me.Controls.Add(Me.shortenPage)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.panelControl)
        Me.transitionFormP.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin_Form"
        Me.Text = "Admin_Form"
        Me.panelMenu.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents extendPage As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents shortenPage As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents panelMenu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnReport As Guna.UI2.WinForms.Guna2GradientButton
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
End Class
