namespace PizzaShop.Pizzas
{
	public class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza()
        {
            name = "NY Style Sauce and Veggie Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Mixed Vegetables");
        }
    }
}
