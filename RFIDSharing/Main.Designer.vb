<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.ServerThread = New System.ComponentModel.BackgroundWorker()
        Me.Button_Start = New System.Windows.Forms.Button()
        Me.Button_Stop = New System.Windows.Forms.Button()
        Me.GUI_Update = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.Label_FTPStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label_SerialStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.SerialTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker_Serial = New System.ComponentModel.BackgroundWorker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_CompanyName = New System.Windows.Forms.TextBox()
        Me.TextBox_CardUID = New System.Windows.Forms.TextBox()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ServerThread
        '
        Me.ServerThread.WorkerSupportsCancellation = True
        '
        'Button_Start
        '
        Me.Button_Start.Location = New System.Drawing.Point(92, 77)
        Me.Button_Start.Name = "Button_Start"
        Me.Button_Start.Size = New System.Drawing.Size(75, 23)
        Me.Button_Start.TabIndex = 0
        Me.Button_Start.Text = "Start"
        Me.Button_Start.UseVisualStyleBackColor = True
        '
        'Button_Stop
        '
        Me.Button_Stop.Location = New System.Drawing.Point(173, 77)
        Me.Button_Stop.Name = "Button_Stop"
        Me.Button_Stop.Size = New System.Drawing.Size(75, 23)
        Me.Button_Stop.TabIndex = 1
        Me.Button_Stop.Text = "Stop"
        Me.Button_Stop.UseVisualStyleBackColor = True
        '
        'GUI_Update
        '
        Me.GUI_Update.Enabled = True
        Me.GUI_Update.Interval = 10
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Label_FTPStatus, Me.Label_SerialStatus})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 390)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(690, 22)
        Me.StatusStrip.TabIndex = 4
        '
        'Label_FTPStatus
        '
        Me.Label_FTPStatus.Name = "Label_FTPStatus"
        Me.Label_FTPStatus.Size = New System.Drawing.Size(58, 17)
        Me.Label_FTPStatus.Text = "No Status"
        '
        'Label_SerialStatus
        '
        Me.Label_SerialStatus.Name = "Label_SerialStatus"
        Me.Label_SerialStatus.Size = New System.Drawing.Size(58, 17)
        Me.Label_SerialStatus.Text = "No Status"
        '
        'SerialPort
        '
        Me.SerialPort.BaudRate = 115200
        Me.SerialPort.DtrEnable = True
        Me.SerialPort.PortName = "COM8"
        '
        'SerialTimer
        '
        Me.SerialTimer.Enabled = True
        Me.SerialTimer.Interval = 1000
        '
        'BackgroundWorker_Serial
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(375, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Company Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(375, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Card UID:"
        '
        'TextBox_CompanyName
        '
        Me.TextBox_CompanyName.Location = New System.Drawing.Point(378, 174)
        Me.TextBox_CompanyName.Name = "TextBox_CompanyName"
        Me.TextBox_CompanyName.ReadOnly = True
        Me.TextBox_CompanyName.Size = New System.Drawing.Size(142, 20)
        Me.TextBox_CompanyName.TabIndex = 7
        '
        'TextBox_CardUID
        '
        Me.TextBox_CardUID.Location = New System.Drawing.Point(378, 213)
        Me.TextBox_CardUID.Name = "TextBox_CardUID"
        Me.TextBox_CardUID.ReadOnly = True
        Me.TextBox_CardUID.Size = New System.Drawing.Size(142, 20)
        Me.TextBox_CardUID.TabIndex = 8
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 412)
        Me.Controls.Add(Me.TextBox_CardUID)
        Me.Controls.Add(Me.TextBox_CompanyName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.Button_Stop)
        Me.Controls.Add(Me.Button_Start)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ServerThread As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button_Start As Button
    Friend WithEvents Button_Stop As Button
    Friend WithEvents GUI_Update As Timer
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents Label_FTPStatus As ToolStripStatusLabel
    Friend WithEvents Label_SerialStatus As ToolStripStatusLabel
    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents SerialTimer As Timer
    Friend WithEvents BackgroundWorker_Serial As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_CompanyName As TextBox
    Friend WithEvents TextBox_CardUID As TextBox
End Class
