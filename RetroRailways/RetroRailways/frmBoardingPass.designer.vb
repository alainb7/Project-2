<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBoardingPass
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
        Me.lblBoardingPass = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPassName = New System.Windows.Forms.Label()
        Me.lblPassSeat = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBoardingPass
        '
        Me.lblBoardingPass.BackColor = System.Drawing.Color.White
        Me.lblBoardingPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBoardingPass.Location = New System.Drawing.Point(16, 15)
        Me.lblBoardingPass.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBoardingPass.Name = "lblBoardingPass"
        Me.lblBoardingPass.Size = New System.Drawing.Size(591, 199)
        Me.lblBoardingPass.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(551, 244)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(56, 19)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 44)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Retro Railways Boarding Pass"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Passenger Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Seat Number:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RetroRailways.My.Resources.Resources.frame
        Me.PictureBox1.Location = New System.Drawing.Point(415, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'lblPassName
        '
        Me.lblPassName.Location = New System.Drawing.Point(200, 93)
        Me.lblPassName.Name = "lblPassName"
        Me.lblPassName.Size = New System.Drawing.Size(100, 13)
        Me.lblPassName.TabIndex = 6
        '
        'lblPassSeat
        '
        Me.lblPassSeat.Location = New System.Drawing.Point(200, 125)
        Me.lblPassSeat.Name = "lblPassSeat"
        Me.lblPassSeat.Size = New System.Drawing.Size(100, 13)
        Me.lblPassSeat.TabIndex = 7
        '
        'frmBoardingPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 294)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblPassSeat)
        Me.Controls.Add(Me.lblPassName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblBoardingPass)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmBoardingPass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Boarding Pass"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBoardingPass As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPassName As Label
    Friend WithEvents lblPassSeat As Label
End Class
