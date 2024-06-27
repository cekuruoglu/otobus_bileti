Imports System.Data.SqlClient

Public Class koltuklar

    Public Shared Sub KoltukOlustur_22(picture As PictureBox, lbl As TextBox, plaka As String, seferId As Integer, _sutunSayi As Label)
        Dim baglan As String = "Data Source=cemeren\SQLEXPRESS;Initial Catalog=Otobus_Bilet;Integrated Security=True"
        Using baglanti As New SqlConnection(baglan)
            baglanti.Open()

            Dim query As String = "SELECT * FROM otobusler where plaka=@plaka"
            Dim cmd As New SqlCommand(query, baglanti)
            cmd.Parameters.AddWithValue("@plaka", plaka)

            Dim dr As SqlDataReader = cmd.ExecuteReader()
            dr.Read()
            Dim koltuksayi As Integer = dr("koltuk_sayisi")
            dr.Close()

            Dim sutunsayi As Integer = 5
            Dim satirsayi As Integer = Math.Ceiling(koltuksayi / (sutunsayi - 1))
            Dim butonGen As Integer = 30
            Dim butonYuk As Integer = 30
            Dim butonboslukX As Integer = 25
            Dim butonboslukY As Integer = 10
            Dim baslangicX As Integer = 40
            Dim baslangicY As Integer = 140

            Dim koltukNumarasi As Integer = 1

            For satir As Integer = 0 To satirsayi - 1
                For sutun As Integer = 0 To sutunsayi - 1
                    If sutun = 2 Then
                        Dim koridorLbl As New Label()
                        koridorLbl.Width = butonGen
                        koridorLbl.Height = butonYuk
                        koridorLbl.Text = ""
                        koridorLbl.BackColor = ColorTranslator.FromHtml("#f3f7f8")
                        koridorLbl.Name = "Koridor" & koltukNumarasi
                        koridorLbl.TextAlign = ContentAlignment.MiddleCenter

                        Dim x As Integer = baslangicX + (sutun * (butonGen + butonboslukX))
                        Dim y As Integer = baslangicY + (satir * (butonYuk + butonboslukY))
                        koridorLbl.Location = New Point(x, y)

                        picture.Controls.Add(koridorLbl)
                    Else

                        If koltukNumarasi <> 23 AndAlso koltukNumarasi <> 24 Then
                            Dim btnKoltuk As New Button()
                            btnKoltuk.Width = butonGen
                            btnKoltuk.Height = butonYuk
                            Dim buttonName As String = "btnKoltuk_" & koltukNumarasi & "_" & sutun ' Buton adına sütun numarasını ekleyelim
                            btnKoltuk.Name = buttonName
                            If koltukNumarasi < 23 Then
                                btnKoltuk.Text = koltukNumarasi
                            ElseIf koltukNumarasi > 24 Then
                                btnKoltuk.Text = koltukNumarasi - 2
                            End If
                            btnKoltuk.FlatStyle = FlatStyle.Flat
                            btnKoltuk.BackColor = Color.LightGreen
                            btnKoltuk.ForeColor = Color.Black
                            btnKoltuk.TextAlign = ContentAlignment.MiddleCenter
                            Dim cinsiyet As String = KoltukCinsiyetiniGetir(plaka, btnKoltuk.Text, seferId)
                            If cinsiyet = "Erkek" Then
                                btnKoltuk.Enabled = False
                                btnKoltuk.BackColor = Color.LightBlue
                            ElseIf cinsiyet = "Kadın" Then
                                btnKoltuk.Enabled = False
                                btnKoltuk.BackColor = Color.Pink
                            Else

                                btnKoltuk.BackColor = Color.LightGreen ' Satılmamış koltuklar için varsayılan renk
                                AddHandler btnKoltuk.Click, Sub(sender, e)
                                                                ' Buton adını analiz ederek kaçıncı sütunda olduğunu belirle
                                                                Dim buttonNameParts() As String = btnKoltuk.Name.Split("_")
                                                                Dim columnNumber As Integer = Convert.ToInt32(buttonNameParts(2))
                                                                _sutunSayi.Text = columnNumber
                                                                lbl.Text = btnKoltuk.Text
                                                            End Sub

                            End If


                            Dim x As Integer = baslangicX + (sutun * (butonGen + butonboslukX))
                            Dim y As Integer = baslangicY + (satir * (butonYuk + butonboslukY))
                            btnKoltuk.Location = New Point(x, y)
                            'AddHandler btnKoltuk.Click, Sub(sender, e) lbl.Text = btnKoltuk.Text
                            picture.Controls.Add(btnKoltuk)
                        End If

                        koltukNumarasi += 1
                    End If
                Next
            Next
        End Using
    End Sub

    Public Shared Sub KoltukOlustur_21(picture As PictureBox, lbl As TextBox, plaka As String, seferId As Integer, _sutunSayi As Label)
        Dim baglan As String = "Data Source=cemeren\SQLEXPRESS;Initial Catalog=Otobus_Bilet;Integrated Security=True"
        Using baglanti As New SqlConnection(baglan)
            baglanti.Open()

            Dim query As String = "SELECT * FROM otobusler where plaka=@plaka"
            Dim cmd As New SqlCommand(query, baglanti)
            cmd.Parameters.AddWithValue("@plaka", plaka)

            Dim dr As SqlDataReader = cmd.ExecuteReader()
            dr.Read()
            Dim koltuksayi As Integer = dr("koltuk_sayisi")
            dr.Close()
            Dim sutunsayi As Integer = 5
            Dim satirsayi As Integer = Math.Ceiling(koltuksayi / (sutunsayi - 2))
            Dim butonGen As Integer = 30
            Dim butonYuk As Integer = 30
            Dim butonboslukX As Integer = 25
            Dim butonboslukY As Integer = 10
            Dim baslangicX As Integer = 40
            Dim baslangicY As Integer = 120

            Dim koltukNumarasi As Integer = 1

            For satir As Integer = 0 To satirsayi - 1
                For sutun As Integer = 0 To sutunsayi - 1
                    If sutun = 2 OrElse sutun = 1 Then

                        Dim koridorLbl As New Label()
                        koridorLbl.Width = butonGen
                        koridorLbl.Height = butonYuk
                        koridorLbl.Text = ""
                        koridorLbl.Name = "Koridor" & koltukNumarasi
                        koridorLbl.BackColor = ColorTranslator.FromHtml("#f3f7f8")
                        koridorLbl.TextAlign = ContentAlignment.MiddleCenter


                        Dim x As Integer = baslangicX + (sutun * (butonGen + butonboslukX))
                        Dim y As Integer = baslangicY + (satir * (butonYuk + butonboslukY))
                        koridorLbl.Location = New Point(x, y)

                        picture.Controls.Add(koridorLbl)
                    Else


                        If koltukNumarasi <> 23 AndAlso koltukNumarasi <> 24 Then
                            Dim btnKoltuk As New Button()
                            btnKoltuk.Width = butonGen
                            btnKoltuk.Height = butonYuk
                            Dim buttonName As String = "btnKoltuk_" & koltukNumarasi & "_" & sutun ' Buton adına sütun numarasını ekleyelim
                            btnKoltuk.Name = buttonName
                            If koltukNumarasi < 23 Then
                                btnKoltuk.Text = koltukNumarasi
                            ElseIf koltukNumarasi > 24 Then
                                btnKoltuk.Text = koltukNumarasi - 2
                            End If
                            btnKoltuk.FlatStyle = FlatStyle.Flat
                            btnKoltuk.BackColor = Color.LightGreen
                            btnKoltuk.ForeColor = Color.Black
                            btnKoltuk.TextAlign = ContentAlignment.MiddleCenter
                            Dim cinsiyet As String = KoltukCinsiyetiniGetir(plaka, btnKoltuk.Text, seferId)
                            If cinsiyet = "Erkek" Then
                                btnKoltuk.Enabled = False
                                btnKoltuk.BackColor = Color.LightBlue
                            ElseIf cinsiyet = "Kadın" Then
                                btnKoltuk.Enabled = False
                                btnKoltuk.BackColor = Color.Pink
                            Else

                                btnKoltuk.BackColor = Color.LightGreen ' Satılmamış koltuklar için varsayılan renk
                                AddHandler btnKoltuk.Click, Sub(sender, e)
                                                                ' Buton adını analiz ederek kaçıncı sütunda olduğunu belirle
                                                                Dim buttonNameParts() As String = btnKoltuk.Name.Split("_")
                                                                Dim columnNumber As Integer = Convert.ToInt32(buttonNameParts(2))
                                                                _sutunSayi.Text = columnNumber
                                                                lbl.Text = btnKoltuk.Text
                                                            End Sub

                            End If

                            Dim x As Integer = baslangicX + (sutun * (butonGen + butonboslukX))
                            Dim y As Integer = baslangicY + (satir * (butonYuk + butonboslukY))
                            btnKoltuk.Location = New Point(x, y)
                            AddHandler btnKoltuk.Click, Sub(sender, e) lbl.Text = btnKoltuk.Text
                            picture.Controls.Add(btnKoltuk)
                        End If

                        koltukNumarasi += 1
                    End If
                Next
            Next
        End Using
    End Sub
    Private Shared Function KoltukCinsiyetiniGetir(plaka As String, koltukNumarasi As Integer, seferId As Integer) As String
        Dim baglan As String = "Data Source=cemeren\SQLEXPRESS;Initial Catalog=Otobus_Bilet;Integrated Security=True"
        Using baglanti As New SqlConnection(baglan)
            baglanti.Open()

            Dim query As String = "SELECT cinsiyet FROM bilet_satis WHERE plaka=@plaka AND koltuk_no=@koltukNumarasi AND sefer_id=@sefer_id"
            Dim cmd As New SqlCommand(query, baglanti)
            cmd.Parameters.AddWithValue("@plaka", plaka)
            cmd.Parameters.AddWithValue("@koltukNumarasi", koltukNumarasi)
            cmd.Parameters.AddWithValue("@sefer_id", seferId)

            Dim cinsiyet As String = Convert.ToString(cmd.ExecuteScalar())

            Return cinsiyet
        End Using
    End Function

End Class
