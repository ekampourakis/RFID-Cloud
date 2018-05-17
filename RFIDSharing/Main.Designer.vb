<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ServerThread
        '
        Me.ServerThread.WorkerSupportsCancellation = True
        '
        'Button_Start
        '
        Me.Button_Start.Location = New System.Drawing.Point(257, 148)
        Me.Button_Start.Name = "Button_Start"
        Me.Button_Start.Size = New System.Drawing.Size(75, 23)
        Me.Button_Start.TabIndex = 0
        Me.Button_Start.Text = "Start"
        Me.Button_Start.UseVisualStyleBackColor = True
        '
        'Button_Stop
        '
        Me.Button_Stop.Location = New System.Drawing.Point(338, 148)
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
        Me.StatusStrip.Location = New System.Drawing.Point(0, 368)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(651, 22)
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
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 390)
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
End Class
