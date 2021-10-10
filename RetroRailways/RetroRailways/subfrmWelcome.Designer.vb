<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subfrmWelcome
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 100)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome! Select a type of seating to get started."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'subfrmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Name = "subfrmWelcome"
        Me.Size = New System.Drawing.Size(482, 321)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
End Class
