using System;
namespace PizzaShop.Pizzas
{
	public class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            name = "Chicago Style Deep Dish Veggie Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Mixed Vegetables");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
