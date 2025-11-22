using lab2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using lab2.Models;
using lab2.Services;

namespace lab2.Controllers
{
    public class TasksController : Controller
    {
        private readonly ITimeService _timeService;

        public TasksController(ITimeService timeService)
        {
            _timeService = timeService;
        }

        // 2. 'SprintTasks' 
        public IActionResult SprintTasks()
        {
            return View();
        }

        // 3. 'Greetings'
        public IActionResult Greetings()
        {
            return View();
        }

        // 4. 'ProductInfo'
        public IActionResult ProductInfo()
        {
            return View();
        }

        // 5. 'SuperMarkets'
        public IActionResult SuperMarkets()
        {
            var markets = new List<string> { "WellMart", "Silpo", "ATB", "Furshet", "Metro" };
            ViewBag.Supermarkets = markets;
            return View();
        }

        // 6. 'ShoppingList'
        public IActionResult ShoppingList()
        {
            var shoppingList = new Dictionary<string, int>
            {
                { "Milk", 2 },
                { "Bread", 2 },
                { "Cake", 1 },
                { "Ice Cream", 5 },
                { "Cola", 10 }
            };
            return View(shoppingList);
        }

        // 8. 'ShoppingCart' - (GET)
        [HttpGet]
        public IActionResult ShoppingCart()
        {
            var viewModel = new ShoppingCartViewModel
            {
                Supermarkets = GetSupermarketsList(),
                AllProducts = GetProductsDictionary()
            };

            return View(viewModel);
        }

        // 8. 'ShoppingCart' - (POST)
        [HttpPost]
        public IActionResult ShoppingCart(ShoppingCartViewModel model)
        {
            model.ResultMessage = $"Your products will be shipped at: {model.Address}. Bon appetite, {model.FullName}!";

            model.Supermarkets = GetSupermarketsList();
            model.AllProducts = GetProductsDictionary();

            return View(model);
        }

        private List<SelectListItem> GetSupermarketsList()
        {
            return new List<SelectListItem>
            {
                new SelectListItem { Text = "WellMart", Value = "WellMart" },
                new SelectListItem { Text = "Silpo", Value = "Silpo" },
                new SelectListItem { Text = "ATB", Value = "ATB" },
                new SelectListItem { Text = "Furshet", Value = "Furshet" },
                new SelectListItem { Text = "Metro", Value = "Metro" }
            };
        }

        private Dictionary<string, int> GetProductsDictionary()
        {
            return new Dictionary<string, int>
            {
                { "Milk", 2 },
                { "Bread", 2 },
                { "Cake", 1 },
                { "Ice Cream", 5 },
                { "Cola", 10 },
                { "Cheese", 0 },
                { "Sausage", 0 }
            };
        }
    }
}