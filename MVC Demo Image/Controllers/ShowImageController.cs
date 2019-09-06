using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace MVC_Demo_Image.Controllers
{
    public class ShowImageController : Controller
    {
        // GET: ShowImage
        public ActionResult GetImageFromByteArray()
        {
            // Get image path  
            string imgPath = Server.MapPath("~/Content/Images/Ganesh.jpg");
            // Convert image to byte array  
            byte[] byteData = System.IO.File.ReadAllBytes(imgPath);
            //Convert byte arry to base64string   
            string imgBase64Data = Convert.ToBase64String(byteData);
            string imgDataURL = string.Format("data:image/jpg;base64,{0}", imgBase64Data);
            //Passing image data in viewbag to view  
            ViewBag.ImageData = imgDataURL;
            return View();
        }
    }
}