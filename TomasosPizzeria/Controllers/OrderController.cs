using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using TomasosPizzeria.Models;
using TomasosPizzeria.ViewModels;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;



// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TomasosPizzeria.Controllers
{
    public class OrderController : Controller
    {

        private TomasosContext _context;
        public OrderController(TomasosContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult OrderingDishes()
        {
            ViewModelOrders model = new ViewModelOrders();

            string customerName = HttpContext.Session.GetString("loginCustomer");
          
            var Customer = _context.Kund.SingleOrDefault(n => n.AnvandarNamn == customerName);
            model.loggedCustomer = Customer;

            Dictionary<string, List<Matratt>> dishDetails = new Dictionary<string, List<Matratt>>();
            var types = _context.MatrattTyp.ToList();

            foreach (var type in types)
            {
                var tempList = _context.Matratt.Where(p => p.MatrattTyp.Equals(type.MatrattTyp1)).ToList();

                foreach (Matratt dish in tempList)
                {
                    var productList = _context.MatrattProdukt.Where(p => p.MatrattId.Equals(dish.MatrattId));

                    StringBuilder ingredients = new StringBuilder();
                    foreach (MatrattProdukt product in productList)
                    {
                        Produkt ingredient = _context.Produkt.SingleOrDefault(p => p.ProduktId == product.ProduktId);
                        ingredients.Append(ingredient.ProduktNamn);
                        ingredients.Append(", ");
                    }

                    model.dishIngredients.Add(dish, ingredients.ToString());
                }

                dishDetails.Add(type.Beskrivning, tempList);
            }

            model.dishByTypes = dishDetails;
            model.dishTypes = types;

            return View(model);

        }

        public IActionResult AddDish(int ID)
        {
            List<Matratt> dishList;

            Matratt SelectedDish = _context.Matratt.ToList().SingleOrDefault(p => p.MatrattId == ID);

            if (HttpContext.Session.GetString("selectedDishes") == null)
            {
                dishList = new List<Matratt>();        
            }

            else
            {
                var temp = HttpContext.Session.GetString("selectedDishes");

                dishList = JsonConvert.DeserializeObject<List<Matratt>>(temp);
            }

            dishList.Add(SelectedDish);

            var dishes = JsonConvert.SerializeObject(dishList);

            HttpContext.Session.SetString("selectedDishes", dishes);

            return RedirectToAction("OrderingDishes");
        }


        public IActionResult Checkout()
        {
            ViewModelOrders orders = new ViewModelOrders();

            var dishList = HttpContext.Session.GetString("selectedDishes");
            if (dishList == null)
                return RedirectToAction("OrderingDishes");
            // TODO: check if dishlist is null
            List<Matratt> dishes = JsonConvert.DeserializeObject<List<Matratt>>(dishList);


            orders.orderedDishes = dishes; // all the orders will be in dishDetails


            return View(orders);
        }

        public IActionResult CompleteOrder(int totalBelopp)
        {
            var user = HttpContext.Session.GetString("loginCustomer");
            var dishList = HttpContext.Session.GetString("selectedDishes");

            List<Matratt> dishes = JsonConvert.DeserializeObject<List<Matratt>>(dishList);
            Bestallning best = new Bestallning();
            List<Matratt> addedDishes = new List<Matratt>();
            List<BestallningMatratt> orderedDishes = new List<BestallningMatratt>();

            foreach (var dish in dishes)
            {
                if (addedDishes.Select(d => d.MatrattNamn).Contains(dish.MatrattNamn))
                {
                    orderedDishes.Single(d => d.MatrattId == dish.MatrattId).Antal++;
                }
                else
                {
                    addedDishes.Add(dish);
                    BestallningMatratt bM = new BestallningMatratt();
                   
                    bM.Antal = 1;
                    bM.MatrattId = _context.Matratt.Single(m => m.MatrattId == dish.MatrattId).MatrattId;
                    orderedDishes.Add(bM);
                }
            }
            foreach (var order in orderedDishes)
            {
                best.BestallningMatratt.Add(order);
            }

            best.Kund = _context.Kund.Single(k => k.AnvandarNamn == user);
            best.Levererad = false;
            best.Totalbelopp = totalBelopp;
            best.BestallningDatum = DateTime.Now;

            _context.Bestallning.Add(best);
            _context.SaveChanges();

            //Remove from session 
            HttpContext.Session.Remove("selectedDishes");
       
            return View("ViewDishes");
        }

    }
}
