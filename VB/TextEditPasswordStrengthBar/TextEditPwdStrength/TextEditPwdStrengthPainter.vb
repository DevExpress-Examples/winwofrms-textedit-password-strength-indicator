Imports System.Drawing
Imports System.Text.RegularExpressions
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo

Namespace TextEditPasswordStrengthBar

    Friend Class TextEditPwdStrengthPainter
        Inherits TextEditPainter

        Public Sub New()
            MyBase.New()
        End Sub

        Protected Overrides Sub DrawContent(ByVal info As ControlGraphicsInfoArgs)
            MyBase.DrawContent(info)
            DrawLine(info)
        End Sub

        Private Sub DrawLine(ByVal info As ControlGraphicsInfoArgs)
            Dim vi As TextEditViewInfo = TryCast(info.ViewInfo, TextEditViewInfo)
            Dim r As Rectangle = vi.ClientRect
            r.Height = 3
            r.Y = vi.ClientRect.Height - r.Height
            Dim brush As Brush = Brushes.Green
            Select Case GetPasswordStrength(vi.EditValue, vi.ClientRect)
                Case 0
                    If vi.EditValue Is Nothing OrElse vi.EditValue.ToString().Length = 0 Then
                        r.Width = 0
                    Else
                        r.Width = r.Width \ 3
                    End If

                    brush = Brushes.Red
                Case 1
                    r.Width = r.Width * 2 \ 3
                    brush = Brushes.Orange
            End Select

            info.Paint.FillRectangle(info.Graphics, brush, r)
        End Sub

        Private Function GetPasswordStrength(ByVal pwd As Object, ByVal contentRectangle As Rectangle) As Integer
            Dim passwordStrength As Integer = 0, passwordPoints As Integer = 0
            If pwd Is Nothing Then Return passwordStrength
            Dim password As String = pwd.ToString()
            ' Simple algorithm of password strength calculation
            Dim rx As Regex
            ' If password is longer than 6 symbols than add 1 point
            If password.Length > 6 Then passwordPoints += 1
            ' If password has both lower and upper case characters than add 1 point
            rx = New Regex("(?=.*[a-z])(?=.*[A-Z])")
            If rx.Match(password).Success Then passwordPoints += 1
            ' Add 1 point if password contains at least one digit
            rx = New Regex("[0-9]")
            If rx.Match(password).Success Then passwordPoints += 1
            ' Add 1 point in case if password contains at least one special char
            rx = New Regex("\~|\@|\#|\$|\%|\^|\&|\*|\:|\;")
            If rx.Match(password).Success Then passwordPoints += 1
            ' Add 1 point if password is longer than 12 symbols
            If password.Length > 12 Then passwordPoints += 1
            If passwordPoints > 3 Then
                passwordStrength = 2
            ElseIf passwordPoints >= 2 AndAlso passwordPoints <= 3 Then
                passwordStrength = 1
            End If

            Return passwordStrength
        End Function
    End Class
End Namespace
