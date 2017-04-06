// Author: Ryan Alderton
// SID: 1609275

using System;

namespace GasStationForms
{
    public class Pump
    {
        // Petrol prices as constants
        const float UNLEADED = 117.5f;
        const float DIESEL = 119.5f;
        const float LPG = 60.1f;

        // Declaring the variables
        private static float flowRate = 1.5f; // 1.5 litres / second
        public static float litresDispensed = 0f;
        public static double totalTakings = 0;
        public static double commision = 0;
        // Encapsulating the above variables
        public static float FlowRate { get; set; }

        public Pump()
        {
            
        }
        
        /// <summary>
        /// Divides the pump timer interval by the pump flow rate
        /// </summary>
        /// <returns>totalLitresDispensed</returns>
        public static void DispenseFuel()
        {
            
            // float var for the litres dispensed whenever this method is called
            float litresDispensedThisTransaction = 0f;

            // Fuelling time, getting the value from form1 and dividing it by 1000 to make it seconds
            float fuellingTimeInSeconds = Form1.fuellingTime / 1000;

            // Litres dispensed this transaction is the fuelling time in seconds times the flow rate (1.5 seconds)
            litresDispensedThisTransaction = (fuellingTimeInSeconds * flowRate);

            // Display the litres dispensed this transaction in the console window
            Console.WriteLine($"This transaction: {litresDispensedThisTransaction}");

            // Add the litres dispensed this transaction onto the litres dispensed variable
            litresDispensed += litresDispensedThisTransaction;

            Console.WriteLine("LD: " + litresDispensed);

            totalTakings += Math.Round((litresDispensedThisTransaction * UNLEADED / 100), 2);

            commision += Math.Round(totalTakings / 100, 2);

            Console.WriteLine(totalTakings);

        }

    }
}
