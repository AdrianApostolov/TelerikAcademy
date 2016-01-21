using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SumNumbers
{
    public partial class SumNumber : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Sum(object sender, EventArgs e)
        {
            this.sum.Value = (double.Parse(this.firstNnumber.Value) + double.Parse(this.secondNumber.Value)).ToString();
        }
    }
}