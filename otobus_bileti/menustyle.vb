Imports System.Drawing
Imports System.Windows.Forms

Public Class menustyle
    Inherits ToolStripProfessionalRenderer

    Protected Overrides Sub OnRenderMenuItemBackground(e As ToolStripItemRenderEventArgs)
        Dim item As ToolStripItem = e.Item

        If item.Selected Then

            Dim rect As New Rectangle(0, 0, item.Width - 1, item.Height - 1)
            Using brush As New System.Drawing.Drawing2D.LinearGradientBrush(rect, ColorTranslator.FromHtml("#D0B8A8"), ColorTranslator.FromHtml("#D0B8A8"), System.Drawing.Drawing2D.LinearGradientMode.Vertical)
                e.Graphics.FillRectangle(brush, rect)
            End Using
        Else
            MyBase.OnRenderMenuItemBackground(e)
        End If
    End Sub

End Class
