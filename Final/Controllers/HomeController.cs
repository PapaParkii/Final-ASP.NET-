using Microsoft.AspNetCore.Mvc;
using Final.Models;

namespace Final.Controllers
{
    public class HomeController : Controller
    {
        private monsterContext context { get; set; }

        public HomeController(monsterContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var monsters = context.Monsters.OrderBy(m => m.Name).ToList();
            return View(monsters);
        }
    }
}
