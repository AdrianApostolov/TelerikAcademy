using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Escaping
{
    public partial class Index : System.Web.UI.Page
    {
        protected void OnSubmitButtonClick(object sender, EventArgs e)
        {
            var enteredText = this.inputTextBox.Text;

            this.enteredText.Text = this.Server.HtmlEncode(enteredText);
            this.enteredTextLabel.Text = this.Server.HtmlEncode(enteredText);
        }
    }
}