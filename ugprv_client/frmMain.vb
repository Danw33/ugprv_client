Imports OpenMFL
Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenMFL.GlassFull.SetGlass(Me, -1, -1, -1, -1)
    End Sub

    Private Sub LaunchTimer_Tick(sender As Object, e As EventArgs) Handles LaunchTimer.Tick
        LaunchTimer.Enabled = False
        LaunchTimer.Stop()
        OpenMFL.Fades.FadeOut(Me)
        Me.Hide()
        frmFlightMain.Show()
        frmFlightMain.Focus()
    End Sub
End Class