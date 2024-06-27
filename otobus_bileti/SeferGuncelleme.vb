Imports System.Data.SqlClient

Public Class SeferGuncelleme
    Dim baglan As String = "Data Source=cemeren\SQLEXPRESS;Initial Catalog=Otobus_Bilet;Integrated Security=True"
    Public Sub degerlergetir(seferid As String, plaka As String, kalkis As String, varis As String, kalkis_saati As String, kalkis_tarih As Date, varis_saati As String, varis_tarih As Date, ucret As String, durak1_yer As String, durak1_varis_saati As String, durak1_tarih As Date, durak1_ucret As String, durak2_yer As String, durak2_varis_saati As String, durak2_tarih As Date, durak2_ucret As String, durak3_yer As String, durak3_varis_saati As String, durak3_tarih As Date, durak3_ucret As String, durak4_yer As String, durak4_varis_saati As String, durak4_tarih As Date, durak4_ucret As String)
        lblSeferId.Text = seferid
        ComboBox1.Text = plaka
        cbKalkis.Text = kalkis
        cbVaris.Text = varis
        saatKalkis.Text = kalkis_saati
        dtKalkis.Value = kalkis_tarih
        saatVaris.Text = varis_saati
        dtVaris.Value = varis_tarih
        UcretTxt.Text = ucret
        cbDurak1.Text = durak1_yer
        saatDurak1.Text = durak1_varis_saati
        dtDurak1.Value = durak1_tarih
        Durak1Ucret.Text = durak1_ucret
        cbDurak2.Text = durak2_yer
        saatDurak2.Text = durak2_varis_saati
        dtDurak2.Value = durak2_tarih
        Durak2Ucret.Text = durak2_ucret
        cbDurak3.Text = durak3_yer
        saatDurak3.Text = durak3_varis_saati
        dtDurak3.Value = durak3_tarih
        Durak3Ucret.Text = durak3_ucret
        cbDurak4.Text = durak4_yer
        saatDurak4.Text = durak4_varis_saati
        dtDurak4.Value = durak4_tarih
        Durak4Ucret.Text = durak4_ucret
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = Nothing OrElse cbKalkis.Text = Nothing OrElse cbVaris.Text = Nothing OrElse cbKalkis.Text = Nothing OrElse saatKalkis.Text = Nothing OrElse saatVaris.Text = Nothing OrElse UcretTxt.Text = Nothing Then
            MessageBox.Show("Lütfen gereki alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If cbKalkis.Text = cbVaris.Text Then
            MessageBox.Show("Lütfen farklı şehirler seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf cbDurak1.Text <> Nothing Then
            If cbKalkis.Text = cbDurak1.Text Or cbVaris.Text = cbDurak1.Text Or cbDurak1.Text = cbDurak2.Text Or cbDurak1.Text = cbDurak3.Text Or cbDurak1.Text = cbDurak4.Text Then
                MessageBox.Show("Lütfen farklı şehirler seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        ElseIf cbDurak2.Text <> Nothing Then
            If cbKalkis.Text = cbDurak2.Text Or cbVaris.Text = cbDurak2.Text Or cbDurak1.Text = cbDurak2.Text Or cbDurak2.Text = cbDurak3.Text Or cbDurak2.Text = cbDurak4.Text Then
                MessageBox.Show("Lütfen farklı şehirler seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        ElseIf cbDurak3.Text <> Nothing Then
            If cbKalkis.Text = cbDurak3.Text Or cbVaris.Text = cbDurak3.Text Or cbDurak3.Text = cbDurak2.Text Or cbDurak1.Text = cbDurak3.Text Or cbDurak3.Text = cbDurak4.Text Then
                MessageBox.Show("Lütfen farklı şehirler seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        ElseIf cbDurak4.Text <> Nothing Then
            If cbKalkis.Text = cbDurak4.Text Or cbVaris.Text = cbDurak4.Text Or cbDurak4.Text = cbDurak2.Text Or cbDurak4.Text = cbDurak3.Text Or cbDurak1.Text = cbDurak4.Text Then
                MessageBox.Show("Lütfen farklı şehirler seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        End If
        Using baglanti As New SqlConnection(baglan)
            baglanti.Open()
            Dim iptal As New SqlCommand("insert into bilet_iptal (satis_id,tc,sefer_id,plaka,ad,soyad,telefon,kalkis_yeri,varis_yeri,koltuk_no,cinsiyet,bilet_tur,fiyat,alinan_tarih,sefer_tarih,iptal_sebebi,iptal_tarih) SELECT satis_id,tc,sefer_id,plaka,ad,soyad,telefon,kalkis_yeri,varis_yeri,koltuk_no,cinsiyet,bilet_tur,fiyat,tarih,sefer_tarih,@iptal_sebebi,@iptal_tarih FROM bilet_satis", baglanti)
            iptal.Parameters.AddWithValue("@iptal_sebebi", "Sefer Güncellendi")
            iptal.Parameters.AddWithValue("@iptal_tarih", DateTime.Now)
            iptal.ExecuteNonQuery()
            Dim satis As New SqlCommand("delete from bilet_satis where sefer_id = '" & lblSeferId.Text & "'", baglanti)
            satis.ExecuteNonQuery()
            baglanti.Close()
            Dim komut As New SqlCommand("UPDATE seferler SET nereden = @nereden, nereye = @nereye, kalkis_saati = @kalkis_saati, kalkis_tarih = @kalkis_tarih, varis_saati = @varis_saati, varis_tarih = @varis_tarih, ucret = @ucret, durak1_yer = @durak1_yer, durak1_varis_saati = @durak1_varis_saati, durak1_tarih = @durak1_tarih, durak1_ucret = @durak1_ucret, durak2_yer = @durak2_yer, durak2_varis_saati = @durak2_varis_saati, durak2_tarih = @durak2_tarih, durak2_ucret = @durak2_ucret, durak3_yer = @durak3_yer, durak3_varis_saati = @durak3_varis_saati, durak3_tarih = @durak3_tarih, durak3_ucret = @durak3_ucret, durak4_yer = @durak4_yer, durak4_varis_saati = @durak4_varis_saati, durak4_tarih = @durak4_tarih, durak4_ucret = @durak4_ucret, plaka = @plaka WHERE sefer_id = @sefer_id", baglanti)
            komut.Parameters.AddWithValue("@sefer_id", lblSeferId.Text)
            komut.Parameters.AddWithValue("@nereden", cbKalkis.Text)
            komut.Parameters.AddWithValue("@nereye", cbVaris.Text)
            komut.Parameters.AddWithValue("@kalkis_saati", saatKalkis.Text)
            komut.Parameters.AddWithValue("@kalkis_tarih", dtKalkis.Value.ToString("dd-MM-yyyy"))
            komut.Parameters.AddWithValue("@varis_saati", saatVaris.Text)
            komut.Parameters.AddWithValue("@varis_tarih", dtVaris.Value.ToString("dd-MM-yyyy"))
            komut.Parameters.AddWithValue("@ucret", UcretTxt.Text)
            komut.Parameters.AddWithValue("@plaka", ComboBox1.Text)
            If cbDurak1.Text = Nothing AndAlso saatDurak1.Text = Nothing AndAlso cbDurak2.Text = Nothing AndAlso saatDurak2.Text = Nothing AndAlso cbDurak3.Text = Nothing AndAlso saatDurak3.Text = Nothing AndAlso cbDurak4.Text = Nothing AndAlso saatDurak4.Text = Nothing AndAlso Durak1Ucret.Text = Nothing AndAlso Durak2Ucret.Text = Nothing AndAlso Durak3Ucret.Text = Nothing AndAlso Durak4Ucret.Text = Nothing Then

                komut.Parameters.AddWithValue("@durak1_yer", lblBos.Text)
                komut.Parameters.AddWithValue("@durak1_varis_saati", lblBos.Text)
                komut.Parameters.AddWithValue("@durak1_tarih", lblBos.Text)
                komut.Parameters.AddWithValue("@durak1_ucret", lblBos.Text)
                komut.Parameters.AddWithValue("@durak2_yer", lblBos.Text)
                komut.Parameters.AddWithValue("@durak2_varis_saati", lblBos.Text)
                komut.Parameters.AddWithValue("@durak2_tarih", lblBos.Text)
                komut.Parameters.AddWithValue("@durak2_ucret", lblBos.Text)
                komut.Parameters.AddWithValue("@durak3_yer", lblBos.Text)
                komut.Parameters.AddWithValue("@durak3_varis_saati", lblBos.Text)
                komut.Parameters.AddWithValue("@durak3_tarih", lblBos.Text)
                komut.Parameters.AddWithValue("@durak3_ucret", lblBos.Text)
                komut.Parameters.AddWithValue("@durak4_yer", lblBos.Text)
                komut.Parameters.AddWithValue("@durak4_varis_saati", lblBos.Text)
                komut.Parameters.AddWithValue("@durak4_tarih", lblBos.Text)
                komut.Parameters.AddWithValue("@durak4_ucret", lblBos.Text)

            ElseIf cbDurak1.SelectedIndex = -1 AndAlso cbDurak2.SelectedIndex = -1 AndAlso saatDurak2.SelectedIndex = -1 AndAlso cbDurak3.SelectedIndex = -1 AndAlso saatDurak3.SelectedIndex = -1 AndAlso cbDurak4.SelectedIndex = -1 AndAlso saatDurak4.SelectedIndex = -1 Then
                MessageBox.Show("Durak 1 yerini seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return

            ElseIf saatDurak1.SelectedIndex = -1 AndAlso cbDurak2.SelectedIndex = -1 AndAlso saatDurak2.SelectedIndex = -1 AndAlso cbDurak3.SelectedIndex = -1 AndAlso saatDurak3.SelectedIndex = -1 AndAlso cbDurak4.SelectedIndex = -1 AndAlso saatDurak4.SelectedIndex = -1 Then
                MessageBox.Show("Durak 1 saatini seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            ElseIf Durak1Ucret.Text = Nothing AndAlso cbDurak2.SelectedIndex = -1 AndAlso saatDurak2.SelectedIndex = -1 AndAlso cbDurak3.SelectedIndex = -1 AndAlso saatDurak3.SelectedIndex = -1 AndAlso cbDurak4.SelectedIndex = -1 AndAlso saatDurak4.SelectedIndex = -1 Then
                MessageBox.Show("Durak 1 ücretini giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            ElseIf Durak2Ucret.Text = Nothing AndAlso Durak3Ucret.Text = Nothing AndAlso Durak4Ucret.Text = Nothing AndAlso cbDurak2.SelectedIndex = -1 AndAlso saatDurak2.SelectedIndex = -1 AndAlso cbDurak3.SelectedIndex = -1 AndAlso saatDurak3.SelectedIndex = -1 AndAlso cbDurak4.SelectedIndex = -1 AndAlso saatDurak4.SelectedIndex = -1 Then

                komut.Parameters.AddWithValue("@durak1_yer", cbDurak1.Text)
                komut.Parameters.AddWithValue("@durak1_varis_saati", saatDurak1.Text)
                komut.Parameters.AddWithValue("@durak1_tarih", dtDurak1.Value.ToString("dd-MM-yyyy"))
                komut.Parameters.AddWithValue("@durak1_ucret", Durak1Ucret.Text)
                komut.Parameters.AddWithValue("@durak2_yer", lblBos.Text)
                komut.Parameters.AddWithValue("@durak2_varis_saati", lblBos.Text)
                komut.Parameters.AddWithValue("@durak2_tarih", lblBos.Text)
                komut.Parameters.AddWithValue("@durak2_ucret", lblBos.Text)
                komut.Parameters.AddWithValue("@durak3_yer", lblBos.Text)
                komut.Parameters.AddWithValue("@durak3_varis_saati", lblBos.Text)
                komut.Parameters.AddWithValue("@durak3_tarih", lblBos.Text)
                komut.Parameters.AddWithValue("@durak3_ucret", lblBos.Text)
                komut.Parameters.AddWithValue("@durak4_yer", lblBos.Text)
                komut.Parameters.AddWithValue("@durak4_varis_saati", lblBos.Text)
                komut.Parameters.AddWithValue("@durak4_tarih", lblBos.Text)
                komut.Parameters.AddWithValue("@durak4_ucret", lblBos.Text)
            ElseIf cbDurak2.SelectedIndex = -1 AndAlso cbDurak3.SelectedIndex = -1 AndAlso saatDurak3.SelectedIndex = -1 AndAlso cbDurak4.SelectedIndex = -1 AndAlso saatDurak4.SelectedIndex = -1 Then
                MessageBox.Show("Durak 2 yerini seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            ElseIf saatDurak2.SelectedIndex = -1 AndAlso cbDurak3.SelectedIndex = -1 AndAlso saatDurak3.SelectedIndex = -1 AndAlso cbDurak4.SelectedIndex = -1 AndAlso saatDurak4.SelectedIndex = -1 Then
                MessageBox.Show("Durak 2 saatini seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            ElseIf Durak2Ucret.Text = Nothing AndAlso cbDurak3.SelectedIndex = -1 AndAlso saatDurak3.SelectedIndex = -1 AndAlso cbDurak4.SelectedIndex = -1 AndAlso saatDurak4.SelectedIndex = -1 Then
                MessageBox.Show("Durak 2 ücretini giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            ElseIf Durak3Ucret.Text = Nothing AndAlso Durak4Ucret.Text = Nothing AndAlso cbDurak3.SelectedIndex = -1 AndAlso saatDurak3.SelectedIndex = -1 AndAlso cbDurak4.SelectedIndex = -1 AndAlso saatDurak4.SelectedIndex = -1 Then

                komut.Parameters.AddWithValue("@durak1_yer", cbDurak1.Text)
                komut.Parameters.AddWithValue("@durak1_varis_saati", saatDurak1.Text)
                komut.Parameters.AddWithValue("@durak1_tarih", dtDurak1.Value.ToString("dd-MM-yyyy"))
                komut.Parameters.AddWithValue("@durak1_ucret", Durak1Ucret.Text)
                komut.Parameters.AddWithValue("@durak2_yer", cbDurak2.Text)
                komut.Parameters.AddWithValue("@durak2_varis_saati", saatDurak2.Text)
                komut.Parameters.AddWithValue("@durak2_tarih", dtDurak2.Value.ToString("dd-MM-yyyy"))
                komut.Parameters.AddWithValue("@durak2_ucret", Durak2Ucret.Text)
                komut.Parameters.AddWithValue("@durak3_yer", lblBos.Text)
                komut.Parameters.AddWithValue("@durak3_varis_saati", lblBos.Text)
                komut.Parameters.AddWithValue("@durak3_tarih", lblBos.Text)
                komut.Parameters.AddWithValue("@durak3_ucret", lblBos.Text)
                komut.Parameters.AddWithValue("@durak4_yer", lblBos.Text)
                komut.Parameters.AddWithValue("@durak4_varis_saati", lblBos.Text)
                komut.Parameters.AddWithValue("@durak4_tarih", lblBos.Text)
                komut.Parameters.AddWithValue("@durak4_ucret", lblBos.Text)
            ElseIf cbDurak3.SelectedIndex = -1 AndAlso cbDurak4.SelectedIndex = -1 AndAlso saatDurak4.SelectedIndex = -1 Then
                MessageBox.Show("Durak 3 yerini seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            ElseIf saatDurak3.SelectedIndex = -1 AndAlso cbDurak4.SelectedIndex = -1 AndAlso saatDurak4.SelectedIndex = -1 Then
                MessageBox.Show("Durak 3 saatini seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            ElseIf Durak3Ucret.Text = Nothing AndAlso cbDurak4.SelectedIndex = -1 AndAlso saatDurak4.SelectedIndex = -1 Then
                MessageBox.Show("Durak 3 ücretini giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            ElseIf cbDurak4.SelectedIndex = -1 AndAlso saatDurak4.SelectedIndex = -1 AndAlso Durak4Ucret.Text = Nothing Then

                komut.Parameters.AddWithValue("@durak1_yer", cbDurak1.Text)
                komut.Parameters.AddWithValue("@durak1_varis_saati", saatDurak1.Text)
                komut.Parameters.AddWithValue("@durak1_tarih", dtDurak1.Value.ToString("dd-MM-yyyy"))
                komut.Parameters.AddWithValue("@durak1_ucret", Durak1Ucret.Text)
                komut.Parameters.AddWithValue("@durak2_yer", cbDurak2.Text)
                komut.Parameters.AddWithValue("@durak2_varis_saati", saatDurak2.Text)
                komut.Parameters.AddWithValue("@durak2_tarih", dtDurak2.Value.ToString("dd-MM-yyyy"))
                komut.Parameters.AddWithValue("@durak2_ucret", Durak2Ucret.Text)
                komut.Parameters.AddWithValue("@durak3_yer", cbDurak3.Text)
                komut.Parameters.AddWithValue("@durak3_varis_saati", saatDurak3.Text)
                komut.Parameters.AddWithValue("@durak3_tarih", dtDurak3.Value.ToString("dd-MM-yyyy"))
                komut.Parameters.AddWithValue("@durak3_ucret", Durak3Ucret.Text)
                komut.Parameters.AddWithValue("@durak4_yer", lblBos.Text)
                komut.Parameters.AddWithValue("@durak4_varis_saati", lblBos.Text)
                komut.Parameters.AddWithValue("@durak4_tarih", lblBos.Text)
                komut.Parameters.AddWithValue("@durak4_ucret", lblBos.Text)
            ElseIf cbDurak4.SelectedIndex = -1 Then
                MessageBox.Show("Durak 4 yerini seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            ElseIf saatDurak4.SelectedIndex = -1 Then
                MessageBox.Show("Durak 4 saatini seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            ElseIf Durak4Ucret.Text = Nothing Then
                MessageBox.Show("Durak 4 ücretini giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                komut.Parameters.AddWithValue("@durak1_yer", cbDurak1.Text)
                komut.Parameters.AddWithValue("@durak1_varis_saati", saatDurak1.Text)
                komut.Parameters.AddWithValue("@durak1_tarih", dtDurak1.Value.ToString("dd-MM-yyyy"))
                komut.Parameters.AddWithValue("@durak1_ucret", Durak1Ucret.Text)
                komut.Parameters.AddWithValue("@durak2_yer", cbDurak2.Text)
                komut.Parameters.AddWithValue("@durak2_varis_saati", saatDurak2.Text)
                komut.Parameters.AddWithValue("@durak2_tarih", dtDurak2.Value.ToString("dd-MM-yyyy"))
                komut.Parameters.AddWithValue("@durak2_ucret", Durak2Ucret.Text)
                komut.Parameters.AddWithValue("@durak3_yer", cbDurak3.Text)
                komut.Parameters.AddWithValue("@durak3_varis_saati", saatDurak3.Text)
                komut.Parameters.AddWithValue("@durak3_tarih", dtDurak3.Value.ToString("dd-MM-yyyy"))
                komut.Parameters.AddWithValue("@durak3_ucret", Durak3Ucret.Text)
                komut.Parameters.AddWithValue("@durak4_yer", cbDurak4.Text)
                komut.Parameters.AddWithValue("@durak4_varis_saati", saatDurak4.Text)
                komut.Parameters.AddWithValue("@durak4_tarih", dtDurak4.Value.ToString("dd-MM-yyyy"))
                komut.Parameters.AddWithValue("@durak4_ucret", Durak4Ucret.Text)
            End If


            Try
                baglanti.Open()
                komut.ExecuteNonQuery()
                MessageBox.Show("Sefer Güncellendi.", "Bilgi")
                Me.Close()

            Catch ex As SqlException
                MessageBox.Show(ex.Message)
            End Try

        End Using

    End Sub
    Private Sub plakagetir()
        Try
            Dim baglanti As New SqlConnection(baglan)
            baglanti.Open()
            Dim cmd As New SqlCommand("select * from otobusler", baglanti)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            While dr.Read()
                ComboBox1.Items.Add(dr("plaka").ToString())
            End While
            baglanti.Close()
        Catch ex As SqlException
            MessageBox.Show("Hata Oluştu" & ex.Message, "Uyarı!!")
        End Try
    End Sub

    Private Sub SeferGuncelleme_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim seferForm As New seferler()
        seferForm.Show()
    End Sub

    Private Sub SeferGuncelleme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        plakagetir()
        tarihkontrol.tarihkontrolet(Me)
    End Sub
End Class