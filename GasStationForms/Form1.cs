﻿// Author: Ryan Alderton
// SID: 1609275

using System;
using System.Windows.Forms;

namespace GasStationForms
{
    
    public partial class Form1 : Form
    {
        // Declaration of variables
        public static string vehicleType = "";
        // Integer to hold the amount of vehicles serviced
        static int vehServiced = 0;
        // String to hold the current lblCarInfo text
        string curlblCarInfo;
        // Boolean to show if there's a car waiting
        bool carWaiting = false;

        // TODO: Implement the carToBeServiced array
        // Array of strings to hold the car to be serviced informationa
        public string[] carToBeServiced;
        // Array of strings to hold the vehicles waiting and their information
        public string[] vehiclesWaiting;

        // Instatiating a new Log, Vehicle, Fuel and pump class object
        static Log log = new Log();
        private Vehicle vehicle = new Vehicle();
        private Fuel fuel = new Fuel();
        private Pump pump = new Pump();

        // Private strings to hold the caronPump info
        private string[] carOnPumpOne,
                carOnPumpTwo,
                carOnPumpThree,
                carOnPumpFour,
                carOnPumpFive,
                carOnPumpSix,
                carOnPumpSeven,
                carOnPumpEight,
                carOnPumpNine;
        
        #region TickEvents

        /// <summary>
        /// Pump Timer Elapsed Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>y
        private void pumpTimer_Tick(object sender, EventArgs e)
        {
            // Create a timer variable and cast the object sender to a timer
            Timer activeTimer = ((Timer)sender);

            // Create a string that holds the tag of the btn that was clicked
            string activePump = (string)activeTimer.Tag;

            // Stop the timer for that event
            activeTimer.Stop();
            
            // Switch statement to decide what fuel to dispense
            switch ((string)activeTimer.Tag)
            {
                case "pumpOne":
                    Pump.DispenseFuel(carOnPumpOne[1], carOnPumpOne[2]);
                    break;
                case "pumpTwo":
                    Pump.DispenseFuel(carOnPumpTwo[1], carOnPumpTwo[2]);
                    break;
                case "pumpThree":
                    Pump.DispenseFuel(carOnPumpThree[1], carOnPumpThree[2]);
                    break;
                case "pumpFour":
                    Pump.DispenseFuel(carOnPumpFour[1], carOnPumpFour[2]);
                    break;
                case "pumpFive":
                    Pump.DispenseFuel(carOnPumpFive[1], carOnPumpFive[2]);
                    break;
                case "pumpSix":
                    Pump.DispenseFuel(carOnPumpSix[1], carOnPumpSix[2]);
                    break;
                case "pumpSeven":
                    Pump.DispenseFuel(carOnPumpSeven[1], carOnPumpSeven[2]);
                    break;
                case "pumpEight":
                    Pump.DispenseFuel(carOnPumpEight[1], carOnPumpEight[2]);
                    break;
                case "pumpNine":
                    Pump.DispenseFuel(carOnPumpNine[1], carOnPumpNine[2]);
                    break;
            }
            
            // Writes the type of vehicle, fuel and which pump it was fulled at
            log.CreateStatusLog(carToBeServiced[0], carToBeServiced[1], carToBeServiced[2], (string)activeTimer.Tag,  true);
            log.CreateFuellingLog(carToBeServiced[1], Pump.litresDispensedThisTransaction, (string)activeTimer.Tag);
            
            // Switch of activePump
            switch (activePump)
            {
                case "pumpOne":
                    btnPumpOne.Text = "Available";
                    break;
                case "pumpTwo":
                    btnPumpTwo.Text = "Available";
                    break;
                case "pumpThree":
                    btnPumpThree.Text = "Available";
                    break;
                case "pumpFour":
                    btnPumpFour.Text = "Available";
                    break;
                case "pumpFive":
                    btnPumpFive.Text = "Available";
                    break;
                case "pumpSix":
                    btnPumpSix.Text = "Available";
                    break;
                case "pumpSeven":
                    btnPumpSeven.Text = "Available";
                    break;
                case "pumpEight":
                    btnPumpEight.Text = "Available";
                    break;
                case "pumpNine":
                    btnPumpNine.Text = "Available";
                    break;
            }

            // Increment the vehicleServiced variable
            vehServiced++;
            lblPetrolDispensed.Text = $"Litres Dispensed: {Pump.petrolLitresDispensed}";
            lblDieselDispensed.Text = $"Litres Dispensed: {Pump.dieselLitresDispensed}";
            lblLpgDispensed.Text = $"Litres Dispensed: {Pump.lpgLitresDispensed}";
            lblTakings.Text = $"Total Takings: {Pump.totalTakings}";
            // Refresh the display
            DisplayRefresh();
            
        }

        private void runtimeTimer_Tick(object sender, EventArgs e)
        {
            // Delete the runtimeTimer object
            runtimeTimer.Dispose();
            // Let the user now that the demo has been completed
            Console.WriteLine("Runtime Tick - Demo Complete");

            // TODO: Create EndDemo form and implement here 
            //this.Visible = false;
            //EndDemo.Visible = true;
        }

        /// <summary>
        /// Handle the driveOffTimer elapsed event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void driveOffTimer_Tick(object sender, EventArgs e)
        {
            // Stop the timer so it doesn't keep happening
            driveOffTimer.Stop();
            // Print to the console that the car got bored

            Console.WriteLine("Vehicle got bored of waiting and drove off");
            log.CreateDriveOffLog();
            // Set the lblCarInfo to be empty
            lblCarInfo.Text = "Waiting for a vehicle to arrive";
            // Set the carWaiting boolean to be false to indicate there is no car
            carWaiting = false;
        }

        #endregion

        /// <summary>
        /// Stores the fuel type for each pump
        /// </summary>
        /// <param name="pump">The relevant Pump number</param>
        void carOnPump(string pump)
        {

            switch (pump)
            {
                case "pumpOne":
                    
                    carOnPumpOne = new string[] { carToBeServiced[0], carToBeServiced[1], carToBeServiced[2] };
                    break;
                case "pumpTwo":
                    carOnPumpTwo = new string[] { carToBeServiced[0], carToBeServiced[1], carToBeServiced[2] };
                    break;
                case "pumpThree":
                    carOnPumpThree = new string[] { carToBeServiced[0], carToBeServiced[1], carToBeServiced[2] };
                    break;
                case "pumpFour":
                    carOnPumpFour = new string[] { carToBeServiced[0], carToBeServiced[1], carToBeServiced[2] };
                    break;
                case "pumpFive":
                    carOnPumpFive = new string[] { carToBeServiced[0], carToBeServiced[1], carToBeServiced[2] };
                    break;
                case "pumpSix":
                    carOnPumpSix = new string[] { carToBeServiced[0], carToBeServiced[1], carToBeServiced[2] };
                    break;
                case "pumpSeven":
                    carOnPumpSeven = new string[] { carToBeServiced[0], carToBeServiced[1], carToBeServiced[2] };
                    break;
                case "pumpEight":
                    carOnPumpEight = new string[] { carToBeServiced[0], carToBeServiced[1], carToBeServiced[2] };
                    break;
                case "pumpNine":
                    carOnPumpNine = new string[] { carToBeServiced[0], carToBeServiced[1], carToBeServiced[2] };
                    break;
                default:
                    Console.WriteLine("ERROR: Incorrect pump Supplied");
                    break;
            }

        }

        /// <summary>
        /// Pump Button Clicked event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPump_Click(object sender, EventArgs e)
        {
            // Declaring a button and casting the object sender to a button
            Button activeButton = ((Button)sender);

            // Call the carOnPump method and cast the activeButton.tag to int
            carOnPump((string)activeButton.Tag);

            // If the pump is free
            if (!CheckPumpBusy(activeButton.Text)) {
                // TODO: Implement a caronPump thing for the log

                carOnPump((string)activeButton.Tag);

                // Change the text of the button to be occupied
                activeButton.Text = "Occupied";
                // Start the timer
                startTimer(activeButton);
                // Disable all the pump methods
                DisablePumps();
                // Let the user know why they are waiting
                lblCarInfo.Text = "Waiting for a vehicle to arrive";
                // Change the carWaiting bool to false, to show there is no car waiting
                carWaiting = false;
            } else
            {
                log.CreateStatusLog(carToBeServiced[0], carToBeServiced[1], carToBeServiced[2], (string)activeButton.Tag, false);
                // Save the current car value
                curlblCarInfo = lblCarInfo.Text;
                // Let the user know that the pump is occupied
                lblCarInfo.Text = "That pump is occupied! Please choose another";
            }
        }
        
        /// <summary>
        /// Starts the set timer, based on what button was clicked
        /// </summary>
        /// <param name="activeButton">From btnClick - the button that was clicked</param>
        private void startTimer(Button activeButton)
        {
            // Set the activeTimer variable to a string cast of the active button tag
            string activeTimer = (string)activeButton.Tag;

            // Switch to decide what timer to start
            switch (activeTimer)
            {
                // If the tag is pumpOne etc, then do the following code;
                case "pumpOne":
                    // Start the timer
                    pumpOneTimer.Interval = (int)Pump.GenerateInterval(carOnPumpOne[1]);
                    pumpOneTimer.Start();
                    // Print to console which timer has been started
                    Console.WriteLine($"{activeTimer} started");
                    break;
                case "pumpTwo":
                    pumpTwoTimer.Interval = (int)Pump.GenerateInterval(carOnPumpTwo[1]);
                    pumpTwoTimer.Start();
                    Console.WriteLine($"{activeTimer} started");
                    break;
                case "pumpThree":
                    pumpThreeTimer.Interval = (int)Pump.GenerateInterval(carOnPumpThree[1]);
                    pumpThreeTimer.Start();
                    Console.WriteLine($"{activeTimer} started");
                    break;
                case "pumpFour":
                    pumpFourTimer.Interval = (int)Pump.GenerateInterval(carOnPumpFour[1]);
                    pumpFourTimer.Start();
                    Console.WriteLine($"{activeTimer} started");
                    break;
                case "pumpFive":
                    pumpFiveTimer.Interval = (int)Pump.GenerateInterval(carOnPumpFive[1]);
                    pumpFiveTimer.Start();
                    Console.WriteLine($"{activeTimer} started");
                    break;
                case "pumpSix":
                    pumpSixTimer.Interval = (int)Pump.GenerateInterval(carOnPumpSix[1]);
                    pumpSixTimer.Start();
                    Console.WriteLine($"{activeTimer} started");
                    break;
                case "pumpSeven":
                    pumpSevenTimer.Interval = (int)Pump.GenerateInterval(carOnPumpSeven[1]);
                    pumpSevenTimer.Start();
                    Console.WriteLine($"{activeTimer} started");
                    break;
                    
                case "pumpEight":
                    pumpEightTimer.Interval = (int)Pump.GenerateInterval(carOnPumpEight[1]);
                    pumpEightTimer.Start();
                    Console.WriteLine($"{activeTimer} started");
                    break;
                case "pumpNine":
                    pumpNineTimer.Interval = (int)Pump.GenerateInterval(carOnPumpNine[1]);
                    pumpNineTimer.Start();
                    Console.WriteLine($"{activeTimer} started");
                    break;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        // Code to do when the form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialise the display by refreshing all the values
            DisplayRefresh();
            // Start the runtimeTimer
            runtimeTimer.Start();
            CarSpawner();
        }

    /// <summary>
    /// Update method to refresh certain text variables on the form itself
    /// </summary>
    private void DisplayRefresh()
        {
            // Change the vehicleServiced variable to show how many have been serviced
            lblVehServiced.Text = $"Vehicles Serviced: {vehServiced} ";
            lblTakings.Text = $"Takings: £{Pump.totalTakings}";
            lblCommision.Text = $"1% Commision: £{Pump.commision}";
            lblPetrolDispensed.Text = $"Petrol Litres Dispensed: {Pump.petrolLitresDispensed}";
            lblDieselDispensed.Text = $"Diesel Litres Dispensed: {Pump.dieselLitresDispensed}";
            lblLpgDispensed.Text = $"LPG Litres Dispensed: {Pump.lpgLitresDispensed}";
        }


        /// <summary>
        /// Car Spawned Timer Tick Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void carSpawnedTimer_Tick(object sender, EventArgs e)
        {
            // Call the generate car method and put it's return into the carinfo label
            lblCarInfo.Text = GenerateCar();
            // Change the carWaiting flag to be true, showing a car is waiting
            carWaiting = true;

            // If there is a car waiting
            if (carWaiting)
            {
                // Enable all of the buttons on the form
                EnablePumps();
            }

        }

        #region Timer interval generators
        /// <summary>
        /// Generates the random integer for the timer interval
        /// </summary>
        void CarSpawner()
        {

            // Instantiating a new random class
            Random random = new Random();

            // Integer to hold the new random integer between 1500 and 2200
            int rndInterval = random.Next(1500, 2200);

            // Setting the carSpawnedTimer interval to the rndInterval value
            carSpawnedTimer.Interval = rndInterval;

            // Start the carSpawnedTimer
            carSpawnedTimer.Start();   
        }

        /// <summary>
        /// Generates the random integer for the timer interval
        /// </summary>
        void WaitTimerGenerator()
        {
            // Instantiates a new random class
            Random random = new Random();

            // Creates an integer to hold the next random integer between 1 and 2 seconds
            int rndInterval = random.Next(1000, 2000);
            
            // set the driveofftimer to be the random generated numbers
            driveOffTimer.Interval = rndInterval;

            // Starts the drive off timer
            driveOffTimer.Start();
        }
        #endregion
        
        /// <summary>
        /// Generates a car with all the information
        /// </summary>
        /// <returns></returns>
        private string GenerateCar()
        {
            // Get the current car label and put it into a variable
            string curlblCarInfo = lblCarInfo.Text;
            
            if (carWaiting)
            {
                // Console print that there is a car waiting
                Console.WriteLine("Vehicle Already waiting - Removing Vehicle");

                Console.WriteLine(curlblCarInfo);

                // Return the carinfo prior to editing
                return curlblCarInfo;
            }
            else {
                // Variable declarations for ease of access
                string brand = RandomManufacturer();
                string vehType = VehicleType(brand);
                string fuelType = Fuel.GenerateFuelText();
                float currentFuelLevel = vehicle.GenerateFuelLevel(vehType);
                
                carToBeServiced = new string[] { brand, vehType, fuelType, Convert.ToString(currentFuelLevel)};
                
                // Car waiting
                log.CreateArrivedLog(brand, vehType, fuelType);
                
                // Calls the wait time generator method
                WaitTimerGenerator();

                // return the brand, vehicle type and fueltype in a string
                return $"Where should a {brand} {vehType} with {fuelType} fuel go? Please click the pump number.";
            }
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
        
        /// <summary>
        /// Generates a random number and matches that with the manufacturer type
        /// </summary>
        /// <returns></returns>
        string RandomManufacturer()
        {
            // Variable declarations
            string decidedManufacturer = null;
            int randomNum;

            // Instantiated a new Random
            Random random = new Random();
            // Getting a random integer between 0 and 5 and putting it into randomNum variable
            randomNum = random.Next(5);

            switch (randomNum)
            {
                case 0:
                    // set the decided manufacturer to be the first element in the manufacturer array
                    // in the vehicle class and so on...
                    decidedManufacturer = vehicle.manufacturer[0]; // Ford
                    break;
                case 1:
                    decidedManufacturer = vehicle.manufacturer[1]; // Vauxhall
                    break;
                case 2:
                    decidedManufacturer = vehicle.manufacturer[2]; // BMW
                    break;
                case 3:
                    decidedManufacturer = vehicle.manufacturer[3]; // Scania HGV
                    break;
                case 4:
                    decidedManufacturer = vehicle.manufacturer[4]; // Volvo HGV
                    break;
                case 5:
                    decidedManufacturer = vehicle.manufacturer[5]; // Iveco HGV
                    break;
                default:
                    Console.WriteLine("Random Number generated {0}, not valid response", randomNum);
                    log.CreateErrorLog($"Random number generated {randomNum}, not a valid response");
                    break;
            }

            // Return the decided manufacturer variable
            return decidedManufacturer;
        }

        /// <summary>
        /// Generates a random number and then matches it with Car, Van or HGV
        /// </summary>
        /// <param name="brand">The type of the Vehicle</param>
        /// <returns></returns>
        static string VehicleType(string brand)
        {
            Vehicle vehicle = new Vehicle();
            // Instatiating a new Random
            Random rand = new Random();

            // Getting a random int between 0 and 2
            int random = rand.Next(2);

            // Switch for selecting vehicle types based on the decided manufacturer
            switch (brand)
            {
                case "Ford":
                    // random generated numbers decide if car or van
                    if (random == 0) vehicleType = "Car";
                    if (random == 1) vehicleType = "Van"; 
                    break;
                case "Vauxhall":
                    if (random == 0) vehicleType = "Car";
                    if (random == 1) vehicleType = "Van";
                    break;
                case "BMW":
                    if (random == 0) vehicleType = "Car";
                    if (random == 1) vehicleType = "Van";
                    break;
                case "Scania":
                    vehicleType = "HGV";
                    break;
                case "Volvo":
                    vehicleType = "HGV";
                    break;
                case "Iveco":
                    vehicleType = "HGV";
                    break;
                default:
                    Console.WriteLine("Brand {0} is not recognised - Error", brand);
                    log.CreateErrorLog($"Brand {brand} is not recognised");
                    break;
            }

            return vehicleType;
        }

        #region Enable/Disable Pumps
        /// <summary>
        /// Enable all the pump buttons on the form
        /// </summary>
        void EnablePumps()
        {
            btnPumpOne.Enabled = true;
            btnPumpTwo.Enabled = true;
            btnPumpThree.Enabled = true;
            btnPumpFour.Enabled = true;
            btnPumpFive.Enabled = true;
            btnPumpSix.Enabled = true;
            btnPumpSeven.Enabled = true;
            btnPumpEight.Enabled = true;
            btnPumpNine.Enabled = true;
        }
        
        // Disable all the pump buttons on the form
        void DisablePumps()
        {
            btnPumpOne.Enabled = false;
            btnPumpTwo.Enabled = false;
            btnPumpThree.Enabled = false;
            btnPumpFour.Enabled = false;
            btnPumpFive.Enabled = false;
            btnPumpSix.Enabled = false;
            btnPumpSeven.Enabled = false;
            btnPumpEight.Enabled = false;
            btnPumpNine.Enabled = false;
        }
        #endregion
        
    }
}
