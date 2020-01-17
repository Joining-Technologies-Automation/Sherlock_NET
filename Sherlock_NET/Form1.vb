Imports System.ComponentModel

Public Class Form1
    Private Sherlock As Sherlock_NET 'initialize in a t/c

#Region "AxIpeDspCtrl1 ActiveX Functions on Main Form"
    ''' <summary>
    ''' Starts the activeX control for Sherlock.
    ''' </summary>
    Private Sub SherlockWindowINIT()
        AxIpeDspCtrl1.ConnectEngine(Sherlock.HSherlock.GetEngineObj)
        AxIpeDspCtrl1.SetZoom(-1)
    End Sub
    ''' <summary>
    ''' Disconnects the current camera feed and connects the passed camera name.
    ''' </summary>
    ''' <param name="CamName">Camera Name used inside the Sherlock investigation.</param>
    Public Sub SherlockLiveImageWindow(ByVal CamName As String)
        AxIpeDspCtrl1.DisconnectImgWindow()
        AxIpeDspCtrl1.ConnectImgWindow(CamName)
    End Sub
#End Region
#Region "Form open and close"
    ''' <summary>
    ''' Load the form.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Sherlock = New Sherlock_NET
            Sherlock.InitializeSherlock()
            SherlockWindowINIT()
        Catch ex As Exception
            If MessageBox.Show(ex.InnerException.Message + vbNewLine + "Would you like to continue?", "Error", MessageBoxButtons.YesNo) = DialogResult.No Then
                Close()
            End If
        End Try
    End Sub
    ''' <summary>
    ''' Close the form.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            AxIpeDspCtrl1.DisconnectImgWindow()         'close camera window.
            AxIpeDspCtrl1.DisconnectEngine()            'close the camera engine.
            Sherlock.CloseSherlock()                    'close sherlock.
        Catch ex As Exception
            MsgBox("Exception in Closing the form", MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub
#End Region
#Region "Buttons"
    Private Sub BTNOpenSherlock_Click(sender As Object, e As EventArgs) Handles BTNOpenSherlock.Click
        Dim d As New OpenFileDialog With {
            .CheckFileExists = True,
            .CheckPathExists = True,
            .Multiselect = False,
            .RestoreDirectory = True,
            .Title = "Open Sherlock *.ivs file",
            .Filter = "Sherlock Files (*.ivs)|*.ivs|All files (*.*)|*.*"}
        d.ShowDialog()
        Try
            Sherlock.LoadInvestigation(d.FileName)
            Sherlock.Investigate(Sherlock_NET.Investigate_Enum.Once)
        Catch ex As Exception
            MsgBox("Problem loading the sherlock investigation", MsgBoxStyle.OkCancel, "Error")
        End Try
    End Sub

    Private Sub BTNStartVideo_Click(sender As Object, e As EventArgs) Handles BTNStartVideo.Click
        SherlockLiveImageWindow(CamNames.CamName1)
    End Sub

    Private Sub BTNStopVideo_Click(sender As Object, e As EventArgs) Handles BTNStopVideo.Click

    End Sub

    Private Sub BTNClose_Click(sender As Object, e As EventArgs) Handles BTNClose.Click
        Close()
    End Sub
#End Region
End Class