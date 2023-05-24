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



    }
}
