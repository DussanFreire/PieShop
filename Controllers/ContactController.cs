using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
    public class ContactController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
