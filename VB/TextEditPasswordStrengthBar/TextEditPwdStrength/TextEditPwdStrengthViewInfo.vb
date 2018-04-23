﻿Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Repository

Namespace TextEditPasswordStrengthBar
    Friend Class TextEditPwdStrengthViewInfo
        Inherits TextEditViewInfo

        Public Sub New(ByVal item As RepositoryItem)
            MyBase.New(item)
        End Sub

        Public ReadOnly Property RepositoryItem() As RepositoryItemTextEditPwdStrength
            Get
                Return TryCast(Me.Item, RepositoryItemTextEditPwdStrength)
            End Get
        End Property

        Protected Overrides Function CalcMaskBoxRect(ByVal content As System.Drawing.Rectangle) As System.Drawing.Rectangle
            Dim r As Rectangle = MyBase.CalcMaskBoxRect(content)
            r.Height -= 1
            r.Y = 1
            Return r
        End Function
    End Class
End Namespace
