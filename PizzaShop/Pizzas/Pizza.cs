using System;
using System.Collections.Generic;

namespace PizzaShop
{
    public abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected List<string> toppings = new List<string>();

        public virtual void prepare()
        {
            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            for (int i = 0; i < toppings.Count; i++)
            {
                Console.WriteLine("   " + toppings[i]);
            }
        }

        public virtual void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350 degrees");
        }
        public virtual void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
        public virtual void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public string getName() {
            return name;
        }
    }
}
