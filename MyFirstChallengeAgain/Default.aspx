<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyFirstChallengeAgain.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
            How old are you?&nbsp;
            <asp:TextBox ID="ageTextBox" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            How much money do you have in your pocket?&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="moneyTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="goBtn" runat="server" OnClick="Button1_Click" Text="Click Me" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
