Imports MySql.Data.MySqlClient
Public Class CrystalReport
    Sub Show_Data()
        da = New MySqlDataAdapter("Select * From tbl_transaksi", conn)
        da.Fill(ds, "data")
    End Sub

    Private Sub crptLaporan_Load(sender As Object, e As EventArgs) Handles crptLaporan.Load
        Dim myrpt As New laporan
        Show_Data()
        myrpt.SetDataSource(ds.Tables("data"))
        crptLaporan.ReportSource = Nothing
        crptLaporan.ReportSource = myrpt
    End Sub
End Class