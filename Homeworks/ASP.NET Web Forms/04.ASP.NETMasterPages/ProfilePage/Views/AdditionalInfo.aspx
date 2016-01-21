<%@ Page Title="Additional Info" 
    Language="C#"
    MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" 
    CodeBehind="AdditionalInfo.aspx.cs" 
    Inherits="ProfilePage.Views.AdditionalInfo" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <h1>Additional Info</h1>
    <ul class="collapsible popout collapsible-accordion" data-collapsible="accordion">
          <li class="">
            <div class="collapsible-header"><i class="material-icons">subtitles</i>TV</div>
            <div class="collapsible-body" style="display: none;"><p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p></div>
          </li>
          <li class="">
            <div class="collapsible-header"><i class="material-icons">games</i>Games</div>
            <div class="collapsible-body" style="display: none;"><p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p></div>
          </li>
          <li class="">
            <div class="collapsible-header"><i class="material-icons">library_books</i>Books</div>
            <div class="collapsible-body" style="display: none;"><p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p></div>
          </li>
        </ul>
</asp:Content>
