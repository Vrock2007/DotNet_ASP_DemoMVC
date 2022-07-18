using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            Movie movie = new Movie
            {
                Id = 1,
                Name = "Dr.MOM",
                Year = 2022,
                Rating = 4
            };
            return View(movie);
        }
        public List<Movie> GetMovies()
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie {Id = 1, Name = "Dr.MOM", Year = 2022, Rating = 4},
                new Movie {Id = 2, Name = "NFS", Year = 2015, Rating = 4},
                new Movie {Id = 3, Name = "Casino Royale", Year = 2006, Rating = 5},
                new Movie {Id = 4, Name = "Quantum of Solace", Year = 2008, Rating = 4},
                new Movie {Id = 5, Name = "Skyfall", Year = 2012, Rating = 5},
                new Movie {Id = 6, Name = "Spectre", Year = 2015, Rating = 5},
                new Movie {Id = 7, Name = "No Time to Die", Year = 2021, Rating = 5},
            };
            return movies;
        }

        public IActionResult List()
        {
            List<Movie> movies = GetMovies();
            int count = movies.Count();
            ViewBag.Count = count;
            return View(movies);
        }

        public IActionResult Find()
        {
            return View();
        }

        public IActionResult SearchMovie(int movieid)
        {
            List<Movie> movies = GetMovies();
            var data = movies.Where(m => m.Id == movieid).FirstOrDefault();
            return View("Index",data);
        }

        [HttpGet]
        public IActionResult FindByYear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FindByYear(int year)
        {
            List<Movie> movies = GetMovies();
            var data = movies.Where(m => m.Year == year);
            ViewBag.Movies = data;
            return View();
        }
    }
}
