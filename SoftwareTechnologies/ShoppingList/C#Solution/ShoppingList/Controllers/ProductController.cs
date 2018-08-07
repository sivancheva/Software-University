using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ShoppingList.Models;

namespace ShoppingList.Controllers
{
    [ValidateInput(false)]
    public class ProductController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            using (var context = new ShoppingListDbContext())
            {
                List<Product> products = context.Products.OrderBy(x=>x.Priority).ToList();
                return View(products);
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
        public ActionResult Create(Product product)
        {
            using (var context = new ShoppingListDbContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
                return Redirect("/");
            }

        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int? id)
        {
            using (var context = new ShoppingListDbContext())
            {
                Product productFromDb = context.Products.Find(id);
                return View(productFromDb);
            }

        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int? id, Product productModel)
        {
            using (var context = new ShoppingListDbContext())
            {
                Product productFromDb = context.Products.Find(id);

                productFromDb.Name = productModel.Name;
                productFromDb.Priority = productModel.Priority;
                productFromDb.Quantity = productModel.Quantity;
                productFromDb.Status = productModel.Status;

                context.SaveChanges();

                return Redirect("/");
            }

        }
    }
}