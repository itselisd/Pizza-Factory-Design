namespace PizzaShop.Pizzas
{
	public class NYStylePepperoniPizza : Pizza
    {
        public NYStylePepperoniPizza()
        {
            name = "NY Style Sauce and Pepperoni Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Spicy Pepperoni");
        }
    }
}
