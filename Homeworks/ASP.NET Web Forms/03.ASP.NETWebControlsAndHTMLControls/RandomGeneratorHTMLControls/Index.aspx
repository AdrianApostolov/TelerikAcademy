<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="RandomGeneratorHTMLControls.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Random Generator</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.5/css/materialize.min.css"/>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.5/js/materialize.min.js"></script>
</head>
<body>
    <form id="mainForm" runat="server">
    <div>
        <div class="row">
            <div class="input-field col s3 push-s3">
                <input placeholder="Min number" min="0" max="1000000" id="minNumberInput" runat="server" type="text" class="validate" />
                <label for="first-number" class="active">Min Number</label>
            </div>
            <div class="input-field col s3 push-s3">
                <input placeholder="Max number" min="0" max="1000000" id="maxNumberInput" runat="server" type="text" class="validate" />
                <label for="second-number" class="active">Max Number</label>
            </div>
        </div>
        <div class="row">
            <div class="input-field col s3  push-s6">
                <input id="randomNumber" type="text" runat="server" class="validate" />
                <label for="randomNumber" class="active">Random Number</label>
            </div>
            <input id="Submit1" runat="server" style="margin-left: 100px;" class="waves-effect waves-light btn" value="Random Number" type="submit" onserverclick="RandomGenerator" />
        </div>
    </div>`
    </form>
</body>
</html>
