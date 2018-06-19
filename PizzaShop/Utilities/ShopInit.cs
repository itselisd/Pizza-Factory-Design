using System;
using PizzaShop.PizzaStores;
using PizzaShop.Enums;

namespace PizzaShop.Utilities
{
    static class ShopInit
    {
        public static void OpenShop()
        {
            Tools.ColorfulWriteLine("Pizza Shop is open for business! Our recipes are home-brewed " +
                                    "by pizza artisans.\n", ConsoleColor.Blue);
            Tools.ColorfulWriteLine("What is your name?", ConsoleColor.Blue);
            string name = Console.ReadLine();

            bool orderPizza = true;

            while(orderPizza)
            {
                Tools.ColorfulWriteLine($"Hey {name}, would you like to eat in our New York or Chicago location? NY | Chicago", ConsoleColor.Blue);
                string location = null;
                while(location == null)
                {
                    string input = Console.ReadLine().ToLower();
                    if(input == "ny")
                    {
                        location = "ny";
                    }
                    else if(input == "chicago")
                    {
                        location = "chicago";
                    }
                    else
                    {
                        Tools.ColorfulWriteLine("You entered an invalid location, please choose either NY or Chicago", ConsoleColor.Red);
                    }
                }
                if (location == "ny")
                {
                    NYStylePizzaStore nyStore = new NYStylePizzaStore();
                    Tools.ColorfulWriteLine("Thank you for choosing our NY location. What kind of " +
                                            "pizza would you like to order? Cheese | Clam | Pepperoni | Veggie", ConsoleColor.Blue);
                    string input = Console.ReadLine().ToLower();
                    Enum.TryParse(input, out PizzaTypes order); // This tries to parse the input and output it as the out variable as enum
                    Pizza pizza = nyStore.orderPizza(order);
                    Tools.ColorfulWriteLine($"{name} ordered a {pizza.getName()}\n", ConsoleColor.Green);
                }
                else if (location == "chicago")
                {
                    ChicagoStylePizzaStore chicagoStore = new ChicagoStylePizzaStore();
                    Tools.ColorfulWriteLine("Thank you for choosing our Chicago location. What kind of " +
                                            "pizza would you like to order? Cheese | Clam | Pepperoni | Veggie", ConsoleColor.Blue);
                    string input = Console.ReadLine().ToLower();
                    Enum.TryParse(input, out PizzaTypes order);
                    Pizza pizza = chicagoStore.orderPizza(order);
                    Tools.ColorfulWriteLine($"{name} ordered a {pizza.getName()}\n", ConsoleColor.Green);
                }
                Tools.ColorfulWriteLine("Would you like to order again? Y | N", ConsoleColor.Blue);
                string shopAgain = Console.ReadLine().ToLower();
                if(shopAgain != "y") {
                    orderPizza = false;
                }
                Tools.ColorfulWriteLine("Thank you for shopping with us!", ConsoleColor.Yellow);

            }
        }
    }
}
