Imports System
Imports DevExpress.ExpressApp
Imports System.ComponentModel
Imports DevExpress.ExpressApp.Xpo
Imports DevExpress.ExpressApp.Web

'using DevExpress.ExpressApp.Security;
Namespace MySolution.Web

    ' For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/DevExpressExpressAppWebWebApplicationMembersTopicAll
    Public Partial Class MySolutionAspNetApplication
        Inherits WebApplication

        Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule

        Private module2 As DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule

        Private module3 As [Module].MySolutionModule

        Private module4 As [Module].Web.MySolutionAspNetModule

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
            args.ObjectSpaceProvider = New XPObjectSpaceProvider(args.ConnectionString, args.Connection, True)
        End Sub

        Private Sub MySolutionAspNetApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DatabaseVersionMismatchEventArgs)
            e.Updater.Update()
            e.Handled = True
        End Sub

        Private Sub InitializeComponent()
            module1 = New SystemModule.SystemModule()
            module2 = New SystemModule.SystemAspNetModule()
            module3 = New [Module].MySolutionModule()
            module4 = New [Module].Web.MySolutionAspNetModule()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' MySolutionAspNetApplication
            ' 
            ApplicationName = "MySolution"
            Modules.Add(module1)
            Modules.Add(module2)
            Modules.Add(module3)
            Modules.Add(module4)
            AddHandler DatabaseVersionMismatch, New EventHandler(Of DatabaseVersionMismatchEventArgs)(AddressOf MySolutionAspNetApplication_DatabaseVersionMismatch)
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        End Sub
    End Class
End Namespace
