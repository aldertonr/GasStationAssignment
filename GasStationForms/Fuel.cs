// Author: Ryan Alderton
// SID: 1609275

using System;

namespace GasStationForms
{
    public class Fuel
    {

        // fuel prices as public constants
        public const float UNLEADED = 117.5f;
        public const float DIESEL = 119.5f;
        public const float LPG = 60.1f;

        // Private array of integers to hold the fuel types
        private int[] fuel;

        // Public integer to hold the fuelType
        public int fuelType;
        
        /// <summary>
        /// Fuel Constructor
        /// </summary>
        public Fuel()
        {
            // Initialise the fuel integer array and set elements 0, 1, 2 to be the respective fuels as below
            fuel = new int[] { 0, 1, 2 }; // 0: Unleaded | 1: Diesel | 2: LPG
        }

        /// <summary>
        /// Fuel Constructor with integer of fuel
        /// </summary>
        /// <param name="fuel"></param>
        public Fuel(int fuel)
        {
            // fuelType is the public variable, so assign the private fuel variable to be the fueltype value
            this.fuelType = fuel;
        }
        
        /// <summary>
        /// Randomly generates a number and matches that with HGV, Van or car, and then 
        /// randomly sets the fuelText to be an appropriate fuelType
        /// </summary>
        /// <returns>fuelText - the fuel as a string</returns>
        public static string GenerateFuelText()
        {
            // New instance of random called random
            Random random = new Random();
            // Integer fuel to hold the random number
            int fuel = random.Next(1,3); // Switch between 0 and 1
            // String to hold the fuelText, intialise it as empty to prevent errors here
            string fuelText = "";

            // Instantiate a new Log object
            Log log = new Log();

            // Switch statement based on what vehicle type has been decided in Form1
            switch (Form1.vehicleType)
            {
                // If Form1.vehicleType is HGV, do this
                case "HGV":
                    // As HGV's can only run on diesel, then set the fuelText to be diesel
                    fuelText = "Diesel";
                    break;
                // If form1.vehicletype is Van, do this
                case "Van":
                    // If the fuel variable is 1, then set the fuelText to be Diesel, else it is LPG,
                    // as vans can only run on Diesel or LPG.
                    if (fuel == 1) fuelText = "Diesel";
                    else if (fuel == 2) fuelText = "LPG";
                    break;
                // If form1.vehicletype is car, do this
                case "Car":
                    // Generate a new random number with a ceiling of 3, and assign it to Fuel
                    fuel = random.Next(3);
                    // if fuel is 0, set the fueltext to Unleaded
                    if (fuel == 0) fuelText = "Unleaded";
                    // else if the fuel is 1, then set the fuelText is Diesel
                    else if (fuel == 1) fuelText = "Diesel";
                    // Else if the fuel is 2, then set the fuelText to LPG
                    else if (fuel == 2) fuelText = "LPG";
                    break;
                // The default case to fall into if form1.vehicleType is neither HGV, Van or Car.
                default:
                    // Log the error into Log.txt
                    log.CreateErrorLog("ERROR: GenerateFuelText - incorrect vehicleType supplied");
                    break;
            }

            return fuelText;
        }
    }
}
