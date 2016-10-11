<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp;
        <asp:Label ID="lblResult" runat="server" Style="z-index: 100; left: 61px; position: absolute;
            top: 50px" Text="Result" Width="75px"></asp:Label>
        <asp:Label ID="lblInBound" runat="server" Style="z-index: 101; left: 61px; position: absolute;
            top: 20px" Text="Inbound" Width="75px"></asp:Label>
        <asp:TextBox ID="txtInbound" runat="server" Style="z-index: 102; left: 142px; position: absolute;
            top: 17px"></asp:TextBox>
        <asp:TextBox ID="txtResult" runat="server" Style="z-index: 103; left: 144px; position: absolute;
            top: 46px"></asp:TextBox>
        <asp:Button ID="btnMultiply" runat="server" Style="z-index: 105; left: 175px; position: absolute;
            top: 79px" Text="Multiply" />
    
    </div>
    </form>
</body>
</html>
