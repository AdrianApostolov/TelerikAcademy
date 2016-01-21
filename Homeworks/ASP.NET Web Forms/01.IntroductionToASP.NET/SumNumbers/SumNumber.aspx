<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SumNumber.aspx.cs" Inherits="SumNumbers.SumNumber" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.5/css/materialize.min.css">
    <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.5/js/materialize.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="row">
            <div class="input-field col s3 push-s3">
                <input placeholder="First number" id="firstNnumber" runat="server" type="text" class="validate" />
                <label for="first-number" class="active">First Number</label>
            </div>
            <div class="input-field col s3 push-s3">
                <input placeholder="Second number" id="secondNumber" runat="server" type="text" class="validate" />
                <label for="second-number" class="active">Second Number</label>
            </div>
        </div>
        <div class="row">
            <div class="input-field col s3  push-s6">
                <input id="sum" type="text" runat="server" class="validate" />
                <label for="sum" class="active">Sum</label>
            </div>
            <input id="Submit1" runat="server" style="margin-left: 100px;" class="waves-effect waves-light btn" value="Sum" type="submit" onserverclick="Sum" />
        </div>
    </form>
</body>
</html>
