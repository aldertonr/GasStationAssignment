// Author: Ryan Alderton
// SID: 1609275

using System;
using System.Windows.Forms;

namespace GasStationForms
{
    public partial class Form1 : Form
    {

        // Declaration of variables
        static int vehServiced = 0;
        static string vehicleType = "";
        Vehicle vehicle = new Vehicle();
        
        private static bool pumpOneAvail,
            pumpTwoAvail,
            pumpThreeAvail,
            pumpFourAvail,
            pumpFiveAvail,
            pumpSixAvail,
            pumpSevenAvail,
            pumpEightAvail,
            pumpNineAvail;
        


        #region TickEvents
        /// <summary>
        /// pumpOneTimer elapsed event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pumpOneTimer_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            pumpOneTimer.Stop();
            // Change the text back to Available
            btnPumpOne.Text = "Available";
            // Increments the vehServiced variable
            vehServiced++;
            // Updates the screen
            DisplayRefresh();
        }

        /// <summary>
        /// pumpTwoTimer elapsed event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pumpTwoTimer_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            pumpTwoTimer.Stop();
            // Change the text back to Available
            btnPumpTwo.Text = "Available";
            // Increments the vehServiced variable
            vehServiced++;
            // Updates the screen
            DisplayRefresh();
        }

        /// <summary>
        /// pumpThreeTimer elapsed event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pumpThreeTimer_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            pumpThreeTimer.Stop();
            // Change the text back to Available
            btnPumpThree.Text = "Available";
            // Increments the vehServiced variable
            vehServiced++;
            // Updates the screen
            DisplayRefresh();
        }

        /// <summary>
        /// pumpFourTimer elapsed event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pumpFourTimer_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            pumpFourTimer.Stop();
            // Change the text back to Available
            btnPumpFour.Text = "Available";
            // Increments the vehServiced variable
            vehServiced++;
            // Updates the screen
            DisplayRefresh();
        }

        /// <summary>
        /// pumpFiveTimer elapsed event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pumpFiveTimer_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            pumpFiveTimer.Stop();
            // Change the text back to Available
            btnPumpFive.Text = "Available";
            // Increments the vehServiced variable
            vehServiced++;
            // Updates the screen
            DisplayRefresh();
        }

        /// <summary>
        /// pumpSixTimer elapsed event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pumpSixTimer_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            pumpSixTimer.Stop();
            // Change the text back to Available
            btnPumpSix.Text = "Available";
            // Increments the vehServiced variable
            vehServiced++;
            // Updates the screen
            DisplayRefresh();
        }

        /// <summary>
        /// pumpSevenTimer elapsed event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pumpSevenTimer_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            pumpSevenTimer.Stop();
            // Change the text back to Available
            btnPumpSeven.Text = "Available";
            // Increments the vehServiced variable
            vehServiced++;
            // Updates the screen
            DisplayRefresh();
        }

        /// <summary>
        /// pumpEightTimer elapsed event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pumpEightTimer_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            pumpEightTimer.Stop();
            // Change the text back to Available
            btnPumpEight.Text = "Available";
            // Increments the vehServiced variable
            vehServiced++;
            // Updates the screen
            DisplayRefresh();
        }

        /// <summary>
        /// pumpNineTimer elapsed event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pumpNineTimer_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            pumpNineTimer.Stop();
            // Change the text back to Available
            btnPumpNine.Text = "Available";
            // Increments the vehServiced variable
            vehServiced++;
            // Updates the screen
            DisplayRefresh();
        }
        #endregion

        #region ButtonClickEvents
        /// <summary>
        /// Pump One Clicked event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPumpOne_Click(object sender, EventArgs e)
        {
            // If the pump is free
            if (!CheckPumpBusy(btnPumpOne.Text)) {
                // Change the text of the button to be occupied
                btnPumpOne.Text = "Occupied";
                // Start the timer
                pumpOneTimer.Start();
            }
        }

        /// <summary>
        /// Pump Two Clicked event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnPumpTwo_Click(object sender, EventArgs e)
        {
            // If the pump is free
            if (!CheckPumpBusy(btnPumpTwo.Text))
            {
                // Change the text of the button to be occupied
                btnPumpTwo.Text = "Occupied";
                // Start the timer
                pumpTwoTimer.Start();
            }
        }

        /// <summary>
        /// Pump Three Clicked event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPumpThree_Click(object sender, EventArgs e)
        {
            // If the pump is free
            if (!CheckPumpBusy(btnPumpThree.Text))
            {
                // Change the text of the button to be occupied
                btnPumpThree.Text = "Occupied";
                // Start the timer
                pumpThreeTimer.Start();
            }
        }

        /// <summary>
        /// Pump Four Clicked event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPumpFour_Click(object sender, EventArgs e)
        {
            // If the pump is free
            if (!CheckPumpBusy(btnPumpFour.Text))
            {
                // Change the text of the button to be occupied
                btnPumpFour.Text = "Occupied";
                // Start the timer
                pumpFourTimer.Start();
            }
        }

        /// <summary>
        /// Pump Five Clicked event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPumpFive_Click(object sender, EventArgs e)
        {
            // If the pump is free
            if (!CheckPumpBusy(btnPumpFive.Text))
            {
                // Change the text of the button to be occupied
                btnPumpFive.Text = "Occupied";
                // Start the timer
                pumpFiveTimer.Start();
            }
        }

        /// <summary>
        /// Pump Six Clicked event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPumpSix_Click(object sender, EventArgs e)
        {
            // If the pump is free
            if (!CheckPumpBusy(btnPumpSix.Text))
            {
                // Change the text of the button to be occupied
                btnPumpSix.Text = "Occupied";
                // Start the timer
                pumpSixTimer.Start();
            }
        }
        
        private void runtimeTimer_Tick(object sender, EventArgs e)
        {
            runtimeTimer.Dispose();
            Console.WriteLine("Runtime Tick - Demo Complete");

            // TODO: Create EndDemo form and implement here 
            //this.Visible = false;
            //EndDemo.Visible = true;
        }

        /// <summary>
        /// Pump Seven Clicked event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPumpSeven_Click(object sender, EventArgs e)
        {
            // If the pump is free
            if (!CheckPumpBusy(btnPumpSeven.Text))
            {
                // Change the text of the button to be occupied
                btnPumpSeven.Text = "Occupied";
                // Start the timer
                pumpSevenTimer.Start();
            }
        }

        /// <summary>
        /// Pump Eight Clicked event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPumpEight_Click(object sender, EventArgs e)
        {
            // If the pump is free
            if (!CheckPumpBusy(btnPumpEight.Text))
            {
                // Change the text of the button to be occupied
                btnPumpEight.Text = "Occupied";
                // Start the timer
                pumpEightTimer.Start();
            }
        }

        /// <summary>
        /// Pump Nine Clicked event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPumpNine_Click(object sender, EventArgs e)
        {
            // If the pump is free
            if (!CheckPumpBusy(btnPumpNine.Text))
            {
                // Change the text of the button to be occupied
                btnPumpNine.Text = "Occupied";
                // Start the timer
                pumpNineTimer.Start();
            }
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayRefresh();
            runtimeTimer.Start();
            carSpawnedTimer.Start();
        }

        /// <summary>
        /// Update method to refresh certain text variables on the form itself
        /// </summary>
        private void DisplayRefresh()
        {
            lblVehServiced.Text = "Vehicles Serviced: " + vehServiced;
        }


        /// <summary>
        /// Car Spawned Timer Tick Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void carSpawnedTimer_Tick(object sender, EventArgs e)
        {
            lblCarInfo.Text = GenerateCar();
        }

        private string GenerateCar()
        {
            string brand = RandomManufacturer();
            string vehType = VehicleType(brand);
           
            Console.WriteLine(brand);
            
            return "A " + brand + "  " + vehType + " with " + vehicle.fuel + "go? Please" +
                "click the pump number.";
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
        static string RandomManufacturer()
        {
            string decidedManufacturer = null;
            int randomNum;

            
            Vehicle vehicle = new Vehicle();

            Random random = new Random();
            randomNum = random.Next(5);

            switch (randomNum)
            {
                case 0:
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

            return decidedManufacturer;
        }

        /// <summary>
        /// Generates a random number and then matches it with Car, Van or HGV
        /// </summary>
        /// <param name="brand">The manufacturer of the Vehicle</param>
        /// <returns></returns>
        static string VehicleType(string brand)
        {

            Random rand = new Random();

            int random = rand.Next(2);
            Console.WriteLine(random);

            switch (brand)
            {
                case "Ford":
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


    }
}
