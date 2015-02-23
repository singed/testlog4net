using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;

namespace TestLog4net.Controllers
{
    
    public class HomeController : Controller
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public ActionResult Index()
        {
            Log.Debug("GET Request traced");
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
