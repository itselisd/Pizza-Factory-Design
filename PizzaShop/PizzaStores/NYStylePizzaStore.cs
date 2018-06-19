using PizzaShop.Pizzas;
using PizzaShop.Enums;

namespace PizzaShop.PizzaStores
{
    public class NYStylePizzaStore : PizzaStore
    {
        override protected Pizza createPizza(PizzaTypes type)
        {
            Pizza pizza = null;

            switch (type) // for type safety we can use enum and a switch rather than checking strings with conditional statements
            {
                case PizzaTypes.cheese:
                    pizza = new NYStyleCheesePizza();
                    break;
                case PizzaTypes.pepperoni:
                    pizza = new NYStylePepperoniPizza();
                    break;
                case PizzaTypes.clam:
                    pizza = new NYStyleClamPizza();
                    break;
                case PizzaTypes.veggie:
                    pizza = new NYStyleVeggiePizza();
                    break;
                default:    
                    break;
            }

            return pizza;
        }
    }
}
