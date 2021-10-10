'Name: Alain Berard
'Date: 3/7/2021
'I affirm that this program was created by Me. 
'It Is solely my work And does Not include any work done by anyone Else.

Public Class subfrmStandardSeating

    'creates the custom event for the subform
    Public Delegate Sub SaveEvent()
    Public Event SavePassenger As SaveEvent

    'initializes the variables
    Public strName As String
    Public strSeat As String
    Public intSeatsLeft As Integer
    Public intStandardCounter = 0
    Private blnErrors As Boolean = False
    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click
        'sets the name and the seat as unassigned 
        strName = txtNameStandard.Text
        strSeat = "Unassigned Seat"

        txtNameStandard.Clear()

        'error handling
        If strName = "" Then
            errPStandard.SetError(txtNameStandard, "You must enter a name")
            blnErrors = True
            Exit Sub
        End If

        lblSeatsLeft.Text += -1 'subtracts 1 from the existing number of seats
        errPStandard.Clear()
        RaiseEvent SavePassenger() 'raises the event for the custom event

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtNameStandard.Clear()
    End Sub
End Class
