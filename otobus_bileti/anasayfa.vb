Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.Diagnostics

Public Class anasayfa
    Dim personelID As Integer
    Dim baglan As String = "Data Source=cemeren\SQLEXPRESS;Initial Catalog=Otobus_Bilet;Integrated Security=True"
    Public Sub New(ByVal personelID As Integer)
        InitializeComponent()
        Me.personelID = personelID
    End Sub
    Private Function GetDuraklar(ByVal kalkisYeri As String, ByVal secilenTarih As Date) As List(Of String)
        Dim duraklar As New List(Of String)

        ' Bağlantıyı aç
        Using baglanti As New SqlConnection(baglan)
            baglanti.Open()

            ' Seçilen kalkış yerine ait ve seçilen tarihte olan durakları getir
            Dim query As String = "SELECT DISTINCT nereye,durak1_yer, durak2_yer, durak3_yer, durak4_yer FROM seferler WHERE (nereden = @kalkisYeri OR durak1_yer = @kalkisYeri OR durak2_yer = @kalkisYeri OR durak3_yer = @kalkisYeri OR durak4_yer = @kalkisYeri) AND kalkis_tarih = @secilenTarih"
            Dim cmd As New SqlCommand(query, baglanti)
            cmd.Parameters.AddWithValue("@kalkisYeri", kalkisYeri)
            cmd.Parameters.AddWithValue("@secilenTarih", secilenTarih.ToString("dd-MM-yyyy"))

            Dim dr As SqlDataReader = cmd.ExecuteReader()

            ' Durakları listeye ekle
            While dr.Read()
                cbVaris.Items.Add(dr("nereye").ToString())
                For i As Integer = 0 To dr.FieldCount - 1
                    If Not dr.IsDBNull(i) Then
                        Dim durak As String = dr.GetString(i)
                        If Not String.IsNullOrEmpty(durak) AndAlso Not durak.Equals("YOK", StringComparison.OrdinalIgnoreCase) AndAlso Not duraklar.Contains(durak) Then
                            duraklar.Add(durak)
                        End If
                    End If
                Next
            End While

            dr.Close()
        End Using

        Return duraklar
    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Visible = False
        MenuStrip1.Renderer = New menustyle()
        Dim personelTuru As String = GetPersonelTuru(personelID)
        If personelTuru = "Yönetici" Then
            btnPersonelEkle.Visible = True
        Else
            btnPersonelEkle.Visible = False
        End If
        tarihkontrol.tarihkontrolet(Me)

    End Sub
    Private Function GetPersonelTuru(personelID As Integer) As String
        Dim personelTuru As String = ""
        Using connection As New SqlConnection(baglan)
            Dim query As String = "SELECT PersonelTuru FROM Personel WHERE PersonelID = @PersonelID"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@PersonelID", personelID)
                connection.Open()

                personelTuru = Convert.ToString(command.ExecuteScalar())
            End Using
        End Using
        Return personelTuru
    End Function
    Private Function KoltukCinsiyetUygunMu() As Boolean

        Dim baglan As String = "Data Source=cemeren\SQLEXPRESS;Initial Catalog=Otobus_Bilet;Integrated Security=True"
        Dim baglanti0 As New SqlConnection(baglan)
        baglanti0.Open()

        ' Seçilen koltuktaki cinsiyeti al
        Dim query As String = "SELECT koltuk_duzeni FROM otobusler WHERE plaka=@plaka"
        Dim cmd1 As New SqlCommand(query, baglanti0)
        cmd1.Parameters.AddWithValue("@plaka", cbPlaka.Text)

        Dim dr As SqlDataReader = cmd1.ExecuteReader()
        dr.Read()
        Dim koltukduzeni As String = dr("koltuk_duzeni").ToString()


        If koltukduzeni = "2+2" Then
            If lblSutun.Text = "1" OrElse lblSutun.Text = "4" Then
                Using baglanti As New SqlConnection(baglan)
                    baglanti.Open()

                    ' Seçilen koltuktaki cinsiyeti al
                    Dim queryKoltuk As String = "SELECT cinsiyet FROM bilet_satis WHERE sefer_id=@sefer_id AND koltuk_no=@koltuk_no"
                    Dim cmd As New SqlCommand(queryKoltuk, baglanti)
                    cmd.Parameters.AddWithValue("@sefer_id", lblSeferId.Text)
                    cmd.Parameters.AddWithValue("@koltuk_no", Convert.ToInt32(txtKoltuk.Text) - 1) ' Önceki koltuğu almak için -1

                    Dim cinsiyetKoltuk As String = ""


                    ' Eğer önceki koltukta bir değer yoksa, cinsiyetKoltuk değişkeni boş kalacak
                    Dim cinsiyetObj As Object = cmd.ExecuteScalar()
                    If cinsiyetObj IsNot Nothing Then
                        cinsiyetKoltuk = cinsiyetObj.ToString()
                    End If

                    Dim secilenCinsiyet As String = cbCinsiyet.Text

                    If secilenCinsiyet = "Erkek" Then
                        If cinsiyetKoltuk = "Kadın" Then
                            Return False '
                        Else
                            Return True
                        End If
                    ElseIf secilenCinsiyet = "Kadın" Then
                        If cinsiyetKoltuk = "Erkek" Then
                            Return False '
                        Else
                            Return True
                        End If
                    Else
                        Return True
                    End If
                End Using
            ElseIf lblSutun.Text = "0" OrElse lblSutun.Text = "3" Then
                Using baglanti As New SqlConnection(baglan)
                    baglanti.Open()

                    ' Seçilen koltuktaki cinsiyeti al
                    Dim queryKoltuk As String = "SELECT cinsiyet FROM bilet_satis WHERE sefer_id=@sefer_id AND koltuk_no=@koltuk_no"
                    Dim cmd As New SqlCommand(queryKoltuk, baglanti)
                    cmd.Parameters.AddWithValue("@sefer_id", lblSeferId.Text)
                    cmd.Parameters.AddWithValue("@koltuk_no", Convert.ToInt32(txtKoltuk.Text) + 1) ' Önceki koltuğu almak için +1

                    Dim cinsiyetKoltuk As String = ""

                    ' Eğer önceki koltukta bir değer yoksa, cinsiyetKoltuk değişkeni boş kalacak
                    Dim cinsiyetObj As Object = cmd.ExecuteScalar()
                    If cinsiyetObj IsNot Nothing Then
                        cinsiyetKoltuk = cinsiyetObj.ToString()
                    End If


                    Dim secilenCinsiyet As String = cbCinsiyet.Text

                    If secilenCinsiyet = "Erkek" Then
                        If cinsiyetKoltuk = "Kadın" Then
                            Return False
                        Else
                            Return True
                        End If
                    ElseIf secilenCinsiyet = "Kadın" Then
                        If cinsiyetKoltuk = "Erkek" Then
                            Return False
                        Else
                            Return True
                        End If
                    Else
                        Return True
                    End If
                End Using
            End If
        ElseIf koltukduzeni = "2+1" Then
            If lblSutun.Text = "4" Then
                Using baglanti As New SqlConnection(baglan)
                    baglanti.Open()

                    ' Seçilen koltuktaki cinsiyeti al
                    Dim queryKoltuk As String = "SELECT cinsiyet FROM bilet_satis WHERE sefer_id=@sefer_id AND koltuk_no=@koltuk_no"
                    Dim cmd As New SqlCommand(queryKoltuk, baglanti)
                    cmd.Parameters.AddWithValue("@sefer_id", lblSeferId.Text)
                    cmd.Parameters.AddWithValue("@koltuk_no", Convert.ToInt32(txtKoltuk.Text) - 1) ' Önceki koltuğu almak için -1

                    Dim cinsiyetKoltuk As String = ""


                    ' Eğer önceki koltukta bir değer yoksa, cinsiyetKoltuk değişkeni boş kalacak
                    Dim cinsiyetObj As Object = cmd.ExecuteScalar()
                    If cinsiyetObj IsNot Nothing Then
                        cinsiyetKoltuk = cinsiyetObj.ToString()
                    End If

                    Dim secilenCinsiyet As String = cbCinsiyet.Text

                    If secilenCinsiyet = "Erkek" Then
                        If cinsiyetKoltuk = "Kadın" Then
                            Return False '
                        Else
                            Return True
                        End If
                    ElseIf secilenCinsiyet = "Kadın" Then
                        If cinsiyetKoltuk = "Erkek" Then
                            Return False '
                        Else
                            Return True
                        End If
                    Else
                        Return True
                    End If
                End Using
            ElseIf lblSutun.Text = "3" Then
                Using baglanti As New SqlConnection(baglan)
                    baglanti.Open()

                    ' Seçilen koltuktaki cinsiyeti al
                    Dim queryKoltuk As String = "SELECT cinsiyet FROM bilet_satis WHERE sefer_id=@sefer_id AND koltuk_no=@koltuk_no"
                    Dim cmd As New SqlCommand(queryKoltuk, baglanti)
                    cmd.Parameters.AddWithValue("@sefer_id", lblSeferId.Text)
                    cmd.Parameters.AddWithValue("@koltuk_no", Convert.ToInt32(txtKoltuk.Text) + 1) ' Önceki koltuğu almak için +1

                    Dim cinsiyetKoltuk As String = ""

                    ' Eğer önceki koltukta bir değer yoksa, cinsiyetKoltuk değişkeni boş kalacak
                    Dim cinsiyetObj As Object = cmd.ExecuteScalar()
                    If cinsiyetObj IsNot Nothing Then
                        cinsiyetKoltuk = cinsiyetObj.ToString()
                    End If


                    Dim secilenCinsiyet As String = cbCinsiyet.Text

                    If secilenCinsiyet = "Erkek" Then
                        If cinsiyetKoltuk = "Kadın" Then
                            Return False
                        Else
                            Return True
                        End If
                    ElseIf secilenCinsiyet = "Kadın" Then
                        If cinsiyetKoltuk = "Erkek" Then
                            Return False
                        Else
                            Return True
                        End If
                    Else
                        Return True
                    End If
                End Using
            Else
                Return True
            End If
        End If


        dr.Close()
        baglanti0.Close()
    End Function




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSatis.Click
        If cbKalkis.SelectedIndex = -1 OrElse cbVaris.SelectedIndex = -1 OrElse saatKalkis.SelectedIndex = -1 OrElse cbPlaka.SelectedIndex = -1 OrElse tbVarisSaati.Text = Nothing OrElse txtKoltuk.Text = Nothing OrElse txtTc.Text = Nothing OrElse txtAd.Text = Nothing OrElse txtSoyad.Text = Nothing OrElse txtTelefon.Text = Nothing OrElse txtBiletFiyat.Text = Nothing OrElse cbCinsiyet.SelectedIndex = -1 OrElse cbBiletTur.SelectedIndex = -1 Then
            MessageBox.Show("Lütfen gereki alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtTc.Text.Length <> 11 Then
            MessageBox.Show("TC Kimlik numarası 11 haneli olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtTelefon.Text.Length <> 15 Then
            MessageBox.Show("Telefon numarası 10 haneli olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If KoltukCinsiyetUygunMu() Then
            Using baglanti As New SqlConnection(baglan)
                Dim komut As New SqlCommand("INSERT INTO bilet_satis (tc,sefer_id,plaka,ad,soyad,telefon,koltuk_no,cinsiyet,bilet_tur,fiyat,tarih,kalkis_yeri,varis_yeri,sefer_tarih) VALUES (@tc,@sefer_id,@plaka,@ad,@soyad,@telefon,@koltuk_no,@cinsiyet,@bilet_tur,@fiyat,@tarih,@kalkis_yeri,@varis_yeri,@sefer_tarih)", baglanti)
                komut.Parameters.AddWithValue("@tc", txtTc.Text)
                komut.Parameters.AddWithValue("@sefer_id", lblSeferId.Text)
                komut.Parameters.AddWithValue("@plaka", cbPlaka.Text)
                komut.Parameters.AddWithValue("@ad", txtAd.Text)
                komut.Parameters.AddWithValue("@soyad", txtSoyad.Text)
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text)
                komut.Parameters.AddWithValue("@koltuk_no", txtKoltuk.Text)
                komut.Parameters.AddWithValue("@cinsiyet", cbCinsiyet.Text)
                komut.Parameters.AddWithValue("@bilet_tur", cbBiletTur.Text)
                komut.Parameters.AddWithValue("@fiyat", txtBiletFiyat.Text)
                komut.Parameters.AddWithValue("@tarih", Date.Now)
                komut.Parameters.AddWithValue("@kalkis_yeri", cbKalkis.Text)
                komut.Parameters.AddWithValue("@varis_yeri", cbVaris.Text)
                komut.Parameters.AddWithValue("@sefer_tarih", dtKalkis.Value)
                Try
                    baglanti.Open()
                    komut.ExecuteNonQuery()
                    MessageBox.Show("Bilet Satıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BiletYazdir()
                    dtKalkis.Value = Date.Now
                    cbKalkis.Text = ""
                    cbVaris.Text = ""
                    saatKalkis.Items.Clear()
                    tbVarisSaati.Text = ""
                    saatKalkis.Text = ""
                    cbPlaka.Text = ""
                    cbPlaka.Items.Clear()
                    PictureBox1.Visible = False
                    lblSeferId.Text = ""
                    cbBiletTur.Text = ""
                    txtBiletFiyat.Text = ""
                    cbCinsiyet.Text = ""
                    txtKoltuk.Text = ""
                    txtTc.Text = ""
                    txtAd.Text = ""
                    txtSoyad.Text = ""
                    txtTelefon.Text = ""
                    lblSutun.Text = ""
                Catch ex As SqlException
                    MessageBox.Show(ex.Message, "HATA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try

            End Using
        Else
            MessageBox.Show("Seçtiğiniz koltuk yalnızca yanındaki koltuktaki ile aynı cinsiyete sahip ise kişi oturabilir!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


    End Sub

    Private Sub BiletYazdir()

        ' Yazı tipi ve boyutunu belirle
        Dim baseFont As BaseFont = BaseFont.CreateFont("C:\Windows\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED)
        Dim font As New iTextSharp.text.Font(baseFont, 10)

        ' Bilet bilgilerini al
        Dim tc As String = txtTc.Text
        Dim gizlenmisTc As String = TcGizle(tc)
        Dim adSoyad As String = txtAd.Text & " " & txtSoyad.Text
        Dim telefon As String = txtTelefon.Text
        Dim gizlenmisTelefon As String = TelefonGizle(telefon)
        Dim seferNo As String = lblSeferId.Text
        Dim kalkisYeri As String = cbKalkis.Text
        Dim varisYeri As String = cbVaris.Text
        Dim tarih As String = dtKalkis.Text
        Dim Klksaat As String = saatKalkis.Text
        Dim Vrssaat As String = tbVarisSaati.Text
        Dim koltukNo As String = txtKoltuk.Text
        Dim aracPlaka As String = cbPlaka.Text
        Dim cinsiyet As String = cbCinsiyet.Text
        Dim biletTur As String = cbBiletTur.Text
        Dim Fiyat As String = txtBiletFiyat.Text

        ' Bilet içeriği
        Dim biletIcerik As String = "Sefer No: " & seferNo & vbCrLf &
                                "Araç Plakası: " & aracPlaka & vbCrLf &
                                "Kalkış Yeri: " & kalkisYeri & vbCrLf &
                                "Varış Yeri: " & varisYeri & vbCrLf &
                                "Tarih: " & tarih & vbCrLf &
                                "Kalkış Saat: " & Klksaat & vbCrLf &
                                "Varış Saat: " & Vrssaat

        Dim yolcuIcerik As String = "Koltuk No: " & koltukNo & vbCrLf &
                                "Yolcu TC: " & gizlenmisTc & vbCrLf &
                                "Yolcu Adı: " & adSoyad & vbCrLf &
                                "Yolcu Telefonu: " & gizlenmisTelefon & vbCrLf &
                                "Cinsiyet: " & cinsiyet & vbCrLf &
                                "Bilet Türü: " & biletTur & vbCrLf &
                                "Fiyat: " & Fiyat



        ' PDF dosyasının adını belirle
        Dim dosyaAdi As String = "bilet_" & tc & "_" & adSoyad.Replace(" ", "_") & "_" & DateTime.Now.ToString("ddMMyyyy") & ".pdf"
        Dim masaustu As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim dosyaYolu As String = Path.Combine(masaustu, dosyaAdi)

        ' PDF dosyasını oluştur ve içeriği yaz
        Dim doc As New Document()
        PdfWriter.GetInstance(doc, New FileStream(dosyaYolu, FileMode.Create))
        doc.Open()

        ' Ana başlık ekleyin (italic)
        Dim karakoyFont As New iTextSharp.text.Font(baseFont, 22, iTextSharp.text.Font.ITALIC)
        Dim karakoyParagraf As New Paragraph("KARAKÖY TURİZM", karakoyFont)
        karakoyParagraf.Alignment = Element.ALIGN_CENTER
        karakoyParagraf.SpacingAfter = 5
        doc.Add(karakoyParagraf)

        ' "Bilet" yazısı ekleyin (italic, sol)
        Dim biletFont As New iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.ITALIC)
        Dim biletParagraf As New Paragraph("Bilet Bilgileri", biletFont)
        biletParagraf.Alignment = Element.ALIGN_CENTER
        biletParagraf.SpacingAfter = 25
        doc.Add(biletParagraf)

        ' Sefer bilgileri başlığı ve çizgi ekleyin (bold)
        Dim seferBilgileriFont As New iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.BOLD)
        Dim seferBilgileriParagraf As New Paragraph("Sefer Bilgileri", seferBilgileriFont)
        Dim seferLine As New iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, iTextSharp.text.BaseColor.BLACK, Element.ALIGN_LEFT, 1)
        seferBilgileriParagraf.SpacingAfter = 8
        doc.Add(seferBilgileriParagraf)
        doc.Add(seferLine)

        ' Bilet içeriği ekleyin
        Dim biletIcerikParagraf As New Paragraph(biletIcerik, font)
        biletIcerikParagraf.SpacingAfter = 20
        doc.Add(biletIcerikParagraf)

        ' Yolcu bilgileri başlığı ve çizgi ekleyin (bold)
        Dim yolcuBilgileriParagraf As New Paragraph("Yolcu Bilgileri", seferBilgileriFont)
        Dim yolcuLine As New iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, iTextSharp.text.BaseColor.BLACK, Element.ALIGN_LEFT, 1)
        yolcuBilgileriParagraf.SpacingAfter = 8
        doc.Add(yolcuBilgileriParagraf)
        doc.Add(yolcuLine)

        Dim yolcuIcerikParagraf As New Paragraph(yolcuIcerik, font)
        doc.Add(yolcuIcerikParagraf)

        ' PDF dosyasını kapatın
        doc.Close()

        MessageBox.Show("Bilet başarıyla kaydedildi: " & dosyaYolu)

        ' Kaydedilen PDF dosyasını aç
        Process.Start(dosyaYolu)
    End Sub

    Private Function TcGizle(ByVal tc As String) As String
        If tc.Length <> 11 Then
            MessageBox.Show("TC Kimlik numarası 11 haneli olmalıdır.")
            Return ""
        End If

        ' TC'nin 5., 6., 7. ve 8. rakamlarını "*" ile değiştir
        Dim gizlenmisTc As String = tc.Substring(0, 4) & "****" & tc.Substring(8)

        Return gizlenmisTc
    End Function

    Private Function TelefonGizle(ByVal telefon As String) As String
        If telefon.Length <> 15 Then
            MessageBox.Show("Telefon numarası 10 haneli olmalıdır.")
            Return ""
        End If

        Dim gizlenmisTelefon As String = telefon.Substring(0, 5) & " *** " & telefon.Substring(9)

        Return gizlenmisTelefon
    End Function


    Private Sub TemizleButonlar()
        For i As Integer = PictureBox1.Controls.Count - 1 To 0 Step -1
            Dim ctrl As Control = PictureBox1.Controls(i)
            If TypeOf ctrl Is Button AndAlso ctrl.Name.StartsWith("btnKoltuk") Then
                PictureBox1.Controls.RemoveAt(i)
                ctrl.Dispose()
            ElseIf TypeOf ctrl Is Label AndAlso ctrl.Name.StartsWith("Koridor") Then
                PictureBox1.Controls.RemoveAt(i)
                ctrl.Dispose()

            End If
        Next
    End Sub

    Private Sub SeferEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeferEkleToolStripMenuItem.Click
        Dim seferekle As New seferler()
        seferekle.Show()
    End Sub

    Private Sub BiletSatışlarıToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtobüsEkleToolStripMenuItem.Click
        Dim bilet_satis As New bilet_satis()
        bilet_satis.Show()
    End Sub
    Private Sub OtobüsEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BiletSatışlarıToolStripMenuItem.Click
        Dim otobusekle As New otobusekle()
        otobusekle.Show()
    End Sub

    Private Sub btnPersonelEkle_Click(sender As Object, e As EventArgs) Handles btnPersonelEkle.Click
        Dim personelekle As New kullaniciekle()
        personelekle.Show()
    End Sub

    Private Sub anasayfa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub cbKalkis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKalkis.SelectedIndexChanged
        saatKalkis.Items.Clear()
        tbVarisSaati.Text = ""
        saatKalkis.Text = ""
        cbPlaka.Text = ""
        PictureBox1.Visible = False
        lblSeferId.Text = ""
        cbPlaka.Items.Clear()
        cbBiletTur.Text = ""
        txtBiletFiyat.Text = ""

        If cbVaris.SelectedIndex <> -1 Then
            Dim varisYeri As String = cbVaris.SelectedItem.ToString()
            Dim secilenDurak As String = cbKalkis.SelectedItem.ToString()

            Using baglanti As New SqlConnection(baglan)
                baglanti.Open()

                ' Kalkış yerini, varış yerini ve tarihi kullanarak seçilen varış yeri için varış saatlerini getir
                Dim query As String = "SELECT DISTINCT varis_saati,nereden,kalkis_saati, durak1_yer, durak2_yer, durak3_yer, durak4_yer, durak1_varis_saati, durak2_varis_saati, durak3_varis_saati, durak4_varis_saati FROM seferler WHERE (nereye = @varisYeri OR durak1_yer = @varisYeri OR durak2_yer = @varisYeri OR durak3_yer = @varisYeri OR durak4_yer = @varisYeri) AND kalkis_tarih = @tarih AND (nereden = @kalkisYeri OR durak1_yer = @kalkisYeri OR durak2_yer = @kalkisYeri OR durak3_yer = @kalkisYeri OR durak4_yer = @kalkisYeri)"
                Dim cmd As New SqlCommand(query, baglanti)
                cmd.Parameters.AddWithValue("@varisYeri", varisYeri)
                cmd.Parameters.AddWithValue("@kalkisYeri", secilenDurak)
                cmd.Parameters.AddWithValue("@tarih", dtKalkis.Value.Date.ToString("dd-MM-yyyy"))

                Dim dr As SqlDataReader = cmd.ExecuteReader()

                While dr.Read()
                    If Not IsDBNull(dr("nereden")) AndAlso dr("nereden").ToString() = secilenDurak Then
                        Dim varisSaati As String = dr("kalkis_saati").ToString()
                        If Not String.IsNullOrEmpty(varisSaati) Then
                            saatKalkis.Items.Add(varisSaati)
                        End If
                    End If

                    If Not IsDBNull(dr("durak1_yer")) AndAlso dr("durak1_yer").ToString() = secilenDurak Then
                        Dim varisSaati As String = dr("durak1_varis_saati").ToString()
                        If Not String.IsNullOrEmpty(varisSaati) Then
                            saatKalkis.Items.Add(varisSaati)
                        End If
                    End If

                    If Not IsDBNull(dr("durak2_yer")) AndAlso dr("durak2_yer").ToString() = secilenDurak Then
                        Dim varisSaati As String = dr("durak2_varis_saati").ToString()
                        If Not String.IsNullOrEmpty(varisSaati) Then
                            saatKalkis.Items.Add(varisSaati)
                        End If
                    End If

                    If Not IsDBNull(dr("durak3_yer")) AndAlso dr("durak3_yer").ToString() = secilenDurak Then
                        Dim varisSaati As String = dr("durak3_varis_saati").ToString()
                        If Not String.IsNullOrEmpty(varisSaati) Then
                            saatKalkis.Items.Add(varisSaati)
                        End If
                    End If

                    If Not IsDBNull(dr("durak4_yer")) AndAlso dr("durak4_yer").ToString() = secilenDurak Then
                        Dim varisSaati As String = dr("durak4_varis_saati").ToString()
                        If Not String.IsNullOrEmpty(varisSaati) Then
                            saatKalkis.Items.Add(varisSaati)
                        End If
                    End If
                End While

                dr.Close()
            End Using
        End If

    End Sub

    Private Sub cbVaris_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbVaris.SelectedIndexChanged
        saatKalkis.Items.Clear()
        tbVarisSaati.Text = ""
        saatKalkis.Text = ""
        cbPlaka.Text = ""
        cbPlaka.Items.Clear()
        PictureBox1.Visible = False
        lblSeferId.Text = ""
        cbBiletTur.Text = ""
        txtBiletFiyat.Text = ""

        If cbVaris.SelectedIndex <> -1 And cbKalkis.SelectedIndex <> -1 Then
            Dim varisYeri As String = cbVaris.SelectedItem.ToString()
            Dim secilenDurak As String = cbKalkis.SelectedItem.ToString()

            Using baglanti As New SqlConnection(baglan)
                baglanti.Open()

                ' Kalkış yerini, varış yerini ve tarihi kullanarak seçilen varış yeri için varış saatlerini getir
                Dim query As String = "SELECT DISTINCT varis_saati,nereden,kalkis_saati, durak1_yer, durak2_yer, durak3_yer, durak4_yer, durak1_varis_saati, durak2_varis_saati, durak3_varis_saati, durak4_varis_saati FROM seferler WHERE (nereye = @varisYeri OR durak1_yer = @varisYeri OR durak2_yer = @varisYeri OR durak3_yer = @varisYeri OR durak4_yer = @varisYeri) AND kalkis_tarih = @tarih AND (nereden = @kalkisYeri OR durak1_yer = @kalkisYeri OR durak2_yer = @kalkisYeri OR durak3_yer = @kalkisYeri OR durak4_yer = @kalkisYeri)"
                Dim cmd As New SqlCommand(query, baglanti)
                cmd.Parameters.AddWithValue("@varisYeri", varisYeri)
                cmd.Parameters.AddWithValue("@kalkisYeri", secilenDurak)
                cmd.Parameters.AddWithValue("@tarih", dtKalkis.Value.Date.ToString("dd-MM-yyyy"))

                Dim dr As SqlDataReader = cmd.ExecuteReader()

                While dr.Read()
                    If Not IsDBNull(dr("nereden")) AndAlso dr("nereden").ToString() = secilenDurak Then
                        Dim varisSaati As String = dr("kalkis_saati").ToString()
                        If Not String.IsNullOrEmpty(varisSaati) Then
                            saatKalkis.Items.Add(varisSaati)
                        End If
                    End If

                    If Not IsDBNull(dr("durak1_yer")) AndAlso dr("durak1_yer").ToString() = secilenDurak Then
                        Dim varisSaati As String = dr("durak1_varis_saati").ToString()
                        If Not String.IsNullOrEmpty(varisSaati) Then
                            saatKalkis.Items.Add(varisSaati)
                        End If
                    End If

                    If Not IsDBNull(dr("durak2_yer")) AndAlso dr("durak2_yer").ToString() = secilenDurak Then
                        Dim varisSaati As String = dr("durak2_varis_saati").ToString()
                        If Not String.IsNullOrEmpty(varisSaati) Then
                            saatKalkis.Items.Add(varisSaati)
                        End If
                    End If

                    If Not IsDBNull(dr("durak3_yer")) AndAlso dr("durak3_yer").ToString() = secilenDurak Then
                        Dim varisSaati As String = dr("durak3_varis_saati").ToString()
                        If Not String.IsNullOrEmpty(varisSaati) Then
                            saatKalkis.Items.Add(varisSaati)
                        End If
                    End If

                    If Not IsDBNull(dr("durak4_yer")) AndAlso dr("durak4_yer").ToString() = secilenDurak Then
                        Dim varisSaati As String = dr("durak4_varis_saati").ToString()
                        If Not String.IsNullOrEmpty(varisSaati) Then
                            saatKalkis.Items.Add(varisSaati)
                        End If
                    End If
                End While

                dr.Close()
            End Using
        End If
    End Sub


    Private Sub saatKalkis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles saatKalkis.SelectedIndexChanged
        tbVarisSaati.Text = ""
        cbPlaka.Text = ""
        PictureBox1.Visible = False
        lblSeferId.Text = ""
        cbPlaka.Items.Clear()
        cbBiletTur.Text = ""
        txtBiletFiyat.Text = ""
        If cbVaris.SelectedIndex <> -1 Then
            Dim varisYeri As String = cbVaris.SelectedItem.ToString()
            Dim secilenDurak As String = cbKalkis.SelectedItem.ToString()

            Using baglanti As New SqlConnection(baglan)
                baglanti.Open()

                ' Kalkış yerini, varış yerini ve tarihi kullanarak seçilen varış yeri için varış saatlerini getir
                Dim query As String = "SELECT DISTINCT plaka,nereye,varis_saati,nereden,kalkis_saati, durak1_yer, durak2_yer, durak3_yer, durak4_yer, durak1_varis_saati, durak2_varis_saati, durak3_varis_saati, durak4_varis_saati FROM seferler WHERE (nereye = @varisYeri OR durak1_yer = @varisYeri OR durak2_yer = @varisYeri OR durak3_yer = @varisYeri OR durak4_yer = @varisYeri) AND kalkis_tarih = @tarih AND (nereden = @kalkisYeri OR durak1_yer = @kalkisYeri OR durak2_yer = @kalkisYeri OR durak3_yer = @kalkisYeri OR durak4_yer = @kalkisYeri)"
                Dim cmd As New SqlCommand(query, baglanti)
                cmd.Parameters.AddWithValue("@varisYeri", varisYeri)
                cmd.Parameters.AddWithValue("@kalkisYeri", secilenDurak)
                cmd.Parameters.AddWithValue("@tarih", dtKalkis.Value.Date.ToString("dd-MM-yyyy"))

                Dim dr As SqlDataReader = cmd.ExecuteReader()

                While dr.Read()
                    If Not IsDBNull(dr("nereye")) AndAlso dr("nereye").ToString() = varisYeri Then
                        Dim varisSaati As String = dr("varis_saati").ToString()
                        If Not String.IsNullOrEmpty(varisSaati) Then
                            tbVarisSaati.Text = varisSaati
                        End If
                    End If

                    If Not IsDBNull(dr("durak1_yer")) AndAlso dr("durak1_yer").ToString() = varisYeri Then
                        Dim varisSaati As String = dr("durak1_varis_saati").ToString()
                        If Not String.IsNullOrEmpty(varisSaati) Then
                            tbVarisSaati.Text = varisSaati
                        End If
                    End If

                    If Not IsDBNull(dr("durak2_yer")) AndAlso dr("durak2_yer").ToString() = varisYeri Then
                        Dim varisSaati As String = dr("durak2_varis_saati").ToString()
                        If Not String.IsNullOrEmpty(varisSaati) Then
                            tbVarisSaati.Text = varisSaati
                        End If
                    End If

                    If Not IsDBNull(dr("durak3_yer")) AndAlso dr("durak3_yer").ToString() = varisYeri Then
                        Dim varisSaati As String = dr("durak3_varis_saati").ToString()
                        If Not String.IsNullOrEmpty(varisSaati) Then
                            tbVarisSaati.Text = varisSaati
                        End If
                    End If

                    If Not IsDBNull(dr("durak4_yer")) AndAlso dr("durak4_yer").ToString() = varisYeri Then
                        Dim varisSaati As String = dr("durak4_varis_saati").ToString()
                        If Not String.IsNullOrEmpty(varisSaati) Then
                            tbVarisSaati.Text = varisSaati
                        End If
                    End If
                End While

                dr.Close()
                Dim query1 As String = "SELECT DISTINCT plaka FROM seferler WHERE (nereden = @kalkisYeri OR durak1_yer = @kalkisYeri OR durak2_yer = @kalkisYeri OR durak3_yer = @kalkisYeri OR durak4_yer = @kalkisYeri) AND (nereye = @varisYeri OR durak1_yer = @varisYeri OR durak2_yer = @varisYeri OR durak3_yer = @varisYeri OR durak4_yer = @varisYeri) AND kalkis_tarih = @tarih"
                Dim cmd1 As New SqlCommand(query1, baglanti)
                cmd1.Parameters.AddWithValue("@varisYeri", varisYeri)
                cmd1.Parameters.AddWithValue("@kalkisYeri", secilenDurak)
                cmd1.Parameters.AddWithValue("@tarih", dtKalkis.Value.Date.ToString("dd-MM-yyyy"))
                Dim dr1 As SqlDataReader = cmd1.ExecuteReader()

                While dr1.Read()
                    Dim plaka As String = dr1("plaka").ToString()
                    If Not String.IsNullOrEmpty(plaka) Then
                        cbPlaka.Items.Add(plaka)
                    End If
                End While

                dr1.Close()
            End Using
        End If
    End Sub

    Private Sub dtKalkis_ValueChanged(sender As Object, e As EventArgs) Handles dtKalkis.ValueChanged
        saatKalkis.Items.Clear()
        tbVarisSaati.Text = ""
        saatKalkis.Text = ""
        cbPlaka.Text = ""
        PictureBox1.Visible = False
        lblSeferId.Text = ""
        cbPlaka.Items.Clear()
        cbBiletTur.Text = ""
        txtBiletFiyat.Text = ""

        If cbVaris.SelectedIndex <> -1 Then
            Dim varisYeri As String = cbVaris.SelectedItem.ToString()
            Dim secilenDurak As String = cbKalkis.SelectedItem.ToString()

            Using baglanti As New SqlConnection(baglan)
                baglanti.Open()

                ' Kalkış yerini, varış yerini ve tarihi kullanarak seçilen varış yeri için varış saatlerini getir
                Dim query As String = "SELECT DISTINCT varis_saati,nereden,kalkis_saati, durak1_yer, durak2_yer, durak3_yer, durak4_yer, durak1_varis_saati, durak2_varis_saati, durak3_varis_saati, durak4_varis_saati FROM seferler WHERE (nereye = @varisYeri OR durak1_yer = @varisYeri OR durak2_yer = @varisYeri OR durak3_yer = @varisYeri OR durak4_yer = @varisYeri) AND kalkis_tarih = @tarih AND (nereden = @kalkisYeri OR durak1_yer = @kalkisYeri OR durak2_yer = @kalkisYeri OR durak3_yer = @kalkisYeri OR durak4_yer = @kalkisYeri)"
                Dim cmd As New SqlCommand(query, baglanti)
                cmd.Parameters.AddWithValue("@varisYeri", varisYeri)
                cmd.Parameters.AddWithValue("@kalkisYeri", secilenDurak)
                cmd.Parameters.AddWithValue("@tarih", dtKalkis.Value.Date.ToString("dd-MM-yyyy"))

                Dim dr As SqlDataReader = cmd.ExecuteReader()

                While dr.Read()
                    If Not IsDBNull(dr("nereden")) AndAlso dr("nereden").ToString() = secilenDurak Then
                        Dim varisSaati As String = dr("kalkis_saati").ToString()
                        If Not String.IsNullOrEmpty(varisSaati) Then
                            saatKalkis.Items.Add(varisSaati)
                        End If
                    End If

                    If Not IsDBNull(dr("durak1_yer")) AndAlso dr("durak1_yer").ToString() = secilenDurak Then
                        Dim varisSaati As String = dr("durak1_varis_saati").ToString()
                        If Not String.IsNullOrEmpty(varisSaati) Then
                            saatKalkis.Items.Add(varisSaati)
                        End If
                    End If

                    If Not IsDBNull(dr("durak2_yer")) AndAlso dr("durak2_yer").ToString() = secilenDurak Then
                        Dim varisSaati As String = dr("durak2_varis_saati").ToString()
                        If Not String.IsNullOrEmpty(varisSaati) Then
                            saatKalkis.Items.Add(varisSaati)
                        End If
                    End If

                    If Not IsDBNull(dr("durak3_yer")) AndAlso dr("durak3_yer").ToString() = secilenDurak Then
                        Dim varisSaati As String = dr("durak3_varis_saati").ToString()
                        If Not String.IsNullOrEmpty(varisSaati) Then
                            saatKalkis.Items.Add(varisSaati)
                        End If
                    End If

                    If Not IsDBNull(dr("durak4_yer")) AndAlso dr("durak4_yer").ToString() = secilenDurak Then
                        Dim varisSaati As String = dr("durak4_varis_saati").ToString()
                        If Not String.IsNullOrEmpty(varisSaati) Then
                            saatKalkis.Items.Add(varisSaati)
                        End If
                    End If
                End While

                dr.Close()
            End Using
        End If
    End Sub

    Private Sub cbPlaka_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPlaka.SelectedIndexChanged
        cbBiletTur.Text = ""
        txtBiletFiyat.Text = ""
        If cbPlaka.SelectedIndex <> -1 Then
            TemizleButonlar()
            Dim varisYeri As String = cbVaris.SelectedItem.ToString()
            Dim kalkisYeri As String = cbKalkis.SelectedItem.ToString()
            Dim secilenSaat As String = saatKalkis.SelectedItem.ToString()
            Using baglanti As New SqlConnection(baglan)
                baglanti.Open()
                Dim query1 As String = "SELECT sefer_id FROM seferler where plaka=@plaka AND (nereye = @varisYeri OR durak1_yer = @varisYeri OR durak2_yer = @varisYeri OR durak3_yer = @varisYeri OR durak4_yer = @varisYeri) AND (kalkis_tarih = @tarih OR durak1_tarih=@tarih OR durak2_tarih=@tarih OR durak3_tarih=@tarih OR durak4_tarih=@tarih) AND (nereden = @kalkisYeri OR durak1_yer = @kalkisYeri OR durak2_yer = @kalkisYeri OR durak3_yer = @kalkisYeri OR durak4_yer = @kalkisYeri) AND (kalkis_saati= @kalkisSaat OR durak1_varis_saati = @kalkisSaat OR durak2_varis_saati = @kalkisSaat OR durak3_varis_saati = @kalkisSaat OR durak4_varis_saati = @kalkisSaat) "
                Dim cmd1 As New SqlCommand(query1, baglanti)
                cmd1.Parameters.AddWithValue("@plaka", cbPlaka.Text)
                cmd1.Parameters.AddWithValue("@varisYeri", varisYeri)
                cmd1.Parameters.AddWithValue("@tarih", dtKalkis.Value.Date.ToString("dd-MM-yyyy"))
                cmd1.Parameters.AddWithValue("@kalkisYeri", kalkisYeri)
                cmd1.Parameters.AddWithValue("@kalkisSaat", secilenSaat)

                Dim dr1 As SqlDataReader = cmd1.ExecuteReader()

                dr1.Read() '
                Dim seferId As Integer = dr1("sefer_id").ToString()
                lblSeferId.Text = seferId
                dr1.Close()

                Dim query As String = "SELECT * FROM otobusler where plaka=@plaka"
                Dim cmd As New SqlCommand(query, baglanti)
                cmd.Parameters.AddWithValue("@plaka", cbPlaka.Text)

                Dim dr As SqlDataReader = cmd.ExecuteReader()

                While dr.Read()
                    Dim koltukDuzeni As String = dr("koltuk_duzeni").ToString()
                    If Not String.IsNullOrEmpty(koltukDuzeni) Then
                        If koltukDuzeni = "2+1" Then
                            PictureBox1.Visible = True
                            koltuklar.KoltukOlustur_21(PictureBox1, txtKoltuk, cbPlaka.Text, seferId, lblSutun)
                        ElseIf koltukDuzeni = "2+2" Then
                            PictureBox1.Visible = True
                            koltuklar.KoltukOlustur_22(PictureBox1, txtKoltuk, cbPlaka.Text, seferId, lblSutun)
                        End If
                    End If
                End While
                dr.Close()

            End Using
        End If
    End Sub

    Private Sub cbBiletTur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBiletTur.SelectedIndexChanged
        If cbBiletTur.SelectedIndex <> -1 AndAlso cbVaris.SelectedIndex <> -1 AndAlso cbKalkis.SelectedIndex <> -1 AndAlso saatKalkis.SelectedIndex <> -1 AndAlso cbPlaka.SelectedIndex <> -1 Then
            Dim varisYeri As String = cbVaris.SelectedItem.ToString()
            Dim kalkisYeri As String = cbKalkis.SelectedItem.ToString()
            Dim secilenSaat As String = saatKalkis.SelectedItem.ToString()
            Using baglanti As New SqlConnection(baglan)
                baglanti.Open()
                Dim query1 As String = "SELECT ucret, durak1_ucret,durak2_ucret,durak3_ucret,durak4_ucret ,nereye,durak1_yer, durak2_yer, durak3_yer, durak4_yer FROM seferler where plaka=@plaka AND (nereye = @varisYeri OR durak1_yer = @varisYeri OR durak2_yer = @varisYeri OR durak3_yer = @varisYeri OR durak4_yer = @varisYeri) AND (kalkis_tarih = @tarih OR durak1_tarih=@tarih OR durak2_tarih=@tarih OR durak3_tarih=@tarih OR durak4_tarih=@tarih) AND (nereden = @kalkisYeri OR durak1_yer = @kalkisYeri OR durak2_yer = @kalkisYeri OR durak3_yer = @kalkisYeri OR durak4_yer = @kalkisYeri) AND (kalkis_saati= @kalkisSaat OR durak1_varis_saati = @kalkisSaat OR durak2_varis_saati = @kalkisSaat OR durak3_varis_saati = @kalkisSaat OR durak4_varis_saati = @kalkisSaat) "
                Dim cmd1 As New SqlCommand(query1, baglanti)
                cmd1.Parameters.AddWithValue("@plaka", cbPlaka.Text)
                cmd1.Parameters.AddWithValue("@varisYeri", varisYeri)
                cmd1.Parameters.AddWithValue("@tarih", dtKalkis.Value.Date.ToString("dd-MM-yyyy"))
                cmd1.Parameters.AddWithValue("@kalkisYeri", kalkisYeri)
                cmd1.Parameters.AddWithValue("@kalkisSaat", secilenSaat)


                Dim baglanti0 As New SqlConnection(baglan)
                baglanti0.Open()


                Dim query As String = "SELECT koltuk_duzeni FROM otobusler WHERE plaka=@plaka"
                Dim cmd2 As New SqlCommand(query, baglanti0)
                cmd2.Parameters.AddWithValue("@plaka", cbPlaka.Text)

                Dim dr1 As SqlDataReader = cmd2.ExecuteReader()
                dr1.Read()
                Dim koltukduzeni As String = dr1("koltuk_duzeni").ToString()

                Dim dr As SqlDataReader = cmd1.ExecuteReader()

                While dr.Read()
                    If Not IsDBNull(dr("nereye")) AndAlso dr("nereye").ToString() = varisYeri Then
                        If Not IsDBNull(dr("ucret")) Then
                            Dim varisUcret As Decimal = Convert.ToDecimal(dr("ucret"))
                            If cbBiletTur.SelectedIndex = 0 Then
                                If koltukduzeni = "2+1" And lblSutun.Text = "0" Then
                                    txtBiletFiyat.Text = (varisUcret - (varisUcret * 0.2) + 10).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+1" And (lblSutun.Text = "3" Or lblSutun.Text = "4") Then
                                    txtBiletFiyat.Text = (varisUcret - (varisUcret * 0.2)).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+2" Then
                                    txtBiletFiyat.Text = (varisUcret - (varisUcret * 0.2)).ToString("N2") & " TL"
                                End If
                            ElseIf cbBiletTur.SelectedIndex = 1 Then
                                If koltukduzeni = "2+1" And lblSutun.Text = "0" Then
                                    txtBiletFiyat.Text = (varisUcret + 10).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+1" And (lblSutun.Text = "3" Or lblSutun.Text = "4") Then
                                    txtBiletFiyat.Text = (varisUcret).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+2" Then
                                    txtBiletFiyat.Text = (varisUcret).ToString("N2") & " TL"
                                End If
                            End If

                        End If
                    End If

                    If Not IsDBNull(dr("durak1_yer")) AndAlso dr("durak1_yer").ToString() = varisYeri Then
                        If Not IsDBNull(dr("durak1_ucret")) Then
                            Dim varisUcret As Decimal = Convert.ToDecimal(dr("durak1_ucret"))
                            If cbBiletTur.SelectedIndex = 0 Then
                                If koltukduzeni = "2+1" And lblSutun.Text = "0" Then
                                    txtBiletFiyat.Text = (varisUcret - (varisUcret * 0.2) + 10).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+1" And (lblSutun.Text = "3" Or lblSutun.Text = "4") Then
                                    txtBiletFiyat.Text = (varisUcret - (varisUcret * 0.2)).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+2" Then
                                    txtBiletFiyat.Text = (varisUcret - (varisUcret * 0.2)).ToString("N2") & " TL"
                                End If
                            ElseIf cbBiletTur.SelectedIndex = 1 Then
                                If koltukduzeni = "2+1" And lblSutun.Text = "0" Then
                                    txtBiletFiyat.Text = (varisUcret + 10).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+1" And (lblSutun.Text = "3" Or lblSutun.Text = "4") Then
                                    txtBiletFiyat.Text = (varisUcret).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+2" Then
                                    txtBiletFiyat.Text = (varisUcret).ToString("N2") & " TL"
                                End If
                            End If

                        End If
                    End If

                    If Not IsDBNull(dr("durak2_yer")) AndAlso dr("durak2_yer").ToString() = varisYeri Then
                        If Not IsDBNull(dr("durak2_ucret")) Then
                            Dim varisUcret As Decimal = Convert.ToDecimal(dr("durak2_ucret"))
                            If cbBiletTur.SelectedIndex = 0 Then
                                If koltukduzeni = "2+1" And lblSutun.Text = "0" Then
                                    txtBiletFiyat.Text = (varisUcret - (varisUcret * 0.2) + 10).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+1" And (lblSutun.Text = "3" Or lblSutun.Text = "4") Then
                                    txtBiletFiyat.Text = (varisUcret - (varisUcret * 0.2)).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+2" Then
                                    txtBiletFiyat.Text = (varisUcret - (varisUcret * 0.2)).ToString("N2") & " TL"
                                End If
                            ElseIf cbBiletTur.SelectedIndex = 1 Then
                                If koltukduzeni = "2+1" And lblSutun.Text = "0" Then
                                    txtBiletFiyat.Text = (varisUcret + 10).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+1" And (lblSutun.Text = "3" Or lblSutun.Text = "4") Then
                                    txtBiletFiyat.Text = (varisUcret).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+2" Then
                                    txtBiletFiyat.Text = (varisUcret).ToString("N2") & " TL"
                                End If
                            End If

                        End If
                    End If

                    If Not IsDBNull(dr("durak3_yer")) AndAlso dr("durak3_yer").ToString() = varisYeri Then
                        If Not IsDBNull(dr("durak3_ucret")) Then
                            Dim varisUcret As Decimal = Convert.ToDecimal(dr("durak3_ucret"))
                            If cbBiletTur.SelectedIndex = 0 Then
                                If koltukduzeni = "2+1" And lblSutun.Text = "0" Then
                                    txtBiletFiyat.Text = (varisUcret - (varisUcret * 0.2) + 10).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+1" And (lblSutun.Text = "3" Or lblSutun.Text = "4") Then
                                    txtBiletFiyat.Text = (varisUcret - (varisUcret * 0.2)).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+2" Then
                                    txtBiletFiyat.Text = (varisUcret - (varisUcret * 0.2)).ToString("N2") & " TL"
                                End If
                            ElseIf cbBiletTur.SelectedIndex = 1 Then
                                If koltukduzeni = "2+1" And lblSutun.Text = "0" Then
                                    txtBiletFiyat.Text = (varisUcret + 10).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+1" And (lblSutun.Text = "3" Or lblSutun.Text = "4") Then
                                    txtBiletFiyat.Text = (varisUcret).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+2" Then
                                    txtBiletFiyat.Text = (varisUcret).ToString("N2") & " TL"
                                End If
                            End If

                        End If
                    End If

                    If Not IsDBNull(dr("durak4_yer")) AndAlso dr("durak4_yer").ToString() = varisYeri Then
                        If Not IsDBNull(dr("durak4_ucret")) Then
                            Dim varisUcret As Decimal = Convert.ToDecimal(dr("durak4_ucret"))
                            If cbBiletTur.SelectedIndex = 0 Then
                                If koltukduzeni = "2+1" And lblSutun.Text = "0" Then
                                    txtBiletFiyat.Text = (varisUcret - (varisUcret * 0.2) + 10).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+1" And (lblSutun.Text = "3" Or lblSutun.Text = "4") Then
                                    txtBiletFiyat.Text = (varisUcret - (varisUcret * 0.2)).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+2" Then
                                    txtBiletFiyat.Text = (varisUcret - (varisUcret * 0.2)).ToString("N2") & " TL"
                                End If
                            ElseIf cbBiletTur.SelectedIndex = 1 Then
                                If koltukduzeni = "2+1" And lblSutun.Text = "0" Then
                                    txtBiletFiyat.Text = (varisUcret + 10).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+1" And (lblSutun.Text = "3" Or lblSutun.Text = "4") Then
                                    txtBiletFiyat.Text = (varisUcret).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+2" Then
                                    txtBiletFiyat.Text = (varisUcret).ToString("N2") & " TL"
                                End If
                            End If

                        End If
                    End If
                End While

                dr.Close()
                dr1.Close()
                baglanti0.Close()
            End Using

        End If
    End Sub

    Private Sub txtKoltuk_TextChanged(sender As Object, e As EventArgs) Handles txtKoltuk.TextChanged
        If cbBiletTur.SelectedIndex <> -1 AndAlso cbVaris.SelectedIndex <> -1 AndAlso cbKalkis.SelectedIndex <> -1 AndAlso saatKalkis.SelectedIndex <> -1 AndAlso cbPlaka.SelectedIndex <> -1 Then
            Dim varisYeri As String = cbVaris.SelectedItem.ToString()
            Dim kalkisYeri As String = cbKalkis.SelectedItem.ToString()
            Dim secilenSaat As String = saatKalkis.SelectedItem.ToString()
            Using baglanti As New SqlConnection(baglan)
                baglanti.Open()
                Dim query1 As String = "SELECT ucret, durak1_ucret,durak2_ucret,durak3_ucret,durak4_ucret ,nereye,durak1_yer, durak2_yer, durak3_yer, durak4_yer FROM seferler where plaka=@plaka AND (nereye = @varisYeri OR durak1_yer = @varisYeri OR durak2_yer = @varisYeri OR durak3_yer = @varisYeri OR durak4_yer = @varisYeri) AND (kalkis_tarih = @tarih OR durak1_tarih=@tarih OR durak2_tarih=@tarih OR durak3_tarih=@tarih OR durak4_tarih=@tarih) AND (nereden = @kalkisYeri OR durak1_yer = @kalkisYeri OR durak2_yer = @kalkisYeri OR durak3_yer = @kalkisYeri OR durak4_yer = @kalkisYeri) AND (kalkis_saati= @kalkisSaat OR durak1_varis_saati = @kalkisSaat OR durak2_varis_saati = @kalkisSaat OR durak3_varis_saati = @kalkisSaat OR durak4_varis_saati = @kalkisSaat) "
                Dim cmd1 As New SqlCommand(query1, baglanti)
                cmd1.Parameters.AddWithValue("@plaka", cbPlaka.Text)
                cmd1.Parameters.AddWithValue("@varisYeri", varisYeri)
                cmd1.Parameters.AddWithValue("@tarih", dtKalkis.Value.Date.ToString("dd-MM-yyyy"))
                cmd1.Parameters.AddWithValue("@kalkisYeri", kalkisYeri)
                cmd1.Parameters.AddWithValue("@kalkisSaat", secilenSaat)


                Dim baglanti0 As New SqlConnection(baglan)
                baglanti0.Open()


                Dim query As String = "SELECT koltuk_duzeni FROM otobusler WHERE plaka=@plaka"
                Dim cmd2 As New SqlCommand(query, baglanti0)
                cmd2.Parameters.AddWithValue("@plaka", cbPlaka.Text)

                Dim dr1 As SqlDataReader = cmd2.ExecuteReader()
                dr1.Read()
                Dim koltukduzeni As String = dr1("koltuk_duzeni").ToString()

                Dim dr As SqlDataReader = cmd1.ExecuteReader()

                While dr.Read()
                    If Not IsDBNull(dr("nereye")) AndAlso dr("nereye").ToString() = varisYeri Then
                        If Not IsDBNull(dr("ucret")) Then
                            Dim varisUcret As Decimal = Convert.ToDecimal(dr("ucret"))
                            If cbBiletTur.SelectedIndex = 0 Then
                                If koltukduzeni = "2+1" And lblSutun.Text = "0" Then
                                    txtBiletFiyat.Text = (varisUcret - (varisUcret * 0.2) + 10).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+1" And (lblSutun.Text = "3" Or lblSutun.Text = "4") Then
                                    txtBiletFiyat.Text = (varisUcret - (varisUcret * 0.2)).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+2" Then
                                    txtBiletFiyat.Text = (varisUcret - (varisUcret * 0.2)).ToString("N2") & " TL"
                                End If
                            ElseIf cbBiletTur.SelectedIndex = 1 Then
                                If koltukduzeni = "2+1" And lblSutun.Text = "0" Then
                                    txtBiletFiyat.Text = (varisUcret + 10).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+1" And (lblSutun.Text = "3" Or lblSutun.Text = "4") Then
                                    txtBiletFiyat.Text = (varisUcret).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+2" Then
                                    txtBiletFiyat.Text = (varisUcret).ToString("N2") & " TL"
                                End If
                            End If

                        End If
                    End If

                    If Not IsDBNull(dr("durak1_yer")) AndAlso dr("durak1_yer").ToString() = varisYeri Then
                        If Not IsDBNull(dr("durak1_ucret")) Then
                            Dim varisUcret As Decimal = Convert.ToDecimal(dr("durak1_ucret"))
                            If cbBiletTur.SelectedIndex = 0 Then
                                If koltukduzeni = "2+1" And lblSutun.Text = "0" Then
                                    txtBiletFiyat.Text = (varisUcret - (varisUcret * 0.2) + 10).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+1" And (lblSutun.Text = "3" Or lblSutun.Text = "4") Then
                                    txtBiletFiyat.Text = (varisUcret - (varisUcret * 0.2)).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+2" Then
                                    txtBiletFiyat.Text = (varisUcret - (varisUcret * 0.2)).ToString("N2") & " TL"
                                End If
                            ElseIf cbBiletTur.SelectedIndex = 1 Then
                                If koltukduzeni = "2+1" And lblSutun.Text = "0" Then
                                    txtBiletFiyat.Text = (varisUcret + 10).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+1" And (lblSutun.Text = "3" Or lblSutun.Text = "4") Then
                                    txtBiletFiyat.Text = (varisUcret).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+2" Then
                                    txtBiletFiyat.Text = (varisUcret).ToString("N2") & " TL"
                                End If
                            End If

                        End If
                    End If

                    If Not IsDBNull(dr("durak2_yer")) AndAlso dr("durak2_yer").ToString() = varisYeri Then
                        If Not IsDBNull(dr("durak2_ucret")) Then
                            Dim varisUcret As Decimal = Convert.ToDecimal(dr("durak2_ucret"))
                            If cbBiletTur.SelectedIndex = 0 Then
                                If koltukduzeni = "2+1" And lblSutun.Text = "0" Then
                                    txtBiletFiyat.Text = (varisUcret - (varisUcret * 0.2) + 10).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+1" And (lblSutun.Text = "3" Or lblSutun.Text = "4") Then
                                    txtBiletFiyat.Text = (varisUcret - (varisUcret * 0.2)).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+2" Then
                                    txtBiletFiyat.Text = (varisUcret - (varisUcret * 0.2)).ToString("N2") & " TL"
                                End If
                            ElseIf cbBiletTur.SelectedIndex = 1 Then
                                If koltukduzeni = "2+1" And lblSutun.Text = "0" Then
                                    txtBiletFiyat.Text = (varisUcret + 10).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+1" And (lblSutun.Text = "3" Or lblSutun.Text = "4") Then
                                    txtBiletFiyat.Text = (varisUcret).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+2" Then
                                    txtBiletFiyat.Text = (varisUcret).ToString("N2") & " TL"
                                End If
                            End If

                        End If
                    End If

                    If Not IsDBNull(dr("durak3_yer")) AndAlso dr("durak3_yer").ToString() = varisYeri Then
                        If Not IsDBNull(dr("durak3_ucret")) Then
                            Dim varisUcret As Decimal = Convert.ToDecimal(dr("durak3_ucret"))
                            If cbBiletTur.SelectedIndex = 0 Then
                                If koltukduzeni = "2+1" And lblSutun.Text = "0" Then
                                    txtBiletFiyat.Text = (varisUcret - (varisUcret * 0.2) + 10).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+1" And (lblSutun.Text = "3" Or lblSutun.Text = "4") Then
                                    txtBiletFiyat.Text = (varisUcret - (varisUcret * 0.2)).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+2" Then
                                    txtBiletFiyat.Text = (varisUcret - (varisUcret * 0.2)).ToString("N2") & " TL"
                                End If
                            ElseIf cbBiletTur.SelectedIndex = 1 Then
                                If koltukduzeni = "2+1" And lblSutun.Text = "0" Then
                                    txtBiletFiyat.Text = (varisUcret + 10).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+1" And (lblSutun.Text = "3" Or lblSutun.Text = "4") Then
                                    txtBiletFiyat.Text = (varisUcret).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+2" Then
                                    txtBiletFiyat.Text = (varisUcret).ToString("N2") & " TL"
                                End If
                            End If

                        End If
                    End If

                    If Not IsDBNull(dr("durak4_yer")) AndAlso dr("durak4_yer").ToString() = varisYeri Then
                        If Not IsDBNull(dr("durak4_ucret")) Then
                            Dim varisUcret As Decimal = Convert.ToDecimal(dr("durak4_ucret"))
                            If cbBiletTur.SelectedIndex = 0 Then
                                If koltukduzeni = "2+1" And lblSutun.Text = "0" Then
                                    txtBiletFiyat.Text = (varisUcret - (varisUcret * 0.2) + 10).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+1" And (lblSutun.Text = "3" Or lblSutun.Text = "4") Then
                                    txtBiletFiyat.Text = (varisUcret - (varisUcret * 0.2)).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+2" Then
                                    txtBiletFiyat.Text = (varisUcret - (varisUcret * 0.2)).ToString("N2") & " TL"
                                End If
                            ElseIf cbBiletTur.SelectedIndex = 1 Then
                                If koltukduzeni = "2+1" And lblSutun.Text = "0" Then
                                    txtBiletFiyat.Text = (varisUcret + 10).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+1" And (lblSutun.Text = "3" Or lblSutun.Text = "4") Then
                                    txtBiletFiyat.Text = (varisUcret).ToString("N2") & " TL"
                                ElseIf koltukduzeni = "2+2" Then
                                    txtBiletFiyat.Text = (varisUcret).ToString("N2") & " TL"
                                End If
                            End If

                        End If
                    End If
                End While

                dr.Close()
                dr1.Close()
                baglanti0.Close()
            End Using

        End If
    End Sub

End Class
