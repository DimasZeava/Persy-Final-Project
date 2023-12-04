Public Class Kasir_Form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

    End Sub

    Private Sub btnBilling_Click(sender As Object, e As EventArgs) Handles btnBilling.Click
        btnBilling.FillColor = Color.White
        btnBilling.FillColor2 = Color.White
        btnBilling.ForeColor = Color.Black
        btnBilling.Image = My.Resources.cashier_machine
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        btnBilling.FillColor = Color.Transparent
        btnBilling.FillColor2 = Color.Transparent
        btnBilling.ForeColor = Color.White
        btnBilling.Image = My.Resources.cashier_machine_white
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