using Microsoft.AspNetCore.Mvc;
using Final.Models;

namespace Final.Controllers
{
    public class MonsterController : Controller
    {
        private monsterContext context { get; set; }
        public MonsterController(monsterContext ctx)
        {
            context = ctx;
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Monster());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var monster = context.Monsters.Find(id);
            return View(monster);
        }
        [HttpPost]
        public IActionResult Edit(Monster monster)
        {
            if (ModelState.IsValid)
            {
                if (monster.MonsterID == 0)
                    context.Monsters.Add(monster);
                else
                    context.Monsters.Update(monster);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (monster.MonsterID == 0) ? "Add" : "Edit";
                return View(monster);
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var monster = context.Monsters.Find(id);
            return View(monster);
        }
        [HttpPost]
        public IActionResult Delete(Monster monster)
        {
            context.Monsters.Remove(monster);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

    }
}
