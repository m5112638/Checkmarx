using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Checkmarx.Models;
using System.Collections.Generic;

namespace Checkmarx.Controllers
{
    [Authorize]
    public class BankingController : Controller
    {
        private HistoryViewModel m_history = new HistoryViewModel();

        //
        // GET: /Banking/Index
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Banking/Transfer
        public ActionResult Transfer()
        {
            BankingViewModel model = new BankingViewModel() { TransferAmount = 1000 };
            return View(model);
        }

        //
        // POST: /Banking/Transfer
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Transfer(BankingViewModel model)
        {
            m_history.Add(model.TransferAmount, DateTime.Now);

            return View(model);
        }

        //
        // GET: /Banking/Transfer
        public ActionResult Transfer2()
        {
            BankingViewModel model = new BankingViewModel() { TransferAmount = 2000 };
            return View(model);
        }

        //
        // POST: /Bancking/Transfer2
        [HttpPost]
        public ActionResult Transfer2(BankingViewModel model)
        {
            m_history.Add(model.TransferAmount, DateTime.Now);

            return View(model);
        }

        //
        // GET: /Banking/History
        public ActionResult History()
        {
            return View(m_history);
        }
    }
}
