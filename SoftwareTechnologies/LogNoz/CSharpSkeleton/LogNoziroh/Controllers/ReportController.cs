namespace LogNoziroh.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using Models;

    [ValidateInput(false)]
    public class ReportController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            using (var context = new LogNozirohDbContext())
            {
                List<Report> reports = context.Reports.ToList();
                return View(reports);
            }

        }

        [HttpGet]
        [Route("details/{id}")]
        public ActionResult Details(int id)
        {
            using (var context = new LogNozirohDbContext())
            {
                Report reportFromDb = context.Reports.Find(id);
                return View(reportFromDb);
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
        public ActionResult Create(Report report)
        {
            using (var context = new LogNozirohDbContext())
            {
                context.Reports.Add(report);
                context.SaveChanges();
                return Redirect("/");
            }

        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            using (var context = new LogNozirohDbContext())
            {
                Report reportFromDb = context.Reports.Find(id);
                return View(reportFromDb);
            }
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id, Report reportModel)
        {
            using (var context = new LogNozirohDbContext())
            {
                Report taskFromDb = context.Reports.Find(id);
                context.Reports.Remove(taskFromDb);
                context.SaveChanges();

                return Redirect("/");
            }
        }
    }
}