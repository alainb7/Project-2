'Name: Alain Berard
'Date: 3/7/2021
'I affirm that this program was created by Me. 
'It Is solely my work And does Not include any work done by anyone Else.

Public Class frmMain

    'subforms and boarding pass form initializations 
    Private WithEvents Welcome As subfrmWelcome
    Private WithEvents StandardSeatingChart As subfrmStandardSeating
    Private WithEvents ClubSeatingChart As subfrmClubSeating
    Private BoardingPass As frmBoardingPass

    'variables used
    Private intStandardCounter As Integer
    Private intClubCounter As Integer
    Private strName As String
    Private blnStandardSeating As Boolean = False
    Private blnClubSeating As Boolean = False
    Private intSeatsLeft As Integer = 16
    Private strSeat As String

    'array to hold subforms
    Private arrSubForms As ArrayList

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        arrSubForms = New ArrayList
        Welcome = New subfrmWelcome
        StandardSeatingChart = New subfrmStandardSeating
        ClubSeatingChart = New subfrmClubSeating

        'adds subforms to array
        arrSubForms.Add(Welcome)
        arrSubForms.Add(StandardSeatingChart)
        arrSubForms.Add(ClubSeatingChart)

        'allows subforms to appear in the work area in the middle of the program
        grpWorkArea.Controls.Add(Welcome)
        grpWorkArea.Controls.Add(StandardSeatingChart)
        grpWorkArea.Controls.Add(ClubSeatingChart)

        'calculates positioning of the subforms in the workarea
        Welcome.Location = CalcLocation(grpWorkArea, Welcome)
        StandardSeatingChart.Location = CalcLocation(grpWorkArea, StandardSeatingChart)
        ClubSeatingChart.Location = CalcLocation(grpWorkArea, ClubSeatingChart)

        Welcome.Visible = True
    End Sub

    Private Sub btnStandard_Click(sender As Object, e As EventArgs) Handles btnStandard.Click

        'checks to see if the standard car is full. Also checks to see if the entire train is full
        If intStandardCounter = 16 Then
            MessageBox.Show("Sorry, the club train is full. Please select a seat in the club car to continue.", "Car is Full", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        If intStandardCounter = 16 And intClubCounter = 8 Then
            MessageBox.Show("The train is completely booked. Please start a new session to continue.", "Car is Full", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'sets the switch to true for the standard seating
        blnStandardSeating = True
        blnClubSeating = False

        'sets count of current seats available in the car
        StandardSeatingChart.lblSeatsLeft.Text = intSeatsLeft

        'hides the other subforms and shows the standard seating subform
        ClubSeatingChart.Visible = False
        Welcome.Visible = False
        StandardSeatingChart.Visible = True
    End Sub

    Private Sub btnClub_Click(sender As Object, e As EventArgs) Handles btnClub.Click

        'checks to see if the club car is full. If it is, it tells the user to check the standard car
        If intClubCounter = 8 Then
            MessageBox.Show("Sorry, the club train is full. Please select a seat in the standard car to continue.", "Car is Full", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If intClubCounter = 8 And intStandardCounter = 16 Then
            MessageBox.Show("The train is completely booked. Please start a new session to continue.", "Car is Full", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'sets the club seating switch to true
        blnClubSeating = True
        blnStandardSeating = False

        'hides other subforms and shows the club seating one
        Welcome.Visible = False
        StandardSeatingChart.Visible = False
        ClubSeatingChart.Visible = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub


    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click
        'creates the summary for the managers in the stats screen when the button is clicked
        Dim strMessage As String
        strMessage = "Total Seats Reserved:" & vbCrLf
        strMessage &= vbCrLf
        strMessage &= "Standard Seats: " & intStandardCounter & vbCrLf
        strMessage &= "Club Seating: " & intClubCounter & vbCrLf
        MessageBox.Show(strMessage)
    End Sub

    'calculates optimal position for the subform inside the work area
    Private Function CalcLocation(grpbox As GroupBox, subForm As UserControl) As Point
        Return New Point((grpbox.Width - subForm.Width) / 2, (grpbox.Height - subForm.Height) / 2)
    End Function

    'handles the custom event to pass the passenger info from the different subforms
    Private Sub SendToBoardingPass() Handles ClubSeatingChart.SavePassenger, StandardSeatingChart.SavePassenger
        BoardingPass = New frmBoardingPass

        'checks the switch
        Select Case blnClubSeating
            Case True 'logic for the club seating subform
                intClubCounter += 1
                BoardingPass.lblPassName.Text = ClubSeatingChart.strName
                BoardingPass.lblPassSeat.Text = ClubSeatingChart.strSeatNumber

            Case False 'logic for the standard seating subform
                intStandardCounter += 1
                intSeatsLeft += -1
                BoardingPass.lblPassName.Text = StandardSeatingChart.strName
                BoardingPass.lblPassSeat.Text = StandardSeatingChart.strSeat
        End Select

        'displays the boarding pass when the button is clicked and hides the subforms. Brings the program back to the welcome subform
        BoardingPass.ShowDialog()
        ClubSeatingChart.Visible = False
        StandardSeatingChart.Visible = False
        Welcome.Visible = True
    End Sub
End Class
