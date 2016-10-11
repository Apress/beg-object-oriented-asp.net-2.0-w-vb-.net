<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblExecutive" runat="server" Style="z-index: 100; left: 145px; position: absolute;
            top: 64px" Text="Executive"></asp:Label>
        <asp:Label ID="lblSalaried" runat="server" Style="z-index: 101; left: 146px; position: absolute;
            top: 37px" Text="Salaried"></asp:Label>
        <asp:TextBox ID="txtsalaried" runat="server" Style="z-index: 102; left: 217px; position: absolute;
            top: 32px" Width="365px"></asp:TextBox>
        <asp:TextBox ID="txtexecutive" runat="server" Style="z-index: 103; left: 219px; position: absolute;
            top: 65px" Width="365px"></asp:TextBox>
        <asp:Button ID="btnExecutive" runat="server" Style="z-index: 104; left: 611px; position: absolute;
            top: 66px" Text="Executive" />
        <asp:Button ID="btnSalaried" runat="server" Style="z-index: 106; left: 608px; position: absolute;
            top: 29px" Text="Salaried" />
    
    </div>
    </form>
</body>
</html>
