using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Customers()
        {
            var movie = new Movie() { Name="Shrek" };
            var customers = new List<Customer>
            {
                new Customer { Name="Customer1"},
                new Customer { Name="Customer2"}
            };


            var viewModel = new RandomMovieViewModel
            {
                Movie=movie,
                Customer=customers
            };
            /*Pass data to view using the view data dictionary
            ViewData["Movies"] = movie;
            return View();


            ViewBag technique of passing data to model, you can create dynamic property
            evaluated at runtime, so no safety
             ViewBag.Movie = movie;
            return View();*/

            //or You can return the movie object using this technique
            //return View(movie);

            return View(viewModel);

        }

        public ActionResult displayCustomers()
        {

            return View();
        }


        /*public ActionResult Edit(int id)
        {
            return Content("id =" + id);
        }

        //int? means that pageIndex is nullable or optional
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}",pageIndex,sortBy));
        }

        type mvcaction4 and press tab to get default action definition
        public ActionResult ByReleaseDate(int year,int month)
        {
            return Content(year+"/"+month);
        }*/

        /*Attribute routes
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }*/
    }
}