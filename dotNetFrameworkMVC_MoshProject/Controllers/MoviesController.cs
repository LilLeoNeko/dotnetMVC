using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dotNetFrameworkMVC_MoshProject.Models;
using dotNetFrameworkMVC_MoshProject.ViewModels;

namespace dotNetFrameworkMVC_MoshProject.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            var movies = new List<Movie>
            {
                new Movie{Name = "Hello World!", Rate = 5.0},
                new Movie{Name = "GoodBye!", Rate = 1.5}
            };
            return View(movies);
        }
        //GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie{Name = "Hello World!", Rate = 5.0};
            var customers = new List<Customer>
            {
                new Customer{Name = "David"},
                new Customer{Name = "Leonardo"},
                new Customer{Name = "Fiona"}
            };
            var viewModel = new MovieCustomerViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}