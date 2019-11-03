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
        Me.BTNCalculate = New System.Windows.Forms.Button()
        Me.LBLOutput = New System.Windows.Forms.Label()
        Me.TXTHourInput = New System.Windows.Forms.TextBox()
        Me.LBLOutputTotalMessages = New System.Windows.Forms.Label()
        Me.LBLEnterTime = New System.Windows.Forms.Label()
        Me.LBLProgramName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTNCalculate
        '
        Me.BTNCalculate.Location = New System.Drawing.Point(12, 92)
        Me.BTNCalculate.Name = "BTNCalculate"
        Me.BTNCalculate.Size = New System.Drawing.Size(75, 23)
        Me.BTNCalculate.TabIndex = 0
        Me.BTNCalculate.Text = "Submit"
        Me.BTNCalculate.UseVisualStyleBackColor = True
        '
        'LBLOutput
        '
        Me.LBLOutput.AutoSize = True
        Me.LBLOutput.Location = New System.Drawing.Point(202, 9)
        Me.LBLOutput.Name = "LBLOutput"
        Me.LBLOutput.Size = New System.Drawing.Size(16, 13)
        Me.LBLOutput.TabIndex = 1
        Me.LBLOutput.Text = "..."
        '
        'TXTHourInput
        '
        Me.TXTHourInput.Location = New System.Drawing.Point(12, 53)
        Me.TXTHourInput.Name = "TXTHourInput"
        Me.TXTHourInput.Size = New System.Drawing.Size(100, 20)
        Me.TXTHourInput.TabIndex = 3
        '
        'LBLOutputTotalMessages
        '
        Me.LBLOutputTotalMessages.AutoSize = True
        Me.LBLOutputTotalMessages.Location = New System.Drawing.Point(9, 76)
        Me.LBLOutputTotalMessages.Name = "LBLOutputTotalMessages"
        Me.LBLOutputTotalMessages.Size = New System.Drawing.Size(16, 13)
        Me.LBLOutputTotalMessages.TabIndex = 4
        Me.LBLOutputTotalMessages.Text = "..."
        '
        'LBLEnterTime
        '
        Me.LBLEnterTime.AutoSize = True
        Me.LBLEnterTime.Location = New System.Drawing.Point(9, 37)
        Me.LBLEnterTime.Name = "LBLEnterTime"
        Me.LBLEnterTime.Size = New System.Drawing.Size(103, 13)
        Me.LBLEnterTime.TabIndex = 5
        Me.LBLEnterTime.Text = "Enter Time in Hours:"
        '
        'LBLProgramName
        '
        Me.LBLProgramName.AutoSize = True
        Me.LBLProgramName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLProgramName.Location = New System.Drawing.Point(9, 9)
        Me.LBLProgramName.Name = "LBLProgramName"
        Me.LBLProgramName.Size = New System.Drawing.Size(173, 20)
        Me.LBLProgramName.TabIndex = 6
        Me.LBLProgramName.Text = "Johnny Barnes Loop"
        '
        'Form1
        '
        Me.AcceptButton = Me.BTNCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1247, 845)
        Me.Controls.Add(Me.LBLProgramName)
        Me.Controls.Add(Me.LBLEnterTime)
        Me.Controls.Add(Me.LBLOutputTotalMessages)
        Me.Controls.Add(Me.TXTHourInput)
        Me.Controls.Add(Me.LBLOutput)
        Me.Controls.Add(Me.BTNCalculate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNCalculate As Button
    Friend WithEvents LBLOutput As Label
    Friend WithEvents TXTHourInput As TextBox
    Friend WithEvents LBLOutputTotalMessages As Label
    Friend WithEvents LBLEnterTime As Label
    Friend WithEvents LBLProgramName As Label
End Class
