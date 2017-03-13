// Author: Ryan Alderton
// SID: 1609275

using System;
using System.Timers;

namespace GasStation
{
    class Program
    {
        
        const float WAGE = 2.49f;
        const string TITLE = "Petrol Somewhat Unlimited LTD M25";

        // Fuel prices
        const float UNLEADED = 119.48f; // -1
        const float DIESEL = 121.98f; // 0
        const float LPG = 62.00f; // 1

        // Pump strings declared outside of main so they can be used throughout all methods
        
        static bool running = true;

        // Individual timers for each pump to decide drive off time
        static Timer pumpOneTimer = new Timer(1500);
        static Timer pumpTwoTimer = new Timer(1500);
        static Timer pumpThreeTimer = new Timer(1500);
        static Timer pumpFourTimer = new Timer(1500);
        static Timer pumpFiveTimer = new Timer(1500);
        static Timer pumpSixTimer = new Timer(1500);
        static Timer pumpSevenTimer = new Timer(1500);
        static Timer pumpEightTimer = new Timer(1500);
        static Timer pumpNineTimer = new Timer(1500);

#pragma warning disable 0168
        // Var Declarations
        static int userIn;
        static int litresDispensed;
        static int takings;
        static int commission;
        static int driveOffVeh;
        
#pragma warning restore 0168

        static void Main(string[] args)
        {
            // TODO: Random generators for vehCreate and driveOffs

            // Code for the timers
            Timer carSpawner = new Timer();
            carSpawner.Elapsed += new ElapsedEventHandler(SpawnCar);
            carSpawner.Interval = 5000; // TODO: Change this to 1500 and randomise

            // Runtime timer
            Timer runtimeTimer = new Timer();
            runtimeTimer.Elapsed += new ElapsedEventHandler(runtimeHandler);
            runtimeTimer.Interval = 120000; // 2 minutes

            // TODO: Detailed list of each fuelling transaction - vehType, litresDispensed, pumpNumber

            // Welcome message
            Console.WriteLine("Welcome to Petrol Somewhat Unlimited LTD M25.\nPlease press enter to begin");
            Console.ReadLine();

            // Prompt user for staff number
            Console.WriteLine("Staff ID:");
            string staffID = Console.ReadLine();

            // Print staff number
            Console.WriteLine("Welcome {0}, the Gas Station will load in two seconds.", staffID);
            System.Threading.Thread.Sleep(2000); // Sleep the thread for 2000 milliseconds
            Console.Clear(); // Clear the console window

            // First bit - TODO: Testing
            //Display display = new Display();

            runtimeTimer.Enabled = true;
            Update();

            // Program running do loop
            do
            {
                carSpawner.Enabled = true;

                try
                {
                    pumpChoice = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("That wasn't the correct format!\n");
                    Console.WriteLine(e);
                    System.Threading.Thread.Sleep(2000);
                }

                // Switch statement to handle pump selection
                #region Switch to handle pump selection
                switch ( pumpChoice)
                {
                    case 1:
                        if (!CheckPumpBusy(pumpOneAvail))
                        {
                            pumpOne = "Occupied";
                            Update();
                            pumpOneAvail = false;

                            pumpOneTimer.Enabled = true;
                            pumpOneTimer.Elapsed += new ElapsedEventHandler(onCarFilledEventPumpOne);
                        }
                        else
                        {
                            Console.WriteLine("This pump is occupied! Please choose another.");
                            pumpOneAvail = false;
                        }

                        break;

                    case 2:
                        if (!CheckPumpBusy( pumpTwoAvail))
                        {
                             pumpTwo = "Occupied";
                             Update();
                             pumpTwoAvail = false;

                            pumpTwoTimer.Enabled = true;
                            pumpTwoTimer.Elapsed += new ElapsedEventHandler(onCarFilledEventPumpTwo);
                        } else
                        {
                            Console.WriteLine("This pump is occupied! Please choose another.");
                        }

                        break;

                    case 3:
                        if (CheckPumpBusy( pumpThreeAvail))
                        {
                            Console.WriteLine("This pump is occupied! Please choose another.");
                        } else
                        {
                             pumpThree = "Occupied";
                             Update();
                             pumpThreeAvail = false;

                            pumpThreeTimer.Enabled = true;
                            pumpThreeTimer.Elapsed += new ElapsedEventHandler(onCarFilledEventPumpThree);
                        }

                        break;

                    case 4:
                        if (CheckPumpBusy( pumpFourAvail))
                        {
                            Console.WriteLine("This pump is occupied! Please choose another.");
                        } else
                        {
                             pumpFour = "Occupied";
                             Update();
                             pumpFourAvail = false;

                            pumpFourTimer.Enabled = true;
                            pumpFourTimer.Elapsed += new ElapsedEventHandler(onCarFilledEventPumpFour);
                        }
                        break;

                    case 5:
                        if (CheckPumpBusy( pumpFiveAvail))
                        {
                            Console.WriteLine("This pump is occupied! Please choose another.");
                        }
                        else
                        {
                             pumpFive = "Occupied";
                             Update();
                             pumpFiveAvail = false;

                            pumpFiveTimer.Enabled = true;
                            pumpFiveTimer.Elapsed += new ElapsedEventHandler(onCarFilledEventPumpFive);
                        }
                        
                        break;

                    case 6:
                        if (CheckPumpBusy( pumpSixAvail))
                        {
                            Console.WriteLine("This pump is occupied! Please choose another.");
                        } else
                        {
                             pumpSix = "Occupied";
                             Update();
                             pumpSixAvail = false;

                            pumpSixTimer.Enabled = true;
                            pumpSixTimer.Elapsed += new ElapsedEventHandler(onCarFilledEventPumpSix);
                        }
                        
                        break;

                    case 7:
                        if (CheckPumpBusy( pumpSevenAvail))
                        {
                            Console.WriteLine("This pump is occupied! Please choose another.");
                        } else
                        {
                             pumpSeven = "Occupied";
                             Update();
                             pumpSevenAvail = false;

                            pumpSevenTimer.Enabled = true;
                            pumpSevenTimer.Elapsed += new ElapsedEventHandler(onCarFilledEventPumpSeven);
                        }
                        
                        break;

                    case 8:
                        if (CheckPumpBusy( pumpEightAvail))
                        {
                            Console.WriteLine("This pump is occupied! Please choose another.");
                        } else
                        {
                             pumpEight = "Occupied";
                             Update();
                             pumpEightAvail = false;

                            pumpEightTimer.Enabled = true;
                            pumpEightTimer.Elapsed += new ElapsedEventHandler(onCarFilledEventPumpEight);
                        }
                        
                        break;

                    case 9:
                        if (CheckPumpBusy( pumpNineAvail))
                        {
                            Console.WriteLine("This pump is occupied! Please choose another.");
                        } else
                        {
                             pumpNine = "Occupied";
                             Update();
                             pumpNineAvail = false;

                            pumpNineTimer.Enabled = true;
                            pumpNineTimer.Elapsed += new ElapsedEventHandler(onCarFilledEventPumpNine);
                        }
                        
                        break;

                    default:
                        Console.WriteLine("u done fucked up");
                        break;
                }
                #endregion

            } while (running == true);

        }
        
        /// <summary>
        /// Check if the pump is busy
        /// </summary>
        /// <param name="pump">The pump number to check</param>
        /// <returns>true if busy, false if not</returns>
        static bool CheckPumpBusy(bool pump)
        {
            if (pump == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// A method for incrementing the vehServiced integer
        /// </summary>
        /// <returns>vehServiced</returns>
        static int VehicleServiced()
        {
            vehServiced = vehServiced + 1;
            return vehServiced;
        }

        // TODO: Method for adding cars and money

        #region UPDATE:TESTING

        public static bool pumpOneAvail = true,
           pumpTwoAvail = true,
           pumpThreeAvail = true,
           pumpFourAvail = true,
           pumpFiveAvail = true,
           pumpSixAvail = true,
           pumpSevenAvail = true,
           pumpEightAvail = true,
           pumpNineAvail = true;

        // Public int
        public static int vehServiced { get; set; }
        public static int pumpChoice { get; set; } = 0;

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
            }

            carIsSpawned = false;
        }
        #endregion

        #region onCarFilledEvent methods

        private static void onCarFilledEventPumpOne(object source, ElapsedEventArgs e)
        {
            pumpOneTimer.Enabled = false; // https://tinyurl.com/zza3zh3
             pumpOne = "Available";
             VehicleServiced();
             pumpOneAvail = true;
             Update();
        }

        private static void onCarFilledEventPumpTwo(object source, ElapsedEventArgs e)
        {
            pumpTwoTimer.Enabled = false;
             pumpTwo = "Available";
             VehicleServiced();
             pumpTwoAvail = true;
             Update();
        }

        private static void onCarFilledEventPumpThree(object source, ElapsedEventArgs e)
        {
            pumpThreeTimer.Enabled = false;
             pumpThree = "Available";
             VehicleServiced();
             pumpThreeAvail = true;
             Update();
        }

        private static void onCarFilledEventPumpFour(object source, ElapsedEventArgs e)
        {
            pumpFourTimer.Enabled = false;
             pumpFour = "Available";
             VehicleServiced();
             pumpFourAvail = true;
             Update();
        }

        private static void onCarFilledEventPumpFive(object source, ElapsedEventArgs e)
        {
            pumpFiveTimer.Enabled = false;
             pumpFive = "Available";
             VehicleServiced();
             pumpFiveAvail = true;
             Update();
        }

        private static void onCarFilledEventPumpSix(object source, ElapsedEventArgs e)
        {
            pumpSixTimer.Enabled = false;
             pumpSix = "Available";
             VehicleServiced();
             pumpSixAvail = true;
             Update();
        }

        private static void onCarFilledEventPumpSeven(object source, ElapsedEventArgs e)
        {
            pumpSevenTimer.Enabled = false;
             pumpSeven = "Available";
             VehicleServiced();
             pumpFiveAvail = true;
             Update();
        }

        private static void onCarFilledEventPumpEight(object source, ElapsedEventArgs e)
        {
            pumpEightTimer.Enabled = false;
             pumpEight = "Available";
             VehicleServiced();
             pumpEightAvail = true;
             Update();
        }

        private static void onCarFilledEventPumpNine(object source, ElapsedEventArgs e)
        {
            pumpNineTimer.Enabled = false;
             pumpNine = "Available";
             VehicleServiced();
             pumpNineAvail = true;
             Update();
        }

        #endregion
        
        #region misc event handlers
        /// <summary>
        /// Event handler for the runtime timer
        /// </summary>
        private static void runtimeHandler(object source, ElapsedEventArgs e)
        {
            running = false;
            Console.WriteLine("Thank you for viewing the demo of Gas Station - 2 minutes has elapsed and the demo is over.");
        }

        // TODO: Re-implement this, fix this, or remove this
        /// <summary>
        /// What happens when the car spawning timer elapses - UN-USED FOR TESTING
        /// </summary>
       // private static void SpawnCar(object source, ElapsedEventArgs e)
      //  {
       //     Console.WriteLine("A blue Ford Fiesta just pulled up. What pump should it go to?");
        //    userIn = Int32.Parse(Console.ReadLine());
       //      Update();
      //  }


        private static void SpawnCar(object source, ElapsedEventArgs e)
        {
             carIsSpawned = true;
             Update();
        }

        #endregion
    }
}
