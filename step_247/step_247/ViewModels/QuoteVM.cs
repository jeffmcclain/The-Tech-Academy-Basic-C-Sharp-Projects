using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace step_247.ViewModels
{
    public class QuoteVM
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public short QuoteAmount { get; set; }

    }
}