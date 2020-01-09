Imports System.ComponentModel

Public Class Form1
    Private Sherlock As Sherlock_NET 'initialize in a t/c

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim d As New OpenFileDialog With {
                .CheckFileExists = True,
                .CheckPathExists = True,
                .Multiselect = False,
                .RestoreDirectory = True,
                .Title = "Open Sherlock *.ivs file",
                .Filter = "Sherlock Files (*.ivs)|*.ivs|All files (*.*)|*.*"}

            d.ShowDialog()

            Sherlock.LoadInvestigation(d.FileName)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        INITSherlockWindow()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Sherlock = New Sherlock_NET
        Catch ex As Exception
            If MessageBox.Show(ex.InnerException.Message + vbNewLine + "Would you like to continue?", "Error", MessageBoxButtons.YesNo) = DialogResult.No Then
                Close()
            End If
        End Try
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Sherlock.CloseSherlock()

    End Sub

    Private Sub INITSherlockWindow()
        AxIpeDspCtrl1.ConnectEngine(Sherlock.hSherlock.GetEngineObj)
        AxIpeDspCtrl1.SetZoom(-1)
    End Sub
End Class
