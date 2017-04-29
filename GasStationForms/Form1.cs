// Author: Ryan Alderton
// SID: 1609275

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GasStationForms
{

    public partial class Form1 : Form
    {
        // Declaration of variables
        public static string vehicleType = "";
        // Integer to hold the amount of vehicles serviced
        static int vehServiced = 0;
        // String to hold the current lblvehInfo text
        string curlblVehInfo;
        // Booleans to show if there's a veh waiting
        bool vehWaiting = false;
        bool vehQueueFull = false;

        // Array of strings to hold the veh to be serviced informationa
        public string[] vehToBeServiced;
        // Array of strings to hold the vehicles waiting and their information
        public string[] vehiclesWaiting;

        // Instatiating a new Log, Vehicle, Fuel and pump class object
        static Log log = new Log();
        private Vehicle vehicle = new Vehicle();
        private Fuel fuel = new Fuel();
        private Pump pump = new Pump();

        // Private strings to hold the vehonPump info
        private string[] vehOnPumpOne,
                vehOnPumpTwo,
                vehOnPumpThree,
                vehOnPumpFour,
                vehOnPumpFive,
                vehOnPumpSix,
                vehOnPumpSeven,
                vehOnPumpEight,
                vehOnPumpNine;

        // Private list of strings to hold the vehicle waiting list
        private List<string> vehWaitList = new List<string>();

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
                    Pump.DispenseFuel(vehOnPumpOne[1], vehOnPumpOne[2]);

                    // Re-enable pumpTwo and pumpThree
                    btnPumpTwo.Enabled = true;
                    btnPumpThree.Enabled = true;

                    // Reset text
                    btnPumpTwo.Text = "Available";
                    btnPumpThree.Text = "Available";
                    break;
                case "pumpTwo":
                    Pump.DispenseFuel(vehOnPumpTwo[1], vehOnPumpTwo[2]);
                    // Enable pumpThree
                    btnPumpThree.Enabled = true;
                    btnPumpThree.Text = "Available";
                    break;
                case "pumpThree":
                    Pump.DispenseFuel(vehOnPumpThree[1], vehOnPumpThree[2]);
                    break;
                case "pumpFour":
                    Pump.DispenseFuel(vehOnPumpFour[1], vehOnPumpFour[2]);
                    // Enable pumpFive and pumpSix
                    btnPumpFive.Enabled = true;
                    btnPumpSix.Enabled = true;

                    btnPumpFive.Text = "Available";
                    btnPumpSix.Text = "Available";
                    break;
                case "pumpFive":
                    Pump.DispenseFuel(vehOnPumpFive[1], vehOnPumpFive[2]);
                    // Enable pumpSix
                    btnPumpSix.Enabled = true;

                    btnPumpSix.Text = "Available";
                    break;
                case "pumpSix":
                    Pump.DispenseFuel(vehOnPumpSix[1], vehOnPumpSix[2]);
                    break;
                case "pumpSeven":
                    Pump.DispenseFuel(vehOnPumpSeven[1], vehOnPumpSeven[2]);
                    // Enable pumpEight and pumpNine
                    btnPumpEight.Enabled = true;
                    btnPumpNine.Enabled = true;

                    btnPumpEight.Text = "Available";
                    btnPumpNine.Text = "Available";
                    break;
                case "pumpEight":
                    Pump.DispenseFuel(vehOnPumpEight[1], vehOnPumpEight[2]);
                    // Enable pumpNine
                    btnPumpNine.Enabled = true;
                    btnPumpNine.Text = "Available";
                    break;
                case "pumpNine":
                    Pump.DispenseFuel(vehOnPumpNine[1], vehOnPumpNine[2]);
                    break;
            }

            // Writes the type of vehicle, fuel and which pump it was fulled at
            log.CreateStatusLog(vehToBeServiced[0], vehToBeServiced[1], vehToBeServiced[2], (string)activeTimer.Tag, true);
            log.CreateFuellingLog(vehToBeServiced[1], Pump.litresDispensedThisTransaction, (string)activeTimer.Tag);

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
            // Let the user now that the demo has been completed via console 
            Console.WriteLine("Runtime Tick - Demo Complete");
            // Let the user know that the demo has been completed via a message box
            MessageBox.Show("Thank you for using my Program, Closing now.", "Closing", MessageBoxButtons.OK);
            // Close the application
            Application.Exit();
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
            // Print to the console that the veh got bored
            log.CreateDriveOffLog();
            // Set the lblvehInfo to be empty
            lblVehInfo.Text = "Waiting for a vehicle to arrive";
            // Set the vehWaiting boolean to be false to indicate there is no veh
            vehWaiting = false;

        }

        #endregion

        /// <summary>
        /// Stores the fuel type for each pump
        /// </summary>
        /// <param name="pump">The relevant Pump number</param>
        void vehOnPump(string pump)
        {

            switch (pump)
            {
                case "pumpOne":

                    vehOnPumpOne = new string[] { vehToBeServiced[0], vehToBeServiced[1], vehToBeServiced[2] };
                    break;
                case "pumpTwo":
                    vehOnPumpTwo = new string[] { vehToBeServiced[0], vehToBeServiced[1], vehToBeServiced[2] };
                    break;
                case "pumpThree":
                    vehOnPumpThree = new string[] { vehToBeServiced[0], vehToBeServiced[1], vehToBeServiced[2] };
                    break;
                case "pumpFour":
                    vehOnPumpFour = new string[] { vehToBeServiced[0], vehToBeServiced[1], vehToBeServiced[2] };
                    break;
                case "pumpFive":
                    vehOnPumpFive = new string[] { vehToBeServiced[0], vehToBeServiced[1], vehToBeServiced[2] };
                    break;
                case "pumpSix":
                    vehOnPumpSix = new string[] { vehToBeServiced[0], vehToBeServiced[1], vehToBeServiced[2] };
                    break;
                case "pumpSeven":
                    vehOnPumpSeven = new string[] { vehToBeServiced[0], vehToBeServiced[1], vehToBeServiced[2] };
                    break;
                case "pumpEight":
                    vehOnPumpEight = new string[] { vehToBeServiced[0], vehToBeServiced[1], vehToBeServiced[2] };
                    break;
                case "pumpNine":
                    vehOnPumpNine = new string[] { vehToBeServiced[0], vehToBeServiced[1], vehToBeServiced[2] };
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

            // Call the vehOnPump method and cast the activeButton.tag to string
            vehOnPump((string)activeButton.Tag);

            // If the pump is free
            if (!CheckPumpBusy(activeButton.Text)) {

                vehOnPump((string)activeButton.Tag);


                try
                {
                    vehWaitList.RemoveAt(0);
                } catch (Exception)
                {
                    vehWaitList.RemoveAt(0);

                    if (vehWaitList.Count == 0)
                    {
                        vehQueueFull = false;
                    }

                }
                DisplayRefresh();

                BlockedLanes((string)activeButton.Tag);

                // Change the text of the button to be occupied
                activeButton.Text = "Occupied";
                // Start the timer
                startTimer(activeButton);
                // Disable all the pump methods
                //DisablePumps();
                // Let the user know why they are waiting
                lblVehInfo.Text = "Waiting for a vehicle to arrive";
                // Change the vehWaiting bool to false, to show there is no veh waiting
                vehWaiting = false;
            } else
            {
                log.CreateStatusLog(vehToBeServiced[0], vehToBeServiced[1], vehToBeServiced[2], (string)activeButton.Tag, false);
                // Save the current veh value
                curlblVehInfo = lblVehInfo.Text;
                // Let the user know that the pump is occupied
                lblVehInfo.Text = "That pump is occupied! Please choose another";
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
                    pumpOneTimer.Interval = (int)Pump.GenerateInterval(vehOnPumpOne[1]);
                    pumpOneTimer.Start();
                    // Print to console which timer has been started
                    Console.WriteLine($"{activeTimer} started");
                    break;
                case "pumpTwo":
                    pumpTwoTimer.Interval = (int)Pump.GenerateInterval(vehOnPumpTwo[1]);
                    pumpTwoTimer.Start();
                    Console.WriteLine($"{activeTimer} started");
                    break;
                case "pumpThree":
                    pumpThreeTimer.Interval = (int)Pump.GenerateInterval(vehOnPumpThree[1]);
                    pumpThreeTimer.Start();
                    Console.WriteLine($"{activeTimer} started");
                    break;
                case "pumpFour":
                    pumpFourTimer.Interval = (int)Pump.GenerateInterval(vehOnPumpFour[1]);
                    pumpFourTimer.Start();
                    Console.WriteLine($"{activeTimer} started");
                    break;
                case "pumpFive":
                    pumpFiveTimer.Interval = (int)Pump.GenerateInterval(vehOnPumpFive[1]);
                    pumpFiveTimer.Start();
                    Console.WriteLine($"{activeTimer} started");
                    break;
                case "pumpSix":
                    pumpSixTimer.Interval = (int)Pump.GenerateInterval(vehOnPumpSix[1]);
                    pumpSixTimer.Start();
                    Console.WriteLine($"{activeTimer} started");
                    break;
                case "pumpSeven":
                    pumpSevenTimer.Interval = (int)Pump.GenerateInterval(vehOnPumpSeven[1]);
                    pumpSevenTimer.Start();
                    Console.WriteLine($"{activeTimer} started");
                    break;

                case "pumpEight":
                    pumpEightTimer.Interval = (int)Pump.GenerateInterval(vehOnPumpEight[1]);
                    pumpEightTimer.Start();
                    Console.WriteLine($"{activeTimer} started");
                    break;
                case "pumpNine":
                    pumpNineTimer.Interval = (int)Pump.GenerateInterval(vehOnPumpNine[1]);
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
            // Call the vehSpawner method to start the vehspawner timer
            VehicleSpawner();
            // Set the lblQueue text value to be empty, to prevent erroneous returns
            lblQueue.Text = "";
            // Set the lblVehInfo
            lblVehInfo.Text = "Waiting for a vehicle to appear...";
            // Make sure all pumps on the forecourt are enabled
            EnablePumps();
        }

        /// <summary>
        /// Run when the exit button on the form is pressed
        /// </summary>
        private void Form1_Close(object sender, FormClosingEventArgs e)
        {
            // Set the form's visible property to false; to make it disapear
            MessageBox.Show("Thank you for using my Program, Closing now.", "Closing", MessageBoxButtons.OK);
            // Close the application
            Application.Exit();
        }

        /// <summary>
        /// Update method to refresh certain text variables on the form itself
        /// </summary>
        private void DisplayRefresh()
        {
            // Give the labels text values to their respective data values
            lblVehServiced.Text = $"Vehicles Serviced: {vehServiced} ";
            lblTakings.Text = $"Takings: £{Pump.totalTakings}";
            lblCommision.Text = $"1% Commision: £{Pump.commision}";
            lblPetrolDispensed.Text = $"Petrol Litres Dispensed: {Pump.petrolLitresDispensed}";
            lblDieselDispensed.Text = $"Diesel Litres Dispensed: {Pump.dieselLitresDispensed}";
            lblLpgDispensed.Text = $"LPG Litres Dispensed: {Pump.lpgLitresDispensed}";
            lblQueue.Text = string.Join("", vehWaitList);
        }


        /// <summary>
        /// veh Spawned Timer Tick Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vehSpawnedTimer_Tick(object sender, EventArgs e)
        {
            // Call the generate veh method and put it's return into the vehinfo label
            lblVehInfo.Text = GenerateVehicle();
            // Change the vehWaiting flag to be true, showing a veh is waiting
            vehWaiting = true;

            // If there is a veh waiting
            if (vehWaiting)
            {
                // Enable all of the buttons on the form
            }

        }

        #region Timer interval generators
        /// <summary>
        /// Generates the random integer for the timer interval
        /// </summary>
        void VehicleSpawner()
        {

            // Instantiating a new random class
            Random random = new Random();

            // Integer to hold the new random integer between 1500 and 2200
            int rndInterval = random.Next(1500, 2200);

            // Setting the vehSpawnedTimer interval to the rndInterval value
            vehSpawnedTimer.Interval = rndInterval;

            // Start the vehSpawnedTimer
            vehSpawnedTimer.Start();   
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
        /// Generates a veh with all the information
        /// </summary>
        /// <returns></returns>
        private string GenerateVehicle()
        {
            // Get the current veh label and put it into a variable
            string curlblvehInfo = lblVehInfo.Text;

            if (vehWaiting)
            {
                // Return the vehinfo prior to editing
                return curlblvehInfo;
            }
            else {

                if (!vehQueueFull)
                {
                    // Variable declarations for ease of access
                    string brand = RandomManufacturer();
                    string vehType = VehicleType(brand);
                    string fuelType = Fuel.GenerateFuelText();
                    float currentFuelLevel = vehicle.GenerateFuelLevel(vehType);

                    // initialise the vehtobeserviced array with strings with the data below
                    vehToBeServiced = new string[] { brand, vehType, fuelType, Convert.ToString(currentFuelLevel) };
                    
                    // veh waiting
                    log.CreateArrivedLog(brand, vehType, fuelType);

                    // Call the addvehicletoqueue and give it the current vehicle type and fuel type
                    AddVehicleToQueue(vehType, fuelType);

                    // Calls the wait time generator method
                    WaitTimerGenerator();

                    // return the brand, vehicle type and fueltype in a string
                    return $"Where should a {brand} {vehType} with {fuelType} fuel go? Please click the pump number.";
                }
                // Return that the vehicle queue is full
                return "Vehicle Queue Full; please service queue first";
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
        /// Generates a random number and then matches it with veh, Van or HGV
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
                    // random generated numbers decide if veh or van
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

        /// <summary>
        /// Tries to add vehType and fuel to vehWaitList if the count less than five
        /// </summary>
        /// <param name="vehType">The vehicle type</param>
        /// <param name="fuel">The fuel type of the vehicle</param>
        void AddVehicleToQueue(string vehType, string fuel)
        {
            
            // If the vehicle wait list is less than 5, then do the following
            if (vehWaitList.Count < 5)
            {
                // Add the vehicle type and fuel to the vehicle wait list
                vehWaitList.Add($"{vehType} with {fuel}\n");
                
                // create a string and join the vehwaitlist                
                string queueText = string.Join("", vehWaitList);

                // set the lblQueue.text to the value of Queue text
                lblQueue.Text = queueText;

            // else do this
            } else
            {
                // Set the lblvehInfo text to tell the user the vehicle wait list is full
                lblVehInfo.Text = "Vehicle Waiting List is currently full.";
                // Write that information to the Command Line
                Console.WriteLine("Vehicle Waiting List is currently full.");
                // Set the vehicle queue full boolean to be true
                vehQueueFull = true;
            }

        }

        /// <summary>
        /// Checks what pumps need to be disabled to implement the blocked lane scenario
        /// </summary>
        /// <param name="pumpPressed"></param>
        void BlockedLanes(string pumpPressed)
        {
            // Switch statement based on what pump was passed into the method
            switch (pumpPressed)
            {
                case "pumpOne":
                    // Disable pumpTwo and pumpThree
                    btnPumpTwo.Enabled = false;
                    btnPumpThree.Enabled = false;

                    // Change button text to be "Blocked"
                    btnPumpTwo.Text = "Blocked";
                    btnPumpThree.Text = "Blocked";
                    break;
                case "pumpTwo":
                    // Disable pumpThree
                    btnPumpThree.Enabled = false;

                    // Change button text to "Blocked"
                    btnPumpThree.Enabled = false;
                    break;
                case "pumpThree":
                    // Nothing is needed to be done, just break out
                    break;
                case "pumpFour":
                    // Disable pumpFive and pumpSix
                    btnPumpFive.Enabled = false;
                    btnPumpSix.Enabled = false;

                    // Change button text to "Blocked"
                    btnPumpFive.Text = "Blocked";
                    btnPumpSix.Text = "Blocked";
                    break;
                case "pumpFive":
                    // Disable pumpSix
                    btnPumpSix.Enabled = false;

                    // Change button text to "Blocked"
                    btnPumpSix.Text = "Blocked";
                    break;
                case "pumpSix":
                    // Nothing is needed, just break out
                    break;
                case "pumpSeven":
                    // Disable pumpEight and pumpNine
                    btnPumpEight.Enabled = false;
                    btnPumpNine.Enabled = false;

                    // Change button text to "Blocked"
                    btnPumpEight.Text = "Blocked";
                    btnPumpNine.Text = "Blocked";
                    break;
                case "pumpEight":
                    // Disable pumpNine
                    btnPumpNine.Enabled = false;

                    // Change button text to "Blocked"
                    btnPumpNine.Text = "Blocked";
                    break;
                case "pumpNine":
                    // Nothing is needed, just break out
                    break;
                default:
                    Console.WriteLine("Default Case");
                    break;
            }

        }

        
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
        
    }
}
