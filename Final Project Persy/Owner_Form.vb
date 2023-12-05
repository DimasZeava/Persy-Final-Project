Public Class Owner_Form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        PersyModule.Clicked_Color(btnHome)

        PersyModule.Restore_Color(btnReport)
        PersyModule.Restore_Color(btnProfile)
        PersyModule.Restore_Color(btnDetail)

        btnHome.Image = My.Resources.home
        btnReport.Image = My.Resources.Laporan
        btnDetail.Image = My.Resources.history
        btnProfile.Image = My.Resources.output_onlinepngtools__1_
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        PersyModule.Clicked_Color(btnReport)

        PersyModule.Restore_Color(btnHome)
        PersyModule.Restore_Color(btnProfile)
        PersyModule.Restore_Color(btnDetail)

        btnReport.Image = My.Resources.report
        btnHome.Image = My.Resources.output_onlinepngtools
        btnDetail.Image = My.Resources.history_white
        btnProfile.Image = My.Resources.output_onlinepngtools__1_
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        PersyModule.Clicked_Color(btnProfile)

        PersyModule.Restore_Color(btnHome)
        PersyModule.Restore_Color(btnReport)
        PersyModule.Restore_Color(btnDetail)

        btnReport.Image = My.Resources.Laporan
        btnHome.Image = My.Resources.output_onlinepngtools
        btnDetail.Image = My.Resources.history_white
        btnProfile.Image = My.Resources.user1
    End Sub

    Private Sub btnDetail_Click(sender As Object, e As EventArgs) Handles btnDetail.Click
        PersyModule.Clicked_Color(btnDetail)

        PersyModule.Restore_Color(btnHome)
        PersyModule.Restore_Color(btnProfile)
        PersyModule.Restore_Color(btnReport)

        btnReport.Image = My.Resources.Laporan
        btnHome.Image = My.Resources.output_onlinepngtools
        btnDetail.Image = My.Resources.history
        btnProfile.Image = My.Resources.output_onlinepngtools__1_
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        PersyModule.Restore_Color(btnHome)
        PersyModule.Restore_Color(btnReport)
        PersyModule.Restore_Color(btnProfile)
        PersyModule.Restore_Color(btnDetail)

        btnHome.Image = My.Resources.output_onlinepngtools
        btnReport.Image = My.Resources.Laporan
        btnDetail.Image = My.Resources.history_white
        btnProfile.Image = My.Resources.output_onlinepngtools__1_

        Me.Hide()
        Login.Show()
    End Sub

    Private Sub shortenPage_Click(sender As Object, e As EventArgs) Handles shortenPage.Click
        extendPage.Visible = True
        shortenPage.Visible = False
        panelMenu.Visible = False
        panelMenu.Width = 46

        transitionFormP.ShowSync(panelMenu)
    End Sub

    Private Sub extendPage_Click(sender As Object, e As EventArgs) Handles extendPage.Click
        extendPage.Visible = False
        shortenPage.Visible = True
        panelMenu.Visible = False
        panelMenu.Width = 204

        transitionFormP.ShowSync(panelMenu)
    End Sub

    Private Sub Owner_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class