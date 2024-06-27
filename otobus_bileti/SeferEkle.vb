Imports System.Data.SqlClient

Public Class SeferEkle
    Dim baglan As String = "Data Source=cemeren\SQLEXPRESS;Initial Catalog=Otobus_Bilet;Integrated Security=True"

    Private Sub SeferEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        plakagetir()
        tarihkontrol.tarihkontrolet(Me)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = -1 OrElse cbVaris.SelectedIndex = -1 OrElse cbKalkis.SelectedIndex = -1 OrElse saatKalkis.SelectedIndex = -1 OrElse saatVaris.SelectedIndex = -1 OrElse UcretTxt.Text = Nothing Then
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
            Dim komut As New SqlCommand("INSERT INTO seferler (nereden,nereye,kalkis_saati,kalkis_tarih,varis_saati,varis_tarih,ucret,durak1_yer,durak1_varis_saati,durak1_tarih,durak1_ucret,durak2_yer,durak2_varis_saati,durak2_tarih,durak2_ucret,durak3_yer,durak3_varis_saati,durak3_tarih,durak3_ucret,durak4_yer,durak4_varis_saati,durak4_tarih,durak4_ucret,plaka) VALUES (@nereden,@nereye,@kalkis_saati,@kalkis_tarih,@varis_saati,@varis_tarih,@ucret,@durak1_yer,@durak1_varis_saati,@durak1_tarih,@durak1_ucret,@durak2_yer,@durak2_varis_saati,@durak2_tarih,@durak2_ucret,@durak3_yer,@durak3_varis_saati,@durak3_tarih,@durak3_ucret,@durak4_yer,@durak4_varis_saati,@durak4_tarih,@durak4_ucret,@plaka)", baglanti)
            komut.Parameters.AddWithValue("@nereden", cbKalkis.Text)
            komut.Parameters.AddWithValue("@nereye", cbVaris.Text)
            komut.Parameters.AddWithValue("@kalkis_saati", saatKalkis.Text)
            komut.Parameters.AddWithValue("@kalkis_tarih", dtKalkis.Value.ToString("dd-MM-yyyy"))
            komut.Parameters.AddWithValue("@varis_saati", saatVaris.Text)
            komut.Parameters.AddWithValue("@varis_tarih", dtVaris.Value.ToString("dd-MM-yyyy"))
            komut.Parameters.AddWithValue("@ucret", UcretTxt.Text)
            komut.Parameters.AddWithValue("@plaka", ComboBox1.Text)
            If cbDurak1.SelectedIndex = -1 AndAlso saatDurak1.SelectedIndex = -1 AndAlso cbDurak2.SelectedIndex = -1 AndAlso saatDurak2.SelectedIndex = -1 AndAlso cbDurak3.SelectedIndex = -1 AndAlso saatDurak3.SelectedIndex = -1 AndAlso cbDurak4.SelectedIndex = -1 AndAlso saatDurak4.SelectedIndex = -1 AndAlso Durak1Ucret.Text = Nothing AndAlso Durak2Ucret.Text = Nothing AndAlso Durak3Ucret.Text = Nothing AndAlso Durak4Ucret.Text = Nothing Then

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
                MessageBox.Show("Sefer eklendi.", "Bilgi")
                Temizle()


            Catch ex As SqlException
                MessageBox.Show(ex.Message)
            End Try

        End Using

    End Sub
    Private Sub Temizle()
        For Each ctrl As Control In Panel1.Controls
            If TypeOf ctrl Is ComboBox Then
                Dim comboBox As ComboBox = DirectCast(ctrl, ComboBox)
                comboBox.SelectedIndex = -1
            ElseIf TypeOf ctrl Is DateTimePicker Then
                Dim dateTimePicker As DateTimePicker = DirectCast(ctrl, DateTimePicker)
                dateTimePicker.Value = DateTime.Today
            ElseIf TypeOf ctrl Is MaskedTextBox Then
                Dim maskedTextBox As MaskedTextBox = DirectCast(ctrl, MaskedTextBox)
                maskedTextBox.Text = ""
            End If
        Next


        For Each ctrl As Control In Panel2.Controls
            If TypeOf ctrl Is ComboBox Then
                Dim comboBox As ComboBox = DirectCast(ctrl, ComboBox)
                comboBox.SelectedIndex = -1
            ElseIf TypeOf ctrl Is DateTimePicker Then
                Dim dateTimePicker As DateTimePicker = DirectCast(ctrl, DateTimePicker)
                dateTimePicker.Value = DateTime.Today
            ElseIf TypeOf ctrl Is MaskedTextBox Then
                Dim maskedTextBox As MaskedTextBox = DirectCast(ctrl, MaskedTextBox)
                maskedTextBox.Text = ""
            End If
        Next


        For Each ctrl As Control In Panel3.Controls
            If TypeOf ctrl Is ComboBox Then
                Dim comboBox As ComboBox = DirectCast(ctrl, ComboBox)
                comboBox.SelectedIndex = -1
            ElseIf TypeOf ctrl Is DateTimePicker Then
                Dim dateTimePicker As DateTimePicker = DirectCast(ctrl, DateTimePicker)
                dateTimePicker.Value = DateTime.Today
            ElseIf TypeOf ctrl Is MaskedTextBox Then
                Dim maskedTextBox As MaskedTextBox = DirectCast(ctrl, MaskedTextBox)
                maskedTextBox.Text = ""
            End If
        Next


        For Each ctrl As Control In Panel4.Controls
            If TypeOf ctrl Is ComboBox Then
                Dim comboBox As ComboBox = DirectCast(ctrl, ComboBox)
                comboBox.SelectedIndex = -1
            ElseIf TypeOf ctrl Is DateTimePicker Then
                Dim dateTimePicker As DateTimePicker = DirectCast(ctrl, DateTimePicker)
                dateTimePicker.Value = DateTime.Today
            ElseIf TypeOf ctrl Is MaskedTextBox Then
                Dim maskedTextBox As MaskedTextBox = DirectCast(ctrl, MaskedTextBox)
                maskedTextBox.Text = ""
            End If
        Next

        For Each ctrl As Control In Panel5.Controls
            If TypeOf ctrl Is ComboBox Then
                Dim comboBox As ComboBox = DirectCast(ctrl, ComboBox)
                comboBox.SelectedIndex = -1
            ElseIf TypeOf ctrl Is DateTimePicker Then
                Dim dateTimePicker As DateTimePicker = DirectCast(ctrl, DateTimePicker)
                dateTimePicker.Value = DateTime.Today
            ElseIf TypeOf ctrl Is MaskedTextBox Then
                Dim maskedTextBox As MaskedTextBox = DirectCast(ctrl, MaskedTextBox)
                maskedTextBox.Text = ""
            End If
        Next
    End Sub

    Private Sub SeferEkle_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim seferForm As New seferler()
        seferForm.Show()
    End Sub



End Class