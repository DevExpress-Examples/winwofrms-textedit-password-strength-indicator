Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Controls

Namespace TextEditPasswordStrengthBar
    'The attribute that points to the registration method 
    <UserRepositoryItem("RegisterTextEditPwdStrength")> _
    Friend Class RepositoryItemTextEditPwdStrength
        Inherits RepositoryItemTextEdit

        Private Shared ReadOnly editValueChanging As New Object()

        ' Static constructor should call registration method
        Shared Sub New()
            RegisterTextEditPwdStrength()
        End Sub

        Public Const TextEditPwdStrengthName As String = "TextEditPwdStrength"
        Public Overrides ReadOnly Property EditorTypeName() As String
            Get
                Return TextEditPwdStrengthName
            End Get
        End Property

        Public Shared Sub RegisterTextEditPwdStrength()
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(TextEditPwdStrengthName, GetType(TextEditPwdStrength), GetType(RepositoryItemTextEditPwdStrength), GetType(TextEditPwdStrengthViewInfo), New TextEditPwdStrengthPainter(), True))
        End Sub
    End Class
End Namespace
