<%@ Page Title="Friends" 
    Language="C#" 
    MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" 
    CodeBehind="Friends.aspx.cs" 
    Inherits="ProfilePage.Views.Friends" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <h1>Friends</h1>
    <ul class="row">
        <li class="col s3">
            <img src="http://telerikacademy.com/Content/Images/DefaultAvatar/default_180x180.jpg" alt="Ninja" width="75" height="75" />
            <span>Smith</span>
        </li>
        <li class="col s3">
            <img src="http://telerikacademy.com/Content/Images/DefaultAvatar/default_180x180.jpg" alt="Ninja" width="75" height="75" />
            <span>John</span>
        </li>
        <li class="col s3">
            <img src="http://telerikacademy.com/Content/Images/DefaultAvatar/default_180x180.jpg" alt="Ninja" width="75" height="75" />
            <span>George</span>
        </li>
        <li class="col s3">
            <img src="http://telerikacademy.com/Content/Images/DefaultAvatar/default_180x180.jpg" alt="Ninja" width="75" height="75" />
            <span>Peter</span>
        </li>
    </ul>
</asp:Content>
