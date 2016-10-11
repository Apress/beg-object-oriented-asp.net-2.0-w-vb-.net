<%@ Page Language="VB" AutoEventWireup="false" CodeFile="AddTicket.aspx.vb" Inherits="AddTicket" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblCategory" runat="server" Style="z-index: 100; left: 376px; position: absolute;
            top: 160px" Text="Category"></asp:Label>
        <asp:Label ID="lblFirstName" runat="server" Style="z-index: 101; left: 40px; position: absolute;
            top: 120px" Text="First Name"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" Style="z-index: 102; left: 40px; position: absolute;
            top: 152px" Text="Last Name"></asp:Label>
        <asp:Label ID="lblPhoneNumber" runat="server" Style="z-index: 103; left: 40px; position: absolute;
            top: 184px" Text="Phone Number"></asp:Label>
        <asp:Label ID="lblProblemDescription" runat="server" Style="z-index: 104; left: 40px;
            position: absolute; top: 216px" Text="Problem Description"></asp:Label>
        <asp:Label ID="lblLocation" runat="server" Style="z-index: 105; left: 376px; position: absolute;
            top: 96px" Text="Location"></asp:Label>
        <asp:Label ID="lblEmailAddress" runat="server" Style="z-index: 106; left: 376px;
            position: absolute; top: 128px" Text="Email Address"></asp:Label>
        <asp:Label ID="lblUserLogin" runat="server" Style="z-index: 107; left: 40px; position: absolute;
            top: 88px" Text="User Login"></asp:Label>
        <asp:TextBox ID="txtUserLogin" runat="server" Style="z-index: 108; left: 144px; position: absolute;
            top: 88px" Width="96px"></asp:TextBox>
        <asp:TextBox ID="txtFirstName" runat="server" Style="z-index: 109; left: 144px; position: absolute;
            top: 120px"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" Style="z-index: 110; left: 144px; position: absolute;
            top: 152px"></asp:TextBox>
        <asp:TextBox ID="txtPhoneNumber" runat="server" Style="z-index: 111; left: 144px;
            position: absolute; top: 184px"></asp:TextBox>
        <asp:TextBox ID="txtProblemDescription" runat="server" Style="z-index: 112; left: 176px;
            position: absolute; top: 216px" Width="608px"></asp:TextBox>
        <asp:TextBox ID="txtLocation" runat="server" Style="z-index: 113; left: 440px; position: absolute;
            top: 96px"></asp:TextBox>
        <asp:TextBox ID="txtEmailAddress" runat="server" Style="z-index: 114; left: 480px;
            position: absolute; top: 128px"></asp:TextBox>
        <asp:TextBox ID="txtCategory" runat="server" Style="z-index: 115; left: 440px; position: absolute;
            top: 160px"></asp:TextBox>
        <asp:Button ID="btnSave" runat="server" Style="z-index: 116; left: 160px; position: absolute;
            top: 264px" Text="Save" />
        <asp:Button ID="btnCancel" runat="server" Style="z-index: 117; left: 312px; position: absolute;
            top: 264px" Text="Cancel" />
        <asp:Label ID="lblStatus" runat="server" Height="64px" Style="z-index: 119; left: 160px;
            position: absolute; top: 16px" Width="600px"></asp:Label>
    
    </div>
    </form>
</body>
</html>
