using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class RentalsController : Controller
    {
        ApplicationDbContext db;
        public RentalsController()
        {
            db = new ApplicationDbContext(); 
        }
        // GET: Rentals
        
        public ActionResult Index()
        {
            var rs = db.Rentals.Include("Movie").Include("Customer").ToList();
            return View(rs);
        }

        public ActionResult create()
        {
            List<Customer> myCustomers = db.Customers.ToList();
            List<Movie> myMovies = db.Movies.ToList();

            NewRentalViewModel myRentalVM = new NewRentalViewModel()
            {
                rental = new Rental(),
                customers = new SelectList(myCustomers, "Id", "Name"),
                movies = new SelectList(myMovies, "Id", "Name")
            };

            return View(myRentalVM);
        }

        [HttpPost]
        public ActionResult create(NewRentalViewModel vm)
        {
            if (ModelState.IsValid)
            {
                vm.rental.DateRented = DateTime.Now;
                db.Rentals.Add(vm.rental);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                List<Customer> myCustomers = db.Customers.ToList();
                List<Movie> myMovies = db.Movies.ToList();

                NewRentalViewModel myRentalVM = new NewRentalViewModel()
                {
                    rental = new Rental(),
                    customers = new SelectList(myCustomers, "Id", "Name"),
                    movies = new SelectList(myMovies, "Id", "Name")
                };

                return View(myRentalVM);
            }
        }
    }
}