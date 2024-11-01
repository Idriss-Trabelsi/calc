Imports System.Net.Security
Imports System.Runtime.CompilerServices

Public Class form1
    Dim d As Double
    Dim r As Double
    Dim c As String


    Private Sub Btnegale_Click(sender As Object, e As EventArgs) Handles Btnegale.Click
        r = Val(txt_A.Text)
        txt_A.Clear()
        If c = "+" Then Lblres.Text = d + r
        If c = "*" Then Lblres.Text = d * r
        If c = "-" Then Lblres.Text = d - r
        If c = "/" Then Lblres.Text = d / r




    End Sub

    Private Sub Btnplus_Click(sender As Object, e As EventArgs) Handles Btnplus.Click
        d = Val(txt_A.Text)
        txt_A.Clear()
        c = "+"

    End Sub

    Private Sub Btnmoin_Click(sender As Object, e As EventArgs) Handles Btnmoin.Click
        d = Val(txt_A.Text)
        txt_A.Clear()
        c = "-"
    End Sub

    Private Sub Btnfois_Click(sender As Object, e As EventArgs) Handles Btnfois.Click
        d = Val(txt_A.Text)
        txt_A.Clear()
        c = "*"
    End Sub

    Private Sub Btnsur_Click(sender As Object, e As EventArgs) Handles Btnsur.Click
        d = Val(txt_A.Text)
        txt_A.Clear()
        c = "/"
    End Sub

    Private Sub num1_Click(sender As Object, e As EventArgs) Handles num1.Click
        txt_A.Text = txt_A.Text + "1"

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        txt_A.Text = txt_A.Text + "2"

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txt_A.Text = txt_A.Text + "3"

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        txt_A.Text = txt_A.Text + "4"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txt_A.Text = txt_A.Text + "5"

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        txt_A.Text = txt_A.Text + "6"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txt_A.Text = txt_A.Text + "7"

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txt_A.Text = txt_A.Text + "8"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt_A.Text = txt_A.Text + "9"

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txt_A.Text = txt_A.Text + "0"


    End Sub

    Private Sub Btnclose_Click(sender As Object, e As EventArgs) Handles Btnclose.Click
        Me.Close()

    End Sub

    Private Sub BtnAC_Click(sender As Object, e As EventArgs) Handles BtnAC.Click
        'AC=Effacer

        txt_A.Clear()
    End Sub
End Class
