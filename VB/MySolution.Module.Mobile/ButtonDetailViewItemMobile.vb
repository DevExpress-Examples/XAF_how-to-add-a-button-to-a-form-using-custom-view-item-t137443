Imports DevExpress.ExpressApp.Editors
Imports DevExpress.ExpressApp.Mobile.MobileModel
Imports DevExpress.ExpressApp.Model
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace MySolution.Module.Mobile
    Public Interface IModelButtonDetailViewItemMobile
        Inherits IModelViewItem

    End Interface
    Public Class SimpleButton
        Inherits TitledComponent

        Public Sub New()
            Type = "simpleButton"
        End Sub
    End Class
    <ViewItem(GetType(IModelButtonDetailViewItemMobile))> _
    Public Class ButtonDetailViewItemMobile
        Inherits ViewItem

        Protected Overrides Function CreateControlCore() As Object
            Dim simpleButton As New SimpleButton()
            simpleButton("text") = "Click me!"
            Return simpleButton
        End Function
        Public Sub New(ByVal model As IModelViewItem, ByVal objectType As Type)
            MyBase.New(objectType, model.Id)
        End Sub
    End Class
End Namespace
