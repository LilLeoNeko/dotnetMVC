using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace dotNetFrameworkMVC_MoshProject.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "Have You Subscribed To Us?")]
        public bool IsSubscribed { get; set; }

        [Display(Name = "Type of Membership")]
        public Membership Membership { get; set; }
    }
}