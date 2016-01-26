using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
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

        public ActionResult Index2()
        {
            BankIndexViewModel model = new BankIndexViewModel();
            List<Pair> Accounts;
            string userName = User.Identity.Name;
            using (BankContext context = new BankContext())
            {
                Accounts = (from a in context.Accounts
                            where a.Username == userName
                            select new Pair { First = a.AccountNumber, Second = a.AccountId.ToString() }).ToList();
            }
            model.Accounts = Accounts;
            return View(model);

        }

        public ActionResult Account2(Guid accountId)
        {
            Account account;
            using (BankContext context = new BankContext())
            {
                account =
                    context.Accounts.Include("Transactions")
                        .Include("User")
                        .FirstOrDefault(a => a.AccountId == accountId);
            }
            return View(account);
        }

        public ActionResult Account3(Guid accountId)
        {
            Account account;
            using (BankContext context = new BankContext())
            {
                account =
                    context.Accounts.Include("Transactions")
                        .Include("User")
                        .FirstOrDefault(a => a.AccountId == accountId);
            }
            if (account != null && account.Username == User.Identity.Name)
            {
                return View("Account2", account);

            }
            return new HttpStatusCodeResult(403);
        }

    }

    public class BankIndexViewModel
    {
        public List<string> AccountNumbers { get; set; }
        public List<Pair> Accounts { get; set; }
    }
}