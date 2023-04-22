<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pb_Achievement1 = New System.Windows.Forms.PictureBox()
        CType(Me.pb_Achievement1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(509, 532)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 72)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Go back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pb_Achievement1
        '
        Me.pb_Achievement1.Location = New System.Drawing.Point(322, 175)
        Me.pb_Achievement1.Name = "pb_Achievement1"
        Me.pb_Achievement1.Size = New System.Drawing.Size(511, 328)
        Me.pb_Achievement1.TabIndex = 1
        Me.pb_Achievement1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1146, 652)
        Me.Controls.Add(Me.pb_Achievement1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.pb_Achievement1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents pb_Achievement1 As PictureBox
End Class
