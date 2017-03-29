// Author: Ryan Alderton
// SID: 1609275

using System;

namespace GasStationForms
{
    public class Pump
    {
        private static float flowRate = 1500f; // 1.5 litres / second
        public static float FlowRate
        {
            get
            {
                return flowRate;
            }

            set
            {
                flowRate = value;
            }
        }

        public Pump()
        {
            
        }
        
        /// <summary>
        /// Divides the pump timer interval by the pump flow rate
        /// </summary>
        /// <returns>totalLitresDispensed</returns>
        public static float DispenseFuel()
        {
                
            float litresDispensedThisTransaction = 0f;

            litresDispensedThisTransaction = Form1.fuellingTime / FlowRate;

            Console.WriteLine(litresDispensedThisTransaction);
            return litresDispensedThisTransaction;

        }

    }
}
