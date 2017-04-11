// Author: Ryan Alderton
// SID: 1609275

using System;

namespace GasStationForms
{
    public class Pump
    {
        Fuel fuel = new Fuel();

        // float var to hold the fuelling time, which is randomly generated
        public static float fuellingTime;
        // Declaring the variables
        private static float flowRate = 1.5f; // 1.5 litres / second
        // float var for the litres dispensed whenever this method is called
        public static float litresDispensedThisTransaction = 0f;
        // float var to hold the litres dispensed for each type of fuel
        public static float petrolLitresDispensed = 0f;
        public static float dieselLitresDispensed = 0f;
        public static float lpgLitresDispensed = 0f;
        // double var to hold the money earnt from sales
        public static double totalTakings = 0;
        // decimal var to hold the 1% commision earnt
        public static decimal commision = 0;

        // Encapsulating the above variables
        public static float FlowRate { get; set; }

        public Pump()
        {
            
        }
        
        /// <summary>
        /// Generates the time it takes to fuel, between 17 and 19 seconds.
        /// </summary>
        /// <returns></returns>
        public static float GenerateInterval()
        {
            // Instantiating a new random class
            Random random = new Random();
            // Set the fuellingTime variable to be a random number between 17000 and 19000
            fuellingTime = random.Next(17000, 19000);
            
            return fuellingTime;
        }

        /// <summary>
        /// Divides the pump timer interval by the pump flow rate
        /// </summary>
        /// <returns>totalLitresDispensed</returns>
        public static void DispenseFuel(string fuel)
        {
            // Fuelling time, getting the value from form1 and dividing it by 1000 to make it seconds
            float fuellingTimeInSeconds = GenerateInterval() / 1000;

            Console.WriteLine($"Fuelling Time: {fuellingTimeInSeconds}");

            // Litres dispensed this transaction is the fuelling time in seconds times the flow rate (1.5 seconds)
            litresDispensedThisTransaction = (fuellingTimeInSeconds * flowRate);

            // Display the litres dispensed this transaction in the console window
            Console.WriteLine($"This transaction: {litresDispensedThisTransaction}");
            
            // Switch statement based on what fuel the vehicle has
            switch (fuel)
            {
                case "Unleaded":
                    // The total takings is the litres dispensed * cost of fuel / 100 rounded to 2 decimal places
                    totalTakings += Math.Round((litresDispensedThisTransaction * Fuel.UNLEADED / 100), 2);
                    // Add the litres dispensed this transaction to what we have already dispensed
                    petrolLitresDispensed += (float)Math.Round(litresDispensedThisTransaction, 2);
                    // Write the costs and fuel to the CLI
                    Console.WriteLine($"Costs: {totalTakings} at {fuel} cost {Fuel.UNLEADED}");
                    break;
                case "Diesel":
                    totalTakings += Math.Round((litresDispensedThisTransaction * Fuel.DIESEL / 100), 2);
                    dieselLitresDispensed += (float)Math.Round(litresDispensedThisTransaction, 2);
                    Console.WriteLine($"Costs: {totalTakings} at {fuel} cost {Fuel.DIESEL}");
                    break;
                case "LPG":
                    totalTakings += Math.Round((litresDispensedThisTransaction * Fuel.LPG / 100), 2);
                    lpgLitresDispensed += (float)Math.Round(litresDispensedThisTransaction, 2);
                    Console.WriteLine($"Costs: {totalTakings} at {fuel} cost {Fuel.LPG}");
                    break;
                default:
                    Console.WriteLine("Incorrect fuel Provided");
                    break;
            }
            // The commision is the total takings divided by 100 to be 1%
            commision = (decimal)totalTakings / 100;
        }

    }
}
