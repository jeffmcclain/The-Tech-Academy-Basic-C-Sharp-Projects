using step_247.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace step_247.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Quote(string firstName, string lastName, string emailAddress, string dateOfBirth, string carYear,
                            string carMake, string carModel, string speedTickets, bool fullCoverage = false, bool dUI = false)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) ||
                 string.IsNullOrEmpty(dateOfBirth) || string.IsNullOrEmpty(carYear) || string.IsNullOrEmpty(carMake) || 
                 string.IsNullOrEmpty(carModel) || string.IsNullOrEmpty(speedTickets))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                // base policy quote starts at 50 dollars
                int policyQuote = 50;
                int Calculator()
                {
                    // get the users age in years
                    var age = ageYears();
                    int ageYears()
                    {
                        DateTime today = DateTime.Now;
                        int years = today.Year - Convert.ToDateTime(dateOfBirth).Year;
                        return years;
                    }
                    // check user's age and apply related policy charges, if any
                    if (age < 18)
                    {
                        policyQuote = policyQuote + 100;
                    }
                    else if ((age > 17 && age < 25) || age > 100)
                    {
                        policyQuote = policyQuote + 25;
                    }
                    // check car year and apply related policy charges, if any
                    if (Convert.ToInt32(carYear) < 2000 || Convert.ToInt32(carYear) > 2015)
                    {
                        policyQuote = policyQuote + 25;
                    }
                    // check if user's car is a Porsche and apply related policy charges, if any
                    if (carMake == "Porsche" || carMake == "porsche")
                    {
                        policyQuote = policyQuote + 25;
                    }
                    // check if user's car model is 'Carrera' and apply related policy charges, if any
                    if (carModel == "Carrera" || carModel == "carrera")
                    {
                        policyQuote = policyQuote + 25;
                    }
                    // check if user has any speeding tickets and apply related policy charges, if any
                    int tickets = Convert.ToInt32(speedTickets);
                    if (tickets > 0)
                    {
                        policyQuote = policyQuote + (tickets * 10);
                    }
                    // check if user has a DUI on record and apply related policy charges, if any
                    if (dUI == true)
                    {
                        policyQuote = policyQuote + (policyQuote / 4);
                    }
                    // check if user wants Full Coverage and apply related policy charges, if any
                    if (fullCoverage == true)
                    {
                        policyQuote = policyQuote + (policyQuote / 2);
                    }
                    return policyQuote;
                }
                

                using (CarInsuranceQuoteEntities1 db = new CarInsuranceQuoteEntities1())
                {
                    var quote = new Quote();
                    quote.QuoteAmount = Convert.ToInt16(Calculator());
                    quote.FirstName = firstName;
                    quote.LastName = lastName;
                    quote.EmailAddress = emailAddress;
                    quote.DateOfBirth = Convert.ToDateTime(dateOfBirth);
                    quote.CarYear = Convert.ToInt16(carYear);
                    quote.CarMake = carMake;
                    quote.CarModel = carModel;
                    quote.DUI = dUI;
                    quote.SpeedTickets = Convert.ToByte(speedTickets);
                    quote.FullCoverage = fullCoverage;

                    db.Quotes.Add(quote);
                    db.SaveChanges();
                }
                return View("Success");
            }
        }
    }
}