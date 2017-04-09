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
        public string manufacturerText;
        public string[] vehType;
        public string vehicleType;

        // TODO: Implement different classes (car, van, HGV)?

        public Vehicle()
        {
            manufacturer = new string[] { "Ford", "Vauxhall", "BMW", "Scania", "Volvo", "Iveco" }; // ?
            vehType = new string[] { "Car", "Van", "HGV" };
        }

        public Vehicle(string manufacturer, string vehType)
        {
            this.manufacturerText = manufacturer;
            this.vehicleType = vehType;

        }
    }
}
