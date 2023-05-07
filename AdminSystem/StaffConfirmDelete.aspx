<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblDelete" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 10px; top: 69px; position: absolute" Text="Yes" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 64px; top: 69px; position: absolute" Text="No" />
        </div>
    </form>
</body>
</html>
