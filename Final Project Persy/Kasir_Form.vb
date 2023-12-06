Public Class Kasir_Form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

    End Sub

    Private Sub btnBilling_Click(sender As Object, e As EventArgs) Handles btnBilling.Click
        PersyModule.Clicked_Color(btnBilling)
        PersyModule.Restore_Color(btnHistory)

        btnBilling.Image = My.Resources.cashier_machine
        btnHistory.Image = My.Resources.history_white
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        PersyModule.Clicked_Color(btnHistory)
        PersyModule.Restore_Color(btnBilling)

        btnHistory.Image = My.Resources.history
        btnBilling.Image = My.Resources.cashier_machine_white
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        PersyModule.Restore_Color(btnBilling)
        PersyModule.Restore_Color(btnHistory)
        PersyModule.HideErrorLogin()

        btnBilling.Image = My.Resources.cashier_machine_white
        btnHistory.Image = My.Resources.history_white
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

    Private Sub Kasir_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class