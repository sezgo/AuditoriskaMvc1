using AuditoriskaMvc1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuditoriskaMvc1.Controllers
{
    public class MoviesController : Controller
    {

        public static Movie movie = new Movie()
        {
            Name = "Shrek!",
            Rating = 4.8f,
            DownloadURL = @"nekoeURL",
            ImageURL = "data:image/jpeg;base64,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"
        };

        public static List<Movie> movies = new List<Movie>();
        public static List<Client> clients = new List<Client>() {
                new Client() { 
                    Name = "Aleksandar Stojmenski", 
                    MovieCard = "1234",
                    Address = "Partizanski Odredi 64",
                    Phone = "075444222",
                    Age = 25},
                new Client() { 
                    Name = "Petko Petkovski", 
                    MovieCard = "5534",
                    Address = "Ilindenska 16",
                    Phone = "02555333",
                    Age = 17},
                new Client() { 
                    Name = "Trajko Trajkovski", 
                    MovieCard = "6666",
                    Address = "Moskovska 12",
                    Phone = "02351144",
                    Age = 21}
        };

        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }

        //localhost:port/Movies/Random

        public ActionResult Random()
        {
            MovieRentals model = new MovieRentals();
            model.movie = movie;
            model.clients = clients;
            return View(model);
        }

        public ActionResult ShowClient(int id)
        {
            return View(clients.ElementAt(id));
        }

        public ActionResult NewMovie()
        {
            Movie model = new Movie();
            return View(model);
        }

        [HttpPost]
        public ActionResult NewMovie(Movie model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            movies.Add(model);
            return View("GetAllMovies",movies);
        }

        public ActionResult GetAllMovies()
        {
            return View(movies);
        }

        public ActionResult EditMovie(int id)
        {
            return View(movies.ElementAt(id));
        }

        [HttpPost]
        public ActionResult EditMovie(Movie model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            Movie forUpdate = movies.ElementAt(model.Id);
            forUpdate.ImageURL = model.ImageURL;
            forUpdate.DownloadURL = model.DownloadURL;
            forUpdate.Name = model.Name;
            forUpdate.Rating = model.Rating;

            return View("GetAllMovies", movies);

        }

        public ActionResult NewClient()
        {
            Client model = new Client();
            return View(model);
        }

        [HttpPost]
        public ActionResult NewClient(Client model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            clients.Add(model);
            return View("GetAllClients", clients);
        }

        public ActionResult GetAllClients()
        {
            return View(clients);
        }

        public ActionResult DeleteMovie(int id)
        {
            movies.RemoveAt(id);
            return View("GetAllMovies", movies);
        }
    }
}