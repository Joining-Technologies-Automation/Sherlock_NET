Imports System.ComponentModel

Public Class Form1
    Private Sherlock As Sherlock_NET 'initialize in a t/c


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
        Catch ex As Exception
            MsgBox("Problem loading the sherlock investigation", MsgBoxStyle.OkCancel, "Error")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LiveImageSherlockWindow(CamNames.CamName1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub
    ''' <summary>
    ''' Load the form.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Sherlock = New Sherlock_NET
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
    ''' <summary>
    ''' Starts the activeX control for Sherlock.
    ''' </summary>
    Private Sub SherlockWindowINIT()
        AxIpeDspCtrl1.ConnectEngine(Sherlock.hSherlock.GetEngineObj)
        AxIpeDspCtrl1.SetZoom(-1)
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="CameraName">Camera Name used inside the Sherlock investigation.</param>
    Public Sub LiveImageSherlockWindow(ByVal CameraName As String)
            AxIpeDspCtrl1.DisconnectImgWindow()
            AxIpeDspCtrl1.ConnectImgWindow(CameraName)
        End Sub


End Class