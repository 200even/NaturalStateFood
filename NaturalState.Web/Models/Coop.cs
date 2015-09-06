using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NaturalState.Web.Models
{
    public class Coop
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }

        [Phone(ErrorMessage = "The phone number is not valid")]
        public string Phone { get; set; }

        [Url(ErrorMessage = "The URL is not valid")]
        public string Url { get; set; }

        [EmailAddress(ErrorMessage = "The email address is not valid")]
        public string Email { get; set; }

        public double MembershipCost { get; set; }

        public double MedianIncome { get; set; }
        public int Population { get; set; }
        public bool IsOpen { get; set; }
    }

    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext()
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Coop> Coops { get; set; }
    }

}