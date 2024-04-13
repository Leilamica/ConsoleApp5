
namespace ClassLibrary6
{
    public class DataLogic
    {
        public static double GetPrice(string menuItem)
        {
        
            switch (menuItem.ToLower())
            {
                case "adobong manok":
                    return 50.00;
                case "tinola":
                    return 50.00;
                case "sinigang":
                    return 60.00;
                case "bicol express":
                    return 60.00;
                case "kaldereta":
                    return 50.00;
                case "bopis":
                    return 50.00;
                case "chopsuy":
                    return 30.00;
                case "rice":
                    return 10.00;
                default:
                    return 0.00; // If item not found
            }
        }
    }
}
