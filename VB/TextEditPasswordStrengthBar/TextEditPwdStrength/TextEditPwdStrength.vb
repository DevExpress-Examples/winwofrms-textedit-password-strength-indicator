Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.ComponentModel
Imports DevExpress.XtraEditors

Namespace TextEditPasswordStrengthBar
    Friend Class TextEditPwdStrength
        Inherits TextEdit

        Shared Sub New()
            RepositoryItemTextEditPwdStrength.RegisterTextEditPwdStrength()
        End Sub
        Public Sub New()
            MyBase.New()
        End Sub

        Public Overrides ReadOnly Property EditorTypeName() As String
            Get
                Return RepositoryItemTextEditPwdStrength.TextEditPwdStrengthName
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public Shadows ReadOnly Property Properties() As RepositoryItemTextEditPwdStrength
            Get
                Return TryCast(MyBase.Properties, RepositoryItemTextEditPwdStrength)
            End Get
        End Property

        Protected Overrides Sub OnEditValueChanged()
            Me.RefreshVisualLayout()
            MyBase.OnEditValueChanged()
        End Sub
    End Class
End Namespace
