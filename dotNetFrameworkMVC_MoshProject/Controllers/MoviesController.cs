using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dotNetFrameworkMVC_MoshProject.Models;
using dotNetFrameworkMVC_MoshProject.ViewModels;

namespace dotNetFrameworkMVC_MoshProject.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Movies
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m=>m.Genre);
            return View(movies);
        }
        //GET: Movies/Detail/id
        [Route("movies/detail/{id}")]
        public ActionResult Detail(int id)
        {
            var movie = _context.Movies.Include(m=>m.Genre).SingleOrDefault(m => m.Id == id);
            return View(movie);
        }
        //GET: Movies/Random
        public ActionResult Random()
        {
            return View();
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