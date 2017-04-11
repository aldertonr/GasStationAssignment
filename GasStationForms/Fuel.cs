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
            int fuel = random.Next(2); // Switch between 0 and 1
            string fuelText = "";

            if(Form1.vehicleType == "HGV")
            {
                fuel = 2;
                fuelText = "LPG"; 
            } else if (Form1.vehicleType == "Car" || Form1.vehicleType == "Van")
            {
                if(fuel == 0)
                {
                    fuelText = "Unleaded";
                } else if(fuel == 1)
                {
                    fuelText = "Diesel";
                }
            } else
            {
                Console.WriteLine("Fuel Error");
            }
            
            return fuelText;
        }
    }
}
