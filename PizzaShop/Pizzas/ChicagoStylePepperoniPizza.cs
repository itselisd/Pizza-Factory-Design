using System;
namespace PizzaShop.Pizzas
{
    public class ChicagoStylePepperoniPizza : Pizza
    {
        public ChicagoStylePepperoniPizza()
        {
            name = "Chicago Style Deep Dish Pepperoni Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Spicy Pepperoni");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
