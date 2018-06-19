using System;
namespace PizzaShop.Utilities
{
    static class Tools
    {
        public static void ColorfulWriteLine(string message, ConsoleColor color) 
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
