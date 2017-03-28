using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStationForms
{
    public class Vehicle
    {
        public string[] manufacturer;
        public int[] fuel;
        public string manufacturerText;
        public int fuelInt;
        public string[] vehType;
        public string vehicleType;

        public Vehicle()
        {
            manufacturer = new string[] { "Ford", "Vauxhall", "BMW", "Scania", "Volvo", "Iveco" }; // ?
            fuel = new int[] { -1, 0, 1 };
            vehType = new string[] { "Car", "Van", "HGV" };
        }

        public Vehicle(string manufacturer, int fuel, string vehType)
        {
            this.manufacturerText = manufacturer;
            this.fuelInt = fuel;
            this.vehicleType = vehType;
           
        }
    }
}
