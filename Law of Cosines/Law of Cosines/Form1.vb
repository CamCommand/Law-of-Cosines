Public Class frm1
    Dim a1 As Integer
    Dim b1 As Integer
    Dim y1 As Double
    Dim c11 As Integer
    Dim c1 As Double
    Dim a2 As Integer
    Dim b2 As Integer
    Dim c2 As Integer
    Dim y2 As Double

    Private Sub btn1_Click(sender As System.Object, e As System.EventArgs) Handles btn1.Click
        a1 = txta1.Text
        b1 = txtb1.Text
        y1 = txty1.Text
        y1 = y1 * Math.PI / 180
        c1 = Math.Round(Math.Sqrt(Math.Pow(a1, 2) + Math.Pow(b1, 2) - 2 * a1 * b1 * Math.Cos(y1)), 2)

        lblc2.Text = c1
        txta2.Enabled = True
        txtb2.Enabled = True
        txtc1.Enabled = True
        btn2.Enabled = True
    End Sub

    Private Sub btn2_Click(sender As System.Object, e As System.EventArgs) Handles btn2.Click
        a2 = txta2.Text
        b2 = txtb2.Text
        c2 = txtc1.Text

        y2 = Math.Acos((Math.Pow(a2, 2) + Math.Pow(b2, 2) - Math.Pow(c2, 2)) / (2 * a2 * b2))
        y2 = Math.Ceiling(y2 * 180 / Math.PI)
        lbly3.Text = y2
    End Sub
End Class
