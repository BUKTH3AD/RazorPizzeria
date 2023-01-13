using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel() { ImageTitle = "Margerita", PizzaName = "Margerita", TomatoSause = true, Cheese = true, FinalPrice = 4},
            new PizzasModel() { ImageTitle = "Bolognese", PizzaName = "Bolognese", TomatoSause = true, Cheese = true, Beef = true, FinalPrice = 5},
            new PizzasModel() { ImageTitle = "Hawaiian", PizzaName = "Hawaiian", TomatoSause = true, Cheese = true, Ham = true, Pineapple = true, FinalPrice = 15},
            new PizzasModel() { ImageTitle = "Carbonara", PizzaName = "Carbonara", TomatoSause = true, Cheese = true, Ham = true, Mushroom = true, FinalPrice = 6},
            new PizzasModel() { ImageTitle = "MeatFeast", PizzaName = "MeatFeast", TomatoSause = true, Cheese = true, Ham = true, Beef = true, FinalPrice = 6},
            new PizzasModel() { ImageTitle = "Mushroom", PizzaName = "Mushroom", TomatoSause = true, Cheese = true, Mushroom = true, FinalPrice = 5},
            new PizzasModel() { ImageTitle = "Pepperoni", PizzaName = "Pepperoni", TomatoSause = true, Cheese = true, Peperoni = true, FinalPrice = 5},
            new PizzasModel() { ImageTitle = "Seafood", PizzaName = "Seafood", TomatoSause = true, Cheese = true, Tuna = true, FinalPrice = 5},
            new PizzasModel() { ImageTitle = "Vegetarian", PizzaName = "Vegetarian", TomatoSause = true, Cheese = true, Mushroom = true, Pineapple = true, FinalPrice = 12}
        };
         public void OnGet()
        {
        }
    }
}
