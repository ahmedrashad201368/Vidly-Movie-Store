using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
using System.Web.Mvc;


namespace Vidly.ViewModels
{
    public class NewRentalViewModel
    {
        public Rental rental { get; set; }
        public SelectList customers { get; set; }

        public SelectList movies { get; set; }
    }
}