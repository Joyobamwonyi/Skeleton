<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 741px;
        }
        .auto-style1 {
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblOrderID" runat="server" CssClass="auto-style1" style="z-index: 1; left: 10px; top: 75px; position: absolute; width: 161px;" Text="Order ID"></asp:Label>
        <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 15px; top: 120px; position: absolute; width: 386px; height: 32px"></asp:TextBox>
        <br />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 460px; top: 120px; position: absolute; height: 35px" Text="Find" Width="100px" />
        <asp:Label ID="lblAddress" runat="server" CssClass="auto-style1" style="z-index: 1; left: 10px; top: 175px; position: absolute; width: 161px;" Text="Customer Address"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 15px; top: 220px; position: absolute; width: 386px; height: 32px"></asp:TextBox>
        <br />
        <asp:DropDownList ID="drpPaymentMethod" runat="server" Height="32px" style="z-index: 1; left: 15px; top: 320px; position: absolute; height: 32px; width: 392px">
            <asp:ListItem Selected="True" Value="0">-- Choose Method --</asp:ListItem>
            <asp:ListItem>Credit Card</asp:ListItem>
            <asp:ListItem>Debit Card</asp:ListItem>
            <asp:ListItem>PayPal</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblPaymentMethod" runat="server" CssClass="auto-style1" style="z-index: 1; left: 10px; top: 280px; position: absolute" Text="Payment Method"></asp:Label>
        <asp:TextBox ID="txtAmount" runat="server" height="32px" style="z-index: 1; left: 15px; top: 420px; position: absolute; width: 386px"></asp:TextBox>
        <asp:Label ID="lblAmount" runat="server" CssClass="auto-style1" style="z-index: 1; left: 10px; top: 380px; position: absolute" Text="Amount" width="131px"></asp:Label>
        <asp:Label ID="lblDateOrdered" runat="server" CssClass="auto-style1" style="z-index: 1; left: 10px; top: 480px; position: absolute" Text="Date Ordered" width="131px"></asp:Label>
        <asp:TextBox ID="txtDateOrdered" runat="server" height="32px" style="z-index: 1; left: 15px; top: 520px; position: absolute" width="386px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 635px; position: absolute; height: 22px"></asp:Label>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 10px; top: 695px; position: absolute; height: 50px" Text="OK" Width="100px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 130px; top: 695px; position: absolute; width: 108px; height: 50px" Text="Cancel" />
        <asp:CheckBox ID="chkPaid" runat="server" Font-Bold="True" OnCheckedChanged="chkPaid_CheckedChanged" style="z-index: 1; left: 10px; top: 585px; position: absolute; height: 32px; width: 96px" Text="Paid" />
       
    </form>
</body>
</html>
