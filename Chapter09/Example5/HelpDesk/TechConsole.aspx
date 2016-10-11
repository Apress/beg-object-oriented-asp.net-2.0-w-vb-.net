<%@ Page Language="VB" AutoEventWireup="false" CodeFile="TechConsole.aspx.vb" Inherits="TechConsole" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
<script language="javascript" type="text/javascript">
<!--

function btnAddNew_onclick() {

}

// -->
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblPageName" runat="server" Style="z-index: 100; left: 360px; position: absolute;
            top: 24px" Text="Technician Console"></asp:Label>
        <asp:Label ID="lblCompanyName" runat="server" Style="z-index: 101; left: 360px; position: absolute;
            top: 48px"></asp:Label>
        <asp:Button ID="btnAdministration" runat="server" Style="z-index: 102; left: 72px; position: absolute;
            top: 88px" Text="Administration" />
        <input id="btnAddNew" style="z-index: 103; left: 72px; position: absolute; top: 120px; width: 120px;"
            type="button" value="New Ticket" language="javascript" onclick="return btnAddNew_onclick()" />
    
    </div>
    </form>
</body>
</html>
