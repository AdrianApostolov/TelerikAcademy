namespace _02.WebFormAppModel
{
    using System;
    using System.Reflection;

    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.mainTextBlock.Text = "Hello, ASP.NET";
            this.locationTextBlock.Text = "Location: " + Assembly.GetExecutingAssembly().Location;
        }
    }
}