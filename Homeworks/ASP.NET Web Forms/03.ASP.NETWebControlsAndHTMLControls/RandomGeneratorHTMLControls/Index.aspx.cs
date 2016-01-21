using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RandomGeneratorHTMLControls
{
    public partial class Index : System.Web.UI.Page
    {
        static Random random = new Random();

        protected void RandomGenerator(object sender, EventArgs e)
        {
            int minNumber;
            int.TryParse(this.minNumberInput.Value, out minNumber);

            int maxNumber;
            int.TryParse(this.maxNumberInput.Value, out maxNumber);

            var randomNumber = random.Next(minNumber, maxNumber + 1);
            this.randomNumber.Value = randomNumber.ToString();
        }
    }
}