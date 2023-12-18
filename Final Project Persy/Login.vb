Imports MySql.Data.MySqlClient
Public Class Login
    Dim id_user As String
    Dim accessLevel As String
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PersyModule.connection()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Dim check As Boolean = True
            If tbxPassLogin.Text = "" And tbxUserLogin.Text = "" Then
                noTextintbx.Visible = True
                passwordIsNot.Visible = False
                userIsNot.Visible = False
                UNPFalse.Visible = False
                check = False
            ElseIf tbxPassLogin.Text = "" Then
                passwordIsNot.Visible = True
                userIsNot.Visible = False
                UNPFalse.Visible = False
                noTextintbx.Visible = False
                check = False
            ElseIf tbxUserLogin.Text = "" Then
                userIsNot.Visible = True
                passwordIsNot.Visible = False
                UNPFalse.Visible = False
                noTextintbx.Visible = False
                check = False
            End If

            If check = True Then
                Try
                    userIsNot.Visible = False
                    passwordIsNot.Visible = False
                    noTextintbx.Visible = False

                    ds.Clear()
                    da = New MySqlDataAdapter("SELECT * FROM tbl_user WHERE username = '" & tbxUserLogin.Text & "' AND user_password ='" & tbxPassLogin.Text & "';", conn)
                    da.Fill(ds, "data")

                    If ds.Tables("Data").Rows.Count > 0 Then
                        accessLevel = ds.Tables("data").Rows(0)("role").ToString()
                        Me.Hide()
                        If accessLevel = "Owner" Then
                            Owner_Form.Show()
                        ElseIf accessLevel = "Kasir" Then
                            Kasir_Form.Show()
                        ElseIf accessLevel = "Admin" Then
                            Admin_Form.Show()
                        End If

                        If tgswRemember.Checked = False Then
                            PersyModule.ClearShadowPanel(panelLogin)
                        End If
                    Else
                        UNPFalse.Visible = True
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            Dim check As Boolean = True
            If tbxCUser.Text = "" AndAlso tbxCEmail.Text = "" AndAlso tbxCPass.Text = "" AndAlso cbRoles IsNot Nothing Then
                dataNotAcquire.Visible = True
                userIsNotReg.Visible = False
                mailIsNotReg.Visible = False
                passwordIsNotReg.Visible = False
                roleIsNotReg.Visible = False
                emailCheckFalse.Visible = False
                check = False
            ElseIf tbxCUser.Text = "" Then
                dataNotAcquire.Visible = False
                userIsNotReg.Visible = True
                mailIsNotReg.Visible = False
                passwordIsNotReg.Visible = False
                roleIsNotReg.Visible = False
                emailCheckFalse.Visible = False
                check = False
            ElseIf tbxCEmail.Text = "" Then
                dataNotAcquire.Visible = False
                userIsNotReg.Visible = False
                mailIsNotReg.Visible = True
                passwordIsNotReg.Visible = False
                roleIsNotReg.Visible = False
                emailCheckFalse.Visible = False
                check = False
            ElseIf tbxCPass.Text = "" Then
                dataNotAcquire.Visible = False
                userIsNotReg.Visible = False
                mailIsNotReg.Visible = False
                passwordIsNotReg.Visible = True
                roleIsNotReg.Visible = False
                emailCheckFalse.Visible = False
                check = False
            ElseIf cbRoles.Text = "" Then
                dataNotAcquire.Visible = False
                userIsNotReg.Visible = False
                mailIsNotReg.Visible = False
                passwordIsNotReg.Visible = False
                roleIsNotReg.Visible = True
                emailCheckFalse.Visible = False
                check = False
            End If

            ds.Clear()
            Dim emailAvailability As String
            da = New MySqlDataAdapter("Select * From tbl_user Where email ='" & tbxCEmail.Text & "'", conn)
            da.Fill(ds, "EmailCheck")
            emailAvailability = ds.Tables("EmailCheck").Rows(0)("email").ToString()
            If emailAvailability = tbxCEmail.Text Then
                emailCheckFalse.Visible = True
                check = False
            End If

            If check = True Then
                Dim code As String
                If cbRoles.SelectedItem = "Kasir" Then
                    code = "CSR"
                ElseIf cbRoles.SelectedItem = "Admin" Then
                    code = "ADM"
                ElseIf cbRoles.SelectedItem = "Owner" Then
                    code = "OWN"
                End If

                ds.Clear()
                da = New MySqlDataAdapter("SELECT
                                        CASE
                                            WHEN MAX(CAST(SUBSTRING(id_user, 4, 3)AS UNSIGNED)) IS NULL THEN '" & code & "001'
                                            ELSE CONCAT('" & code & "',LPAD(MAX(CAST(SUBSTRING(id_user, 4, 3)AS UNSIGNED)) + 1, 3, '0'))
                                        END AS nomor
                                       FROM tbl_user
                                       WHERE id_user LIKE '" & code & "%';", conn)
                da.Fill(ds, "Data")
                id_user = ds.Tables("Data").Rows(0).Item(0).ToString

                ds.Clear()
                da = New MySqlDataAdapter("INSERT INTO tbl_user VALUES (?,?,?,?,?)", conn)
                da.SelectCommand.Parameters.AddWithValue("id_user", id_user)
                da.SelectCommand.Parameters.AddWithValue("username", tbxCUser.Text)
                da.SelectCommand.Parameters.AddWithValue("email", tbxCEmail.Text)
                da.SelectCommand.Parameters.AddWithValue("user_password", tbxCPass.Text)
                da.SelectCommand.Parameters.AddWithValue("role", cbRoles.Text)

                da.Fill(ds, "Data")

                PersyModule.ClearShadowPanel(panelRegister)
                panelFPass.Hide()
                panelRegister.Hide()
                panelLogin.Show()
            End If

            PersyModule.HideErrorLogin()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnGanti_Click(sender As Object, e As EventArgs) Handles btnGanti.Click
        Try
            Dim check As Boolean = True
            If tbxFPEmail.Text = "" AndAlso tbxFPNewPass.Text = "" AndAlso tbxFPPass.Text = "" Then
                noTextFP.Visible = True
                mailIsNotFP.Visible = False
                passwordIsNotFP.Visible = False
                rpassIsNotFP.Visible = False
                check = False
            ElseIf tbxFPEmail.Text = "" Then
                noTextFP.Visible = False
                mailIsNotFP.Visible = True
                passwordIsNotFP.Visible = False
                rpassIsNotFP.Visible = False
                check = False
            ElseIf tbxFPNewPass.Text = "" Then
                noTextFP.Visible = False
                mailIsNotFP.Visible = False
                passwordIsNotFP.Visible = True
                rpassIsNotFP.Visible = False
                check = False
            ElseIf tbxFPPass.Text = "" Then
                noTextFP.Visible = False
                mailIsNotFP.Visible = False
                passwordIsNotFP.Visible = False
                rpassIsNotFP.Visible = True
                check = False
            End If

            ds.Clear()
            da = New MySqlDataAdapter("Select * From tbl_user Where email ='" & tbxFPEmail.Text & "'", conn)
            da.Fill(ds, "EmailCheck")

            If check = True AndAlso ds.Tables("EmailCheck").Rows.Count > 0 Then
                emailNotFound.Visible = False
                ds.Clear()
                da = New MySqlDataAdapter("UPDATE tbl_user SET user_password = ? WHERE email = '" & tbxFPEmail.Text & "'", conn)
                da.SelectCommand.Parameters.AddWithValue("user_password", tbxFPPass.Text)
                da.Fill(ds, "Data")

                PersyModule.ClearShadowPanel(panelFPass)
                panelFPass.Hide()
                panelRegister.Hide()
                panelLogin.Show()
            Else
                emailNotFound.Visible = True
            End If

            PersyModule.HideErrorLogin()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub lkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkRegister.LinkClicked
        PersyModule.HideErrorRegister()

        panelLogin.Hide()
        panelRegister.Show()
    End Sub

    Private Sub btnBacklogin_Click(sender As Object, e As EventArgs) Handles btnBacklogin.Click
        PersyModule.HideErrorLogin()

        panelRegister.Hide()
        panelLogin.Show()
    End Sub

    Private Sub btnFPBackLogin_Click(sender As Object, e As EventArgs) Handles btnFPBackLogin.Click
        PersyModule.HideErrorLogin()

        panelFPass.Hide()
        panelLogin.Show()
    End Sub

    Private Sub lkForgot_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkForgot.LinkClicked
        PersyModule.HideErrorForgorPass()

        panelLogin.Hide()
        panelRegister.Hide()
        panelFPass.Show()
    End Sub

    Private Sub iconShow_Click(sender As Object, e As EventArgs) Handles iconShow.Click
        tbxPassLogin.PasswordChar = ""
        iconShow.Hide()
        iconHidenew.Show()
    End Sub

    Private Sub iconHidenew_Click(sender As Object, e As EventArgs) Handles iconHidenew.Click
        tbxPassLogin.PasswordChar = "●"
        iconHidenew.Hide()
        iconShow.Show()
    End Sub

    Private Sub iconShowReg_Click(sender As Object, e As EventArgs) Handles iconShowReg.Click
        tbxCPass.PasswordChar = ""
        iconShowReg.Hide()
        iconHideReg.Show()
    End Sub

    Private Sub iconHideReg_Click(sender As Object, e As EventArgs) Handles iconHideReg.Click
        tbxCPass.PasswordChar = "●"
        iconHideReg.Hide()
        iconShowReg.Show()
    End Sub

    Private Sub iconHideNP_Click(sender As Object, e As EventArgs) Handles iconHideNP.Click
        tbxFPNewPass.PasswordChar = "●"
        iconHideNP.Hide()
        iconShowNP.Show()
    End Sub

    Private Sub iconShowNP_Click(sender As Object, e As EventArgs) Handles iconShowNP.Click
        tbxFPNewPass.PasswordChar = ""
        iconShowNP.Hide()
        iconHideNP.Show()
    End Sub

    Private Sub iconHideRP_Click(sender As Object, e As EventArgs) Handles iconHideRP.Click
        tbxFPPass.PasswordChar = "●"
        iconHideRP.Hide()
        iconShowRP.Show()
    End Sub

    Private Sub iconShowRP_Click(sender As Object, e As EventArgs) Handles iconShowRP.Click
        tbxFPPass.PasswordChar = ""
        iconShowRP.Hide()
        iconHideRP.Show()
    End Sub

End Class