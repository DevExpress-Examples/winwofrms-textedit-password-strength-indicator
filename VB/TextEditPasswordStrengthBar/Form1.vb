Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace TextEditPasswordStrengthBar
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub textEditPwdStrength_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles textEditPwdStrength2.Leave, textEditPwdStrength1.Leave
            Dim te As TextEditPwdStrength = TryCast(sender, TextEditPwdStrength)
            te.Properties.PasswordChar = "*"c
        End Sub

        Private Sub textEditPwdStrength_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles textEditPwdStrength2.Enter, textEditPwdStrength1.Enter
            Dim te As TextEditPwdStrength = TryCast(sender, TextEditPwdStrength)
            te.Properties.PasswordChar = ControlChars.NullChar
        End Sub
    End Class
End Namespace
