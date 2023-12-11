<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Kasir_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kasir_Form))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.panelMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnListBarang = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnHistory = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnBilling = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.panelControl = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnMinimize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.btnClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.transitionFormP = New Guna.UI2.WinForms.Guna2Transition()
        Me.extendPage = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.shortenPage = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
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
        Me.panelMenu.Controls.Add(Me.btnListBarang)
        Me.panelMenu.Controls.Add(Me.Guna2Separator1)
        Me.panelMenu.Controls.Add(Me.btnLogout)
        Me.panelMenu.Controls.Add(Me.btnHistory)
        Me.panelMenu.Controls.Add(Me.btnBilling)
        Me.panelMenu.Controls.Add(Me.Guna2PictureBox1)
        Me.transitionFormP.SetDecoration(Me.panelMenu, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(46, 548)
        Me.panelMenu.TabIndex = 15
        '
        'btnListBarang
        '
        Me.btnListBarang.Animated = True
        Me.btnListBarang.BackColor = System.Drawing.Color.Transparent
        Me.btnListBarang.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.transitionFormP.SetDecoration(Me.btnListBarang, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnListBarang.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnListBarang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnListBarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnListBarang.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnListBarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnListBarang.FillColor = System.Drawing.Color.Transparent
        Me.btnListBarang.FillColor2 = System.Drawing.Color.Transparent
        Me.btnListBarang.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.btnListBarang.ForeColor = System.Drawing.Color.White
        Me.btnListBarang.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnListBarang.HoverState.FillColor = System.Drawing.Color.White
        Me.btnListBarang.HoverState.FillColor2 = System.Drawing.Color.White
        Me.btnListBarang.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnListBarang.HoverState.Image = Global.Final_Project_Persy.My.Resources.Resources.menu
        Me.btnListBarang.Image = Global.Final_Project_Persy.My.Resources.Resources.menu_white
        Me.btnListBarang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnListBarang.Location = New System.Drawing.Point(3, 116)
        Me.btnListBarang.Name = "btnListBarang"
        Me.btnListBarang.Size = New System.Drawing.Size(202, 45)
        Me.btnListBarang.TabIndex = 6
        Me.btnListBarang.Text = "List Barang"
        Me.btnListBarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnListBarang.TextOffset = New System.Drawing.Point(10, 0)
        Me.btnListBarang.UseTransparentBackground = True
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
        'btnHistory
        '
        Me.btnHistory.Animated = True
        Me.btnHistory.BackColor = System.Drawing.Color.Transparent
        Me.btnHistory.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.transitionFormP.SetDecoration(Me.btnHistory, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHistory.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnHistory.FillColor = System.Drawing.Color.Transparent
        Me.btnHistory.FillColor2 = System.Drawing.Color.Transparent
        Me.btnHistory.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.btnHistory.ForeColor = System.Drawing.Color.White
        Me.btnHistory.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnHistory.HoverState.FillColor = System.Drawing.Color.White
        Me.btnHistory.HoverState.FillColor2 = System.Drawing.Color.White
        Me.btnHistory.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnHistory.HoverState.Image = Global.Final_Project_Persy.My.Resources.Resources.history
        Me.btnHistory.Image = Global.Final_Project_Persy.My.Resources.Resources.history_white
        Me.btnHistory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnHistory.Location = New System.Drawing.Point(3, 218)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(202, 45)
        Me.btnHistory.TabIndex = 2
        Me.btnHistory.Text = "History"
        Me.btnHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnHistory.TextOffset = New System.Drawing.Point(10, 0)
        Me.btnHistory.UseTransparentBackground = True
        '
        'btnBilling
        '
        Me.btnBilling.Animated = True
        Me.btnBilling.BackColor = System.Drawing.Color.Transparent
        Me.btnBilling.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.transitionFormP.SetDecoration(Me.btnBilling, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnBilling.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBilling.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBilling.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBilling.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBilling.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBilling.FillColor = System.Drawing.Color.Transparent
        Me.btnBilling.FillColor2 = System.Drawing.Color.Transparent
        Me.btnBilling.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.btnBilling.ForeColor = System.Drawing.Color.White
        Me.btnBilling.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnBilling.HoverState.FillColor = System.Drawing.Color.White
        Me.btnBilling.HoverState.FillColor2 = System.Drawing.Color.White
        Me.btnBilling.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnBilling.HoverState.Image = Global.Final_Project_Persy.My.Resources.Resources.cashier_machine
        Me.btnBilling.Image = Global.Final_Project_Persy.My.Resources.Resources.cashier_machine_white
        Me.btnBilling.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBilling.Location = New System.Drawing.Point(3, 167)
        Me.btnBilling.Name = "btnBilling"
        Me.btnBilling.Size = New System.Drawing.Size(202, 45)
        Me.btnBilling.TabIndex = 1
        Me.btnBilling.Text = "Billing"
        Me.btnBilling.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBilling.TextOffset = New System.Drawing.Point(10, 0)
        Me.btnBilling.UseTransparentBackground = True
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
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND
        '
        'Kasir_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(918, 506)
        Me.Controls.Add(Me.extendPage)
        Me.Controls.Add(Me.shortenPage)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.panelControl)
        Me.transitionFormP.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Kasir_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Kasir_Form"
        Me.panelMenu.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents extendPage As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents shortenPage As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents panelMenu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnHistory As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnBilling As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents panelControl As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnMinimize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents transitionFormP As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents btnListBarang As Guna.UI2.WinForms.Guna2GradientButton
End Class
