Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace TextEditPasswordStrengthBar

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub textEditPwdStrength_Leave(ByVal sender As Object, ByVal e As EventArgs)
            Dim te As TextEditPwdStrength = TryCast(sender, TextEditPwdStrength)
            te.Properties.PasswordChar = "*"c
        End Sub

        Private Sub textEditPwdStrength_Enter(ByVal sender As Object, ByVal e As EventArgs)
            Dim te As TextEditPwdStrength = TryCast(sender, TextEditPwdStrength)
            te.Properties.PasswordChar = Microsoft.VisualBasic.Strings.ChrW(0)
        End Sub
    End Class
End Namespace
