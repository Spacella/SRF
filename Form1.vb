Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim YourIGN0, OffenderIGN0, Offence0, Evidence0, notes0 As String
        YourIGN0 = YourIGN.Text
        OffenderIGN0 = OffenderIGN.Text
        Offence0 = ComboBox1.Text
        Evidence0 = Evidence.Text
        notes0 = Notes.Text
        TextBox1.Text = "My IGN: " + YourIGN0 & vbNewLine & "Offender's IGN: " + OffenderIGN0 & vbNewLine & "Offence: " + Offence0 & vbNewLine & "Evidence: " + Evidence0 & vbNewLine & notes0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Clipboard.SetText(TextBox1.Text)
    End Sub

End Class
