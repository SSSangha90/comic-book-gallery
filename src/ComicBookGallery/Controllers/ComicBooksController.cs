using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    //controller classes need to be public for the site to run
    public class ComicBooksController : Controller
    {
        //Action results also need to be public
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                return Redirect("/");
            }
            return Content("Comic books controller");
        }
    }
}