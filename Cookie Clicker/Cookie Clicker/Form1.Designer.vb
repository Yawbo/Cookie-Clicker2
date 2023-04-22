<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Cookie_Value = New System.Windows.Forms.Label()
        Me.btn_cookie_click = New System.Windows.Forms.Button()
        Me.lbl_Click_Upgrade_Cost = New System.Windows.Forms.Label()
        Me.btn_click_upgrade = New System.Windows.Forms.Button()
        Me.lbl_Click_Level_Value = New System.Windows.Forms.Label()
        Me.lbl_Passive_One_Cost = New System.Windows.Forms.Label()
        Me.btn_passive_one_upgrade = New System.Windows.Forms.Button()
        Me.lbl_Passive_One_Value = New System.Windows.Forms.Label()
        Me.PassiveCookieTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Round_Button1 = New Cookie_Clicker.Round_Button()
        Me.AnimationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.CountedLabel = New System.Windows.Forms.Label()
        Me.SineLabel = New System.Windows.Forms.Label()
        Me.btn_SwapToForm2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Cookie_Value
        '
        Me.Cookie_Value.Location = New System.Drawing.Point(431, 44)
        Me.Cookie_Value.Name = "Cookie_Value"
        Me.Cookie_Value.Size = New System.Drawing.Size(229, 35)
        Me.Cookie_Value.TabIndex = 0
        Me.Cookie_Value.Text = "Value 0"
        Me.Cookie_Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_cookie_click
        '
        Me.btn_cookie_click.Location = New System.Drawing.Point(770, 396)
        Me.btn_cookie_click.Name = "btn_cookie_click"
        Me.btn_cookie_click.Size = New System.Drawing.Size(339, 128)
        Me.btn_cookie_click.TabIndex = 1
        Me.btn_cookie_click.Text = "Click to increase cookies by 1"
        Me.btn_cookie_click.UseVisualStyleBackColor = True
        Me.btn_cookie_click.Visible = False
        '
        'lbl_Click_Upgrade_Cost
        '
        Me.lbl_Click_Upgrade_Cost.AutoSize = True
        Me.lbl_Click_Upgrade_Cost.Location = New System.Drawing.Point(996, 64)
        Me.lbl_Click_Upgrade_Cost.Name = "lbl_Click_Upgrade_Cost"
        Me.lbl_Click_Upgrade_Cost.Size = New System.Drawing.Size(45, 15)
        Me.lbl_Click_Upgrade_Cost.TabIndex = 2
        Me.lbl_Click_Upgrade_Cost.Text = "Price: 1"
        '
        'btn_click_upgrade
        '
        Me.btn_click_upgrade.Location = New System.Drawing.Point(974, 82)
        Me.btn_click_upgrade.Name = "btn_click_upgrade"
        Me.btn_click_upgrade.Size = New System.Drawing.Size(89, 76)
        Me.btn_click_upgrade.TabIndex = 3
        Me.btn_click_upgrade.Text = "Increase Value Of Click"
        Me.btn_click_upgrade.UseVisualStyleBackColor = True
        '
        'lbl_Click_Level_Value
        '
        Me.lbl_Click_Level_Value.AutoSize = True
        Me.lbl_Click_Level_Value.Location = New System.Drawing.Point(996, 161)
        Me.lbl_Click_Level_Value.Name = "lbl_Click_Level_Value"
        Me.lbl_Click_Level_Value.Size = New System.Drawing.Size(36, 15)
        Me.lbl_Click_Level_Value.TabIndex = 4
        Me.lbl_Click_Level_Value.Text = "LvL: 0"
        '
        'lbl_Passive_One_Cost
        '
        Me.lbl_Passive_One_Cost.AutoSize = True
        Me.lbl_Passive_One_Cost.Location = New System.Drawing.Point(996, 210)
        Me.lbl_Passive_One_Cost.Name = "lbl_Passive_One_Cost"
        Me.lbl_Passive_One_Cost.Size = New System.Drawing.Size(51, 15)
        Me.lbl_Passive_One_Cost.TabIndex = 5
        Me.lbl_Passive_One_Cost.Text = "Price: 10"
        '
        'btn_passive_one_upgrade
        '
        Me.btn_passive_one_upgrade.Location = New System.Drawing.Point(974, 238)
        Me.btn_passive_one_upgrade.Name = "btn_passive_one_upgrade"
        Me.btn_passive_one_upgrade.Size = New System.Drawing.Size(94, 73)
        Me.btn_passive_one_upgrade.TabIndex = 6
        Me.btn_passive_one_upgrade.Text = "Passive One Upgrade"
        Me.btn_passive_one_upgrade.UseVisualStyleBackColor = True
        '
        'lbl_Passive_One_Value
        '
        Me.lbl_Passive_One_Value.AutoSize = True
        Me.lbl_Passive_One_Value.Location = New System.Drawing.Point(996, 314)
        Me.lbl_Passive_One_Value.Name = "lbl_Passive_One_Value"
        Me.lbl_Passive_One_Value.Size = New System.Drawing.Size(36, 15)
        Me.lbl_Passive_One_Value.TabIndex = 7
        Me.lbl_Passive_One_Value.Text = "LvL: 0"
        '
        'PassiveCookieTimer
        '
        '
        'Round_Button1
        '
        Me.Round_Button1.Image = CType(resources.GetObject("Round_Button1.Image"), System.Drawing.Image)
        Me.Round_Button1.Location = New System.Drawing.Point(29, 27)
        Me.Round_Button1.Name = "Round_Button1"
        Me.Round_Button1.Size = New System.Drawing.Size(362, 338)
        Me.Round_Button1.TabIndex = 8
        Me.Round_Button1.Text = "Round_Button1"
        Me.Round_Button1.UseVisualStyleBackColor = True
        '
        'AnimationTimer
        '
        '
        'CountedLabel
        '
        Me.CountedLabel.AutoSize = True
        Me.CountedLabel.Location = New System.Drawing.Point(183, 396)
        Me.CountedLabel.Name = "CountedLabel"
        Me.CountedLabel.Size = New System.Drawing.Size(13, 15)
        Me.CountedLabel.TabIndex = 9
        Me.CountedLabel.Text = "0"
        Me.CountedLabel.Visible = False
        '
        'SineLabel
        '
        Me.SineLabel.AutoSize = True
        Me.SineLabel.Location = New System.Drawing.Point(182, 424)
        Me.SineLabel.Name = "SineLabel"
        Me.SineLabel.Size = New System.Drawing.Size(41, 15)
        Me.SineLabel.TabIndex = 10
        Me.SineLabel.Text = "Label1"
        Me.SineLabel.Visible = False
        '
        'btn_SwapToForm2
        '
        Me.btn_SwapToForm2.Location = New System.Drawing.Point(543, 455)
        Me.btn_SwapToForm2.Name = "btn_SwapToForm2"
        Me.btn_SwapToForm2.Size = New System.Drawing.Size(117, 58)
        Me.btn_SwapToForm2.TabIndex = 11
        Me.btn_SwapToForm2.Text = "Swap to Form 2"
        Me.btn_SwapToForm2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1152, 647)
        Me.Controls.Add(Me.btn_SwapToForm2)
        Me.Controls.Add(Me.SineLabel)
        Me.Controls.Add(Me.CountedLabel)
        Me.Controls.Add(Me.Round_Button1)
        Me.Controls.Add(Me.lbl_Passive_One_Value)
        Me.Controls.Add(Me.btn_passive_one_upgrade)
        Me.Controls.Add(Me.lbl_Passive_One_Cost)
        Me.Controls.Add(Me.lbl_Click_Level_Value)
        Me.Controls.Add(Me.btn_click_upgrade)
        Me.Controls.Add(Me.lbl_Click_Upgrade_Cost)
        Me.Controls.Add(Me.btn_cookie_click)
        Me.Controls.Add(Me.Cookie_Value)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cookie_Value As Label
    Friend WithEvents btn_cookie_click As Button
    Friend WithEvents lbl_Click_Upgrade_Cost As Label
    Friend WithEvents lbl_Click_Level_Value As Label
    Friend WithEvents btn_click_upgrade As Button
    Friend WithEvents lbl_Passive_One_Cost As Label
    Friend WithEvents btn_passive_one_upgrade As Button
    Friend WithEvents lbl_Passive_One_Value As Label
    Friend WithEvents PassiveCookieTimer As Timer
    Friend WithEvents Round_Button1 As Round_Button
    Friend WithEvents AnimationTimer As Timer
    Friend WithEvents CountedLabel As Label
    Friend WithEvents SineLabel As Label
    Friend WithEvents btn_SwapToForm2 As Button
End Class
