using step_247.Models;
using step_247.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace step_247.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (CarInsuranceQuoteEntities1 db = new CarInsuranceQuoteEntities1())
            {
                var quotes = (from x in db.Quotes select x).ToList();
                var quoteVms = new List<QuoteVM>();
                foreach (var quote in quotes)
                {
                    var quoteVm = new QuoteVM();
                    quoteVm.Id = quote.Id;
                    quoteVm.FirstName = quote.FirstName;
                    quoteVm.LastName = quote.LastName;
                    quoteVm.EmailAddress = quote.EmailAddress;
                    quoteVm.QuoteAmount = Convert.ToInt16(quote.QuoteAmount);
                    quoteVms.Add(quoteVm);
                }
                return View(quoteVms);
            }
        }
    }
}