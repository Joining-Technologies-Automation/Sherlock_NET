Imports IpeEngCtrlLib


''' <summary>
''' 
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
    ''' Load the investigation into sherlock. Start investigation.
    ''' </summary>
    ''' <param name="filepath"></param>
    Public Sub LoadInvestigation(ByVal filepath As String)
        nErr = hSherlock.InvModeSet(I_MODE.I_EXE_MODE_HALT_AFTER_ITERATION)
        nErr = hSherlock.InvModeWaitForHalt 'trying something new.
        nErr = hSherlock.InvLoad(filepath)
        If nErr <> I_ENG_ERROR.I_OK Then Throw New ApplicationException("Error loading " + filepath + " into sherlock.")
        nErr = hSherlock.InvModeSet(I_MODE.I_EXE_MODE_CONT)
        Console.WriteLine(TimeString + " Loaded investigation: " + filepath) 'feedback.
    End Sub

    Public Sub CloseSherlock()
        hSherlock.EngTerminate()
    End Sub

End Class