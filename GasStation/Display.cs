// Author: Ryan Alderton
// SID: 1609275

using System;

namespace GasStation
{
    class Display
    {
        const string TITLE = "Petrol Somewhat Unlimited LTD M25";

        public static string pumpOne = "Available",
              pumpTwo = "Available",
              pumpThree = "Available",
              pumpFour = "Available",
              pumpFive = "Available",
              pumpSix = "Available",
              pumpSeven = "Available",
              pumpEight = "Available",
              pumpNine = "Available";
        
        public static bool pumpOneAvail = true,
               pumpTwoAvail = true,
               pumpThreeAvail = true,
               pumpFourAvail = true,
               pumpFiveAvail = true,
               pumpSixAvail = true,
               pumpSevenAvail = true,
               pumpEightAvail = true,
               pumpNineAvail = true;

        public static float pumpOneFuel,
                     pumpTwoFuel,
                     pumpThreeFuel,
                     pumpFourFuel,
                     pumpFiveFuel,
                     pumpSixFuel,
                     pumpSevenFuel,
                     pumpEightFuel,
                     pumpNineFuel;

        public static int vehServiced = 0;

        /// <summary>
        /// Prints and updates the gas station on the screen
        /// </summary>
        public static void Update()
        {
            Console.Clear();
            Console.WriteLine(TITLE);

            // Print the gas station
            Console.WriteLine();
            Console.WriteLine("-----1:{0}-----2:{1}-----3:{2}-----", pumpOne, pumpTwo, pumpThree);
            Console.WriteLine("-----4:{0}-----5:{1}-----6:{2}-----", pumpFour, pumpFive, pumpSix);
            Console.WriteLine("-----7:{0}-----8:{1}-----9:{2}-----", pumpSeven, pumpEight, pumpNine);

            Console.WriteLine("Vehicles Serviced: {0}", vehServiced);
        }

    }
        

            
}
