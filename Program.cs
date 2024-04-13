
using ClassLibrary6;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
          
            UI.DisplayMenu();

           
            string choice = UI.GetUserChoice();
            double price = DataLogic.GetPrice(choice);

       
            double total = BusinessLogic.CalculateTotalBill(price);

          
            UI.DisplayTotalBill(total);
        }
    }
}
