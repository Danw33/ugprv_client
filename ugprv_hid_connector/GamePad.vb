Imports System.Runtime.InteropServices

Public Class GamePad
    'Joystick/GamePad DLL
    Protected Declare Function joyGetPosEx Lib "winmm.dll" (ByVal uJoyID As Integer, ByRef pji As JOYINFOEX) As Integer

    'Known Maximum and Minimum Input Values
    Public Const HIDMin As Long = 0
    Public Const HIDMax As Long = 65535

    'Holders for Output Data
    Public PosX, PosY, PosZ, PosR, PosU, PosV, POV As New Integer 'Raw Axis Positions + POV
    Public Buttons, ButtonNumber As String 'Button information
    Public ActX, ActY, ActZ As New Long 'Dan's "Actual" Axis Values - X and Y are -100 to 100, Z is 0 to 255

    <StructLayout(LayoutKind.Sequential)> _
    Protected Structure JOYINFOEX
        Public dwSize As Integer
        Public dwFlags As Integer
        Public dwXpos As Integer
        Public dwYpos As Integer
        Public dwZpos As Integer
        Public dwRpos As Integer
        Public dwUpos As Integer
        Public dwVpos As Integer
        Public dwButtons As Integer
        Public dwButtonNumber As Integer
        Public dwPOV As Integer
        Public dwReserved1 As Integer
        Public dwReserved2 As Integer
    End Structure

    Dim gamepadEX As JOYINFOEX

    Public Sub Poll(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' Get the joystick information
        Call joyGetPosEx(0, gamepadEX)

        With gamepadEX
            Me.PosX = CInt(.dwXpos)          'Up to six axis supported
            Me.PosY = CInt(.dwYpos)
            Me.PosZ = CInt(.dwZpos)
            Me.PosR = CInt(.dwRpos)
            Me.PosU = CInt(.dwUpos)
            Me.PosV = CInt(.dwVpos)
            Me.Buttons = .dwButtons.ToString("X")  'Print in Hex, so can see the individual bits associated with the buttons
            Me.ButtonNumber = .dwButtonNumber.ToString  'number of buttons pressed at the same time
            Me.POV = CInt(CInt(.dwPOV) / 100)    'POV hat (in 1/100ths of degrees, so divided by 100 to give degrees)
        End With

        'Dans Custom Mapping
        Me.ActX = Me.Map(Me.PosX, -100, 100)
        Me.ActY = Me.Map(Me.PosY, -100, 100)
        Me.ActZ = Me.Map(Me.PosZ, 0, 255)
    End Sub

    Public Function Setup(ByVal sender As System.Object, ByVal e As System.EventArgs) As Boolean
        gamepadEX.dwSize = 64
        gamepadEX.dwFlags = &HFF ' All information
        Return True
    End Function

    Public Function Map(ByVal x As Long, out_min As Long, out_max As Long, Optional in_min As Long = HIDMin, Optional in_max As Long = HIDMax) As Long
        Return CLng((x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min)
    End Function
End Class