<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Struk
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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.panelControl = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnMinimize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.btnClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.crptLaporanStruk = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.panelControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.panelControl
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'panelControl
        '
        Me.panelControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.panelControl.Controls.Add(Me.btnMinimize)
        Me.panelControl.Controls.Add(Me.btnClose)
        Me.panelControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelControl.Location = New System.Drawing.Point(0, 0)
        Me.panelControl.Name = "panelControl"
        Me.panelControl.Size = New System.Drawing.Size(618, 38)
        Me.panelControl.TabIndex = 12
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.btnMinimize.FillColor = System.Drawing.Color.Transparent
        Me.btnMinimize.IconColor = System.Drawing.Color.White
        Me.btnMinimize.Location = New System.Drawing.Point(537, 3)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(33, 29)
        Me.btnMinimize.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FillColor = System.Drawing.Color.Transparent
        Me.btnClose.IconColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(576, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(33, 29)
        Me.btnClose.TabIndex = 0
        '
        'crptLaporanStruk
        '
        Me.crptLaporanStruk.ActiveViewIndex = -1
        Me.crptLaporanStruk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crptLaporanStruk.Cursor = System.Windows.Forms.Cursors.Default
        Me.crptLaporanStruk.Location = New System.Drawing.Point(-1, 38)
        Me.crptLaporanStruk.Name = "crptLaporanStruk"
        Me.crptLaporanStruk.Size = New System.Drawing.Size(619, 367)
        Me.crptLaporanStruk.TabIndex = 11
        '
        'Struk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 405)
        Me.Controls.Add(Me.panelControl)
        Me.Controls.Add(Me.crptLaporanStruk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Struk"
        Me.Text = "Struk"
        Me.panelControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents panelControl As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnMinimize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents crptLaporanStruk As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
