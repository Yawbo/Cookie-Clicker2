Imports System.Numerics

Public Class Form1
    Public totalCookies, ClickValue, ClickLevel As Integer
    Public PassiveOneValue, PassiveOneLevel As Integer
    Public Counted As Integer
    Public totalClicks As Integer
    Public AchievementStatus As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totalCookies = 0
        ClickValue = 1
        ClickLevel = 1
        PassiveOneValue = 0
        PassiveOneLevel = 1
        Counted = 0
        AchievementStatus = False

        set_Timer(100)

        AnimationTimer.Start()
        PassiveCookieTimer.Start()

    End Sub

    Private Sub PassiveCookieTimer_Tick(sender As Object, e As EventArgs) Handles PassiveCookieTimer.Tick
        totalCookies = totalCookies + PassiveOneValue
        Cookie_Value.Text = "Value: " + totalCookies.ToString
        CountedLabel.Text = "Counted: " + Counted.ToString
        SineLabel.Text = "Sine: " + (Math.Sin(Counted * 300) * 20).ToString
    End Sub

    Private Sub btn_click_upgrade_Click(sender As Object, e As EventArgs) Handles btn_click_upgrade.Click
        Dim upgradeCost As Integer
        upgradeCost = ClickLevel * 2

        If totalCookies >= upgradeCost Then
            totalCookies = totalCookies - upgradeCost

            ClickLevel = ClickLevel + 1
            ClickValue = (ClickLevel - 1) * 2

            upgradeCost = ClickLevel * 2
            lbl_Click_Level_Value.Text = "LvL: " + ClickLevel.ToString
            lbl_Click_Upgrade_Cost.Text = "Price: " + upgradeCost.ToString
            btn_cookie_click.Text = "Click to increase cookies by: " + ClickValue.ToString
        End If
    End Sub

    Private Sub btn_passive_one_upgrade_Click(sender As Object, e As EventArgs) Handles btn_passive_one_upgrade.Click
        Dim upgradeCost2 As Integer
        upgradeCost2 = PassiveOneLevel * PassiveOneLevel * 10

        If totalCookies >= upgradeCost2 Then
            totalCookies = totalCookies - upgradeCost2

            PassiveOneLevel = PassiveOneLevel + 1
            PassiveOneValue = PassiveOneValue + 1
            upgradeCost2 = PassiveOneLevel '* PassiveOneLevel * 10

            upgradeCost2 = PassiveOneLevel * 2.5
            lbl_Passive_One_Value.Text = "LvL: " + PassiveOneLevel.ToString
            lbl_Passive_One_Cost.Text = "Price: " + upgradeCost2.ToString
        End If
    End Sub

    Private Sub Round_Button1_Click(sender As Object, e As EventArgs) Handles Round_Button1.Click
        totalClicks = totalClicks + 1
        If totalClicks >= 10 Then
            AchievementStatus = True
        End If
        cookie_click()
    End Sub

    Private Sub AnimationTimer_Tick(sender As Object, e As EventArgs) Handles AnimationTimer.Tick
        Counted = Counted + 1
        Round_Button1.Location = New Point(Round_Button1.Location.X, Round_Button1.Location.Y + (Math.Sin(Counted * 300) * 20))
    End Sub

    Private Sub btn_SwapToForm2_Click(sender As Object, e As EventArgs) Handles btn_SwapToForm2.Click
        Dim form2 As New Form2()
        form2.Show()
        Me.Visible = False
    End Sub

    Private Sub cookie_click()
        totalCookies = totalCookies + ClickValue
        Cookie_Value.Text = "Value " + totalCookies.ToString
    End Sub

    Private Sub btn_cookie_click_Click(sender As Object, e As EventArgs) Handles btn_cookie_click.Click
        cookie_click()
    End Sub

    Private Sub set_Timer(interval As Integer)
        PassiveCookieTimer.Interval = interval
        AnimationTimer.Interval = interval
    End Sub
End Class
