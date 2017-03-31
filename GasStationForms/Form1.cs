// Author: Ryan Alderton
// SID: 1609275

using System;
using System.Windows.Forms;

namespace GasStationForms
{
    
    public partial class Form1 : Form
    {
        // Declaration of variables
        public static string vehicleType = "";
        // The interval for the fuelling timer so it can be passed to Fuel.cs
        public static float fuellingTime = 18000f;
        static int vehServiced = 0;
        string curlblCarInfo;
        bool carWaiting = false;
        
        // Instatiating a new Vehicle and Fuel class object
        private Vehicle vehicle = new Vehicle();
        private Fuel fuel = new Fuel();

        public Vehicle Vehicle { get => vehicle; set => vehicle = value; }
        public Fuel Fuel { get => fuel; set => fuel = value; }


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

            Pump.DispenseFuel();

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
            lblLitresDispensed.Text = $"Litres Dispensed: {Pump.litresDispensed}";
            lblTakings.Text = $"Total Takings: {Pump.totalTakings}";
            // Refresh the display
            DisplayRefresh();

            // TODO: REMOVE THIS AFTER TESTING
            Console.WriteLine($"{activePump} elapsed");
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

        #endregion
        
        /// <summary>
        /// Pump Button Clicked event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPump_Click(object sender, EventArgs e)
        {

            // Declaring a button and casting the object sender to a button
            Button activeButton = ((Button)sender);
            

            // If the pump is free
            if (!CheckPumpBusy(activeButton.Text)) {
                // Change the text of the button to be occupied
                activeButton.Text = "Occupied";
                // Start the timer
                startTimer(activeButton);
                // Disable all the pump methods
                DisablePumps();
                // Let the user know why they are waiting
                lblCarInfo.Text = "Waiting for a car to arrive...";
                // Change the carWaiting bool to false, to show there is no car waiting
                carWaiting = false;
            } else
            {
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
                    pumpOneTimer.Start();
                    // Print to console which timer has been started
                    Console.WriteLine($"{activeTimer} started");
                    break;
                case "pumpTwo":
                    pumpTwoTimer.Start();
                    Console.WriteLine($"{activeTimer} started");
                    break;
                case "pumpThree":
                    pumpThreeTimer.Start();
                    Console.WriteLine($"{activeTimer} started");
                    break;
                case "pumpFour":
                    pumpFourTimer.Start();
                    Console.WriteLine($"{activeTimer} started");
                    break;
                case "pumpFive":
                    pumpFiveTimer.Start();
                    Console.WriteLine($"{activeTimer} started");
                    break;
                case "pumpSix":
                    pumpSixTimer.Start();
                    Console.WriteLine($"{activeTimer} started");
                    break;
                case "pumpSeven":
                    pumpSevenTimer.Start();
                    Console.WriteLine($"{activeTimer} started");
                    break;
                case "pumpEight":
                    pumpEightTimer.Start();
                    Console.WriteLine($"{activeTimer} started");
                    break;
                case "pumpNine":
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
            // Start the car spawned timer, which spawns cars randomly
            carSpawnedTimer.Start();
        }

    /// <summary>
    /// Update method to refresh certain text variables on the form itself
    /// </summary>
    private void DisplayRefresh()
        {
            // Change the vehicleServiced variable to show how many have been serviced
            lblVehServiced.Text = $"Vehicles Serviced: {vehServiced} ";
            lblLitresDispensed.Text = $"Litres Dispensed: {Pump.litresDispensed}";
            lblTakings.Text = $"Takings: £{Pump.totalTakings}";
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
                Console.WriteLine("Car Waiting...");
                // Return the carinfo prior to editing
                return curlblCarInfo;
            }
            else {
                // Variable declarations for ease of access
                string brand = RandomManufacturer();
                string vehType = VehicleType(brand);
                string fuelType = Fuel.GenerateFuelText(brand);
           
                // Console print the brand for debugging purposes
                Console.WriteLine(brand);
            
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
                    break;
            }

            // Return the decided manufacturer variable
            return decidedManufacturer;
        }

        /// <summary>
        /// Generates a random number and then matches it with Car, Van or HGV
        /// </summary>
        /// <param name="brand">The manufacturer of the Vehicle</param>
        /// <returns></returns>
        static string VehicleType(string brand)
        {

            // Instatiating a new Random
            Random rand = new Random();

            // Getting a random int between 0 and 2
            int random = rand.Next(2);
            // Writing the value of random to the console
            Console.WriteLine(random);

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
                    break;
            }

            return vehicleType;
        }
        
        void CreateLog(bool fuelled, string brand, string vehType, string fuel)
        {
            string logLines = "";

            System.IO.File.OpenWrite("log.txt");
            Console.WriteLine("Log.txt created!");

            if (fuelled)
            {
                logLines = $"{DateTime.Now}: {brand} {vehType} with {fuel} fuel has been filled";
                System.IO.File.WriteAllText("log.txt", logLines);
            } else
            {
                logLines = $"{DateTime.Now}: {brand} {vehType} with {fuel} fuel drove off before filling was complete.";
                System.IO.File.WriteAllText("log.txt", logLines);
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

    }
}
