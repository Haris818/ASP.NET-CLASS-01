using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CLASS_01.Controllers
{
    public class WEBController : Controller
    {
        // GET: WEB
        public ActionResult HOME()
        {
            return View();
        }
    }
}