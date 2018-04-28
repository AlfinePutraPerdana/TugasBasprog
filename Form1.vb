Public Class Form1

    
    
    Private Sub ButtonHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHitung.Click
        Dim a, b, c, rataan As Decimal

        a = TextBoxNilai1.Text
        b = TextBoxNilai2.Text
        c = TextBoxNilai3.Text
        rataan = (a + b + c) / 3
        LabelRataan.Text = FormatNumber(rataan, 2)
        If rataan > 80 Then
            LabelHadiah.Text = "Rp.10.000.000 + Sertifikat"
        ElseIf rataan > 70 Then
            LabelHadiah.Text = "Rp.7.500.000 + Sertifikat"
        Else
            LabelHadiah.Text = "Sertifikat"
        End If

    End Sub

    Private Sub ButtonUlang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUlang.Click
        TextBoxNama.Clear()
        TextBoxNilai1.Clear()
        TextBoxNilai2.Clear()
        TextBoxNilai3.Clear()
        LabelHadiah.Text = ".............................."
        LabelRataan.Text = ".............................."
    End Sub
End Class
