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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int Id, Drink drinkModified)
        {
            if(ModelState.IsValid)
            {
                using(PizzaContext db = new PizzaContext())
                {
                    Drink? drinkToModify = db.Bevande.Where(drink => drink.Id == Id).FirstOrDefault();

                    if(drinkToModify != null)
                    {
                        drinkToModify.Name = drinkModified.Name;
                        drinkToModify.Description = drinkModified.Description;
                        drinkToModify.Liters = drinkModified.Liters;
                        drinkToModify.Price = drinkModified.Price;

                        db.SaveChanges();
                        return RedirectToAction("Index");
                    } else
                    {
                        return NotFound("Bevanda non trovata!!!!");
                    }
                    
                }
               
            }

            return View(drinkModified);
        }

        [HttpGet]
        public IActionResult Update(int Id)
        {
            using (PizzaContext db = new PizzaContext())
            {
                Drink? drinkToModify = db.Bevande.Where(drink => drink.Id == Id).FirstOrDefault();
                
                if(drinkToModify != null)
                {
                    return View(drinkToModify);
                } else
                {
                    return NotFound("Bevanda non trovata!!!!");
                }

            }               

        }

    }

}
