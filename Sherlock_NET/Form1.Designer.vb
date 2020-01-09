<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AxIpeDspCtrl1 = New AxIpeDspCtrlLib.AxIpeDspCtrl()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(31, 360)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 45)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Open Sherlock *.ivs file"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(226, 360)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 45)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Start Video"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(421, 360)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 45)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Stop Video"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(616, 360)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(107, 45)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AxIpeDspCtrl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AxIpeDspCtrl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AxIpeDspCtrl1 As AxIpeDspCtrlLib.AxIpeDspCtrl
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
