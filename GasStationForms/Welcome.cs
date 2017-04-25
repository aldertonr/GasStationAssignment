// Author: Ryan Alderton
// SID: 1609275

using System;
using System.Windows.Forms;

namespace GasStationForms
{
    public partial class Welcome : Form
    {
        // The welcome form constructor
        public Welcome()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method to run when btnStart is clicked
        /// </summary>
        private void btnStart_Click(object sender, EventArgs e)
        {
            // Create an instance of form1 called mainForm
            Form1 mainForm = new Form1();

            // set the visible property of this form to be false
            this.Visible = false;
            // set the visible property of mainForm to be true
            mainForm.Visible = true;

        }

        /// <summary>
        /// Method to run when the btnHelp button is clicked
        /// </summary>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            // Show a message box with the following message
            MessageBox.Show("The UserGuide can be found in the release folder of the working directory of this program", "User Guide", MessageBoxButtons.OK);
        }
    }
}
