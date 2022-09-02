using Microsoft.AspNetCore.Mvc;

namespace OnlineShop2.Areas.Seller.Controllers
{
    public class SellerOrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
