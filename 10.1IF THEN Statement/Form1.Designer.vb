<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		TextBox1 = New TextBox()
		Label1 = New Label()
		Label2 = New Label()
		Button1 = New Button()
		SuspendLayout()
		' 
		' TextBox1
		' 
		TextBox1.Location = New Point(396, 56)
		TextBox1.Name = "TextBox1"
		TextBox1.Size = New Size(150, 31)
		TextBox1.TabIndex = 0
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(214, 51)
		Label1.Name = "Label1"
		Label1.Size = New Size(149, 25)
		Label1.TabIndex = 1
		Label1.Text = "Enter my number"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(214, 117)
		Label2.Name = "Label2"
		Label2.Size = New Size(63, 25)
		Label2.TabIndex = 2
		Label2.Text = "Label2"
		' 
		' Button1
		' 
		Button1.Location = New Point(453, 209)
		Button1.Name = "Button1"
		Button1.Size = New Size(112, 34)
		Button1.TabIndex = 3
		Button1.Text = "Button1"
		Button1.UseVisualStyleBackColor = True
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(10F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(800, 450)
		Controls.Add(Button1)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Controls.Add(TextBox1)
		Name = "Form1"
		Text = "Form1"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Button1 As Button
End Class
