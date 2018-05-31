Imports System.Text
Imports mooftpserv

Public Class Main

#Const DEBUG = True


#Region "Server"

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

#End Region

    Dim ScannerConnected As Boolean = False

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#If DEBUG Then
        SerialPort.Open()
        ScannerConnected = True
#Else
        BackgroundWorker_Serial.RunWorkerAsync()
#End If

        Console.WriteLine("Current UID: " & My.Settings.UID)
        If My.Settings.UID <> "null" Then
            ' load normal GUI
            InitServer(My.Settings.UID)
        Else
            ' load welcome GUI
            ' go through registration steps
            '   set state to wait for UID from Serial
        End If
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
            If Label_FTPStatus.ForeColor <> Color.Green Then
                Label_FTPStatus.Text = "Running at " & GetIPv4Address() & " on port " & ServerInstance.LocalPort
                Label_FTPStatus.ForeColor = Color.Green
            End If
            If Button_Start.Enabled Then
                Button_Start.Enabled = False
            End If
            If Button_Stop.Enabled = False Then
                Button_Stop.Enabled = True
            End If
        Else
            If Label_FTPStatus.ForeColor <> Color.Firebrick Then
                Label_FTPStatus.Text = "Stopped"
                Label_FTPStatus.ForeColor = Color.Firebrick
            End If
            If Button_Start.Enabled = False Then
                Button_Start.Enabled = True
            End If
            If Button_Stop.Enabled Then
                Button_Stop.Enabled = False
            End If
        End If

        If ScannerConnected Then
            If Label_SerialStatus.ForeColor <> Color.Green Then
                Label_SerialStatus.ForeColor = Color.Green
                Label_SerialStatus.Text = "Scanner Connected"
            End If
        Else
            If Label_SerialStatus.ForeColor <> Color.Firebrick Then
                Label_SerialStatus.ForeColor = Color.Firebrick
                Label_SerialStatus.Text = "Scanner Disconnected"
            End If
        End If
    End Sub

    Private Function UIDToString(Input As Byte())
        Dim strTemp As String = ""
        For Each b As Byte In Input
            strTemp &= (Hex(b).PadLeft(2, "0"))
        Next
        Return strTemp
    End Function

    Private Sub SerialPort_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        If ScannerConnected Then
            If SerialPort.BytesToRead > 5 Then
                Dim Received(6) As Byte
                For Index As Integer = 0 To 5
                    Received(Index) = SerialPort.ReadByte()
                Next
                Console.WriteLine("Received: " & UIDToString(Received))
                If Received(0) = 1 And Received(5) = 2 Then
                    Dim UID(4) As Byte
                    For Index As Integer = 0 To 3
                        UID(Index) = Received(Index + 1)
                    Next
                    If My.Settings.UID <> "null" Then
                        ' just read a card then try connect to it
                        Console.Write("just a card")
                    Else

                        My.Settings.UID = UIDToString(UID)
                        My.Settings.Save()
                        Console.WriteLine(UIDToString(UID))
                    End If
                End If
            End If
        End If

        'if received card scan command then
        '   ask for rfid code
        '   if card registered
        '       if registered code = code
        '           repeat password set procedure to change password
        '       else
        '           search network for the server with this code
        '   else
        '       register code and ask for password
        '       send password to be written on the card and create blocking function here until received password written code
        'if received password written command then
        '
        'if received waiting for card to write password code
        '
        'if received error code
        '   analyze error code
    End Sub

    Private Sub BackgroundWorker_Serial_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker_Serial.DoWork
Wait:   While Not ScannerConnected
            ScannerConnected = EnhancedSerial.AutoConnect(SerialPort, 13, {0, 255}, 115200)
        End While
        While ScannerConnected
            ' do some kind of ping here to see if the serial is still there
        End While
        GoTo Wait
    End Sub
End Class