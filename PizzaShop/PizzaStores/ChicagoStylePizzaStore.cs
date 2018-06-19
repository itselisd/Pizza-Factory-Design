using PizzaShop.Enums;
using PizzaShop.Pizzas;

namespace PizzaShop.PizzaStores
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        override protected Pizza createPizza(PizzaTypes type)
        {
            Pizza pizza = null;

            switch (type)
            {
                case PizzaTypes.cheese:
                    pizza = new ChicagoStyleCheesePizza();
                    break;
                case PizzaTypes.pepperoni:
                    pizza = new ChicagoStylePepperoniPizza();
                    break;
                case PizzaTypes.clam:
                    pizza = new ChicagoStyleClamPizza();
                    break;
                case PizzaTypes.veggie:
                    pizza = new ChicagoStyleVeggiePizza();
                    break;
                default:
                    break;
            }

            return pizza;
        }
    }
}