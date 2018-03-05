'''Author:                  Omar Dargazli, 100662836
'''Date:                    February 7, 2017
'''Program:                 AverageUnitsShipped
'''Description:             Form will take 7 days of user input and return
'''                         the average of the units entered

Public Class frmAverageUnitsShipped
    'Constant Declarations
    Const unitMaximum As Integer = 1000     'This is the upper boundary of the valid range
    Const unitMinimum As Integer = 0        'This is the lower boundary of the valid range
    Const daysOfWeek As Integer = 6         'This is the upper boundary of the week


    'Variable Declarations
    Dim unitInput As String = String.Empty  'Holding the unit as a string
    Dim unitInputValid As Integer = 0       'Holds the unit after it has been validated
    Dim unitArray(6) As Integer             'Array will contain the units entered by the user
    Dim dayCounter As Integer = 0           'Counter to display the days and keep track of units entered
    Dim totalUnits As Integer = 0           'Holds the total amount of units added and the average of the units


    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        If Not (dayCounter > daysOfWeek) Then                                                                   'Checking to see that the dayCounter does not exceed the amount of days

            If (dayCounter <= daysOfWeek) Then                                                                  'Checking to see that the dayCounter is within valid range
                unitInput = tbUnitInput.Text                                                                    'Get the input from the textbox

                If Not Integer.TryParse(unitInput, unitInputValid) Then                                         'Checking to see that the input is a number
                    MessageBox.Show("Please ensure you enter a number for units shipped!")                      'Display error message
                    tbUnitInput.SelectionStart = 0                                                              'Start the selection at the beginning of the textbox
                    tbUnitInput.SelectionLength = tbUnitInput.Text.Length                                       'Select the rest of the text in the textbox

                ElseIf (unitInputValid < unitMinimum OrElse unitInputValid > unitMaximum) Then                  'Checking to see that the input is in range
                    MessageBox.Show("Please ensure you enter a number in range for units shipped!")             'Display error message
                    tbUnitInput.SelectionStart = 0                                                              'Start the selection at the beginning of the textbox
                    tbUnitInput.SelectionLength = tbUnitInput.Text.Length                                       'Select the rest of the text in the texbox
                Else
                    unitArray(dayCounter) = unitInputValid                                                      'Store the unitInput when it's valid in array at the current index defined by dayCounter
                    tbEntryDisplay.Text += unitArray(dayCounter).ToString & vbCrLf                              'Display the input along with past inputs in the textbox

                    dayCounter = dayCounter + 1                                                                 'Counter increment
                    If dayCounter > daysOfWeek Then                                                             'Checking to see if the counter exceeds the days of the week
                        tbUnitInput.ReadOnly = True                                                             'Disable user's ability to enter anything in the textbox
                        btnEnter.Enabled = False                                                                'Disable user's ability to click the accept button


                        For arrayCounter As Integer = unitMinimum To dayCounter - 1                             'For counter to add all units together in the array
                            totalUnits += unitArray(arrayCounter)                                               'Add the element of the array to totalUnits

                        Next
                        totalUnits = Math.Round((totalUnits / unitArray.Length), 2)                             'Caculates the average of the total units
                        lbAverageOutput.Text = "Unit Average for the Week: " + totalUnits.ToString              'Displays the average in the lbAverageOutput label
                    End If
                End If

                tbUnitInput.Text = ""                                                                           'Clears the text for next input
                tbUnitInput.Focus()                                                                             'Focuses on the textbox for next input

                If (dayCounter <= daysOfWeek) Then                                                              'Checking to see the dayCounter does not exceed the days of the week
                    lbDayCounter.Text = "Day " + (dayCounter + 1).ToString                                      'Display the current day in the lbDayCounter
                End If
            End If
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        formReset()                                                                                             'Calls the reset function 
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()                                                                                      'Closes the form
    End Sub
    Private Sub formReset()
        dayCounter = 0                                                                                          'Reset the dayCounter
        totalUnits = 0                                                                                          'Reset the totalUnits
        btnEnter.Enabled = True                                                                                 'Reenable the Enter button
        tbUnitInput.Text = String.Empty                                                                         'Make the unit input textbox empty 
        tbUnitInput.ReadOnly = False                                                                            'Give the user the ability to type in the textbox
        tbUnitInput.Focus()                                                                                     'Focus on the textbox
        tbEntryDisplay.Text = String.Empty                                                                      'Make the entry display textbox empty
        lbAverageOutput.Text = String.Empty                                                                     'Make the average output label empty
        lbDayCounter.Text = "Day 1"                                                                             'Reset the day counter label to the first day
    End Sub
End Class