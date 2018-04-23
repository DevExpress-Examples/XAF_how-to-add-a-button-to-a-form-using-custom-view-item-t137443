Imports System
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.ExpressApp.Model
Imports DevExpress.ExpressApp.Web
Imports DevExpress.Web

Namespace MySolution.Module.Web
    Public Interface IModelButtonDetailViewItemWeb
        Inherits IModelViewItem

    End Interface

    <ViewItemAttribute(GetType(IModelButtonDetailViewItemWeb))> _
    Public Class ButtonDetailViewItemWeb
        Inherits ViewItem

        Public Sub New(ByVal model As IModelViewItem, ByVal objectType As Type)
            MyBase.New(objectType, model.Id)
            CreateControl()
        End Sub
        Protected Overrides Function CreateControlCore() As Object
            Dim button As New ASPxButton()
            button.Text = "Click me!"
            button.EnableClientSideAPI = True
            AddHandler button.Click, AddressOf button_Click
            Return button
        End Function
        Private Sub button_Click(ByVal sender As Object, ByVal e As EventArgs)
            WebWindow.CurrentRequestWindow.RegisterClientScript("ShowAlert", "alert('Action from custom view item was executed!');")
        End Sub
    End Class
End Namespace

