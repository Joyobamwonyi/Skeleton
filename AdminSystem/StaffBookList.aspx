<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffBookList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStaffs" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 450px; width: 500px;"></asp:ListBox>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 30px; top: 477px; position: absolute" Text="Add" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 109px; top: 477px; position: absolute" Text="Edit" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; top: 473px; position: absolute; left: 210px;" Text="Delete" />
        </p>
        <p>
            <asp:Label ID="lblEnter" runat="server" style="z-index: 1; left: 10px; top: 523px; position: absolute; right: 1122px;">Enter a salary</asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 148px; top: 521px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 10px; top: 567px; position: absolute" Text="Apply" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 100px; top: 567px; position: absolute" Text="Clear" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 613px; position: absolute"></asp:Label>
        </p>
    </form>
</body>
</html>
