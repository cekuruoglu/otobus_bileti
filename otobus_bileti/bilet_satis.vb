Imports System.Data.SqlClient

Public Class bilet_satis
    Dim baglanti As String = "Data Source=cemeren\SQLEXPRESS;Initial Catalog=Otobus_Bilet;Integrated Security=True"
    Dim daset As New DataSet()
    Private Sub bilet_satis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStrip1.Renderer = New menustyle()
        satislarlistele()
        plakagetir()
    End Sub
    Private Sub plakagetir()
        Try
            Dim con As New SqlConnection(baglanti)
            con.Open()
            Dim cmd As New SqlCommand("select * from otobusler", con)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            While dr.Read()
                cbPlaka.Items.Add(dr("plaka").ToString())
            End While
            con.Close()
        Catch ex As SqlException
            MessageBox.Show("Hata Oluştu" & ex.Message, "Uyarı!!")
        End Try
    End Sub
    Private Sub satislarlistele()
        Try
            Dim con As New SqlConnection(baglanti)
            con.Open()
            Dim adtr As New SqlDataAdapter("select * from bilet_satis", con)
            adtr.Fill(daset, "bilet_satis")
            DataGridView1.DataSource = daset.Tables("bilet_satis")
            DataGridView1.Columns("satis_id").Visible = False
            con.Close()
        Catch ex As SqlException
            MessageBox.Show("Hata Oluştu" & ex.Message, "Uyarı!!")
        End Try
    End Sub
#Region "Filtreleme"
    Private Sub txtTc_TextChanged(sender As Object, e As EventArgs) Handles txtTc.TextChanged
        Dim table As New DataTable()
        Dim con As New SqlConnection(baglanti)
        con.Open()
        Dim adtr As New SqlDataAdapter("select * from bilet_satis where tc like '%" & txtTc.Text & "%'", con)
        adtr.Fill(table)
        DataGridView1.DataSource = table
        con.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim table As New DataTable()
        Dim con As New SqlConnection(baglanti)
        con.Open()
        Dim adtr As New SqlDataAdapter("select * from bilet_satis where ad like '%" & TextBox1.Text & "%'", con)
        adtr.Fill(table)
        DataGridView1.DataSource = table
        con.Close()
    End Sub

    Private Sub txtSoyad_TextChanged(sender As Object, e As EventArgs) Handles txtSoyad.TextChanged
        Dim table As New DataTable()
        Dim con As New SqlConnection(baglanti)
        con.Open()
        Dim adtr As New SqlDataAdapter("select * from bilet_satis where soyad like '%" & txtSoyad.Text & "%'", con)
        adtr.Fill(table)
        DataGridView1.DataSource = table
        con.Close()
    End Sub

    Private Sub txtTelefon_TextChanged(sender As Object, e As EventArgs) Handles txtTelefon.TextChanged
        Dim table As New DataTable()
        Dim con As New SqlConnection(baglanti)
        con.Open()
        Dim adtr As New SqlDataAdapter("select * from bilet_satis where telefon like '%" & txtTelefon.Text & "%'", con)
        adtr.Fill(table)
        DataGridView1.DataSource = table
        con.Close()
    End Sub


    Private Sub cbKalkisF_TextChanged(sender As Object, e As EventArgs) Handles cbKalkisF.TextChanged
        Dim table As New DataTable()
        Dim con As New SqlConnection(baglanti)
        con.Open()
        Dim adtr As New SqlDataAdapter("select * from bilet_satis where kalkis_yeri like '%" & cbKalkisF.Text & "%'", con)
        adtr.Fill(table)
        DataGridView1.DataSource = table
        con.Close()
    End Sub

    Private Sub cbVarisF_TextChanged(sender As Object, e As EventArgs) Handles cbVarisF.TextChanged
        Dim table As New DataTable()
        Dim con As New SqlConnection(baglanti)
        con.Open()
        Dim adtr As New SqlDataAdapter("select * from bilet_satis where varis_yeri like '%" & cbVarisF.Text & "%'", con)
        adtr.Fill(table)
        DataGridView1.DataSource = table
        con.Close()
    End Sub

    Private Sub dtKalkisF_ValueChanged(sender As Object, e As EventArgs) Handles dtKalkisF.ValueChanged
        Dim table As New DataTable()
        Dim con As New SqlConnection(baglanti)
        con.Open()
        Dim adtr As New SqlDataAdapter("select * from bilet_satis where sefer_tarih like '%" & dtKalkisF.Value & "%'", con)
        adtr.Fill(table)
        DataGridView1.DataSource = table
        con.Close()
    End Sub
    Private Sub cbPlaka_TextChanged(sender As Object, e As EventArgs) Handles cbPlaka.TextChanged
        Dim table As New DataTable()
        Dim con As New SqlConnection(baglanti)
        con.Open()
        Dim adtr As New SqlDataAdapter("select * from bilet_satis where plaka like '%" & cbPlaka.Text & "%'", con)
        adtr.Fill(table)
        DataGridView1.DataSource = table
        con.Close()
    End Sub
#End Region
    Private Sub biletİptal_Click(sender As Object, e As EventArgs) Handles biletİptal.Click
        Dim result As DialogResult
        result = MessageBox.Show("Bileti iptal etmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                Dim con As New SqlConnection(baglanti)
                con.Open()
                Dim iptal As New SqlCommand("insert into bilet_iptal (satis_id,tc,sefer_id,plaka,ad,soyad,telefon,kalkis_yeri,varis_yeri,koltuk_no,cinsiyet,bilet_tur,fiyat,alinan_tarih,sefer_tarih,iptal_sebebi,iptal_tarih) SELECT satis_id,tc,sefer_id,plaka,ad,soyad,telefon,kalkis_yeri,varis_yeri,koltuk_no,cinsiyet,bilet_tur,fiyat,tarih,sefer_tarih,@iptal_sebebi,@iptal_tarih FROM bilet_satis where satis_id = '" & DataGridView1.CurrentRow.Cells("satis_id").Value.ToString() & "'", con)
                iptal.Parameters.AddWithValue("@iptal_sebebi", "Müşteri isteğiyle iptal edildi")
                iptal.Parameters.AddWithValue("@iptal_tarih", DateTime.Now)
                iptal.ExecuteNonQuery()
                Dim satis As New SqlCommand("delete from bilet_satis where satis_id = '" & DataGridView1.CurrentRow.Cells("satis_id").Value.ToString() & "'", con)
                satis.ExecuteNonQuery()
                con.Close()
                daset.Tables("bilet_satis").Clear()
                satislarlistele()
                MessageBox.Show("Bilet İptal Edildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As SqlException
                MessageBox.Show("Hata Oluştu " & ex.Message, "Uyarı!!")
            End Try
        Else

        End If
    End Sub

    Private Sub iptalBiletler_Click(sender As Object, e As EventArgs) Handles iptalBiletler.Click
        Dim iptal As New bilet_iptal()
        iptal.Show()
        Me.Close()
    End Sub


End Class