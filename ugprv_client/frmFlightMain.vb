Imports ugprv_ui_elements
Imports ugprv_hid_connector
Imports ugprv_hid_connector.GamePad
Imports Media

Public Class frmFlightMain
    Protected HIDGamePad As New ugprv_hid_connector.GamePad()
    Protected WithEvents HIDPoll As New System.Windows.Forms.Timer()

    Protected roll, pitch As Double
    Protected altitude, speed, heading As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine("[HID] Initialising HID Support")
        HIDGamePad.Setup(sender, e)

        Debug.WriteLine("[HID] Starting HID Poll Cycle - 5hz")
        HIDPoll.Interval = 10 'HIDPoll.Interval = 200
        HIDPoll.Enabled = True
        HIDPoll.Start()

        Debug.WriteLine("[HID] HID Connector Running!")



        'Camera stream stuff
        Debug.WriteLine("[Media] Configuring RTSP Streaming Client...")
        Dim CamHost As String = "rtsp://127.0.0.1:8554/" '"rtsp://77.68.36.93:5661/Feed"

        Dim CamAURI As String = CStr(CamHost & "")
        Dim CamBURI As String = CStr(CamHost & "B")
        Dim CamCURI As String = CStr(CamHost & "C")

        Dim CamAStream As New Media.Rtsp.RtspClient(CamAURI, Rtsp.RtspClient.ClientProtocolType.Tcp)
        Dim CamBStream As New Media.Rtsp.RtspClient(CamBURI, Rtsp.RtspClient.ClientProtocolType.Reliable)
        Dim CamCStream As New Media.Rtsp.RtspClient(CamCURI, Rtsp.RtspClient.ClientProtocolType.Reliable)

        Debug.WriteLine("[Media] Initiating RTSP Connections...")

        Try
            CamAStream.Connect()
            Debug.WriteLine("[Media] Feed A is ONLINE!")
        Catch ex As Exception
            Debug.WriteLine("[Media] Feed A is OFFLINE! - " & ex.Message)
        End Try


        'Try
        '    CamBStream.Connect()
        '    Debug.WriteLine("[Media] Feed B is ONLINE!")
        'Catch ex As Exception
        '    Debug.WriteLine("[Media] Feed B is OFFLINE! - " & ex.Message)
        'End Try

        'Try
        '    CamCStream.Connect()
        '    Debug.WriteLine("[Media] Feed C is ONLINE!")
        'Catch ex As Exception
        '    Debug.WriteLine("[Media] Feed C is OFFLINE! - " & ex.Message)
        'End Try
    End Sub

    Private Sub HIDPoll_Tick(sender As Object, e As EventArgs) Handles HIDPoll.Tick
        With HIDGamePad
            .Poll(sender, e)
            Debug.WriteLine("[HID] HID Poll Event Completed - X:" & .ActX & ", Y:" & .ActY & ", Z:" & .ActZ & " (RAW - X:" & .PosX & ", Y:" & .PosY & ", Z:" & .PosZ & ", Button Press Count: " & CStr(.ButtonNumber) & ", Buttons: " & CStr(.Buttons) & ")")

            NumericUpDown2.Value = CDec(.ActY / 4) 'Pitch
            NumericUpDown5.Value = CDec((.ActX / 2) * -1) 'Roll
            NumericUpDown3.Value = .Map(.ActZ, 255, 0, 0, 255) 'Throttle
        End With

        Application.DoEvents() 'Prevent App Hang on slower systems
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        altitude = CInt(NumericUpDown1.Value())
        Me.ALT1.SetAlimeterParameters(altitude)
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        pitch = NumericUpDown2.Value()
        Me.AAI1.SetAttitudeIndicatorParameters(pitch, roll)
    End Sub

    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown3.ValueChanged
        speed = CInt(NumericUpDown3.Value())
        Me.ASI1.SetAirSpeedIndicatorParameters(speed)
    End Sub

    Private Sub NumericUpDown4_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown4.ValueChanged
        heading = CInt(NumericUpDown4.Value())
        Me.HDG1.SetHeadingIndicatorParameters(heading)
    End Sub

    Private Sub NumericUpDown5_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown5.ValueChanged
        roll = CInt(NumericUpDown5.Value)
        Me.AAI1.SetAttitudeIndicatorParameters(pitch, roll)

        'Calculate the Absolute Single and "Soften" it to be used for Turn Co-Ordinator
        Dim turnRate = Math.Abs(CSng(roll)) 'Pad the turn rate by a factor of 100
        Dim turnQual = 0 'Math.Abs(turnRate / 10) 'Estimate a Turn Quality

        If CSng(roll) = 0 Then 'Level Flight
            Me.TCI1.SetTurnCoordinatorParameters(0, 0)
            Debug.WriteLine("[ROLL] No Roll (Level Flight)")
        ElseIf CSng(roll) >= 1 Then 'Left Roll
            Me.TCI1.SetTurnCoordinatorParameters((turnRate * -1) / 10, (turnQual * -1)) 'Invert the numbers to make minus numbers
            Debug.WriteLine("[ROLL] Left Roll (Turn Rate: " & turnRate * -1 & ", Turn Quality: " & (turnQual * -1) & ")")
        ElseIf CSng(roll) <= -1 Then 'Right Roll
            Me.TCI1.SetTurnCoordinatorParameters((turnRate) / 10, turnQual) 'Invert the number to make a minus
            Debug.WriteLine("[ROLL] Right Roll (Turn Rate: " & turnRate & ", Turn Quality: " & turnQual & ")")
        Else 'Egg Roll?
            Debug.WriteLine("[ROLL] Egg Roll (Turn Rate: " & turnRate & ", Turn Quality: " & turnQual & ") - That's an Error ;-)")
            Me.TCI1.SetTurnCoordinatorParameters(0, 0)
            Me.TCI1.Enabled = False
        End If

    End Sub
End Class
