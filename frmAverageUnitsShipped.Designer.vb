<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShipped
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
        Me.components = New System.ComponentModel.Container()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.AverageUnitsShippedToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.tbUnitInput = New System.Windows.Forms.TextBox()
        Me.lbAverageOutput = New System.Windows.Forms.Label()
        Me.tbEntryDisplay = New System.Windows.Forms.TextBox()
        Me.lbUnits = New System.Windows.Forms.Label()
        Me.lbDayCounter = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(12, 242)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 5
        Me.btnEnter.Text = "&Enter"
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.btnEnter, "Enter the number for this day")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(197, 242)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.btnExit, "Exit the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(104, 242)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "&Reset"
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.btnReset, "Reset the enter program")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'tbUnitInput
        '
        Me.tbUnitInput.Location = New System.Drawing.Point(104, 25)
        Me.tbUnitInput.Name = "tbUnitInput"
        Me.tbUnitInput.Size = New System.Drawing.Size(75, 20)
        Me.tbUnitInput.TabIndex = 1
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.tbUnitInput, "Enter a number for this day")
        '
        'lbAverageOutput
        '
        Me.lbAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAverageOutput.Location = New System.Drawing.Point(65, 216)
        Me.lbAverageOutput.Name = "lbAverageOutput"
        Me.lbAverageOutput.Size = New System.Drawing.Size(160, 23)
        Me.lbAverageOutput.TabIndex = 4
        Me.lbAverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.lbAverageOutput, "Will output the average units after 7 days")
        '
        'tbEntryDisplay
        '
        Me.tbEntryDisplay.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbEntryDisplay.Location = New System.Drawing.Point(65, 72)
        Me.tbEntryDisplay.Multiline = True
        Me.tbEntryDisplay.Name = "tbEntryDisplay"
        Me.tbEntryDisplay.ReadOnly = True
        Me.tbEntryDisplay.Size = New System.Drawing.Size(160, 127)
        Me.tbEntryDisplay.TabIndex = 3
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.tbEntryDisplay, "Will display entries")
        '
        'lbUnits
        '
        Me.lbUnits.Location = New System.Drawing.Point(12, 25)
        Me.lbUnits.Name = "lbUnits"
        Me.lbUnits.Size = New System.Drawing.Size(75, 23)
        Me.lbUnits.TabIndex = 0
        Me.lbUnits.Text = "&Units:"
        Me.lbUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.lbUnits, "How many units were sold today?")
        '
        'lbDayCounter
        '
        Me.lbDayCounter.AutoSize = True
        Me.lbDayCounter.Location = New System.Drawing.Point(194, 30)
        Me.lbDayCounter.Name = "lbDayCounter"
        Me.lbDayCounter.Size = New System.Drawing.Size(35, 13)
        Me.lbDayCounter.TabIndex = 2
        Me.lbDayCounter.Text = "Day 1"
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.lbDayCounter, "Displays the current day")
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(284, 277)
        Me.Controls.Add(Me.lbDayCounter)
        Me.Controls.Add(Me.tbEntryDisplay)
        Me.Controls.Add(Me.lbAverageOutput)
        Me.Controls.Add(Me.tbUnitInput)
        Me.Controls.Add(Me.lbUnits)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnter)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.AverageUnitsShippedToolTip.SetToolTip(Me, "Enter 7 numbers for each day of the week and the program will display the average" &
        " of those numbers")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents AverageUnitsShippedToolTip As ToolTip
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lbUnits As Label
    Friend WithEvents tbUnitInput As TextBox
    Friend WithEvents lbAverageOutput As Label
    Friend WithEvents tbEntryDisplay As TextBox
    Friend WithEvents lbDayCounter As Label
End Class
