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
        ServerRunning = True
        ServerInstance.Run()
        ServerRunning = False
    End Sub

    Private Sub StartServer()
        If ServerRunning = False Then
            ServerThread.RunWorkerAsync()
        End If
    End Sub

    Private Sub StopServer()
        If ServerRunning Then
            ServerInstance.Stop()
            ServerThread.CancelAsync()
            ServerRunning = False
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitServer("MyUID")
    End Sub

    Private Function GetIPv4Address() As String
        GetIPv4Address = String.Empty
        Dim strHostName As String = Net.Dns.GetHostName()
        Dim iphe As Net.IPHostEntry = Net.Dns.GetHostEntry(strHostName)
        For Each ipheal As Net.IPAddress In iphe.AddressList
            If ipheal.AddressFamily = Net.Sockets.AddressFamily.InterNetwork Then
                GetIPv4Address = ipheal.ToString()
            End If
        Next
    End Function

    Private Sub Button_Start_Click(sender As Object, e As EventArgs) Handles Button_Start.Click
        StartServer()
    End Sub

    Private Sub Button_Stop_Click(sender As Object, e As EventArgs) Handles Button_Stop.Click
        StopServer()
    End Sub

    Private Sub GUI_Update_Tick(sender As Object, e As EventArgs) Handles GUI_Update.Tick
        If ServerRunning Then
            If Label_Status.ForeColor <> Color.Green Then
                Label_Status.Text = "Running at " & GetIPv4Address() & " on port " & ServerInstance.LocalPort
                Label_Status.ForeColor = Color.Green
            End If
            If Button_Start.Enabled Then
                Button_Start.Enabled = False
            End If
            If Button_Stop.Enabled = False Then
                Button_Stop.Enabled = True
            End If
        Else
            If Label_Status.ForeColor <> Color.Firebrick Then
                Label_Status.Text = "Stopped"
                Label_Status.ForeColor = Color.Firebrick
            End If
            If Button_Start.Enabled = False Then
                Button_Start.Enabled = True
            End If
            If Button_Stop.Enabled Then
                Button_Stop.Enabled = False
            End If
        End If
    End Sub


End Class