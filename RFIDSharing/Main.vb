Imports mooftpserv

Public Class Main

    Dim ServerRunning As Boolean = False
    Dim ServerInstance

    Private Sub InitServer(ByVal ServerPassword As String)
        ServerInstance = New Server With {
            .LogHandler = New DefaultLogHandler(False),
            .AuthHandler = New DefaultAuthHandler(False),
            .Password = ServerPassword
        }
    End Sub

    Private Sub ServerThread_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles ServerThread.DoWork
        ServerInstance.Run()
    End Sub



    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'srv.LogHandler = New DefaultLogHandler(False)
        'srv.AuthHandler = New DefaultAuthHandler(False)
        'srv.ServerPassword = "hello"
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ServerThread.RunWorkerAsync()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'srv.Stop()
        ServerThread.CancelAsync()
    End Sub

    Private Sub GUI_Update_Tick(sender As Object, e As EventArgs) Handles GUI_Update.Tick
        If ServerThread.IsBusy Then
            Label1.Text = "Running @ " '& srv.LocalEndPoint.ToString
            Label1.ForeColor = Color.Green
        Else
            Label1.Text = "Stopped"
            Label1.ForeColor = Color.Firebrick
        End If
    End Sub


End Class