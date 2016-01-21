<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Escaping.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="mainForm" runat="server">
        <div>
            <asp:TextBox ID="inputTextBox" runat="server" Placeholder="Enter some text"></asp:TextBox>
            <asp:Button Text="Submit" runat="server" OnClick="OnSubmitButtonClick" />

            <asp:TextBox runat="server" ID="enteredText"></asp:TextBox>
            <asp:Label runat="server" ID="enteredTextLabel"></asp:Label>
        </div>
    </form>
</body>
</html>
