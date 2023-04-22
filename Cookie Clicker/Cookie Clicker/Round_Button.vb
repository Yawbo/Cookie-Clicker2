﻿Imports System.Drawing.Drawing2D

Public Class Round_Button
    Inherits Button
    Public Sub New()
        Me.SetStyle(ControlStyles.UserPaint, True)
    End Sub
    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)
        Dim g As GraphicsPath = New GraphicsPath()
        g.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height)
        Me.Region = New Region(g)
    End Sub
End Class
