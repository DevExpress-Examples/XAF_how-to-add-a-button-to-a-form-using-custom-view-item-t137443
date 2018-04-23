Imports System
Imports System.Configuration
Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports System.ComponentModel
Imports DevExpress.ExpressApp.Mobile
Imports System.Collections.Generic
Imports DevExpress.ExpressApp.Xpo
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Mobile.MobileModel

Namespace MySolution.Mobile
    ' For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/DevExpressExpressAppWebWebApplicationMembersTopicAll.aspx
    Partial Public Class MySolutionMobileApplication
        Inherits MobileApplication

        Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
        Private module2 As DevExpress.ExpressApp.Mobile.SystemModule.SystemMobileModule
        Private module3 As MySolution.Module.MySolutionModule
        Private module4 As MySolution.Module.Mobile.MySolutionMobileModule
        Private securityModule1 As DevExpress.ExpressApp.Security.SecurityModule

        #Region "Default XAF configuration options (https:" 'www.devexpress.com/kb=T501418)
        Shared Sub New()
            DevExpress.Persistent.Base.PasswordCryptographer.EnableRfc2898 = True
            DevExpress.Persistent.Base.PasswordCryptographer.SupportLegacySha512 = False
        End Sub
        #End Region
        Public Sub New()
            Tracing.Initialize()
            If ConfigurationManager.ConnectionStrings("ConnectionString") IsNot Nothing Then
                ConnectionString = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
            End If
#If EASYTEST Then
            If ConfigurationManager.ConnectionStrings("EasyTestConnectionString") IsNot Nothing Then
                ConnectionString = ConfigurationManager.ConnectionStrings("EasyTestConnectionString").ConnectionString
            End If
#End If
            InitializeComponent()
#If DEBUG Then
            If System.Diagnostics.Debugger.IsAttached AndAlso CheckCompatibilityType = CheckCompatibilityType.DatabaseSchema Then
                DatabaseUpdateMode = DatabaseUpdateMode.UpdateDatabaseAlways
            End If
            AddHandler CustomizeApplicationConfig, AddressOf MySolutionMobileApplication_CustomizeApplicationConfig
#End If
        End Sub

        Private Sub MySolutionMobileApplication_CustomizeApplicationConfig(ByVal sender As Object, ByVal e As CustomizeApplicationConfigEventArgs)
            e.ApplicationConfig.Modules.Add(New MobileModule() With {.Name = "simpleButton"})
        End Sub

        Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
            args.ObjectSpaceProvider = New XPObjectSpaceProvider(GetDataStoreProvider(args.ConnectionString, args.Connection), True)
            args.ObjectSpaceProviders.Add(New NonPersistentObjectSpaceProvider(TypesInfo, Nothing))
        End Sub
        Private Function GetDataStoreProvider(ByVal connectionString As String, ByVal connection As System.Data.IDbConnection) As IXpoDataStoreProvider
            Dim dataStoreProvider As IXpoDataStoreProvider = Nothing
            If Not String.IsNullOrEmpty(connectionString) Then
                dataStoreProvider = New ConnectionStringDataStoreProvider(connectionString)
            ElseIf connection IsNot Nothing Then
                dataStoreProvider = New ConnectionDataStoreProvider(connection)
            End If
            Return dataStoreProvider
        End Function
        Private Sub MySolutionMobileApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles Me.DatabaseVersionMismatch
#If EASYTEST Then
            e.Updater.Update()
            e.Handled = True
#Else
            If System.Diagnostics.Debugger.IsAttached Then
                e.Updater.Update()
                e.Handled = True
            Else
                Dim message As String = "The application cannot connect to the specified database, " & "because the database doesn't exist, its version is older " & "than that of the application or its schema does not match " & "the ORM data model structure. To avoid this error, use one " & "of the solutions from the https://www.devexpress.com/kb=T367835 KB Article."

                If e.CompatibilityError IsNot Nothing AndAlso e.CompatibilityError.Exception IsNot Nothing Then
                    message &= ControlChars.CrLf & ControlChars.CrLf & "Inner exception: " & e.CompatibilityError.Exception.Message
                End If
                Throw New InvalidOperationException(message)
            End If
#End If
        End Sub
        Private Sub InitializeComponent()
            Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
            Me.module2 = New DevExpress.ExpressApp.Mobile.SystemModule.SystemMobileModule()
            Me.module3 = New MySolution.Module.MySolutionModule()
            Me.module4 = New MySolution.Module.Mobile.MySolutionMobileModule()
            Me.securityModule1 = New DevExpress.ExpressApp.Security.SecurityModule()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' MySolutionMobileApplication
            ' 
            Me.ApplicationName = "MySolution"
            Me.Modules.Add(Me.module1)
            Me.Modules.Add(Me.module2)
            Me.Modules.Add(Me.module3)
            Me.Modules.Add(Me.module4)
            Me.Modules.Add(Me.securityModule1)
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
    End Class
End Namespace
