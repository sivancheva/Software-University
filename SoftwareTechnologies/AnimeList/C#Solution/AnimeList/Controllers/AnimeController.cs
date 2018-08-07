using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AnimeList.Models;

namespace AnimeList.Controllers
{
    [ValidateInput(false)]
    public class AnimeController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            using (var context = new AnimeListDbContext())
            {
                List<Anime> animes = context.Animes.ToList();
                return View(animes);
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
        public ActionResult Create(Anime anime)
        {
            using (var context = new AnimeListDbContext())
            {
                context.Animes.Add(anime);
                context.SaveChanges();
                return Redirect("/");
            }

        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int? id)
        {
            using (var context = new AnimeListDbContext())
            {
                Anime animeFromDb = context.Animes.Find(id);
                return View(animeFromDb);
            }

        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int? id, Anime animeModel)
        {
            using (var context = new AnimeListDbContext())
            {
                Anime animeFromDb = context.Animes.Find(id);
                context.Animes.Remove(animeFromDb);
                context.SaveChanges();
                return Redirect("/");
            }
        }
    }
}