using Microsoft.AspNetCore.Mvc;
using TP1_Sotomayor.Models;

namespace TP1_Sotomayor.Controllers
{
    public class HomeController : Controller
    {
        private BaseDeDonnees DB { get; set; }
        public HomeController(BaseDeDonnees dB)
        {
            this.DB = dB;
        }

        public IActionResult Index()
        {
            return View(DB.Parents.ToList());
        }
    }
}
