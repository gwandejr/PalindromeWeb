<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmPalindrome.aspx.cs" Inherits="Palindrome.web.frmPalindrome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>WELCOME TO THE PALINDROME FINDER</h3>
            <p>Enter text below, then click submit to see if it’s a palindrome.</p>
            <asp:TextBox ID="txtUserInput" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
            <asp:Button ID="cmdUserInput" runat="server" Text="Submit" OnClick="cmdUserInput_Click" />
            <asp:Button ID="cmdClearUserInput" runat="server" Text="Clear " OnClick="cmdClearUserInput_Click" />
            <br /><br />
            <asp:Label ID="lblUserResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
