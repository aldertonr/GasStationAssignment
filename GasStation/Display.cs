// Author: Ryan Alderton
// SID: 1609275

using System;
using System.Threading;

namespace GasStation
{
    class Display
    {
        const string TITLE = "Petrol Somewhat Unlimited LTD M25";

        public static bool carIsSpawned { get; set; } = false;

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

        // Public int
        public static int vehServiced { get; set;}
        public static int pumpChoice { get; set; }

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

            if (carIsSpawned)
            {
                Console.WriteLine("A blue Ford Fiesta just pulled up. What pump should it go to?");
                try
                {
                    pumpChoice = Int32.Parse(Console.ReadLine());
                } catch (Exception e)
                {
                    Console.WriteLine("That wasn't the correct format!\n");
                    Console.WriteLine(e);
                    Thread.Sleep(2000);

                }
            }

            carIsSpawned = false;
        }

    }
        

            
}
