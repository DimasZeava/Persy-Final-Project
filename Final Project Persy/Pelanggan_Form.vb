Public Class Pelanggan_Form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        btnHome.FillColor = Color.White
        btnHome.FillColor2 = Color.White
        btnHome.ForeColor = Color.Black
        btnHome.Image = My.Resources.home
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        btnHome.FillColor = Color.Transparent
        btnHome.FillColor2 = Color.Transparent
        btnHome.ForeColor = Color.White
        btnHome.Image = My.Resources.output_onlinepngtools

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
End Class