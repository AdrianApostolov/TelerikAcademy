using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoMapper.QueryableExtensions;
using Movies.Data.Repositories;
using Movies.Models;
using Movies.Web.ViewModels;

namespace Movies.Web.Controllers
{
    public class MoviesController : Controller
    {
        public IRepository<Movie> movies;

        public IRepository<Actor> actors;

        public MoviesController(IRepository<Movie> movies, IRepository<Actor> actors)
        {
            this.movies = movies;
            this.actors = actors;
        }

        public ActionResult Index()
        {
            var movies = this.movies
                .All()
                .ProjectTo<MovieViewModel>();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = this.movies.GetById(id);

            return View(movie);
        }

        // GET: /Movies/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MovieViewModel model)
        {
            if (ModelState.IsValid)
            {
                var newMovie = new Movie()
                {
                    Title = model.Title,
                    Year = model.Year,
                    StudioName = model.StudioName,
                    StudioAddress = model.StudioAddress,
                    LeadingFemaleRole = new Actor() { Name = model.LeadingFemaleRole, Age = model.LeadingFemaleRoleAge },
                    LeadingMaleRole = new Actor() { Name = model.LeadingMaleRole, Age = model.LeadingMaleRoleAge }
                };

                this.movies.Add(newMovie);
                this.movies.SaveChanges();
                return this.RedirectToAction("Index");
            }

            return View(model);
        }

        // GET: /Movies/Create
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var movieForEdit = this.movies
                .All()
                .Where(x => x.Id == id)
                .ProjectTo<MovieViewModel>()
                .FirstOrDefault();

            return View(movieForEdit);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MovieViewModel model)
        {
            if (ModelState.IsValid)
            {
                var movieForEdit = this.movies.GetById(model.Id);

                movieForEdit.Title = model.Title;
                movieForEdit.Year = model.Year;
                movieForEdit.StudioName = model.StudioName;
                movieForEdit.StudioAddress = model.StudioAddress;
                movieForEdit.LeadingMaleRole.Name = model.LeadingMaleRole;
                movieForEdit.LeadingFemaleRole.Name = model.LeadingFemaleRole;
                movieForEdit.LeadingMaleRole.Age = model.LeadingMaleRoleAge;
                movieForEdit.LeadingFemaleRole.Age = model.LeadingFemaleRoleAge;

                this.movies.SaveChanges();
                return this.RedirectToAction("Index");
            }

            return View(model);
        }


        // GET: /Movies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var movieForEdit = this.movies
               .All()
               .Where(x => x.Id == id)
               .ProjectTo<MovieViewModel>()
               .FirstOrDefault();

            if (movieForEdit == null)
            {
                return HttpNotFound();
            }
            return View(movieForEdit);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteMovieComfirm(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            this.movies.Delete(id);
            this.movies.SaveChanges();
            return this.RedirectToAction("Index");
        }
    }
}