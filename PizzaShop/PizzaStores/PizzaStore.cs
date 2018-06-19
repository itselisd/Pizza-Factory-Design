using PizzaShop.Enums;

namespace PizzaShop
{
    public abstract class PizzaStore
    {

        public Pizza orderPizza(PizzaTypes type)
        {
            Pizza pizza;

            pizza = createPizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }

        // other methods here
        protected abstract Pizza createPizza(PizzaTypes type);
    }
}
