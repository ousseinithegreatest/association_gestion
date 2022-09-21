using Microsoft.AspNetCore.Mvc;

namespace association_gestion.Controllers
{
    public class FinanceController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
