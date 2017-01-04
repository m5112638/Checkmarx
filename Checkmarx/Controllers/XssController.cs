using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Checkmarx.Controllers
{
    public class XssController : Controller
    {
        // GET: Xss/Index
        public ActionResult Index(string s)
        {
            return View(new Models.XssViewModel() { Value = s });
        }

        // GET: Xss/Index2
        [ValidateInput(false)]
        public ActionResult Index2(string s)
        {
            return View("Index", new Models.XssViewModel() { Value = s });
        }

        // GET: Xss/XssA
        [Authorize]
        [ValidateInput(false)]
        public ActionResult XssA(string s)
        {
            return View(new Models.XssViewModel() { Value = s });
        }
    }
}

