Imports System.Data.SqlClient

Public Class girisekran
    Dim connectionString As String = "Data Source=cemeren\SQLEXPRESS;Initial Catalog=Otobus_Bilet;Integrated Security=True"

    Private Sub btnGiris_Click(sender As Object, e As EventArgs) Handles btnGiris.Click
        Dim kullaniciAdi As String = txtKullaniciAdi.Text
        Dim sifre As String = txtSifre.Text

        ' Kullanıcı adı ve şifreyi kullanarak giriş yapılıyor
        Dim personelID As Integer = GirisYap(kullaniciAdi, sifre)
        If personelID <> -1 Then
            MessageBox.Show("Giriş Başarılı", "Bilgi", MessageBoxButtons.OK)
            Dim anaForm As New anasayfa(personelID)
            anaForm.Show()
            Me.Hide() ' Giriş ekranını gizle
        Else
            MessageBox.Show("Giriş Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function GirisYap(kullaniciAdi As String, sifre As String) As Integer
        Dim personelID As Integer = -1 ' -1, giriş başarısız olduğunda döndürülecek değer
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT PersonelID FROM Personel WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi)
                command.Parameters.AddWithValue("@Sifre", sifre)
                connection.Open()
                Dim result As Object = command.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    ' Eğer bir sonuç döndüyse, giriş başarılı
                    personelID = Convert.ToInt32(result)
                End If
            End Using
        End Using
        Return personelID
    End Function

End Class