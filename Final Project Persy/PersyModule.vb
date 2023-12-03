Imports MySql.Data.MySqlClient
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
    Public Sub Clear(ByVal form As Form)
        For Each ctr In form.Controls
            If TypeOf ctr Is TextBox Then
                ctr.Text = ""
            ElseIf TypeOf ctr Is ComboBox Then
                DirectCast(ctr, ComboBox).SelectedItem = Nothing
            End If
        Next
    End Sub
End Module
