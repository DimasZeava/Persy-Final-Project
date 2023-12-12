Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Module PersyModule
    Public conn As New MySqlConnection
    Public da As New MySqlDataAdapter
    Public ds As New DataSet

    Public Sub connection()
        conn = New MySqlConnection("
                                    server  = localhost ;
                                    user id = root ;
                                    password = ;
                                    database = db_persy2")
    End Sub
    Public Sub Clear(ByVal panel As Guna2ShadowPanel)
        For Each ctr As Control In panel.Controls
            If TypeOf ctr Is Guna2TextBox Then
                ctr.Text = ""
            ElseIf TypeOf ctr Is Guna2ComboBox Then
                DirectCast(ctr, Guna2ComboBox).SelectedItem = Nothing
            End If
        Next
    End Sub
    Public Sub ClearPanel(ByVal panel As Guna2Panel)
        For Each ctr As Control In panel.Controls
            If TypeOf ctr Is Guna2TextBox Then
                ctr.Text = ""
            ElseIf TypeOf ctr Is Guna2ComboBox Then
                DirectCast(ctr, Guna2ComboBox).SelectedItem = Nothing
            ElseIf TypeOf ctr Is Guna2NumericUpDown Then
                DirectCast(ctr, Guna2NumericUpDown).Value = 0
            End If
        Next
    End Sub

    Public Sub Clicked_Color(ByVal button As Guna2GradientButton)
        button.FillColor = Color.White
        button.FillColor2 = Color.White
        button.ForeColor = Color.Black
    End Sub

    Public Sub Restore_Color(ByVal button As Guna2GradientButton)
        button.FillColor = Color.Transparent
        button.FillColor2 = Color.Transparent
        button.ForeColor = Color.White
    End Sub

    Public Sub HideErrorLogin()
        Login.userIsNot.Visible = False
        Login.passwordIsNot.Visible = False
        Login.noTextintbx.Visible = False
        Login.UNPFalse.Visible = False
    End Sub

    Public Sub HideErrorRegister()
        Login.dataNotAcquire.Visible = False
        Login.userIsNotReg.Visible = False
        Login.mailIsNotReg.Visible = False
        Login.passwordIsNotReg.Visible = False
        Login.roleIsNotReg.Visible = False
        Login.emailCheckFalse.Visible = False
    End Sub

    Public Sub HideErrorForgorPass()
        Login.noTextFP.Visible = False
        Login.mailIsNotFP.Visible = False
        Login.passwordIsNotFP.Visible = False
        Login.rpassIsNotFP.Visible = False
    End Sub
End Module
