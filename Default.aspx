<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Hourly Wages:<br />
        <asp:TextBox ID="rateTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Hours:<br />
        <asp:TextBox ID="hourTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Pre-tax deductions:<br />
        <asp:TextBox ID="pretaxTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        After-tax dedictions:<br />
        <asp:TextBox ID="aftertaxTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="calculateButton" runat="server" Text="Calculate Net Payment" Height="30px" Width="180px" />
        <br />
        <br />
        <asp:Label ID="result" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="clearButton" runat="server" Text="Clear" Width="180px" Height="30px" />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
