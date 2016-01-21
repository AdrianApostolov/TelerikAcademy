<%@ Page Title="Profile"
    Language="C#"
    MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="Profile.aspx.cs"
    Inherits="ProfilePage.Views.Profile" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="row">
        <div class="col s12 m7">
            <h2 class="header">Profile</h2>
            <div class="card" style="overflow: hidden;">
                <div class="card-image waves-effect waves-block waves-light">
                    <img class="activator" src="http://nerdrating.com/files/2013/10/batman_arkham_origins_by_vgwallpapers-d6oajdj.jpg" />
                </div>
                <div class="card-content">
                    <span class="card-title activator grey-text text-darken-4">More Info<i class="material-icons right">more_vert</i></span>

                </div>
                <div class="card-reveal" style="display: none; transform: translateY(0px);">
                    <span class="card-title grey-text text-darken-4">More Info<i class="material-icons right">close</i></span>
                    <p>Here is some more information about this product that is only revealed once clicked on.</p>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
