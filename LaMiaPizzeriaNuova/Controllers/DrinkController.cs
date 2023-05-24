using LaMiaPizzeriaNuova.DataBase;
using LaMiaPizzeriaNuova.Models;
using Microsoft.AspNetCore.Mvc;

namespace LaMiaPizzeriaNuova.Controllers
{
    public class DrinkController : Controller
    {
        public IActionResult Index()
        {
            using (PizzaContext db = new PizzaContext())
            {
                List<Drink> drinks = db.Bevande.ToList();

                return View(drinks);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult AddDrink(Drink drinkToAdd)
        {
            if (ModelState.IsValid)
            {
                using (PizzaContext ctx = new PizzaContext())
                {
                    ctx.Add(drinkToAdd);
                    ctx.SaveChanges();
                    return RedirectToAction("Index");

                }
            }
            else
            {
                return View("AddDrink", drinkToAdd);

            }

        }


        [HttpGet]
        public IActionResult AddDrink()
        {
            return View("AddDrink");
        }

    }
}
