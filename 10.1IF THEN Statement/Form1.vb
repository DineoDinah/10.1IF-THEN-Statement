Public Class Form1
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim myNumber As Integer

		myNumber = TextBox1.Text
		If myNumber > 100 Then
			Label2.Text = MsgBox((" You win a lucky prize"))
		End If
	End Sub
End Class
