Imports System.Data.SqlClient

Public Class kullaniciekle
    Dim connectionString As String = "Data Source=cemeren\SQLEXPRESS;Initial Catalog=Otobus_Bilet;Integrated Security=True"
    Dim durum As Boolean
    Private Sub kadikontrol()
        Dim durum As Boolean = True
        Dim con As New SqlConnection(connectionString)
        con.Open()
        Dim cmd As New SqlCommand("select * from Personel", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        While dr.Read()
            If txtKullaniciAdi.Text = dr("KullaniciAdi").ToString() OrElse txtKullaniciAdi.Text = "" Then
                durum = False
            End If
        End While
        con.Close()
    End Sub
    Private Sub btnGiris_Click(sender As Object, e As EventArgs) Handles btnGiris.Click
        Dim personelAdi As String = txtKullaniciAdi.Text
        Dim sifre As String = txtSifre.Text
        kadikontrol()
        If durum = True Then
            If String.IsNullOrEmpty(personelAdi) OrElse String.IsNullOrEmpty(sifre) OrElse cmbTuru.SelectedIndex = -1 Then
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Dim personelTuru As String = cmbTuru.SelectedItem.ToString()
            If PersonelEkle(personelAdi, sifre, personelTuru) Then
                MessageBox.Show("Kullanıcı Adı başarıyla eklendi.")
                Temizle()
            Else
                MessageBox.Show("Kullanıcı Adı eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Böyle bir Kullanıcı Adı var", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Private Function PersonelEkle(personelAdi As String, sifre As String, personelTuru As String) As Boolean
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO Personel (KullaniciAdi, Sifre, PersonelTuru) VALUES (@KullaniciAdi, @Sifre, @PersonelTuru)"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@KullaniciAdi", personelAdi)
                command.Parameters.AddWithValue("@Sifre", sifre)
                command.Parameters.AddWithValue("@PersonelTuru", personelTuru)
                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

    Private Sub Temizle()

        txtKullaniciAdi.Clear()
        txtSifre.Clear()
        cmbTuru.SelectedIndex = -1
    End Sub

End Class