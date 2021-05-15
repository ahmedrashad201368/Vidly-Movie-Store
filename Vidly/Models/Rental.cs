using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vidly.Models
{
    public class Rental
    {   
        public int Id { get; set; }
        [Display(Name = "Customer")]
        [ForeignKey("Customer")]
        public int Customer_Id { get; set; }

        
        public Customer Customer { get; set; }
        [Display(Name ="Movie")]
        [ForeignKey("Movie")]
        public int Movie_Id { get; set; }
        
        public Movie Movie { get; set; }
        public DateTime DateRented { get; set; }
        public DateTime? dateReturned { get; set; }

    }
}