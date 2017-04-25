// Author: Ryan Alderton
// SID: 1609275

using System;

namespace GasStationForms
{
    public class Vehicle
    {
        // Constants for the tank size in liters
        public const int CAR_TANK = 52;
        const int VAN_TANK = 96;
        const int HGV_TANK = 300;

        // Public arrays: must be public due to accessibility
        public string[] manufacturer;
        public string[] vehType;

        // Private (but encapsulated) string variables
        private string manufacturerText;
        private string vehicleType;
        private float tankSize; // in Litres
        private float currentFuel; // in Litres
        private int currentFuelLvl;

        // The encapsulation property for the above variables
        public string ManufacturerText
        {
            get
            {
                return manufacturerText;
            }

            set
            {
                manufacturerText = value;
            }
        }
        public string VehicleType
        {
            get
            {
                return vehicleType;
            }

            set
            {
                vehicleType = value;
            }
        }
        public float TankSize
        {
            get
            {
                return tankSize;
            }

            set
            {
                tankSize = value;
            }
        }
        public float CurrentFuel
        {
            get
            {
                return currentFuel;
            }

            set
            {
                currentFuel = value;
            }
        }
        public int CurrentFuelLvl
        {
            get
            {
                return currentFuelLvl;
            }

            set
            {
                currentFuelLvl = value;
            }
        }

        // The vehicle constructor
        public Vehicle()
        {
            // set the manufacturer string array to be the following
            manufacturer = new string[] { "Ford", "Vauxhall", "BMW", "Scania", "Volvo", "Iveco" };
            // set the vehType string array to be the following
            vehType = new string[] { "Car", "Van", "HGV" };
        }

        // The vehicle Constructor with two parameters
        public Vehicle(string manufacturer, string vehType)
        {
            // Set the public manufacturertext to be the value of the private manufacturer
            this.ManufacturerText = manufacturer;
            // Set the public vehicleType to be the value of the private vehType
            this.VehicleType = vehType;
        }

        /// <summary>
        /// Generates a random number and returns a random fuelLevel of the vehicle
        /// </summary>
        /// <param name="vehType">The vehicle type (Car, Van, HGV)</param>
        /// <returns>A random fuelLevel of the vehicle, not greater than 25% of the max tank size</returns>
        public int GenerateFuelLevel(string vehType)
        {
            // Instantiate a new random object
            Random random = new Random();
            Log log = new Log();

            // Switched based on the vehType parameter
            switch (vehType)
            {
                // If vehType is car, do this
                case "Car":
                    // set the currentFuelLvl integer to be a random number between 1 and 25% of the car's max tank size
                    CurrentFuelLvl = random.Next(1, CAR_TANK / 4);
                    // Write the current fuel level to the command line
                    Console.WriteLine($"Current fuel level of the car is: {CurrentFuelLvl}");
                   break;
                // if vehType is van, do this
                case "Van":
                    // Set the currentFuelLvl to be a random number between 1 and 25% of the van's max tank size
                    CurrentFuelLvl = random.Next(1, VAN_TANK / 4);
                    // Write the current Fuel level to the command line
                    Console.WriteLine($"Current fuel level of the car is: {CurrentFuelLvl}");
                    break;
                // if the vehType is HGV, do this
                case "HGV":
                    // set the currentfuelLvl integer to be a random number between 1 and 25% of the maximum HGV tank size
                    CurrentFuelLvl = random.Next(1, HGV_TANK / 4);
                    // Write the current fuel level to the command line
                    Console.WriteLine($"Current fuel level of the car is: {CurrentFuelLvl}");
                    break;
                // if the vehType is neither Car, Van or HGV, then do this
                default:
                    // Log the error with the error message
                    log.CreateErrorLog("ERROR: Vehicle type not recognised");
                    // Set the currentFuelLvl to be 0
                    CurrentFuelLvl = 0;
                    break;
            }

            // Return the value decided in the switch
            return currentFuelLvl;
        }
        
    }
}
