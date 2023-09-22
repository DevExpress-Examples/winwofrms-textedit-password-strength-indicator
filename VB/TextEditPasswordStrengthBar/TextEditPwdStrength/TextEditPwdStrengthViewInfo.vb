Imports System.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Repository

Namespace TextEditPasswordStrengthBar

    Friend Class TextEditPwdStrengthViewInfo
        Inherits TextEditViewInfo

        Public Sub New(ByVal item As RepositoryItem)
            MyBase.New(item)
        End Sub

        Public ReadOnly Property RepositoryItem As RepositoryItemTextEditPwdStrength
            Get
                Return TryCast(Item, RepositoryItemTextEditPwdStrength)
            End Get
        End Property

        Protected Overrides Function CalcMaskBoxRect(ByVal content As System.Drawing.Rectangle, ByRef contextImageBounds As Rectangle) As System.Drawing.Rectangle
            Dim r As Rectangle = MyBase.CalcMaskBoxRect(content, contextImageBounds)
            r.Height -= 1
            r.Y = 1
            Return r
        End Function
    End Class
End Namespace
