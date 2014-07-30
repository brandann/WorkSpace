Public Class Form4

    
    Private Sub MaskedTextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Namebox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim name As String = Namebox.Text.ToLower
        If name = "brandan" Then
            form1.Show()
            form1.Button_Brandan.PerformClick()
            Me.Close()
        ElseIf name = "corey" Then
            form1.Show()
            form1.Button_Corey.PerformClick()
            Me.Close()
        End If
    End Sub
End Class