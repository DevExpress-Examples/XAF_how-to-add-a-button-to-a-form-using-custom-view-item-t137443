Imports System
Imports System.Windows.Forms
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.ExpressApp.Model
Imports DevExpress.ExpressApp

Namespace MySolution.Module.Win

    Public Interface IModelButtonDetailViewItemWin
        Inherits IModelViewItem

    End Interface

    <ViewItemAttribute(GetType(IModelButtonDetailViewItemWin))>
    Public Class ButtonDetailViewItemWin
        Inherits ViewItem

        Public Sub New(ByVal model As IModelViewItem, ByVal objectType As Type)
            MyBase.New(objectType, model.Id)
        End Sub

        Protected Overrides Function CreateControlCore() As Object
            Dim button As Button = New Button()
            button.Text = "Click me!"
            AddHandler button.Click, New EventHandler(AddressOf button_Click)
            Return button
        End Function

        Private Sub button_Click(ByVal sender As Object, ByVal e As EventArgs)
            Throw New UserFriendlyException("Action from custom view item was executed!")
        End Sub
    End Class
End Namespace
