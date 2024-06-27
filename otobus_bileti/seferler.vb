Imports System.Data.SqlClient

Public Class seferler
    Dim baglanti As String = "Data Source=cemeren\SQLEXPRESS;Initial Catalog=Otobus_Bilet;Integrated Security=True"
    Dim daset As New DataSet()
#Region " Özel Fonksiyonlar"
    Private Sub plakagetir()
        Try
            Dim con As New SqlConnection(Me.baglanti)
            con.Open()
            Dim cmd As New SqlCommand("select * from otobusler", con)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            While dr.Read()
                cbPlakaF.Items.Add(dr("plaka").ToString())
            End While
            con.Close()
        Catch ex As SqlException
            MessageBox.Show("Hata Oluştu" & ex.Message, "Uyarı!!")
        End Try
    End Sub
    Private Sub Seferlistele()
        Try
            Dim con As New SqlConnection(baglanti)
            con.Open()
            Dim adtr As New SqlDataAdapter("select * from seferler", con)
            adtr.Fill(daset, "seferler")
            DataGridView1.DataSource = daset.Tables("seferler")
            DataGridView1.Columns("sefer_id").Visible = False
            con.Close()
        Catch ex As SqlException
            MessageBox.Show("Hata Oluştu" & ex.Message, "Uyarı!!")
        End Try
    End Sub
#End Region
    Private Sub seferler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStrip1.Renderer = New menustyle()
        Seferlistele()
        plakagetir()
    End Sub

#Region " Filtreleme"

    Private Sub cbPlaka_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPlakaF.SelectedIndexChanged, cbPlakaF.TextChanged
        Dim table As New DataTable()
        Dim con As New SqlConnection(baglanti)
        con.Open()
        Dim adtr As New SqlDataAdapter("select plaka,nereden,nereye,kalkis_saati,kalkis_tarih,varis_saati,varis_tarih,durak1_yer,durak1_varis_saati,durak1_tarih,durak2_yer,durak2_varis_saati,durak2_tarih,durak3_yer,durak3_varis_saati,durak3_tarih,durak4_yer,durak4_varis_saati,durak4_tarih from seferler where plaka like '%" + cbPlakaF.Text + "%'", con)
        adtr.Fill(table)
        DataGridView1.DataSource = table
        con.Close()
    End Sub

    Private Sub cbKalkis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKalkisF.SelectedIndexChanged, cbKalkisF.TextChanged
        Dim table As New DataTable()
        Dim con As New SqlConnection(baglanti)
        con.Open()
        Dim adtr As New SqlDataAdapter("select plaka,nereden,nereye,kalkis_saati,kalkis_tarih,varis_saati,varis_tarih,durak1_yer,durak1_varis_saati,durak1_tarih,durak2_yer,durak2_varis_saati,durak2_tarih,durak3_yer,durak3_varis_saati,durak3_tarih,durak4_yer,durak4_varis_saati,durak4_tarih from seferler where (nereden like '%" & cbKalkisF.Text & "%' OR durak1_yer LIKE '%" & cbKalkisF.Text & "%' OR durak2_yer LIKE '%" & cbKalkisF.Text & "%' OR durak3_yer LIKE '%" & cbKalkisF.Text & "%' OR durak4_yer LIKE '%" & cbKalkisF.Text & "%')", con)
        adtr.Fill(table)
        DataGridView1.DataSource = table
        con.Close()
    End Sub

    Private Sub dtKalkis_ValueChanged(sender As Object, e As EventArgs) Handles dtKalkisF.ValueChanged
        Dim table As New DataTable()
        Dim con As New SqlConnection(baglanti)
        con.Open()
        Dim adtr As New SqlDataAdapter("select plaka,nereden,nereye,kalkis_saati,kalkis_tarih,varis_saati,varis_tarih,durak1_yer,durak1_varis_saati,durak1_tarih,durak2_yer,durak2_varis_saati,durak2_tarih,durak3_yer,durak3_varis_saati,durak3_tarih,durak4_yer,durak4_varis_saati,durak4_tarih from seferler where (kalkis_tarih like '%" & dtKalkisF.Text & "%' OR durak1_tarih LIKE '%" & dtKalkisF.Text & "%' OR durak2_tarih LIKE '%" & dtKalkisF.Text & "%'  OR durak3_tarih LIKE '%" & dtKalkisF.Text & "%' OR durak4_tarih LIKE '%" & dtKalkisF.Text & "%' )", con)
        adtr.Fill(table)
        DataGridView1.DataSource = table
        con.Close()
    End Sub

    Private Sub saatKalkis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles saatKalkisF.SelectedIndexChanged, saatKalkisF.TextChanged
        Dim table As New DataTable()
        Dim con As New SqlConnection(baglanti)
        con.Open()
        Dim adtr As New SqlDataAdapter("select plaka,nereden,nereye,kalkis_saati,kalkis_tarih,varis_saati,varis_tarih,durak1_yer,durak1_varis_saati,durak1_tarih,durak2_yer,durak2_varis_saati,durak2_tarih,durak3_yer,durak3_varis_saati,durak3_tarih,durak4_yer,durak4_varis_saati,durak4_tarih from seferler where (kalkis_saati like '%" & saatKalkisF.Text & "%' OR durak1_varis_saati LIKE '%" & saatKalkisF.Text & "%' OR durak2_varis_saati LIKE '%" & saatKalkisF.Text & "%' OR durak3_varis_saati LIKE '%" & saatKalkisF.Text & "%' OR durak4_varis_saati LIKE '%" & saatKalkisF.Text & "%')", con)
        adtr.Fill(table)
        DataGridView1.DataSource = table
        con.Close()
    End Sub

    Private Sub cbVaris_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbVarisF.SelectedIndexChanged, cbVarisF.TextChanged
        Dim table As New DataTable()
        Dim con As New SqlConnection(baglanti)
        con.Open()
        Dim adtr As New SqlDataAdapter("select plaka,nereden,nereye,kalkis_saati,kalkis_tarih,varis_saati,varis_tarih,durak1_yer,durak1_varis_saati,durak1_tarih,durak2_yer,durak2_varis_saati,durak2_tarih,durak3_yer,durak3_varis_saati,durak3_tarih,durak4_yer,durak4_varis_saati,durak4_tarih from seferler where (nereye like '%" & cbVarisF.Text & "%' OR durak1_yer LIKE '%" & cbVarisF.Text & "%' OR durak2_yer LIKE '%" & cbVarisF.Text & "%' OR durak3_yer LIKE '%" & cbVarisF.Text & "%' OR durak4_yer LIKE '%" & cbVarisF.Text & "%')", con)
        adtr.Fill(table)
        DataGridView1.DataSource = table
        con.Close()
    End Sub

    Private Sub dtVaris_ValueChanged(sender As Object, e As EventArgs) Handles dtVarisF.ValueChanged
        Dim table As New DataTable()
        Dim con As New SqlConnection(baglanti)
        con.Open()
        Dim adtr As New SqlDataAdapter("select plaka,nereden,nereye,kalkis_saati,kalkis_tarih,varis_saati,varis_tarih,durak1_yer,durak1_varis_saati,durak1_tarih,durak2_yer,durak2_varis_saati,durak2_tarih,durak3_yer,durak3_varis_saati,durak3_tarih,durak4_yer,durak4_varis_saati,durak4_tarih from seferler where (varis_tarih like '%" & dtVarisF.Text & "%' OR durak1_tarih LIKE '%" & dtVarisF.Text & "%' OR durak2_tarih LIKE '%" & dtVarisF.Text & "%'  OR durak3_tarih LIKE '%" & dtVarisF.Text & "%' OR durak4_tarih LIKE '%" & dtVarisF.Text & "%' )", con)
        adtr.Fill(table)
        DataGridView1.DataSource = table
        con.Close()
    End Sub

    Private Sub saatVaris_SelectedIndexChanged(sender As Object, e As EventArgs) Handles saatVarisF.SelectedIndexChanged, saatVarisF.TextChanged
        Dim table As New DataTable()
        Dim con As New SqlConnection(baglanti)
        con.Open()
        Dim adtr As New SqlDataAdapter("select plaka,nereden,nereye,kalkis_saati,kalkis_tarih,varis_saati,varis_tarih,durak1_yer,durak1_varis_saati,durak1_tarih,durak2_yer,durak2_varis_saati,durak2_tarih,durak3_yer,durak3_varis_saati,durak3_tarih,durak4_yer,durak4_varis_saati,durak4_tarih from seferler where (varis_saati like '%" & saatVarisF.Text & "%' OR durak1_varis_saati LIKE '%" & saatVarisF.Text & "%' OR durak2_varis_saati LIKE '%" & saatVarisF.Text & "%' OR durak3_varis_saati LIKE '%" & saatVarisF.Text & "%' OR durak4_varis_saati LIKE '%" & saatVarisF.Text & "%')", con)
        adtr.Fill(table)
        DataGridView1.DataSource = table
        con.Close()
    End Sub
#End Region

#Region " Butonlar"
    Private Sub SeferEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeferEkToolStripMenuItem.Click
        Dim seferekle As New SeferEkle()
        seferekle.Show()
        Me.Close()

    End Sub

    Private Sub SeferiGüncelleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeferiGüncelleToolStripMenuItem.Click
        lblSeferId.Text = DataGridView1.CurrentRow.Cells("sefer_id").Value.ToString()
        cbPlaka.Text = DataGridView1.CurrentRow.Cells("plaka").Value.ToString()
        cbKalkis.Text = DataGridView1.CurrentRow.Cells("nereden").Value.ToString()
        cbVaris.Text = DataGridView1.CurrentRow.Cells("nereye").Value.ToString()
        saatKalkis.Text = DataGridView1.CurrentRow.Cells("kalkis_saati").Value.ToString()
        dtKalkis.Value = DataGridView1.CurrentRow.Cells("kalkis_tarih").Value
        saatVaris.Text = DataGridView1.CurrentRow.Cells("varis_saati").Value.ToString()
        dtVaris.Value = DataGridView1.CurrentRow.Cells("varis_tarih").Value
        UcretTxt.Text = DataGridView1.CurrentRow.Cells("ucret").Value.ToString()

        cbDurak1.Text = DataGridView1.CurrentRow.Cells("durak1_yer").Value.ToString()
        If cbDurak1.Text = "YOK" Or cbDurak1.Text = "" Then
            cbDurak1.Text = ""
        Else
            cbDurak1.Text = DataGridView1.CurrentRow.Cells("durak1_yer").Value.ToString()
        End If
        saatDurak1.Text = DataGridView1.CurrentRow.Cells("durak1_varis_saati").Value.ToString()
        If saatDurak1.Text = "YOK" Or saatDurak1.Text = "" Then
            saatDurak1.Text = ""
        Else
            saatDurak1.Text = DataGridView1.CurrentRow.Cells("durak1_varis_saati").Value.ToString()
        End If

        Dim durak1Tarih As Object = DataGridView1.CurrentRow.Cells("durak1_tarih").Value
        If durak1Tarih IsNot Nothing AndAlso Not durak1Tarih.ToString().Equals("YOK") Then
            dtDurak1.Value = DateTime.Parse(durak1Tarih.ToString())
        Else
            dtDurak1.Value = DateTime.Now
        End If
        Durak1Ucret.Text = DataGridView1.CurrentRow.Cells("durak1_ucret").Value.ToString()
        cbDurak2.Text = DataGridView1.CurrentRow.Cells("durak2_yer").Value.ToString()
        If cbDurak2.Text = "YOK" Or cbDurak2.Text = "" Then
            cbDurak2.Text = ""
        Else
            cbDurak2.Text = DataGridView1.CurrentRow.Cells("durak2_yer").Value.ToString()
        End If
        saatDurak2.Text = DataGridView1.CurrentRow.Cells("durak2_varis_saati").Value.ToString()
        If saatDurak2.Text = "YOK" Or saatDurak2.Text = "" Then
            saatDurak2.Text = ""
        Else
            saatDurak2.Text = DataGridView1.CurrentRow.Cells("durak2_varis_saati").Value.ToString()
        End If

        Dim durak2Tarih As Object = DataGridView1.CurrentRow.Cells("durak2_tarih").Value
        If durak2Tarih IsNot Nothing AndAlso Not durak2Tarih.ToString().Equals("YOK") Then
            dtDurak2.Value = DateTime.Parse(durak2Tarih.ToString())
        Else
            dtDurak2.Value = DateTime.Now
        End If
        Durak2Ucret.Text = DataGridView1.CurrentRow.Cells("durak2_ucret").Value.ToString()
        cbDurak3.Text = DataGridView1.CurrentRow.Cells("durak3_yer").Value.ToString()
        If cbDurak3.Text = "YOK" Or cbDurak3.Text = "" Then
            cbDurak3.Text = ""
        Else
            cbDurak3.Text = DataGridView1.CurrentRow.Cells("durak3_yer").Value.ToString()
        End If

        saatDurak3.Text = DataGridView1.CurrentRow.Cells("durak3_varis_saati").Value.ToString()
        If saatDurak3.Text = "YOK" Or saatDurak3.Text = "" Then
            saatDurak3.Text = ""
        Else
            saatDurak3.Text = DataGridView1.CurrentRow.Cells("durak3_varis_saati").Value.ToString()
        End If

        Dim durak3Tarih As Object = DataGridView1.CurrentRow.Cells("durak3_tarih").Value
        If durak3Tarih IsNot Nothing AndAlso Not durak3Tarih.ToString().Equals("YOK") Then
            dtDurak3.Value = DateTime.Parse(durak3Tarih.ToString())
        Else
            dtDurak3.Value = DateTime.Now
        End If
        Durak3Ucret.Text = DataGridView1.CurrentRow.Cells("durak3_ucret").Value.ToString()
        cbDurak4.Text = DataGridView1.CurrentRow.Cells("durak4_yer").Value.ToString()
        If cbDurak4.Text = "YOK" Or cbDurak4.Text = "" Then
            cbDurak4.Text = ""
        Else
            cbDurak4.Text = DataGridView1.CurrentRow.Cells("durak4_yer").Value.ToString()
        End If

        saatDurak4.Text = DataGridView1.CurrentRow.Cells("durak4_varis_saati").Value.ToString()
        If saatDurak4.Text = "YOK" Or saatDurak4.Text = "" Then
            saatDurak4.Text = ""
        Else
            saatDurak4.Text = DataGridView1.CurrentRow.Cells("durak4_varis_saati").Value.ToString()
        End If

        Dim durak4Tarih As Object = DataGridView1.CurrentRow.Cells("durak4_tarih").Value
        If durak4Tarih IsNot Nothing AndAlso Not durak4Tarih.ToString().Equals("YOK") Then
            dtDurak4.Value = DateTime.Parse(durak4Tarih.ToString())
        Else
            dtDurak4.Value = DateTime.Now
        End If
        Durak4Ucret.Text = DataGridView1.CurrentRow.Cells("durak4_ucret").Value.ToString()
        Dim seferguncelle As New SeferGuncelleme()
        seferguncelle.degerlergetir(lblSeferId.Text, cbPlaka.Text, cbKalkis.Text, cbVaris.Text, saatKalkis.Text, dtKalkis.Value, saatVaris.Text, dtVaris.Value, UcretTxt.Text, cbDurak1.Text, saatDurak1.Text, dtDurak1.Value, Durak1Ucret.Text, cbDurak2.Text, saatDurak2.Text, dtDurak2.Value, Durak2Ucret.Text, cbDurak3.Text, saatDurak3.Text, dtDurak3.Value, Durak3Ucret.Text, cbDurak4.Text, saatDurak4.Text, dtDurak4.Value, Durak4Ucret.Text)
        seferguncelle.Show()
        Me.Close()
    End Sub

    Private Sub SeferiSilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeferiSilToolStripMenuItem.Click
        Try
            Dim con As New SqlConnection(baglanti)
            con.Open()
            Dim iptal As New SqlCommand("insert into bilet_iptal (satis_id,tc,sefer_id,plaka,ad,soyad,telefon,kalkis_yeri,varis_yeri,koltuk_no,cinsiyet,bilet_tur,fiyat,alinan_tarih,sefer_tarih,iptal_sebebi,iptal_tarih) SELECT satis_id,tc,sefer_id,plaka,ad,soyad,telefon,kalkis_yeri,varis_yeri,koltuk_no,cinsiyet,bilet_tur,fiyat,tarih,sefer_tarih,@iptal_sebebi,@iptal_tarih FROM bilet_satis", con)
            iptal.Parameters.AddWithValue("@iptal_sebebi", "Sefer İptal Edildi")
            iptal.Parameters.AddWithValue("@iptal_tarih", DateTime.Now)
            iptal.ExecuteNonQuery()
            Dim satis As New SqlCommand("delete from bilet_satis where sefer_id = '" & DataGridView1.CurrentRow.Cells("sefer_id").Value.ToString() & "'", con)
            satis.ExecuteNonQuery()
            Dim sefer As New SqlCommand("delete from seferler where sefer_id = '" & DataGridView1.CurrentRow.Cells("sefer_id").Value.ToString() & "'", con)
            sefer.ExecuteNonQuery()
            con.Close()
            daset.Tables("seferler").Clear()
            Seferlistele()
            MessageBox.Show("Kayıt Silindi!")
        Catch ex As SqlException
            MessageBox.Show("Hata Oluştu " & ex.Message, "Uyarı!!")
        End Try
    End Sub
#End Region
End Class