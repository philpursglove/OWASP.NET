using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03_CrossSiteScripting.Controllers
{
    //[ValidateInput(false)]
    public class XSSController : Controller
    {
        // GET: XSS
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string RichText)
        {
            ViewBag.RichText = RichText;
            return View();
        }
    }
}