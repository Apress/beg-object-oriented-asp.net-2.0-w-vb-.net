
Partial Class AddTicket
    Inherits System.Web.UI.Page
    Private clsTicket As Ticket

    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            clsTicket = New Ticket
            clsTicket.UserLoginName = Trim(txtUserLogin.Text)
            clsTicket.FirstName = Trim(txtFirstName.Text)
            clsTicket.LastName = Trim(txtLastName.Text)
            clsTicket.PhoneNumber = Trim(txtPhoneNumber.Text)
            clsTicket.Location = Trim(txtLocation.Text)
            clsTicket.EmailAddress = Trim(txtEmailAddress.Text)
            clsTicket.Category = Trim(txtCategory.Text)
            clsTicket.ProblemDescription = Trim(txtProblemDescription.Text)
            If clsTicket.NewTicket Then
                lblStatus.Text = "Ticket Added. Ticket Number is " & clsTicket.TicketID
            Else
                lblStatus.Text = "Ticket was not added"
            End If
        Catch ex As Exception
            lblStatus.Text = ex.ToString
        End Try
    End Sub

    Private Sub ClearValues()
        txtUserLogin.Text = String.Empty
        txtFirstName.Text = String.Empty
        txtLastName.Text = String.Empty
        txtPhoneNumber.Text = String.Empty
        txtLocation.Text = String.Empty
        txtEmailAddress.Text = String.Empty
        txtCategory.Text = String.Empty
        txtProblemDescription.Text = String.Empty

    End Sub

    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ClearValues()
    End Sub
End Class
