<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStaffNo" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Staff Number"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStaffNo" runat="server" style="z-index: 1; left: 154px; top: 15px; position: absolute"></asp:TextBox>
            <br />
            <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 10px; top: 42px; position: absolute" Text="First Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 154px; top: 42px; position: absolute"></asp:TextBox>
            <br />
            <asp:Label ID="lblSurname" runat="server" style="z-index: 1; left: 10px; top: 69px; position: absolute" Text="Surname"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtSurname" runat="server" style="z-index: 1; left: 154px; top: 69px; position: absolute"></asp:TextBox>
            <br />
            <asp:Label ID="lblBirthday" runat="server" style="z-index: 1; left: 10px; top: 96px; position: absolute" Text="Birthday"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtBirthday" runat="server" style="z-index: 1; left: 154px; top: 96px; position: absolute"></asp:TextBox>
            <br />
            <asp:Label ID="lblSalary" runat="server" style="z-index: 1; left: 10px; top: 123px; position: absolute" Text="Salary"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtSalary" runat="server" style="z-index: 1; left: 154px; top: 123px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkAvailable" runat="server" style="z-index: 1; left: 10px; top: 177px; position: absolute" Text="Available" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 231px; position: absolute"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 10px; top: 285px; position: absolute" Text="OK" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 58px; top: 285px; position: absolute" Text="Cancel" />
        </div>
    </form>
</body>
</html>
