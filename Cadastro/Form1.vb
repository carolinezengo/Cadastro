Public Class Form1
    Dim cod As Integer
    Dim nome As String
    Dim tel As Double
    Dim email As String

    Private Sub btnovo_Click(sender As Object, e As EventArgs) Handles btnovo.Click
        txtcod.Text = ""
        txtnome.Text = ""
        txttel.Text = ""
        txtemail.Text = ""
        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""



    End Sub

    Private Sub btnsalvar_Click(sender As Object, e As EventArgs) Handles btnsalvar.Click
        cod = txtcod.Text
        nome = txtnome.Text
        tel = txttel.Text
        email = txtemail.Text
        Label2.Text = cod
        Label3.Text = nome
        Label5.Text = tel
        Label4.Text = email


    End Sub

    Private Sub btnsair_Click(sender As Object, e As EventArgs) Handles btnsair.Click

        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
