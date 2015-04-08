Public Class frmCharFunctions

    Private Sub btnXor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXor.Click
        txtOut.Text = ""
        Dim a As String = txtIn.Text
        For i As Integer = 0 To a.Length - 1
            txtOut.Text &= ChrW(AscW(a.Substring(i, 1)) Xor CInt(txtNo.Text))
        Next
    End Sub

    Private Sub btnSubtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubtract.Click
        txtOut.Text = ""
        Dim a As String = txtIn.Text
        For i As Integer = 0 To a.Length - 1
            txtOut.Text &= ChrW(AscW(a.Substring(i, 1)) - CInt(txtNo.Text))
        Next
    End Sub
End Class
