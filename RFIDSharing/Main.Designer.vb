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
        Me.ServerThread = New System.ComponentModel.BackgroundWorker()
        Me.Button_Start = New System.Windows.Forms.Button()
        Me.Button_Stop = New System.Windows.Forms.Button()
        Me.GUI_Update = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.Label_Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ServerThread
        '
        Me.ServerThread.WorkerSupportsCancellation = True
        '
        'Button_Start
        '
        Me.Button_Start.Location = New System.Drawing.Point(78, 55)
        Me.Button_Start.Name = "Button_Start"
        Me.Button_Start.Size = New System.Drawing.Size(75, 23)
        Me.Button_Start.TabIndex = 0
        Me.Button_Start.Text = "Start"
        Me.Button_Start.UseVisualStyleBackColor = True
        '
        'Button_Stop
        '
        Me.Button_Stop.Location = New System.Drawing.Point(159, 55)
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
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Label_Status})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(912, 22)
        Me.StatusStrip.TabIndex = 4
        '
        'Label_Status
        '
        Me.Label_Status.Name = "Label_Status"
        Me.Label_Status.Size = New System.Drawing.Size(58, 17)
        Me.Label_Status.Text = "No Status"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 453)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.Button_Stop)
        Me.Controls.Add(Me.Button_Start)
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
    Friend WithEvents Label_Status As ToolStripStatusLabel
End Class
