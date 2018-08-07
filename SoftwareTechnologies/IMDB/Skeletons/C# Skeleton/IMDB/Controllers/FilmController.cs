using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using IMDB.Models;

namespace IMDB.Controllers
{
    [ValidateInput(false)]
    public class FilmController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            using (var context = new IMDBDbContext())
            {
                List<Film> films = context.Films.ToList();
                return View(films);
            }

        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {            
                return View();         

        }

        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Film film)
        {
            using (var context = new IMDBDbContext())
            {
                context.Films.Add(film);
                context.SaveChanges();
                return Redirect("/");
            }

        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int? id)
        {
            using (var context = new IMDBDbContext())
            {
                Film filmFromDb = context.Films.Find(id);
                return View(filmFromDb);
            }

        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int? id, Film filmModel)
        {
            using (var context = new IMDBDbContext())
            {
                Film filmFromDb = context.Films.Find(id);
                filmFromDb.Name = filmModel.Name;
                filmFromDb.Genre = filmModel.Genre;
                filmFromDb.Director = filmModel.Director;
                filmFromDb.Year = filmModel.Year;
                context.SaveChanges();

                return Redirect("/");
            }


        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int? id)
        {
            using (var context = new IMDBDbContext())
            {
               Film filmFromDb = context.Films.Find(id);
                return View(filmFromDb);
            }

        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int? id, Film filmModel)
        {
            using (var context = new IMDBDbContext())
            {
                Film taskFromDb = context.Films.Find(id);
                context.Films.Remove(taskFromDb);
                context.SaveChanges();

                return Redirect("/");
            }

        }
    }
}