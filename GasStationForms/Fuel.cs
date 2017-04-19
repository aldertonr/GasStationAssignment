using System;

namespace GasStationForms
{
    public class Fuel
    {

        // Petrol prices as constants
        public const float UNLEADED = 117.5f;
        public const float DIESEL = 119.5f;
        public const float LPG = 60.1f;

        private int[] fuel;

        public int fuelType;

        public Fuel()
        {
            fuel = new int[] { 0, 1, 2 }; // 0: Unleaded | 1: Diesel | 2: LPG
        }

        public Fuel(int fuel)
        {
            this.fuelType = fuel;
        }
        
        public static string GenerateFuelText()
        {
            
            Random random = new Random();
            int fuel = random.Next(1,3); // Switch between 0 and 1
            string fuelText = "";

            switch (Form1.vehicleType)
            {
                case "HGV":
                    fuelText = "Diesel";
                    break;
                case "Van":
                    if (fuel == 1) fuelText = "Diesel";
                    else if (fuel == 2) fuelText = "LPG";
                    break;
                case "Car":
                    fuel = random.Next(3);
                    if (fuel == 0) fuelText = "Unleaded";
                    else if (fuel == 1) fuelText = "Diesel";
                    else if (fuel == 2) fuelText = "LPG";
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            
            return fuelText;
        }
    }
}
