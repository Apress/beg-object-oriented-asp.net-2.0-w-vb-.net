<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblFirst" runat="server" Style="z-index: 100; left: 144px; position: absolute;
            top: 32px" Text="First" Width="64px"></asp:Label>
        <asp:Label ID="lblsecond" runat="server" Style="z-index: 101; left: 144px; position: absolute;
            top: 64px" Text="Second" Width="64px"></asp:Label>
        <asp:Label ID="lblAnswer" runat="server" Style="z-index: 102; left: 144px; position: absolute;
            top: 96px" Text="Answer" Width="64px"></asp:Label>
        <asp:TextBox ID="txtFirst" runat="server" Style="z-index: 103; left: 216px; position: absolute;
            top: 32px"></asp:TextBox>
        <asp:TextBox ID="txtSecond" runat="server" Style="z-index: 104; left: 216px; position: absolute;
            top: 64px"></asp:TextBox>
        <asp:TextBox ID="txtThird" runat="server" Style="z-index: 105; left: 216px; position: absolute;
            top: 96px"></asp:TextBox>
        <asp:Button ID="btnAddIntegers" runat="server" Style="z-index: 106; left: 144px;
            position: absolute; top: 128px" Text="Add Integers" />
        <asp:Button ID="btnMultiplyDecimals" runat="server" Style="z-index: 107; left: 288px; position: absolute;
            top: 160px" Text="Multiply Decimals" />
        <asp:Button ID="btnAddDecimals" runat="server" Style="z-index: 108; left: 144px;
            position: absolute; top: 160px" Text="Add Decimals" />
        <asp:Button ID="btnMultiplyIntegers" runat="server" Height="24px" Style="z-index: 110;
            left: 288px; position: absolute; top: 128px" Text="Multiply Integers" />
    
    </div>
    </form>
</body>
</html>
