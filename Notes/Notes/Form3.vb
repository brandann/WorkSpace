Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim name As String = MaskedTextBox1.Text.ToLower
        If name = "foundhitler" Then
            Form4.Show()
            Me.Close()

        End If
    End Sub

    Private Sub MaskedTextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MaskedTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub
End Class