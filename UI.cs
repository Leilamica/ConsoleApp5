using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp5
{
    public class UI
    {
        public static void DisplayMenu()
        {
        
            Console.WriteLine("Welcome to PUP canteen!!");
            Console.WriteLine("1. Adobong manok ---> Php 50.00");
            Console.WriteLine("2. Tinola ---> Php 50.00");
            Console.WriteLine("3. Sinigang ---> Php 60.00");
            Console.WriteLine("4. Bicol express ---> Php 60.00");
            Console.WriteLine("5. Kaldereta ---> Php 50.00");
            Console.WriteLine("6. Bopis ---> Php 50.00");
            Console.WriteLine("7. Chopsuy ---> Php 30.00");
            Console.WriteLine("8. Rice ---> Php 10.00");
            Console.WriteLine("9. None");
        }

        public static string GetUserChoice()
        {
            // UI logic to get user choice
            Console.WriteLine("What's your order?");
            return Console.ReadLine();
        }

        public static void DisplayTotalBill(double total)
        {
          
            Console.WriteLine("Your bill is: " + total.ToString(""));
        }
    }
}