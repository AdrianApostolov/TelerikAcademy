using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _03.PageLifeCycle
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            this.Response.Write("Page_PreInit invoked" + "<br/>");
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            this.Response.Write("Page_Init invoked" + "<br/>");
        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            this.Response.Write("Page_InitComplete invoked" + "<br/>");
        }

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            this.Response.Write("Page_PreLoad invoked" + "<br/>");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.Response.Write("Page_Load invoked" + "<br/>");
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            this.Response.Write("Page_LoadComplete invoked" + "<br/>");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            this.Response.Write("Page_PreRender invoked" + "<br/>");
        }

        protected void Page_SaveStateComplete(object sender, EventArgs e)
        {
            this.Response.Write("Page_SaveStateComplete invoked" + "<br/>");
        }

        protected void Page_Render(object sender, EventArgs e)
        {
            this.Response.Write("Page_Render invoked" + "<br/>");
        }

        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            this.Response.Write("Page_PreRenderComplete invoked" + "<br/>");
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            // this.Response.Write("Page_Unload invoked" + "<br/>");
        }

        protected void OnButtonInit(object sender, EventArgs e)
        {
            this.Response.Write("OnButtonInit invoked" + "<br/>");
        }

        protected void OnButtonLoad(object sender, EventArgs e)
        {
            this.Response.Write("OnButtonLoad invoked" + "<br/>");
        }

        protected void OnButtonClicked(object sender, EventArgs e)
        {
            this.Response.Write("OnButtonClicked invoked" + "<br/>");
        }

        protected void OnButtonPreRender(object sender, EventArgs e)
        {
            this.Response.Write("OnButtonPreRender invoked" + "<br/>");
        }
    }
}