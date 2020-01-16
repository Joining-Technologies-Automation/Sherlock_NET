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
        Me.btnOpenSherlock = New System.Windows.Forms.Button()
        Me.btnStartVideo = New System.Windows.Forms.Button()
        Me.btnStopVideo = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
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
        'btnOpenSherlock
        '
        Me.btnOpenSherlock.Location = New System.Drawing.Point(31, 368)
        Me.btnOpenSherlock.Name = "btnOpenSherlock"
        Me.btnOpenSherlock.Size = New System.Drawing.Size(107, 45)
        Me.btnOpenSherlock.TabIndex = 1
        Me.btnOpenSherlock.Text = "Open Sherlock *.ivs file"
        Me.btnOpenSherlock.UseVisualStyleBackColor = True
        '
        'btnStartVideo
        '
        Me.btnStartVideo.Location = New System.Drawing.Point(226, 368)
        Me.btnStartVideo.Name = "btnStartVideo"
        Me.btnStartVideo.Size = New System.Drawing.Size(107, 45)
        Me.btnStartVideo.TabIndex = 2
        Me.btnStartVideo.Text = "Start Video"
        Me.btnStartVideo.UseVisualStyleBackColor = True
        '
        'btnStopVideo
        '
        Me.btnStopVideo.Location = New System.Drawing.Point(421, 368)
        Me.btnStopVideo.Name = "btnStopVideo"
        Me.btnStopVideo.Size = New System.Drawing.Size(107, 45)
        Me.btnStopVideo.TabIndex = 3
        Me.btnStopVideo.Text = "Stop Video"
        Me.btnStopVideo.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(616, 368)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(107, 45)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnStopVideo)
        Me.Controls.Add(Me.btnStartVideo)
        Me.Controls.Add(Me.btnOpenSherlock)
        Me.Controls.Add(Me.AxIpeDspCtrl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AxIpeDspCtrl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AxIpeDspCtrl1 As AxIpeDspCtrlLib.AxIpeDspCtrl
    Friend WithEvents btnOpenSherlock As Button
    Friend WithEvents btnStartVideo As Button
    Friend WithEvents btnStopVideo As Button
    Friend WithEvents btnClose As Button
End Class
