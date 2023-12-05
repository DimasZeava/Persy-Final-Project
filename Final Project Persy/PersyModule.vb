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
End Module
