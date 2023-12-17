Imports MySql.Data.MySqlClient
Public Class Struk
    Sub Show_Data()
        da = New MySqlDataAdapter("select 
            dt.no_invoice, 
            dt.jumlah, 
            t.nama_pembeli, 
            dt.subtotal, 
            p.nama_produk,
            p.kategori,
            p.harga
        from 
            tbl_detailtransaksi dt 
        join 
            tbl_transaksi t on dt.no_invoice = t.no_invoice 
        join 
            tbl_produk p on dt.id_produk = p.id_produk
        where
            dt.no_invoice ='" & no_invoice & "'", conn)
        da.Fill(ds, "strukpembeli")
    End Sub
    Private Sub crptLaporan_Load(sender As Object, e As EventArgs) Handles crptLaporanStruk.Load
        ds.Clear()
        connection()
        Try
            Dim myrpt As New laporanStruk
            Show_Data()
            myrpt.SetDataSource(ds.Tables("strukpembeli"))
            crptLaporanStruk.ReportSource = Nothing
            crptLaporanStruk.ReportSource = myrpt
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class