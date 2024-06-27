Imports System.Data.SqlClient

Public Class otobusekle
    Dim baglan As String = "Data Source=cemeren\SQLEXPRESS;Initial Catalog=Otobus_Bilet;Integrated Security=True"
    Dim durum As Boolean
    Private Sub plakakontrol()
        durum = True
        Dim baglanti As New SqlConnection(baglan)
        baglanti.Open()
        Dim komut As New SqlCommand("select * from otobusler", baglanti)
        Dim dr As SqlDataReader = komut.ExecuteReader()
        While dr.Read()
            If TextBox1.Text = dr("plaka").ToString() OrElse TextBox1.Text = "" Then
                durum = False
            End If
        End While
        baglanti.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        plakakontrol()
        If String.IsNullOrEmpty(TextBox1.Text) OrElse ComboBox1.SelectedIndex = -1 OrElse ComboBox2.SelectedIndex = -1 Then
            MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If durum = True Then
            Using baglanti As New SqlConnection(baglan)
                Dim komut As New SqlCommand("insert into otobusler (plaka,koltuk_sayisi,koltuk_duzeni) values (@plaka,@koltuk_sayisi,@koltuk_duzeni)", baglanti)
                komut.Parameters.AddWithValue("@plaka", TextBox1.Text)
                komut.Parameters.AddWithValue("@koltuk_sayisi", ComboBox2.Text)
                komut.Parameters.AddWithValue("@koltuk_duzeni", ComboBox1.Text)
                Try
                    baglanti.Open()
                    komut.ExecuteNonQuery()
                    MessageBox.Show(" Otobüs eklendi.")
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try
                baglanti.Close()
            End Using
        Else
            MessageBox.Show("Aynı Plaka Numarası zaten var!!")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim secilen As String = ComboBox1.SelectedItem.ToString()
        ComboBox2.Items.Clear()
        Select Case secilen
            Case "2+1"
                ComboBox2.Items.Add("37")
                ComboBox2.Items.Add("40")
                ComboBox2.Items.Add("43")
                ComboBox2.Items.Add("46")
            Case "2+2"
                ComboBox2.Items.Add("42")
                ComboBox2.Items.Add("46")
                ComboBox2.Items.Add("50")
                ComboBox2.Items.Add("54")
        End Select
    End Sub

End Class