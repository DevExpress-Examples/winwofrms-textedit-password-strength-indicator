Namespace TextEditPasswordStrengthBar

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.textEditPwdStrength2 = New TextEditPasswordStrengthBar.TextEditPwdStrength()
            Me.textEditPwdStrength1 = New TextEditPasswordStrengthBar.TextEditPwdStrength()
            CType((Me.textEditPwdStrength2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEditPwdStrength1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' textEditPwdStrength2
            ' 
            Me.textEditPwdStrength2.Location = New System.Drawing.Point(120, 13)
            Me.textEditPwdStrength2.Name = "textEditPwdStrength2"
            Me.textEditPwdStrength2.Properties.PasswordChar = "*"c
            Me.textEditPwdStrength2.Size = New System.Drawing.Size(100, 20)
            Me.textEditPwdStrength2.TabIndex = 1
            AddHandler Me.textEditPwdStrength2.Leave, New System.EventHandler(AddressOf Me.textEditPwdStrength_Leave)
            AddHandler Me.textEditPwdStrength2.Enter, New System.EventHandler(AddressOf Me.textEditPwdStrength_Enter)
            ' 
            ' textEditPwdStrength1
            ' 
            Me.textEditPwdStrength1.EditValue = "@Erv_42Ord"
            Me.textEditPwdStrength1.Location = New System.Drawing.Point(13, 13)
            Me.textEditPwdStrength1.Name = "textEditPwdStrength1"
            Me.textEditPwdStrength1.Properties.PasswordChar = "*"c
            Me.textEditPwdStrength1.Size = New System.Drawing.Size(100, 20)
            Me.textEditPwdStrength1.TabIndex = 0
            AddHandler Me.textEditPwdStrength1.Leave, New System.EventHandler(AddressOf Me.textEditPwdStrength_Leave)
            AddHandler Me.textEditPwdStrength1.Enter, New System.EventHandler(AddressOf Me.textEditPwdStrength_Enter)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(233, 44)
            Me.Controls.Add(Me.textEditPwdStrength2)
            Me.Controls.Add(Me.textEditPwdStrength1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.textEditPwdStrength2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEditPwdStrength1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private textEditPwdStrength1 As TextEditPasswordStrengthBar.TextEditPwdStrength

        Private textEditPwdStrength2 As TextEditPasswordStrengthBar.TextEditPwdStrength
    End Class
End Namespace
