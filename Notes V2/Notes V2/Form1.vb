Imports System
Imports System.Windows


'--------------------------------------------------------------------

Public Class Form1
    Dim folder As String = "P:\Northshore Time Sheet\Tools\"
    Public Sub FandR()
        Dim find As String = txtFind.Text
        Dim replace As String = txtReplace.Text

        For Each i As String In ListBox1.Items
            If i.Contains(find) Then
                i.Replace(find, replace)
            End If
        Next
        txtFind.Text = ""
        txtReplace.Text = ""
    End Sub
    Private Sub boxUser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxUser.SelectedIndexChanged

        Dim user As String = folder & boxUser.SelectedItem & ".txt"

        ListBox2.Items.Add(My.Computer.FileSystem.ReadAllText(user))



    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each i As String In My.Computer.FileSystem.GetFiles(folder)
            Dim j() As String = i.Split(".")
            boxSystem.Items.Add(j(0).Substring(31))

        Next
        boxSystem.Items.Remove("Brandan")
        boxSystem.Items.Remove("Corey")
        boxSystem.Items.Remove("Miah")
        boxSystem.Items.Remove("Notes")
        boxSystem.Items.Remove("Notes V2")
    End Sub

    Private Sub btnEditSystem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditSystem.Click
        If boxSystem.SelectedItem <> "" Then
            Dim file As String = folder & boxSystem.SelectedItem & ".txt"
            Process.Start(file)
        Else
            MessageBox.Show("Sorry, but i cannot read your mind. Please tell me what file you would like to edit!", "??")
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FandR()

    End Sub
End Class
