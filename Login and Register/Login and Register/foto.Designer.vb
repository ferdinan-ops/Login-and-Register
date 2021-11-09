<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class foto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GunaTextBox4 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.SuspendLayout()
        '
        'GunaTextBox4
        '
        Me.GunaTextBox4.BaseColor = System.Drawing.Color.White
        Me.GunaTextBox4.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox4.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaTextBox4.Location = New System.Drawing.Point(15, 15)
        Me.GunaTextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaTextBox4.Name = "GunaTextBox4"
        Me.GunaTextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox4.SelectedText = ""
        Me.GunaTextBox4.Size = New System.Drawing.Size(425, 37)
        Me.GunaTextBox4.TabIndex = 10
        Me.GunaTextBox4.Text = "GunaTextBox4"
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'foto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(455, 66)
        Me.Controls.Add(Me.GunaTextBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "foto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "foto"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaTextBox4 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
End Class
