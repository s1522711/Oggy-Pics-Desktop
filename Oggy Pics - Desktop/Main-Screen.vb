Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Main_Screen
    Private Sub Main_Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoSizeMode = AutoSizeMode.GrowAndShrink

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadingLabel.Show()
        PictureBox1.Hide()
        PictureBox1.LoadAsync("https://piggo.cc/cat/img.png")
    End Sub

    Private Sub PictureBox1_LoadCompleted(sender As Object, e As EventArgs)
        LoadingLabel.Hide()
        PictureBox1.Show()
    End Sub

    Private Sub PassButton_Click(sender As Object, e As EventArgs) Handles PassButton.Click
        If PassTextBox.Text.ToLower = "1234" Then
            MessageBox.Show("You are an idiot!")
            PassTextBox.Hide()
            PassButton.Hide()
        Else
            MessageBox.Show("Incorrect Password")
        End If
    End Sub

    Private Sub PassTextBox_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PassTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If PassTextBox.Text.ToLower = "1234" Then
                MessageBox.Show("You are an idiot!")
                PassTextBox.Hide()
                PassButton.Hide()
            Else
                MessageBox.Show("Incorrect Password")
            End If
        End If
    End Sub
End Class