Imports ugprv_ui_elements

Public Class Form1
    Dim roll As Double
    Dim pitch As Double
    Dim altitude As Integer
    Dim speed As Integer
    Dim heading As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        Me.TCI1.SetTurnCoordinatorParameters(CSng(roll), 1)
    End Sub
End Class
