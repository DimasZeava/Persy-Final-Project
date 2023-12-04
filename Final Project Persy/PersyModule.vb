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
End Module
