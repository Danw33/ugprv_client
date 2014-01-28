<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ASI1 = New ugprv_ui_elements.AirSpeedIndicatorInstrumentControl()
        Me.ALT1 = New ugprv_ui_elements.AltimeterInstrumentControl()
        Me.AAI1 = New ugprv_ui_elements.AttitudeIndicatorInstrumentControl()
        Me.HDG1 = New ugprv_ui_elements.HeadingIndicatorInstrumentControl()
        Me.TCI1 = New ugprv_ui_elements.TurnCoordinatorInstrumentControl()
        Me.VSI1 = New ugprv_ui_elements.VerticalSpeedIndicatorInstrumentControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown5 = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ASI1
        '
        Me.ASI1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ASI1.Location = New System.Drawing.Point(380, 523)
        Me.ASI1.Name = "ASI1"
        Me.ASI1.Size = New System.Drawing.Size(148, 149)
        Me.ASI1.TabIndex = 0
        Me.ASI1.Text = "AirSpeedIndicatorInstrumentControl1"
        '
        'ALT1
        '
        Me.ALT1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ALT1.Location = New System.Drawing.Point(748, 523)
        Me.ALT1.Name = "ALT1"
        Me.ALT1.Size = New System.Drawing.Size(148, 149)
        Me.ALT1.TabIndex = 1
        Me.ALT1.Text = "AltimeterInstrumentControl1"
        '
        'AAI1
        '
        Me.AAI1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.AAI1.Location = New System.Drawing.Point(534, 463)
        Me.AAI1.Name = "AAI1"
        Me.AAI1.Size = New System.Drawing.Size(208, 209)
        Me.AAI1.TabIndex = 2
        Me.AAI1.Text = "AttitudeIndicatorInstrumentControl1"
        '
        'HDG1
        '
        Me.HDG1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HDG1.Location = New System.Drawing.Point(1077, 12)
        Me.HDG1.Name = "HDG1"
        Me.HDG1.Size = New System.Drawing.Size(122, 120)
        Me.HDG1.TabIndex = 3
        Me.HDG1.Text = "HeadingIndicatorInstrumentControl1"
        '
        'TCI1
        '
        Me.TCI1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TCI1.Location = New System.Drawing.Point(902, 523)
        Me.TCI1.Name = "TCI1"
        Me.TCI1.Size = New System.Drawing.Size(148, 149)
        Me.TCI1.TabIndex = 4
        Me.TCI1.Text = "TurnCoordinatorInstrumentControl1"
        '
        'VSI1
        '
        Me.VSI1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.VSI1.Location = New System.Drawing.Point(226, 523)
        Me.VSI1.Name = "VSI1"
        Me.VSI1.Size = New System.Drawing.Size(148, 149)
        Me.VSI1.TabIndex = 5
        Me.VSI1.Text = "VerticalSpeedIndicatorInstrumentControl1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.ugprv_client.My.Resources.Resources.Runway
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1211, 684)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "A/V FEED: Nose Camera"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.NumericUpDown5)
        Me.Panel1.Controls.Add(Me.NumericUpDown4)
        Me.Panel1.Controls.Add(Me.NumericUpDown3)
        Me.Panel1.Controls.Add(Me.NumericUpDown2)
        Me.Panel1.Controls.Add(Me.NumericUpDown1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(15, 497)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(192, 168)
        Me.Panel1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Controls Debug"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Altitude:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Speed:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Attitude:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Heading:"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Location = New System.Drawing.Point(74, 25)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {8000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(91, 20)
        Me.NumericUpDown1.TabIndex = 5
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(74, 51)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(91, 20)
        Me.NumericUpDown2.TabIndex = 6
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(74, 77)
        Me.NumericUpDown3.Maximum = New Decimal(New Integer() {800, 0, 0, 0})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(91, 20)
        Me.NumericUpDown3.TabIndex = 7
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.Location = New System.Drawing.Point(74, 103)
        Me.NumericUpDown4.Maximum = New Decimal(New Integer() {359, 0, 0, 0})
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(91, 20)
        Me.NumericUpDown4.TabIndex = 8
        '
        'NumericUpDown5
        '
        Me.NumericUpDown5.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown5.Location = New System.Drawing.Point(74, 129)
        Me.NumericUpDown5.Name = "NumericUpDown5"
        Me.NumericUpDown5.Size = New System.Drawing.Size(91, 20)
        Me.NumericUpDown5.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Roll:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1211, 684)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.VSI1)
        Me.Controls.Add(Me.TCI1)
        Me.Controls.Add(Me.HDG1)
        Me.Controls.Add(Me.AAI1)
        Me.Controls.Add(Me.ALT1)
        Me.Controls.Add(Me.ASI1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "U-GPRV Control Software"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ASI1 As ugprv_ui_elements.AirSpeedIndicatorInstrumentControl
    Friend WithEvents ALT1 As ugprv_ui_elements.AltimeterInstrumentControl
    Friend WithEvents AAI1 As ugprv_ui_elements.AttitudeIndicatorInstrumentControl
    Friend WithEvents HDG1 As ugprv_ui_elements.HeadingIndicatorInstrumentControl
    Friend WithEvents TCI1 As ugprv_ui_elements.TurnCoordinatorInstrumentControl
    Friend WithEvents VSI1 As ugprv_ui_elements.VerticalSpeedIndicatorInstrumentControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents NumericUpDown4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown5 As System.Windows.Forms.NumericUpDown

End Class
