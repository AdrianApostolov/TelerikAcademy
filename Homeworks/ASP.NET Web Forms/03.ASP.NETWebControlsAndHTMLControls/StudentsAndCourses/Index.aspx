<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="StudentsAndCourses.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Form</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.5/css/materialize.min.css" />
    <script src="https://code.jquery.com/jquery-2.2.0.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.5/js/materialize.min.js"></script>
</head>
<body>
    <form id="mainForm" runat="server">
        <div class="row">
            <div runat="server" id="registrationForm" class="col s4 push-s4">
                First name:
            <asp:TextBox runat="server" ID="firstNameInput" /><br />
                <br />
                Second name:
            <asp:TextBox runat="server" ID="lastNameInput" /><br />
                <br />
                Faculty number:
            <asp:TextBox runat="server" ID="facultyNumberInput" /><br />
                <br />

                University:
            <asp:DropDownList ID="universityDropdown" runat="server">
                <asp:ListItem Text="SU"></asp:ListItem>
                <asp:ListItem Text="UNWE"></asp:ListItem>
                <asp:ListItem Text="TU"></asp:ListItem>
                <asp:ListItem Text="NSA"></asp:ListItem>
            </asp:DropDownList>
                <br />
                <br />

                Specialty: 
                <asp:DropDownList runat="server" ID="specialtyDropDown">
                    <asp:ListItem Text="Bariatric Surgery" />
                    <asp:ListItem Text="Concussions" />
                    <asp:ListItem Text="Counseling" />
                    <asp:ListItem Text="Diagnostic Lab" />
                </asp:DropDownList>
                <br />
                <br />

                Course:
            <asp:DropDownList ID="courseUniversity" runat="server">
                <asp:ListItem Text="Computer Science"></asp:ListItem>
                <asp:ListItem Text="Iconomics"></asp:ListItem>
                <asp:ListItem Text="Engineering"></asp:ListItem>
                <asp:ListItem Text="NSA"></asp:ListItem>
            </asp:DropDownList>
                <br />
                <br />

                <asp:Button CssClass="waves-effect waves-light btn" Text="Register" runat="server" OnClick="OnRegisterStudentButtonClicked" />
            </div>

            <div runat="server" id="registrationInfo"></div>
        </div>
    </form>
    <script>
        $(document).ready(function () {
            $('select').material_select();
        });
    </script>
</body>
</html>
