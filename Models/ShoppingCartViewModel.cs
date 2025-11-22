using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace lab2.Models
{
    public class ShoppingCartViewModel
    {

        public string FullName { get; set; }
        public string Address { get; set; }

        public string Supermarket { get; set; }
        public List<SelectListItem> Supermarkets { get; set; }

        public DateTime ShipDate { get; set; }

        public string[] SelectedProducts { get; set; }
        public Dictionary<string, int> AllProducts { get; set; }

        public string ResultMessage { get; set; }

        public ShoppingCartViewModel()
        {
            Supermarkets = new List<SelectListItem>();
            AllProducts = new Dictionary<string, int>();
            SelectedProducts = new string[0];
            ShipDate = DateTime.Today;
        }
    }
}