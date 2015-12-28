Public Class HelloWorld

    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click
        MessageBox.Show("Hello World!", "Greet", MessageBoxButtons.OK)
    End Sub

    Private Sub HelloWorld_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result = MessageBox.Show("Are you sure you want to exit?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class
