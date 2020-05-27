Public Class FrmJuegoCaos
    Private AristaX(2), AristaY(2) As Single
    Private UltimaX, UltimaY As Single
    Private Sub FrmJuegoCaos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Dim i As Integer
        Dim Gr As Graphics = Me.CreateGraphics()
        Me.Show()
        PatronInicio()
        Do
            i = CInt(Int(Rnd() * 3))
            UltimaX = (UltimaX + AristaX(i)) / 2
            UltimaY = (UltimaY + AristaY(i)) / 2
            Gr.DrawLine(Pens.Red, UltimaX, UltimaY, UltimaX + 1, UltimaY + 1)
            Application.DoEvents()
        Loop
    End Sub

    Private Sub PatronInicio()
        Const R As Integer = 5
        Dim i As Integer
        Dim Gr As Graphics = Me.CreateGraphics()
        Gr.Clear(Me.BackColor)

        AristaX(0) = R + 10
        AristaY(0) = Me.ClientRectangle.Bottom - R - 2

        AristaX(1) = Me.ClientRectangle.Width \ 2
        AristaY(1) = R + 2

        AristaX(2) = Me.ClientRectangle.Right - R - 2
        AristaY(2) = Me.ClientRectangle.Bottom - R - 2

        For i = 0 To 2
            Gr.DrawEllipse(Pens.Red, AristaX(i) - R \ 2, AristaY(i) - R \ 2, R, R)
        Next

    End Sub
End Class
