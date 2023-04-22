Imports System.Windows.Forms.VisualStyles

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.AchievementStatus Then
            pb_Achievement1.BackgroundImage = Image.FromFile("C:\Users\yawbo\Downloads\1618902619_Walter_White__dark__fantasy__matte__intense__dramatically_lit__sharp_outline__epic__beautiful__manga__painting_by_Gustave_Dore_.png")
        Else
            pb_Achievement1.BackgroundImage = Image.FromFile("C:\Users\yawbo\Downloads\stare.jpg")
        End If
    End Sub
End Class