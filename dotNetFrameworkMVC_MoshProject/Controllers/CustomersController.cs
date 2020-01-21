using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dotNetFrameworkMVC_MoshProject.Models;
using dotNetFrameworkMVC_MoshProject.ViewModels;

namespace dotNetFrameworkMVC_MoshProject.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult NewCustomer()
        {
            var memberships = _context.Memberships.ToList();
            var viewModel = new NewCustomerViewModel
            {
                Memberships = memberships
            };
            return View(viewModel);
        }
        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c=>c.Membership);

            return View(customers);
        }
        [Route("customers/detail/{id}")]
        public ActionResult Detail(int id)
        {
            var customer = _context.Customers.Include(c => c.Membership).SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index","Customers");
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c=>c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }

            var viewModel = new NewCustomerViewModel
            {
                Customer = customer,
                Memberships = _context.Memberships.ToList()
            };
            return View();
        }
    }
}