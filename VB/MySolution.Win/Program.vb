Imports System
Imports System.Windows.Forms
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Xpo

Namespace MySolution.Win

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
#If EASYTEST
            DevExpress.ExpressApp.Win.EasyTest.EasyTestRemotingRegistration.Register();
#End If
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            EditModelPermission.AlwaysGranted = System.Diagnostics.Debugger.IsAttached
            Dim winApplication As MySolutionWindowsFormsApplication = New MySolutionWindowsFormsApplication()
            winApplication.ConnectionString = InMemoryDataStoreProvider.ConnectionString
            Try
                winApplication.Setup()
                winApplication.Start()
            Catch e As Exception
                winApplication.HandleException(e)
            End Try
        End Sub
    End Module
End Namespace
