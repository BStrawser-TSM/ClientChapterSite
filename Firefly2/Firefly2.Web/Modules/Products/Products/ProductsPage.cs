
namespace Firefly2.Products.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Products/Products"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.ProductsRow))]
    public class ProductsController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Products/Products/ProductsIndex.cshtml");
        }
    }
}