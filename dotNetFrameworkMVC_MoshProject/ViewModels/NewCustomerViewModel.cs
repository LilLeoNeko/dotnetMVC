using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dotNetFrameworkMVC_MoshProject.Models;

namespace dotNetFrameworkMVC_MoshProject.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<Membership> Memberships { get; set; }
        public Customer Customer { get; set; }
    }
}