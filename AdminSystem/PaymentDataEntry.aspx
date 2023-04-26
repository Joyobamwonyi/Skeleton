<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaymentDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="lblNameOnCard" runat="server" style="z-index: 1; left: 11px; top: 22px; position: absolute" Text="Name on Card" width="108px"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblCardNumber" runat="server" style="z-index: 1; left: 10px; top: 62px; position: absolute" Text="Card Number" width="108px"></asp:Label>
            <asp:TextBox ID="txtCardNumber" runat="server" height="24px" style="z-index: 1; left: 121px; top: 58px; position: absolute" width="145px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtNameonCard" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 121px; top: 17px; position: absolute; height: 24px; width: 145px"></asp:TextBox>
            <asp:TextBox ID="txtPostalCode" runat="server" height="24px" OnTextChanged="TextBox1_TextChanged1" style="z-index: 1; left: 121px; top: 94px; position: absolute" width="145px"></asp:TextBox>
        </p>
        <asp:Label ID="lblPostalCode" runat="server" style="z-index: 1; left: 10px; top: 99px; position: absolute" Text="PostalCode" width="108px"></asp:Label>
        <asp:Label ID="lblExparationDate" runat="server" style="z-index: 1; left: 10px; position: absolute; width: 108px; top: 129px; bottom: 520px" Text="Exparation Date"></asp:Label>
        <asp:TextBox ID="txtExparationDate" runat="server" height="24px" style="z-index: 1; left: 121px; top: 129px; position: absolute; right: 276px;" width="145px"></asp:TextBox>
        <p>
            <asp:Label ID="lblCvv" runat="server" style="z-index: 1; left: 10px; top: 168px; position: absolute" Text="Cvv" width="108px"></asp:Label>
            <asp:TextBox ID="txtCvv" runat="server" height="24px" style="z-index: 1; left: 121px; top: 166px; position: absolute" width="145px"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 13px; top: 198px; position: absolute" Text="Save payment details" />
        <p>
            <asp:Button ID="btnPay" runat="server" OnClick="Button1_Click1" style="z-index: 1; left: 19px; top: 258px; position: absolute" Text="Pay Now" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 224px; position: absolute" Text="lbError"></asp:Label>
    </form>
</body>
</html>
