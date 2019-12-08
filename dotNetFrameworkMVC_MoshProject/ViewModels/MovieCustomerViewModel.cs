using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dotNetFrameworkMVC_MoshProject.Models;

namespace dotNetFrameworkMVC_MoshProject.ViewModels
{
    public class MovieCustomerViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}