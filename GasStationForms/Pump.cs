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

        public static float fuellingTime;
        // Declaring the variables
        private static float flowRate = 1.5f; // 1.5 litres / second
        // float var for the litres dispensed whenever this method is called
        public static float litresDispensedThisTransaction = 0f;
        public static float litresDispensed = 0f;
        public static double totalTakings = 0;

        public static decimal commision = 0;
        // Encapsulating the above variables
        public static float FlowRate { get; set; }

        public Pump()
        {
            
        }
        
        public static float GenerateInterval()
        {
            // Instantiating a new random class
            Random random = new Random();
            fuellingTime = random.Next(17000, 19000);

            return fuellingTime;
        }

        /// <summary>
        /// Divides the pump timer interval by the pump flow rate
        /// </summary>
        /// <returns>totalLitresDispensed</returns>
        public static void DispenseFuel()
        {
            // Fuelling time, getting the value from form1 and dividing it by 1000 to make it seconds
            float fuellingTimeInSeconds = GenerateInterval() / 1000;

            Console.WriteLine($"Fuelling Time: {fuellingTimeInSeconds}");

            // Litres dispensed this transaction is the fuelling time in seconds times the flow rate (1.5 seconds)
            litresDispensedThisTransaction = (fuellingTimeInSeconds * flowRate);

            // Display the litres dispensed this transaction in the console window
            Console.WriteLine($"This transaction: {litresDispensedThisTransaction}");

            // Add the litres dispensed this transaction onto the litres dispensed variable
            litresDispensed += litresDispensedThisTransaction;
            
            totalTakings += Math.Round((litresDispensedThisTransaction * UNLEADED / 100), 2);
            
            commision = (decimal)totalTakings / 100;
            
        }

    }
}
