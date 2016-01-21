using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.PrintYourName
{
    public partial class Index : System.Web.UI.Page
    {
        protected void OnButtonClicked(object sender, EventArgs e)
        {
            this.nameResultBox.Text = "HELLO " + this.Server.HtmlEncode(this.nameTextBox.Text);
        }
    }
}