using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Checkmarx.Controllers
{
    public class XssController : Controller
    {
        // GET: Xss
        public ActionResult Index(string s)
        {
            return View(new Models.XssViewModel() { Value = s });
        }
    }
}

