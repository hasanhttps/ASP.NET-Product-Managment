using Microsoft.AspNetCore.Mvc;
using ASP.NET_Product_Managment.Models.Conceretes;

namespace ASP.NET_Product_Managment.Controllers {
    public class ProductController : Controller {

        // Fields

        public List<Product> Products { get; set; }

        // Constructor

        public ProductController() {
            Products = new List<Product>() {
                new Product { Id = 1,Name="Cola",Price=10},
                new Product { Id = 2,Name="Lays",Price=12},
                new Product { Id = 3,Name="Sprite",Price=14},
                new Product { Id = 4,Name="Doritos",Price=16},
                new Product { Id = 5,Name="Fanta",Price=19},
                new Product { Id = 6,Name="Mirinda",Price=20},
                new Product { Id = 7,Name="Mountain Dew",Price=30},
                new Product { Id = 8,Name="Pepsi",Price=40},
                new Product { Id = 9,Name="Snickers",Price=50},
                new Product { Id = 10,Name="Bounty",Price=110},
                new Product { Id = 11,Name="Salmon",Price=80},
                new Product { Id = 12,Name="Cappy",Price=90},
                new Product { Id = 13,Name="Red Bull",Price=111},
                new Product { Id = 14,Name="Hell",Price=102},
                new Product { Id = 15,Name="Bizon",Price=104},
                new Product { Id = 16,Name="Burn",Price=105},
                new Product { Id = 17,Name="Dynamit",Price=106},
                new Product { Id = 18,Name="Twix",Price=107},
                new Product { Id = 19,Name="Mars",Price=108},
                new Product { Id = 20,Name="Magnum",Price=113},
            };
        }


        // Actions

        public IActionResult AllProducts() {
            return View(Products);
        }
    }
}
