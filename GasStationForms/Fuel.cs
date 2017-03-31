using System;

namespace GasStationForms
{
    public class Fuel
    {
        public int[] fuel;
        private int fuelType { get; set; }

        public Fuel()
        {
            fuel = new int[] { 0, 1, 2 }; // 0: Unleaded | 1: Diesel | 2: LPG
        }

        public Fuel(int fuel)
        {
            this.fuelType = fuel;
        }
        
        public static string GenerateFuelText(string brand)
        {
            
            Random random = new Random();
            int fuel = random.Next(2); // Switch between 0 and 1
            string fuelText = "";

            if(Form1.vehicleType == "HGV")
            {
                // TODO: ENUM this?
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

            }


            return fuelText;
        }
    }
}
