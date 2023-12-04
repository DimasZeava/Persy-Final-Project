Public Class Admin_Form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

    End Sub

    Private Sub btnBarang_Click(sender As Object, e As EventArgs) Handles btnBarang.Click
        btnBarang.FillColor = Color.White
        btnBarang.FillColor2 = Color.White
        btnBarang.ForeColor = Color.Black
        btnBarang.Image = My.Resources.product
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        btnBarang.FillColor = Color.Transparent
        btnBarang.FillColor2 = Color.Transparent
        btnBarang.ForeColor = Color.White
        btnBarang.Image = My.Resources.Barang
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