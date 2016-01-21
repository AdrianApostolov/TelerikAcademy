<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="_01.PrintYourName.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Print Name</title>
</head>
<body>
    <form id="printNameForm" runat="server">
        <div>
            <div>Enter your name:</div>
            <asp:TextBox runat="server" ID="nameTextBox"></asp:TextBox>
            <br />
            <button type="submit" runat="server" onserverclick="OnButtonClicked">Submit</button>
            <br />
            <asp:Label runat="server" ID="nameResultBox"></asp:Label>
        </div>
    </form>
</body>
</html>
