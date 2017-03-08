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
            Display display = new Display();

            runtimeTimer.Enabled = true;
            Display.Update();

            // Program running do loop
            do
            {
                carSpawner.Enabled = true;

                Console.ReadLine();

                // Switch statement to handle pump selection
                #region Switch to handle pump selection
                switch (userIn)
                {
                    case 1:
                        if (CheckPumpBusy(Display.pumpOne))
                        {
                            Console.WriteLine("This pump is occupied! Please choose another.");
                        }
                        else
                        {

                            Display.pumpOne = "Occupied";
                            Display.Update();
                            Display.pumpOneAvail = false;

                            pumpOneTimer.Enabled = true;
                            pumpOneTimer.Elapsed += new ElapsedEventHandler(onCarFilledEventPumpOne);
                        }

                        break;

                    case 2:
                        if (!CheckPumpBusy(Display.pumpTwo))
                        {
                            Display.pumpTwo = "Occupied";
                            Display.Update();
                            Display.pumpTwoAvail = false;

                            pumpTwoTimer.Enabled = true;
                            pumpTwoTimer.Elapsed += new ElapsedEventHandler(onCarFilledEventPumpTwo);
                        } else
                        {
                            Console.WriteLine("This pump is occupied! Please choose another.");
                        }

                        break;

                    case 3:
                        if (CheckPumpBusy(Display.pumpThree))
                        {
                            Console.WriteLine("This pump is occupied! Please choose another.");
                        } else
                        {
                            Display.pumpThree = "Occupied";
                            Display.Update();
                            Display.pumpThreeAvail = false;

                            pumpThreeTimer.Enabled = true;
                            pumpThreeTimer.Elapsed += new ElapsedEventHandler(onCarFilledEventPumpThree);
                        }

                        break;

                    case 4:
                        if (CheckPumpBusy(Display.pumpFour))
                        {
                            Console.WriteLine("This pump is occupied! Please choose another.");
                        } else
                        {
                            Display.pumpFour = "Occupied";
                            Display.Update();
                            Display.pumpFourAvail = false;

                            pumpFourTimer.Enabled = true;
                            pumpFourTimer.Elapsed += new ElapsedEventHandler(onCarFilledEventPumpFour);
                        }
                        break;

                    case 5:
                        if (CheckPumpBusy(Display.pumpFive))
                        {
                            Console.WriteLine("This pump is occupied! Please choose another.");
                        }
                        else
                        {
                            Display.pumpFive = "Occupied";
                            Display.Update();
                            Display.pumpFiveAvail = false;

                            pumpFiveTimer.Enabled = true;
                            pumpFiveTimer.Elapsed += new ElapsedEventHandler(onCarFilledEventPumpFive);
                        }
                        
                        break;

                    case 6:
                        if (CheckPumpBusy(Display.pumpSix))
                        {
                            Console.WriteLine("This pump is occupied! Please choose another.");
                        } else
                        {
                            Display.pumpSix = "Occupied";
                            Display.Update();
                            Display.pumpSixAvail = false;

                            pumpSixTimer.Enabled = true;
                            pumpSixTimer.Elapsed += new ElapsedEventHandler(onCarFilledEventPumpSix);
                        }
                        
                        break;

                    case 7:
                        if (CheckPumpBusy(Display.pumpSeven))
                        {
                            Console.WriteLine("This pump is occupied! Please choose another.");
                        } else
                        {
                            Display.pumpSeven = "Occupied";
                            Display.Update();
                            Display.pumpSevenAvail = false;

                            pumpSevenTimer.Enabled = true;
                            pumpSevenTimer.Elapsed += new ElapsedEventHandler(onCarFilledEventPumpSeven);
                        }
                        
                        break;

                    case 8:
                        if (CheckPumpBusy(Display.pumpEight))
                        {
                            Console.WriteLine("This pump is occupied! Please choose another.");
                        } else
                        {
                            Display.pumpEight = "Occupied";
                            Display.Update();
                            Display.pumpEightAvail = false;

                            pumpEightTimer.Enabled = true;
                            pumpEightTimer.Elapsed += new ElapsedEventHandler(onCarFilledEventPumpEight);
                        }
                        
                        break;

                    case 9:
                        if (CheckPumpBusy(Display.pumpNine))
                        {
                            Console.WriteLine("This pump is occupied! Please choose another.");
                        } else
                        {
                            Display.pumpNine = "Occupied";
                            Display.Update();
                            Display.pumpNineAvail = false;

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
        static bool CheckPumpBusy(string pump)
        {
            if (pump == "Occupied")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // TODO: Method for adding cars and money


        #region onCarFilledEvent methods

        private static void onCarFilledEventPumpOne(object source, ElapsedEventArgs e)
        {
            pumpOneTimer.Enabled = false; // https://tinyurl.com/zza3zh3
            Display.pumpOne = "Available";
            Display.vehServiced++;
            Display.pumpOneAvail = true;
            Display.Update();
            
        }

        private static void onCarFilledEventPumpTwo(object source, ElapsedEventArgs e)
        {
            pumpTwoTimer.Enabled = false;
            Display.pumpTwo = "Available";
            Display.vehServiced += 1;
            Display.pumpTwoAvail = true;
            Display.Update();
        }

        private static void onCarFilledEventPumpThree(object source, ElapsedEventArgs e)
        {
            pumpThreeTimer.Enabled = false;
            Display.pumpThree = "Available";
            Display.vehServiced += 1;
            Display.pumpThreeAvail = true;
            Display.Update();
        }

        private static void onCarFilledEventPumpFour(object source, ElapsedEventArgs e)
        {
            pumpFourTimer.Enabled = false;
            Display.pumpFour = "Available";
            Display.vehServiced += 1;
            Display.pumpFourAvail = true;
            Display.Update();
        }

        private static void onCarFilledEventPumpFive(object source, ElapsedEventArgs e)
        {
            pumpFiveTimer.Enabled = false;
            Display.pumpFive = "Available";
            Display.vehServiced += 1;
            Display.pumpFiveAvail = true;
            Display.Update();
        }

        private static void onCarFilledEventPumpSix(object source, ElapsedEventArgs e)
        {
            pumpSixTimer.Enabled = false;
            Display.pumpSix = "Available";
            Display.vehServiced += 1;
            Display.pumpSixAvail = true;
            Display.Update();
        }

        private static void onCarFilledEventPumpSeven(object source, ElapsedEventArgs e)
        {
            pumpSevenTimer.Enabled = false;
            Display.pumpSeven = "Available";
            Display.vehServiced += 1;
            Display.pumpFiveAvail = true;
            Display.Update();
        }

        private static void onCarFilledEventPumpEight(object source, ElapsedEventArgs e)
        {
            pumpEightTimer.Enabled = false;
            Display.pumpEight = "Available";
            Display.vehServiced += 1;
            Display.pumpEightAvail = true;
            Display.Update();
        }

        private static void onCarFilledEventPumpNine(object source, ElapsedEventArgs e)
        {
            pumpNineTimer.Enabled = false;
            Display.pumpNine = "Available";
            Display.vehServiced += 1;
            Display.pumpNineAvail = true;
            Display.Update();
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

        /// <summary>
        /// What happens when the car spawning timer elapses
        /// </summary>
        private static void SpawnCar(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("A blue Ford Fiesta just pulled up. What pump should it go to?");
            userIn = Int32.Parse(Console.ReadLine());
            Display.Update();
        }
        #endregion
    }
}
