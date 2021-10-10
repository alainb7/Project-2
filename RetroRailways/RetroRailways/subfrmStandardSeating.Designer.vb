<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subfrmStandardSeating
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.txtNameStandard = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSeatsLeft = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnReserve = New System.Windows.Forms.Button()
        Me.errPStandard = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.errPStandard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNameStandard
        '
        Me.txtNameStandard.Location = New System.Drawing.Point(237, 24)
        Me.txtNameStandard.Name = "txtNameStandard"
        Me.txtNameStandard.Size = New System.Drawing.Size(194, 20)
        Me.txtNameStandard.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 35)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter Passenger Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Number of Seats Left:"
        '
        'lblSeatsLeft
        '
        Me.lblSeatsLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeatsLeft.Location = New System.Drawing.Point(237, 68)
        Me.lblSeatsLeft.Name = "lblSeatsLeft"
        Me.lblSeatsLeft.Size = New System.Drawing.Size(194, 20)
        Me.lblSeatsLeft.TabIndex = 6
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(325, 247)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnReserve
        '
        Me.btnReserve.Location = New System.Drawing.Point(84, 247)
        Me.btnReserve.Name = "btnReserve"
        Me.btnReserve.Size = New System.Drawing.Size(75, 23)
        Me.btnReserve.TabIndex = 7
        Me.btnReserve.Text = "Book Seat"
        Me.btnReserve.UseVisualStyleBackColor = True
        '
        'errPStandard
        '
        Me.errPStandard.ContainerControl = Me
        '
        'subfrmStandardSeating
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnReserve)
        Me.Controls.Add(Me.lblSeatsLeft)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNameStandard)
        Me.Controls.Add(Me.Label1)
        Me.Name = "subfrmStandardSeating"
        Me.Size = New System.Drawing.Size(482, 321)
        CType(Me.errPStandard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNameStandard As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSeatsLeft As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnReserve As Button
    Friend WithEvents errPStandard As ErrorProvider
End Class
