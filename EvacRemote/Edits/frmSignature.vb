Imports System.Drawing.Drawing2D

Public Class frmSignature
    Private lastPT As Point
    Private signature As New GraphicsPath

    Private mPrintBitmap As Bitmap
    Private _Service As EvacService

    Public Sub New(ByRef pService As EvacService)

        ' This call is required by the designer.
        InitializeComponent()
        _Service = pService
        SignatureBox1.Image = _Service.Signature
        btnConfirm.Enabled = False
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim bmp As New Drawing.Bitmap(SignatureBox1.Width, SignatureBox1.Height)
        SignatureBox1.DrawToBitmap(bmp, SignatureBox1.ClientRectangle)
        _Service.Signature = bmp
        _Service.Signer = txtSigner.Text.Trim
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub SignatureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SignatureBox1.MouseDown
        If Not IsNothing(signature) Then
            If e.Button = Windows.Forms.MouseButtons.Left Then
                lastPT = New Point(e.X, e.Y)
            End If
        End If
    End Sub

    Private Sub SignatureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SignatureBox1.MouseMove
        If Not IsNothing(signature) Then
            If e.Button = Windows.Forms.MouseButtons.Left Then
                Dim curPt As New Point(e.X, e.Y)
                signature.AddLine(lastPT, curPt)
                lastPT = curPt
                SignatureBox1.Refresh()
            End If
        End If
    End Sub

    Private Sub SignatureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SignatureBox1.MouseUp
        If Not IsNothing(signature) Then
            If e.Button = Windows.Forms.MouseButtons.Left Then
                signature.StartFigure()
            End If
        End If
    End Sub

    Private Sub SignatureBox1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SignatureBox1.Paint
        If Not IsNothing(signature) Then
            Using p As New Pen(Color.Black)
                p.Width = 2
                e.Graphics.DrawPath(p, signature)
            End Using      
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        signature.Reset()
        SignatureBox1.Refresh()
    End Sub

   
    Private Sub txtSigner_Validated(sender As Object, e As EventArgs) Handles txtSigner.Validated
        If Len(txtSigner.Text.Trim) > 0 Then
            btnConfirm.Enabled = True
        Else
            btnConfirm.Enabled = False
        End If

    End Sub

    Private Sub txtSigner_EditValueChanged(sender As Object, e As EventArgs) Handles txtSigner.EditValueChanged
     EnabledConfirm
    End Sub

    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        signature.Reset()
        SignatureBox1.Image = Nothing
        SignatureBox1.Refresh()
        EnabledConfirm()
    End Sub
    Private Sub EnabledConfirm()
        If Len(txtSigner.Text.Trim) > 0 Then
            btnConfirm.Enabled = True
        Else
            btnConfirm.Enabled = False
        End If
    End Sub
End Class