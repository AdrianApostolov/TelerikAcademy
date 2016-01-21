using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;

namespace TextToImageHttpHandler
{
    public class CustomHandler : IHttpHandler
    {
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "image/png";
            var imageAsText = context.Request.Params[0];
            byte[] bytes = Convert.FromBase64String(imageAsText);
            using (Bitmap image = (Bitmap)Image.FromStream(new MemoryStream(bytes)))
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    image.Save(memoryStream, ImageFormat.Png);
                    memoryStream.WriteTo(context.Response.OutputStream);
                }
            }
        }
    }
}