using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStationForms
{
    public class Vehicle
    {
        // Public arrays: must be public due to accessibility
        public string[] manufacturer;
        public string[] vehType;

        // Private (but encapsulated) string variables
        private string manufacturerText;
        private string vehicleType;
        private float tankSize; // in Litres
        private float currentFuel; // in Litres

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

        // TODO: Implement different classes (car, van, HGV)?

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

        public float GenerateFuelLevel(string vehType)
        {
            float currentFuelLvl = 0f;
            float tankSize;
            Random random = new Random();

            

            return currentFuelLvl;
        }

    }
}
