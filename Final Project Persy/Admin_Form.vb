Public Class Admin_Form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

    End Sub

    Private Sub btnBarang_Click(sender As Object, e As EventArgs) Handles btnBarang.Click
        PersyModule.Clicked_Color(btnBarang)
        PersyModule.Restore_Color(btnDetail)

        btnDetail.Image = My.Resources.transaction_detail
        btnBarang.Image = My.Resources.product
    End Sub

    Private Sub btnDetail_Click(sender As Object, e As EventArgs) Handles btnDetail.Click
        PersyModule.Clicked_Color(btnDetail)
        PersyModule.Restore_Color(btnBarang)

        btnBarang.Image = My.Resources.Barang
        btnDetail.Image = My.Resources.transaction_detail1
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        PersyModule.Restore_Color(btnBarang)
        PersyModule.Restore_Color(btnDetail)
        PersyModule.HideErrorLogin()

        btnBarang.Image = My.Resources.Barang
        btnDetail.Image = My.Resources.transaction_detail

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

    Private Sub Admin_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class