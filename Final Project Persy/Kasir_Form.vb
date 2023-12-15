Imports MySql.Data.MySqlClient
Public Class Kasir_Form
    Sub Show_Data()
        ds.Clear()
        da = New MySqlDataAdapter("SELECT id_produk, nama_produk, kategori, harga FROM tbl_produk", conn)

        da.Fill(ds, "produk")
        dgvListBarang.Rows.Clear()

        For i As Integer = 0 To ds.Tables("produk").Rows.Count - 1
            dgvListBarang.Rows.Add(ds.Tables("produk").Rows(i).Item(0).ToString,
                               ds.Tables("produk").Rows(i).Item(1).ToString,
                               ds.Tables("produk").Rows(i).Item(2).ToString,
                               ds.Tables("produk").Rows(i).Item(3).ToString()
           )
        Next
    End Sub

    Sub Invoice()
        ds.Clear()
        da = New MySqlDataAdapter("SELECT CASE WHEN MAX(CAST(SUBSTRING(no_invoice, 5, 3) AS UNSIGNED)) IS NULL 
        THEN 1 ELSE MAX(CAST(SUBSTRING(no_invoice, 5, 3) AS UNSIGNED)) + 1 END AS nomor 
        FROM ( 
        SELECT
            MAX(CAST(SUBSTRING(no_invoice, 9, 2) AS UNSIGNED)) AS bln,
            MAX(CAST(SUBSTRING(no_invoice, 12, 4) AS UNSIGNED)) AS thn, 
            no_invoice
            FROM tbl_transaksi
            GROUP BY no_invoice) a
        WHERE a.bln = MONTH(NOW()) AND a.thn = YEAR(NOW());", conn)
        da.Fill(ds, "nomor")
        Dim nom As Integer
        nom = Integer.Parse(ds.Tables("nomor").Rows(0).Item(0))
        tbxInvoice.Text = "INV/" & Format(nom, "0##") & "/" & Format(Now.Month, "0#") & "/" & Now.Year
    End Sub
    Private Sub btnListBarang_Click(sender As Object, e As EventArgs) Handles btnListBarang.Click
        PersyModule.Clicked_Color(btnListBarang)
        PersyModule.Restore_Color(btnHistory)

        btnListBarang.Image = My.Resources.menu
        btnHistory.Image = My.Resources.history_white

        panelListBarang.Visible = True
        panelPembayaran.Visible = False
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        PersyModule.Clicked_Color(btnHistory)
        PersyModule.Restore_Color(btnListBarang)

        btnHistory.Image = My.Resources.history
        btnListBarang.Image = My.Resources.menu_white

        panelListBarang.Visible = False
        panelPembayaran.Visible = False
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        PersyModule.Restore_Color(btnHistory)
        PersyModule.Restore_Color(btnListBarang)
        PersyModule.HideErrorLogin()

        btnHistory.Image = My.Resources.history_white
        btnListBarang.Image = My.Resources.menu_white

        panelListBarang.Visible = False
        panelPembayaran.Visible = False
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub shortenPage_Click(sender As Object, e As EventArgs) Handles shortenPage.Click
        extendPage.Visible = True
        shortenPage.Visible = False

        lblListBarang.Location = New Point(306, 26)
        panelListBarang.Location = New Point(63, 60)
        panelListBarang.Width = 843
        dgvListBarang.Width = 817

        lbPembayaran.Location = New Point(316, 0)
        panelPembayaran.Location = New Point(63, 60)
        panelPembayaran.Width = 843
        dgvBarang.Width = 502

        btnPanelPembayaran.Location = New Point(660, 371)

        panelMenu.Visible = False
        panelMenu.Width = 46

        transitionFormP.ShowSync(panelMenu)
    End Sub

    Private Sub extendPage_Click(sender As Object, e As EventArgs) Handles extendPage.Click
        extendPage.Visible = False
        shortenPage.Visible = True

        lblListBarang.Location = New Point(256, 26)
        panelListBarang.Location = New Point(211, 60)
        panelListBarang.Width = 673
        dgvListBarang.Width = 626

        lbPembayaran.Location = New Point(230, 0)
        panelPembayaran.Location = New Point(211, 60)
        panelPembayaran.Width = 673
        dgvBarang.Width = 332

        btnPanelPembayaran.Location = New Point(460, 371)

        panelMenu.Visible = False
        panelMenu.Width = 204

        transitionFormP.ShowSync(panelMenu)
    End Sub

    Private Sub Kasir_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()
        Invoice()
    End Sub

    Private Sub panelListBarang_Paint(sender As Object, e As PaintEventArgs) Handles panelListBarang.Paint
        Show_Data()
    End Sub

    Private Sub dgvListBarang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListBarang.CellContentClick
        Dim existingRow As DataGridViewRow = Nothing

        If e.ColumnIndex = dgvListBarang.Columns("btnTambah").Index Then
            panelJumlah.Visible = True
        End If

        tbxProduk.Text = dgvListBarang.Rows(e.RowIndex).Cells("namaProduk").Value.ToString()
        tbxKategori.Text = dgvListBarang.Rows(e.RowIndex).Cells("kategori").Value.ToString()
        tbxidproduk.Text = dgvListBarang.Rows(e.RowIndex).Cells("idproduk").Value.ToString()
    End Sub

    Private Sub btnClosePanel_Click(sender As Object, e As EventArgs) Handles btnClosePanel.Click
        panelJumlah.Visible = False
    End Sub

    Private Sub numJumlah_ValueChanged(sender As Object, e As EventArgs) Handles numJumlah.ValueChanged
        ds.Clear()
        da = New MySqlDataAdapter("Select harga from tbl_produk where nama_produk = '" & tbxProduk.Text & "'", conn)
        da.Fill(ds, "harga")
        If ds.Tables("harga").Rows.Count > 0 Then
            Dim harga As Integer = Integer.Parse(ds.Tables("harga").Rows(0).Item(0))
            Dim jumlah As Integer = numJumlah.Value
            Dim subtotal As Integer = harga * jumlah

            tbxSubtotal.Text = subtotal.ToString()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim existingRow As DataGridViewRow = Nothing

        For Each row As DataGridViewRow In dgvBarang.Rows
            If row.Cells("idProdukPersy").Value IsNot Nothing AndAlso row.Cells("idProdukPersy").Value.ToString() = tbxidproduk.Text Then
                existingRow = row
                Exit For
            End If
        Next

        da = New MySqlDataAdapter("select stock from tbl_produk where nama_produk = '" & tbxProduk.Text & "'", conn)
        da.Fill(ds, "Stock")
        Dim currentStock As Integer = Integer.Parse(ds.Tables("Stock").Rows(0).Item(0))

        If existingRow IsNot Nothing AndAlso currentStock <> 0 Then
            Dim existingQuantity As Integer = Integer.Parse(existingRow.Cells("jumlah").Value)
            Dim existingSubtotal As Integer = Integer.Parse(existingRow.Cells("subtotal").Value)

            existingRow.Cells("jumlah").Value = existingQuantity + numJumlah.Value
            existingRow.Cells("subtotal").Value = existingSubtotal + tbxSubtotal.Text
        Else
            dgvBarang.Rows.Add(tbxidproduk.Text, tbxProduk.Text, tbxKategori.Text, numJumlah.Value, tbxSubtotal.Text)
        End If
    End Sub

    Private Sub dgvBarang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBarang.CellContentClick

    End Sub
    Private Sub btnPanelPembayaran_Click(sender As Object, e As EventArgs) Handles btnPanelPembayaran.Click
        panelPembayaran.Visible = True
        Dim total As Integer = 0
        For Each row As DataGridViewRow In dgvBarang.Rows
            If row.Cells("subtotal").Value IsNot Nothing Then
                total += row.Cells("subtotal").Value
            End If
        Next
        tbxTotalPembayaran.Text = total.ToString()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        panelPembayaran.Visible = False
    End Sub

    Private Sub btnKonfirmasi_Click(sender As Object, e As EventArgs) Handles btnKonfirmasi.Click
        'Try
        ds.Clear()
            da = New MySqlDataAdapter("insert into tbl_transaksi values (?,?,?)", conn)
            da.SelectCommand.Parameters.AddWithValue("no_invoice", tbxInvoice.Text)
            da.SelectCommand.Parameters.AddWithValue("nama_pembeli", tbxPelanggan.Text)
            da.SelectCommand.Parameters.AddWithValue("total", tbxTotalPembayaran.Text)
            da.Fill(ds, "transaksi")
            ds.Clear()

        For i As Integer = 0 To dgvBarang.Rows.Count - 1
            If i >= 0 AndAlso i < dgvBarang.Rows.Count Then
                Dim jumlahProduk As Integer = dgvBarang.Rows(i).Cells("jumlah").Value
                Dim subtotalProduk As Integer = dgvBarang.Rows(i).Cells("subtotal").Value
                Dim namaProduk As String = dgvBarang.Rows(i).Cells("produkPembeli").Value
                Dim kategoriProduk As String = dgvBarang.Rows(i).Cells("kategoriProduk").Value
                ds.Clear()
                da = New MySqlDataAdapter("select id_produk from tbl_produk where nama_produk ='" & namaProduk & "' AND kategori = '" & kategoriProduk & "'", conn)
                da.Fill(ds, "produk")
                If ds.Tables("produk").Rows.Count > 0 Then
                    Dim id_item As String = ds.Tables("produk").Rows(0).Item(0)
                    If Not (jumlahProduk = 0 OrElse subtotalProduk = 0) Then
                        ds.Clear()
                        da = New MySqlDataAdapter("insert into tbl_detailtransaksi (no_invoice, id_produk, jumlah, subtotal) Values (?,?,?,?)", conn)
                        da.SelectCommand.Parameters.AddWithValue("no_invoice", tbxInvoice.Text)
                        da.SelectCommand.Parameters.AddWithValue("id_barang", id_item)
                        da.SelectCommand.Parameters.AddWithValue("jumlah", jumlahProduk)
                        da.SelectCommand.Parameters.AddWithValue("subtotal", subtotalProduk)
                        da.Fill(ds, "detail")
                    End If
                End If
                'no_invoice = tbxInvoice.Text
                PersyModule.ClearPanel(panelPembayaran)
                dgvBarang.Rows.Clear()
                Invoice()
            End If
        Next
    End Sub
End Class