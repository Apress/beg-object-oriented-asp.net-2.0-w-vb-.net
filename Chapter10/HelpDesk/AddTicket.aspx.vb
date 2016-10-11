
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
            clsTicket.Location = CInt(DDLocation.SelectedValue)
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
    Private Sub AddItem()
        Dim NItem As New ListItem
        NItem.Text = "Select a Location"
        NItem.Value = "999"
        NItem.Selected = True
        DDLocation.Items.Add(NItem)
    End Sub
    Private Sub ClearValues()
        txtUserLogin.Text = String.Empty
        txtFirstName.Text = String.Empty
        txtLastName.Text = String.Empty
        txtPhoneNumber.Text = String.Empty
        'txtLocation.Text = String.Empty
        txtEmailAddress.Text = String.Empty
        txtCategory.Text = String.Empty
        txtProblemDescription.Text = String.Empty

    End Sub

    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ClearValues()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim wsUserInformation As New UserInformation.UserInformation
        txtUserLogin.Text = Session("UserLogin").ToString
        txtFirstName.Text = wsUserInformation.GetFirstName(Session("UserLogin").ToString)
        txtLastName.Text = wsUserInformation.GetLastName(Session("UserLogin").ToString)
        txtPhoneNumber.Text = wsUserInformation.GetPhoneNumber(Session("UserLogin").ToString)
        txtEmailAddress.Text = wsUserInformation.GetEmailAddress(Session("UserLogin").ToString)

        AddItem()
        Dim intLocation As Integer
        intLocation = wsUserInformation.GetLocation(Session("UserLogin").ToString)
        If intLocation > 0 Then
            DDLocation.SelectedValue = DDLocation.Items.FindByValue(intLocation.ToString).Value
        Else
            DDLocation.SelectedValue = "999"
        End If
    End Sub
End Class
