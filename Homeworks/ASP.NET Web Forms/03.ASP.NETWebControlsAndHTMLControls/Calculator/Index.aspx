<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Calculator.Index" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.5/css/materialize.min.css" />
    <script src="https://code.jquery.com/jquery-2.2.0.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.5/js/materialize.min.js"></script>
    <style>
        form {
    padding: 4px;
    width: 193px;
    border: 4px solid #808080;
}

form ul {
    overflow: hidden;
    margin: 0;
    padding: 0;
    list-style-type: none;
}

form li {
    float: left;
}

form input {
    margin: 4px; 
    font-size: 18px;
}

input[type="text"] {    
    width: 165px;
    padding: 6px 7px 6px 7px;
    text-align: right;
}

input[type="button"] {
    width: 40px;
    height: 40px;
    text-align: center;
}
    </style>
</head>
<body>
    <form id="sumatorForm" runat="server">
        <div>
            <input type="text" runat="server" name="valueInMemory" id="valueInMemory" hidden="hidden" />
            <input type="text" runat="server" name="lastSelectedOperator" id="lastSelectedOperator" hidden="hidden" />
            <input type="text" runat="server" value="0" id="resultBox" readonly />

            <ul>
                <li>
                    <input runat="server" onserverclick="OnDigitButtonClicked" type="button" value="1" /></li>
                <li>
                    <input runat="server" onserverclick="OnDigitButtonClicked" type="button" value="2" /></li>
                <li>
                    <input runat="server" onserverclick="OnDigitButtonClicked" type="button" value="3" /></li>
                <li>
                    <input runat="server" onserverclick="OnOperatorButtonClicked" type="button" value="+" /></li>
                <li>
                    <input runat="server" onserverclick="OnDigitButtonClicked" type="button" value="4" /></li>
                <li>
                    <input runat="server" onserverclick="OnDigitButtonClicked" type="button" value="5" /></li>
                <li>
                    <input runat="server" onserverclick="OnDigitButtonClicked" type="button" value="6" /></li>
                <li>
                    <input runat="server" onserverclick="OnOperatorButtonClicked" type="button" value="-" /></li>
                <li>
                    <input runat="server" onserverclick="OnDigitButtonClicked" type="button" value="7" /></li>
                <li>
                    <input runat="server" onserverclick="OnDigitButtonClicked" type="button" value="8" /></li>
                <li>
                    <input runat="server" onserverclick="OnDigitButtonClicked" type="button" value="9" /></li>
                <li>
                    <input runat="server" onserverclick="OnOperatorButtonClicked" type="button" value="*" /></li>
                <li>
                    <input runat="server" onserverclick="OnDigitButtonClicked" type="button" value="0" /></li>
                <li>
                    <input runat="server" onserverclick="OnRootButtonClicked" type="button" value="√" /></li>
                <li>
                    <input runat="server" onserverclick="OnOperatorButtonClicked" type="button" value="/" /></li>
                <li>
                    <input runat="server" onserverclick="OnGetResultButtonClicked" type="button" value="=" /></li>
            </ul>
        </div>
    </form>
</body>
</html>
