'Name: Alain Berard
'Date: 3/7/2021
'I affirm that this program was created by Me. 
'It Is solely my work And does Not include any work done by anyone Else.

Public Class subfrmClubSeating
    'initialze the custom event for the subform
    Public Delegate Sub SaveEvent()
    Public Event SavePassenger As SaveEvent


    Public strSeatNumber As String
    Public strName As String
    Private arrChkClub(7) As CheckBox 'initializes the checkbox array
    Private blnSeatPicked As Boolean = False

    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click
        Dim i As Integer
        strName = txtNameClub.Text

        'error handling for the subform
        If strName = "" Then
            errPClub.SetError(txtNameClub, "You must enter a name")
            Exit Sub
        End If
        If blnSeatPicked = False Then
            errPClub.SetError(grpClubSeatingChart, "You must enter a seat.")
            Exit Sub
        End If

        'this logic says if the checkbox is checked, uncheck it and disable the checkbox so it can't be picked again
        For i = 0 To arrChkClub.Length - 1
            If arrChkClub(i).Checked = True Then
                arrChkClub(i).Enabled = False
                arrChkClub(i).Checked = False
            End If
        Next
        txtNameClub.Clear()
        errPClub.Clear()
        RaiseEvent SavePassenger() 'raises the custom event

    End Sub

    Private Sub subfrmClubSeating_Load(sender As Object, e As EventArgs) Handles Me.Load

        'loads the checkboxes into an array
        arrChkClub(0) = chkA1
        arrChkClub(1) = chkA2
        arrChkClub(2) = chkA3
        arrChkClub(3) = chkA4
        arrChkClub(4) = chkB1
        arrChkClub(5) = chkB2
        arrChkClub(6) = chkB3
        arrChkClub(7) = chkB4

    End Sub

    'this checks to see if the checkbox has been checked, grabs the text from the checkbox and marks the seat picked switch for the error handling
    Private Sub chkBoxes_CheckedChanged(sender As Object, e As EventArgs) Handles chkA1.CheckedChanged, chkA2.CheckedChanged, chkA3.CheckedChanged, chkA4.CheckedChanged, chkB1.CheckedChanged, chkB2.CheckedChanged, chkB3.CheckedChanged, chkB4.CheckedChanged
        Dim chk As CheckBox
        chk = DirectCast(sender, CheckBox)
        strSeatNumber = chk.Text
        blnSeatPicked = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtNameClub.Clear()
        For i = 0 To arrChkClub.Length - 1
            If arrChkClub(i).Checked = True Then
                arrChkClub(i).Checked = False
            End If
        Next
    End Sub
End Class
