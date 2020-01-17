<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AxIpeDspCtrl1 = New AxIpeDspCtrlLib.AxIpeDspCtrl()
        Me.BTNOpenSherlock = New System.Windows.Forms.Button()
        Me.BTNStartVideo = New System.Windows.Forms.Button()
        Me.BTNStopVideo = New System.Windows.Forms.Button()
        Me.BTNClose = New System.Windows.Forms.Button()
        CType(Me.AxIpeDspCtrl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxIpeDspCtrl1
        '
        Me.AxIpeDspCtrl1.Enabled = True
        Me.AxIpeDspCtrl1.Location = New System.Drawing.Point(12, 12)
        Me.AxIpeDspCtrl1.Name = "AxIpeDspCtrl1"
        Me.AxIpeDspCtrl1.OcxState = CType(resources.GetObject("AxIpeDspCtrl1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxIpeDspCtrl1.Size = New System.Drawing.Size(776, 333)
        Me.AxIpeDspCtrl1.TabIndex = 0
        '
        'BTNOpenSherlock
        '
        Me.BTNOpenSherlock.Location = New System.Drawing.Point(31, 368)
        Me.BTNOpenSherlock.Name = "BTNOpenSherlock"
        Me.BTNOpenSherlock.Size = New System.Drawing.Size(107, 45)
        Me.BTNOpenSherlock.TabIndex = 1
        Me.BTNOpenSherlock.Text = "Open Sherlock *.ivs file"
        Me.BTNOpenSherlock.UseVisualStyleBackColor = True
        '
        'BTNStartVideo
        '
        Me.BTNStartVideo.Location = New System.Drawing.Point(226, 368)
        Me.BTNStartVideo.Name = "BTNStartVideo"
        Me.BTNStartVideo.Size = New System.Drawing.Size(107, 45)
        Me.BTNStartVideo.TabIndex = 2
        Me.BTNStartVideo.Text = "Start Video"
        Me.BTNStartVideo.UseVisualStyleBackColor = True
        '
        'BTNStopVideo
        '
        Me.BTNStopVideo.Location = New System.Drawing.Point(421, 368)
        Me.BTNStopVideo.Name = "BTNStopVideo"
        Me.BTNStopVideo.Size = New System.Drawing.Size(107, 45)
        Me.BTNStopVideo.TabIndex = 3
        Me.BTNStopVideo.Text = "Stop Video"
        Me.BTNStopVideo.UseVisualStyleBackColor = True
        '
        'BTNClose
        '
        Me.BTNClose.Location = New System.Drawing.Point(616, 368)
        Me.BTNClose.Name = "BTNClose"
        Me.BTNClose.Size = New System.Drawing.Size(107, 45)
        Me.BTNClose.TabIndex = 4
        Me.BTNClose.Text = "Close"
        Me.BTNClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTNClose)
        Me.Controls.Add(Me.BTNStopVideo)
        Me.Controls.Add(Me.BTNStartVideo)
        Me.Controls.Add(Me.BTNOpenSherlock)
        Me.Controls.Add(Me.AxIpeDspCtrl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AxIpeDspCtrl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AxIpeDspCtrl1 As AxIpeDspCtrlLib.AxIpeDspCtrl
    Friend WithEvents BTNOpenSherlock As Button
    Friend WithEvents BTNStartVideo As Button
    Friend WithEvents BTNStopVideo As Button
    Friend WithEvents BTNClose As Button
End Class
