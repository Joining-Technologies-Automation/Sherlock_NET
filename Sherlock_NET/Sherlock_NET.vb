Imports IpeEngCtrlLib

''' <summary>
''' Fill the Sherlock Vars with the Camera names, with the variables being pulled from the investigations etc.
''' </summary>
Module SherlockVars
    'You will need to update this section with the required Sherlock variables you want to use in your specific
    'Sherlock Investigations.
#Region "Sherlock Variables"
#Region "Bool"

#End Region
#Region "Point"

#End Region
#Region "Double"

#End Region
#End Region

    ''' <summary>
    ''' Names of the different cameras. 
    ''' Camera names are found in the Sherlock investigations. Image Window instruction. The default camera name is "imgA". 
    ''' </summary>
    Public Structure CamNames
        Const CamName1 As String = "exCamName1"
        Const CamName2 As String = "exCamName2"
        'etc. etc. etc...
    End Structure
End Module

''' <summary>
''' Control the Sherlock software.
''' </summary>
Public Class Sherlock_NET
#Region "Declarations"
    Friend WithEvents HSherlock As New Engine
    Friend nErr As I_ENG_ERROR

    Public Enum Investigate_Enum
        Once = 1
        Continuous = 2
    End Enum
#End Region
#Region "Events"
    Private Sub Sherlock_afterload_event() Handles HSherlock.AfterLoad
        Console.WriteLine(String.Format("{0}: Sherlock after load event", TimeString))
        'fill this with actions to take.
    End Sub

    Private Sub Sherlock_beforeload_event() Handles HSherlock.BeforeLoad
        Console.WriteLine(String.Format("{0}: Sherlock before load event", TimeString))
        'fill this with actions to take.
    End Sub

    Private Sub Sherlock_on_run_error_event() Handles HSherlock.OnRunError
        Console.WriteLine(String.Format("{0}: Sherlock on run error event", TimeString))
        Console.WriteLine(String.Format("{0}: Sherlock Error: {1}", TimeString, nErr.ToString))
        'fill this with actions to take.
    End Sub

    Private Sub Sherlock_run_complete_event() Handles HSherlock.RunCompleted
        Console.WriteLine(String.Format("{0}: Sherlock run complete event", TimeString))
        'fill this with actions to take.
    End Sub
#End Region

    ''' <summary>
    ''' Initialize Sherlock Engine.
    ''' </summary>
    Public Sub InitializeSherlock()
        nErr = HSherlock.EngInitialize
        Dim x As Integer = 0
        While nErr <> I_ENG_ERROR.I_OK
            If x >= 30 Then
                Console.WriteLine(String.Format("{0}: Sherlock did not initialize.", TimeString))
                Throw New ApplicationException("Sherlock did not initialize.")
            End If
            x += 1
        End While
        Console.WriteLine(String.Format("{0}: Successfully initialized Sherlock.", TimeString))
    End Sub

    ''' <summary>
    ''' Load the investigation into Sherlock. ActiveX controlled separately.
    ''' </summary>
    ''' <param name="filepath"></param>
    Public Sub LoadInvestigation(ByVal filepath As String)
        nErr = HSherlock.InvModeSet(I_MODE.I_EXE_MODE_HALT_AFTER_ITERATION) 'stop the current program.
        nErr = HSherlock.InvModeWaitForHalt 'wait for the halt.
        nErr = HSherlock.InvLoad(filepath)
        If nErr <> I_ENG_ERROR.I_OK Then Throw New ApplicationException("Error loading " + filepath + " into sherlock.")
        Console.WriteLine(String.Format("{0}: Loaded investigation: {1}", TimeString, filepath))
    End Sub

    ''' <summary>
    ''' Terminate the Sherlock engine.
    ''' </summary>
    Public Sub CloseSherlock()
        HSherlock.EngTerminate()
        Console.WriteLine("Sherlock successfully closed.")
    End Sub

    ''' <summary>
    ''' Investigate. Choose the style.
    ''' </summary>
    ''' <param name="Value">Once = a single investigation, Continuous = continual investigation.</param>
    Public Sub Investigate(ByVal Value As Investigate_Enum)
        If Value = Sherlock_NET.Investigate_Enum.Continuous Then
            nErr = HSherlock.InvModeSet(I_MODE.I_EXE_MODE_CONT)
        ElseIf Value = Sherlock_NET.Investigate_Enum.Once Then
            nErr = HSherlock.InvModeSet(I_MODE.I_EXE_MODE_ONCE)
        End If
    End Sub


    ''' <summary>
    ''' Run the calibration on the camera.
    ''' </summary>
    Public Sub Calibration()
        nErr = HSherlock.InvModeSet(I_MODE.I_EXE_MODE_HALT_AFTER_ITERATION)
        nErr = HSherlock.InvModeWaitForHalt
        nErr = HSherlock.InvModeSet(I_MODE.I_EXE_MODE_CALIB)
    End Sub


End Class