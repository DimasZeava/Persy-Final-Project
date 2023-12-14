Imports MySql.Data.MySqlClient
Public Class Admin_Form
    Public Sub Show_Data()
        ds.Clear()
        da = New MySqlDataAdapter("SELECT nama_produk, kategori, harga, stock, id_produk FROM tbl_produk", conn)

        da.Fill(ds, "produk")
        dgvBarang.Rows.Clear()

        For i As Integer = 0 To ds.Tables("produk").Rows.Count - 1
            dgvBarang.Rows.Add(ds.Tables("produk").Rows(i).Item(0).ToString,
                               ds.Tables("produk").Rows(i).Item(1).ToString,
                               ds.Tables("produk").Rows(i).Item(2).ToString,
                               ds.Tables("produk").Rows(i).Item(3).ToString,
                               ds.Tables("produk").Rows(i).Item(4).ToString
           )
        Next
    End Sub

    Private Sub btnBarang_Click(sender As Object, e As EventArgs) Handles btnBarang.Click
        PersyModule.Clicked_Color(btnBarang)
        PersyModule.Restore_Color(btnDetail)

        btnDetail.Image = My.Resources.transaction_detail_white
        btnBarang.Image = My.Resources.product
        panelTambah.Visible = True
    End Sub

    Private Sub btnDetail_Click(sender As Object, e As EventArgs) Handles btnDetail.Click
        PersyModule.Clicked_Color(btnDetail)
        PersyModule.Restore_Color(btnBarang)

        btnBarang.Image = My.Resources.Barang
        btnDetail.Image = My.Resources.transaction_detail1
        panelTambah.Visible = False
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        PersyModule.Restore_Color(btnBarang)
        PersyModule.Restore_Color(btnDetail)
        PersyModule.HideErrorLogin()

        btnBarang.Image = My.Resources.Barang
        btnDetail.Image = My.Resources.transaction_detail_white
        panelTambah.Visible = False

        Me.Hide()
        Login.Show()
    End Sub

    Private Sub shortenPage_Click(sender As Object, e As EventArgs) Handles shortenPage.Click
        extendPage.Visible = True
        shortenPage.Visible = False

        panelTambah.Location = New Point(63, 38)
        panelTambah.Width = 824
        dgvBarang.Width = 521

        panelMenu.Visible = False
        panelMenu.Width = 46

        transitionFormP.ShowSync(panelMenu)
    End Sub

    Private Sub extendPage_Click(sender As Object, e As EventArgs) Handles extendPage.Click
        extendPage.Visible = False
        shortenPage.Visible = True

        panelTambah.Location = New Point(229, 38)
        panelTambah.Width = 662
        dgvBarang.Width = 321

        panelMenu.Visible = False
        panelMenu.Width = 204

        transitionFormP.ShowSync(panelMenu)
    End Sub

    Private Sub Admin_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()
        Show_Data()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim id_produk, produk As String
        If tbxKategori.Text = "Personality Parfume" Then
            id_produk = "PP"
        ElseIf tbxKategori.Text = "Homer Diffuser" Then
            id_produk = "HP"
        ElseIf tbxKategori.Text = "Car Parfume" Then
            id_produk = "CP"
        Else
            MessageBox.Show("Please Fill Category")
        End If
        ds.Clear()
        da = New MySqlDataAdapter("SELECT
                                        CASE
                                            WHEN MAX(CAST(SUBSTRING(id_produk, 4, 3)AS UNSIGNED)) IS NULL THEN '" & id_produk & "001'
                                            ELSE CONCAT('" & id_produk & "',LPAD(MAX(CAST(SUBSTRING(id_produk, 4, 3)AS UNSIGNED)) + 1, 3, '0'))
                                        END AS nomor
                                       FROM tbl_produk
                                       WHERE id_produk LIKE '" & id_produk & "%';", conn)
        da.Fill(ds, "id")
        produk = ds.Tables("id").Rows(0).Item(0).ToString

        ds.Clear()
        da = New MySqlDataAdapter("Insert into tbl_produk Values (?,?,?,?,?)", conn)
        da.SelectCommand.Parameters.AddWithValue("id_produk", produk)
        da.SelectCommand.Parameters.AddWithValue("nama_produk", tbxProduk.Text)
        da.SelectCommand.Parameters.AddWithValue("harga", tbxHarga.Text)
        da.SelectCommand.Parameters.AddWithValue("stock", numStock.Value)
        da.SelectCommand.Parameters.AddWithValue("kategori", tbxKategori.Text)
        da.Fill(ds, "Data_Barang")
        ds.Clear()
        Show_Data()
        PersyModule.ClearPanel(panelTambah)
    End Sub
    Private Sub dgvBarang_DoubleClick(sender As Object, e As EventArgs) Handles dgvBarang.DoubleClick
        If dgvBarang.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvBarang.SelectedRows(0)
            tbxID.Text = selectedRow.Cells("idProduk").Value.ToString()
            tbxProduk.Text = selectedRow.Cells("namaProduk").Value.ToString()
            tbxKategori.Text = selectedRow.Cells("kategori").Value.ToString()
            tbxHarga.Text = selectedRow.Cells("harga").Value.ToString()
            numStock.Value = selectedRow.Cells("stock").Value
            tbxKategori.ReadOnly = True
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        tbxKategori.ReadOnly = False
        da = New MySqlDataAdapter("Update tbl_produk Set nama_produk=?, harga=?, stock=? Where id_produk = '" & tbxID.Text & "'", conn)
        da.SelectCommand.Parameters.AddWithValue("nama_produk", tbxProduk.Text)
        da.SelectCommand.Parameters.AddWithValue("harga", tbxHarga.Text)
        da.SelectCommand.Parameters.AddWithValue("stock", numStock.Value)
        da.Fill(ds, "Data_Barang")
        ds.Clear()
        PersyModule.ClearPanel(panelTambah)
        Show_Data()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Try
            da = New MySqlDataAdapter("DELETE FROM tbl_produk WHERE id_produk = '" & tbxID.Text & "'", conn)
            da.Fill(ds, "Data_Barang")
            ds.Clear()
            PersyModule.ClearPanel(panelTambah)
            Show_Data()
        Catch ex As Exception
            MessageBox.Show("Error dalam mengapus data" & ex.Message)
        End Try
    End Sub
End Class