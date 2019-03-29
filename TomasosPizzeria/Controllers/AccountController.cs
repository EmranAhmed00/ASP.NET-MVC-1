using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using TomasosPizzeria.Models;
using TomasosPizzeria.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TomasosPizzeria.Controllers
{
    public class AccountController : Controller
    {
        private TomasosContext _context;
        public AccountController(TomasosContext context)
        {
            _context = context;
        }

        // Sign up here 
        [HttpGet]
        public IActionResult CreateAccount()
        {
            AccountViewModel model = new AccountViewModel();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateAccount(AccountViewModel register)
        {
            Kund newCustomer = new Kund();

            if (ModelState.IsValid)
            {
                newCustomer.AnvandarNamn = register.AnvandarNamn;
                newCustomer.Losenord = register.Losenord;
                newCustomer.Namn = register.Namn;
                newCustomer.Gatuadress = register.Gatuadress;
                newCustomer.Postnr = register.Postnr;
                newCustomer.Postort = register.Postort;
                newCustomer.Email = register.Email;
                newCustomer.Telefon = register.Telefon;

                _context.Kund.Add(newCustomer);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(register);
            }

        }
        // Sign up Success:
        public IActionResult Index()
        {
            return View();
        }

        // Login 

        [HttpGet]
        public IActionResult LogIn()
        {
            LoginViewModel model = new LoginViewModel();

            return View(model);
        }

        public IActionResult LogIn(LoginViewModel model)
        {
            // ViewModelOrders model1 = new ViewModelOrders();

            if (ModelState.IsValid)
            {
                bool login = false;

                foreach (Kund customer in _context.Kund)
                {
                    if (customer.AnvandarNamn == model.UserName &&
                        customer.Losenord == model.Password)
                    {
                        login = true;
                        HttpContext.Session.SetString("loginCustomer", model.UserName);

                        break;
                    }
                }

                if (login)
                    return RedirectToAction("OrderingDishes", "Order");
                else
                    return RedirectToAction("LogIn");
            }
            else
            {
                return View(model);
            }

        }

        //Change Customer Information
        [HttpGet]
        public IActionResult CustomerDetails()
        {
            ViewModelOrders model = new ViewModelOrders();
            string customerName = HttpContext.Session.GetString("loginCustomer");
            var Customer = _context.Kund.SingleOrDefault(n => n.AnvandarNamn == customerName);
            model.loggedCustomer = Customer;


            return View(model);
        }
        [HttpPost]
        public IActionResult CustomerDetails(ViewModelOrders model)
        {

            string customerName = HttpContext.Session.GetString("loginCustomer");
            var Customer = _context.Kund.SingleOrDefault(n => n.AnvandarNamn == customerName);
            Customer.Email = model.loggedCustomer.Email;
            Customer.Gatuadress = model.loggedCustomer.Gatuadress;
            Customer.Postort = model.loggedCustomer.Postort;
            Customer.Postnr = model.loggedCustomer.Postnr;
            Customer.Telefon = model.loggedCustomer.Telefon;
            _context.SaveChanges();
            return View("Update");
        }
    
        // Update Success:
        public IActionResult Update()
        {
            return View();
        }

    }
}
