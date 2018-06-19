using System;
namespace PizzaShop.Pizzas
{
	public class ChicagoStyleClamPizza : Pizza
    {
        public ChicagoStyleClamPizza()
        {
            name = "Chicago Style Deep Dish Clam Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Fresh Clams");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
