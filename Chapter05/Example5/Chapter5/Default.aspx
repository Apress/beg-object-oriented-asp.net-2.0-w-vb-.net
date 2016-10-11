<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblCalculateSalary" runat="server" Style="z-index: 100; left: 145px; position: absolute;
            top: 64px" Text="Calculate Salary"></asp:Label>
        <asp:Label ID="lblSalary" runat="server" Style="z-index: 101; left: 146px; position: absolute;
            top: 37px" Text="Salary"></asp:Label>
        <asp:TextBox ID="txtSalary" runat="server" Style="z-index: 102; left: 249px; position: absolute;
            top: 33px" Width="122px"></asp:TextBox>
        <asp:TextBox ID="txtCalculateSalary" runat="server" Style="z-index: 103; left: 249px; position: absolute;
            top: 61px" Width="121px"></asp:TextBox>
        &nbsp;
        <asp:Button ID="btnCalculate" runat="server" Style="z-index: 104; left: 218px; position: absolute;
            top: 95px" Text="Calculate" />
        <asp:Label ID="lblCalculateHourly" runat="server" Style="z-index: 105; left: 144px;
            position: absolute; top: 207px" Text="Calculate Hourly"></asp:Label>
        <asp:Label ID="lblHours" runat="server" Style="z-index: 106; left: 144px; position: absolute;
            top: 135px" Text="Hours"></asp:Label>
        <asp:TextBox ID="txtHours" runat="server" Style="z-index: 107; left: 248px; position: absolute;
            top: 134px" Width="122px"></asp:TextBox>
        <asp:TextBox ID="txtRate" runat="server" Style="z-index: 108; left: 250px; position: absolute;
            top: 169px" Width="121px"></asp:TextBox>
        <asp:Label ID="lblRate" runat="server" Style="z-index: 109; left: 143px; position: absolute;
            top: 168px" Text="Rate"></asp:Label>
        <asp:TextBox ID="txtCalculateHourly" runat="server" Style="z-index: 111; left: 250px; position: absolute;
            top: 201px" Width="121px"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
