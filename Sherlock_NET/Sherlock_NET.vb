Imports IpeEngCtrlLib
''' <summary>
''' Fill the Sherlock Vars with the Camera names, with the variables being pulled from the investigations etc.
''' </summary>
Module SherlockVars
    ''' <summary>
    ''' Names of the different cameras. 
    ''' Camera names are found in the Sherlock investigations. Image Window instruction. The default camera name is "imgA". 
    ''' </summary>
    Public Structure CamNames
        '
        Const CamName1 As String = "exCamName1"
        Const CamName2 As String = "exCamName2"
        'etc. etc. etc...
    End Structure

#Region "Sherlock Variables"
#Region "Bool"

#End Region
#Region "Point"

#End Region
#Region "Double"

#End Region
#End Region

End Module

''' <summary>
''' Control the Sherlock software.
''' </summary>
Public Class Sherlock_NET
    Friend WithEvents hSherlock As Engine
    Friend nErr As I_ENG_ERROR

    ''' <summary>
    ''' Initializes Sherlock for use.
    ''' </summary>
    Public Sub New()
        hSherlock = New Engine
        nErr = hSherlock.EngInitialize
        Dim x As Integer = 0
        While nErr <> I_ENG_ERROR.I_OK
            If x >= 30 Then Throw New ApplicationException("Sherlock did not initialize.")
            x += 1
        End While
        Console.WriteLine(TimeString + " Successfully initialized Sherlock.")
    End Sub

    ''' <summary>
    ''' Load the investigation into sherlock. Start investigation. ActiveX controlled separately.
    ''' </summary>
    ''' <param name="filepath"></param>
    Public Sub LoadInvestigation(ByVal filepath As String)
        nErr = hSherlock.InvModeSet(I_MODE.I_EXE_MODE_HALT_AFTER_ITERATION) 'stop the current program.
        nErr = hSherlock.InvModeWaitForHalt 'trying something new.
        nErr = hSherlock.InvLoad(filepath)
        If nErr <> I_ENG_ERROR.I_OK Then Throw New ApplicationException("Error loading " + filepath + " into sherlock.")
        nErr = hSherlock.InvModeSet(I_MODE.I_EXE_MODE_CONT)
        Console.WriteLine(TimeString + " Loaded investigation: " + filepath)
    End Sub
    ''' <summary>
    ''' Terminate the Sherlock engine.
    ''' </summary>
    Public Sub CloseSherlock()
        hSherlock.EngTerminate()
    End Sub

End Class