Imports System.Data.SqlClient

Public Class bilet_iptal
    Dim baglanti As String = "Data Source=cemeren\SQLEXPRESS;Initial Catalog=Otobus_Bilet;Integrated Security=True"
    Dim daset As New DataSet()
    Private Sub bilet_iptal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iptallistele()
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
    Private Sub iptallistele()
        Try
            Dim con As New SqlConnection(baglanti)
            con.Open()
            Dim adtr As New SqlDataAdapter("select * from bilet_iptal", con)
            adtr.Fill(daset, "bilet_iptal")
            DataGridView1.DataSource = daset.Tables("bilet_iptal")
            DataGridView1.Columns("iptal_id").Visible = False
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
        Dim adtr As New SqlDataAdapter("select * from bilet_iptal where tc like '%" & txtTc.Text & "%'", con)
        adtr.Fill(table)
        DataGridView1.DataSource = table
        con.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim table As New DataTable()
        Dim con As New SqlConnection(baglanti)
        con.Open()
        Dim adtr As New SqlDataAdapter("select * from bilet_iptal where ad like '%" & TextBox1.Text & "%'", con)
        adtr.Fill(table)
        DataGridView1.DataSource = table
        con.Close()
    End Sub

    Private Sub txtSoyad_TextChanged(sender As Object, e As EventArgs) Handles txtSoyad.TextChanged
        Dim table As New DataTable()
        Dim con As New SqlConnection(baglanti)
        con.Open()
        Dim adtr As New SqlDataAdapter("select * from bilet_iptal where soyad like '%" & txtSoyad.Text & "%'", con)
        adtr.Fill(table)
        DataGridView1.DataSource = table
        con.Close()
    End Sub

    Private Sub txtTelefon_TextChanged(sender As Object, e As EventArgs) Handles txtTelefon.TextChanged
        Dim table As New DataTable()
        Dim con As New SqlConnection(baglanti)
        con.Open()
        Dim adtr As New SqlDataAdapter("select * from bilet_iptal where telefon like '%" & txtTelefon.Text & "%'", con)
        adtr.Fill(table)
        DataGridView1.DataSource = table
        con.Close()
    End Sub


    Private Sub cbKalkisF_TextChanged(sender As Object, e As EventArgs) Handles cbKalkisF.TextChanged
        Dim table As New DataTable()
        Dim con As New SqlConnection(baglanti)
        con.Open()
        Dim adtr As New SqlDataAdapter("select * from bilet_iptal where kalkis_yeri like '%" & cbKalkisF.Text & "%'", con)
        adtr.Fill(table)
        DataGridView1.DataSource = table
        con.Close()
    End Sub

    Private Sub cbVarisF_TextChanged(sender As Object, e As EventArgs) Handles cbVarisF.TextChanged
        Dim table As New DataTable()
        Dim con As New SqlConnection(baglanti)
        con.Open()
        Dim adtr As New SqlDataAdapter("select * from bilet_iptal where varis_yeri like '%" & cbVarisF.Text & "%'", con)
        adtr.Fill(table)
        DataGridView1.DataSource = table
        con.Close()
    End Sub

    Private Sub dtKalkisF_ValueChanged(sender As Object, e As EventArgs) Handles dtKalkisF.ValueChanged
        Dim table As New DataTable()
        Dim con As New SqlConnection(baglanti)
        con.Open()
        Dim adtr As New SqlDataAdapter("select * from bilet_iptal where sefer_tarih like '%" & dtKalkisF.Value & "%'", con)
        adtr.Fill(table)
        DataGridView1.DataSource = table
        con.Close()
    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        Dim table As New DataTable()
        Dim con As New SqlConnection(baglanti)
        con.Open()
        Dim adtr As New SqlDataAdapter("select * from bilet_iptal where iptal_sebebi like '%" & ComboBox1.Text & "%'", con)
        adtr.Fill(table)
        DataGridView1.DataSource = table
        con.Close()
    End Sub

    Private Sub cbPlaka_TextChanged(sender As Object, e As EventArgs) Handles cbPlaka.TextChanged
        Dim table As New DataTable()
        Dim con As New SqlConnection(baglanti)
        con.Open()
        Dim adtr As New SqlDataAdapter("select * from bilet_iptal where plaka like '%" & cbPlaka.Text & "%'", con)
        adtr.Fill(table)
        DataGridView1.DataSource = table
        con.Close()
    End Sub
#End Region
End Class