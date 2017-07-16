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

        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id = 1, Name = "Shrek!"},
                new Movie {Id = 1, Name = "Hangover"},
                new Movie {Id = 1, Name = "Titanic"},
                new Movie {Id = 1, Name = "Hangover 2"}

            };
        }

        // GET: Movies
        public ViewResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel

            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);

        }
    }
}