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

        public Vehicle()
        {
            manufacturer = new string[] { "Ford", "Vauxhall", "BMW", "Scania HGV", "Volvo HGV", "Iveco HGV" }; // ?
            fuel = new int[] { -1, 0, 1 };
        }

        public Vehicle(string manufacturer, int fuel)
        {
            this.manufacturerText = manufacturer;
            this.fuelInt = fuel;
           
        }
    }
}
