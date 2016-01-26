using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _04_InsecureDirectObjectReference.Models;

namespace _04_InsecureDirectObjectReference.Controllers
{
    [Authorize]
    public class BankController : Controller
    {
        // GET: Bank
        public ActionResult Index()
        {
            BankIndexViewModel model = new BankIndexViewModel();
            List<string> Numbers;
            string userName = User.Identity.Name;
            using (BankContext context = new BankContext())
            {
                Numbers = (from a in context.Accounts
                    where a.Username == userName
                    select a.AccountNumber).ToList();
            }
            model.AccountNumbers = Numbers;
            return View(model);
        }

        public ActionResult Account(string accountNumber)
        {
            Account account;
            using (BankContext context = new BankContext())
            {
                account = context.Accounts.Include("Transactions").Include("User").FirstOrDefault(a => a.AccountNumber == accountNumber);
            }
            return View(account);
        }
    }

    public class BankIndexViewModel
    {
        public List<string> AccountNumbers { get; set; }
    }
}