using InlineEditingJobTask.Models;
using InlineEditingJobTask.Services;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;

namespace InlineEditingJobTask.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService productService;
        public ProductController(ProductService product)
        {
            productService = product;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(productService.Read().ToDataSourceResult(request));
        }
        [AcceptVerbs("Post")]
        public ActionResult Create(Product product)
        {
            if (product != null)
            {
                productService.Create(product);
            }

            return Json(product);
        }

        [AcceptVerbs("Post")]
        public ActionResult Update(Product product)
        {
            if (product != null )
            {
                productService.Update(product);
            }

            return Json(product);
        }

        [AcceptVerbs("Post")]
        public ActionResult Destroy(Product product)
        {
            if (product != null)
            {
                productService.Destroy(product);
            }

            return Json(ModelState);
        }
    }
}
