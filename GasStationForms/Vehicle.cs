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

        public Vehicle()
        {
            manufacturer = new string[] { "Ford", "Vauxhall", "BMW", "Scania", "Volvo", "Iveco" }; // ?
            vehType = new string[] { "Car", "Van", "HGV" };
        }

        public Vehicle(string manufacturer, string vehType)
        {
            this.ManufacturerText = manufacturer;
            this.VehicleType = vehType;
        }

        public int GenerateFuelLevel(string vehType)
        {
            Random random = new Random();
            
            switch (vehType)
            {
                case "Car":
                    CurrentFuelLvl = random.Next(1, CAR_TANK / 4);
                    Console.WriteLine($"Current fuel level of the car is: {CurrentFuelLvl}");
                   break;
                case "Van":
                    CurrentFuelLvl = random.Next(1, VAN_TANK / 4);
                    Console.WriteLine($"Current fuel level of the car is: {CurrentFuelLvl}");
                    break;
                case "HGV":
                    CurrentFuelLvl = random.Next(1, HGV_TANK / 4);
                    Console.WriteLine($"Current fuel level of the car is: {CurrentFuelLvl}");
                    break;
                default:
                    Console.WriteLine("ERROR: Vehicle type not recognised");
                    CurrentFuelLvl = 0;
                    break;
            }

            return currentFuelLvl;
        }
        
    }
}
