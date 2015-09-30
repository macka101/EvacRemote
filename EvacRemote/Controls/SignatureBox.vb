Imports System.Drawing.Drawing2D

Public Class SignatureBox
    Private lastPT As Point
    Private signature As New GraphicsPath

    Private _sig As Drawing.Bitmap

    Public Property Image() As Drawing.Bitmap
        Get
            Dim bmp As New Drawing.Bitmap(PictureBox.Width, PictureBox.Height)
            PictureBox.DrawToBitmap(bmp, PictureBox.ClientRectangle)
            Return bmp
        End Get
        Set(ByVal value As Drawing.Bitmap)
            _sig = value
        End Set
    End Property


    Private Sub PictureBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If Not IsNothing(signature) Then
            If e.Button = Windows.Forms.MouseButtons.Left Then
                lastPT = New Point(e.X, e.Y)
            End If
        End If
    End Sub

    Private Sub PictureBox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If Not IsNothing(signature) Then
            If e.Button = Windows.Forms.MouseButtons.Left Then
                Dim curPt As New Point(e.X, e.Y)
                signature.AddLine(lastPT, curPt)
                lastPT = curPt
                PictureBox.Refresh()
            End If
        End If
    End Sub

    Private Sub PictureBox_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If Not IsNothing(signature) Then
            If e.Button = Windows.Forms.MouseButtons.Left Then
                signature.StartFigure()
            End If
        End If
    End Sub

    Private Sub PictureBox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        If Not IsNothing(signature) Then
            Using p As New Pen(Color.Black)
                p.Width = 2
                e.Graphics.DrawPath(p, signature)
            End Using

        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        signature.Reset()
        PictureBox.Refresh()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim bmp As New Drawing.Bitmap(PictureBox.Width, PictureBox.Height)
        PictureBox.DrawToBitmap(bmp, PictureBox.ClientRectangle)
        bmp.Save(System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "test.bmp"), System.Drawing.Imaging.ImageFormat.Bmp)
    End Sub

End Class
