﻿namespace GasStationForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPumpOne = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnPumpTwo = new System.Windows.Forms.Button();
            this.btnPumpThree = new System.Windows.Forms.Button();
            this.btnPumpFour = new System.Windows.Forms.Button();
            this.btnPumpFive = new System.Windows.Forms.Button();
            this.btnPumpSix = new System.Windows.Forms.Button();
            this.btnPumpSeven = new System.Windows.Forms.Button();
            this.btnPumpEight = new System.Windows.Forms.Button();
            this.btnPumpNine = new System.Windows.Forms.Button();
            this.lblPumpTwo = new System.Windows.Forms.Label();
            this.lblPumpOne = new System.Windows.Forms.Label();
            this.lblPumpThree = new System.Windows.Forms.Label();
            this.lblPumpFour = new System.Windows.Forms.Label();
            this.lblPumpFive = new System.Windows.Forms.Label();
            this.lblPumpSix = new System.Windows.Forms.Label();
            this.lblPumpSeven = new System.Windows.Forms.Label();
            this.lblPumpEight = new System.Windows.Forms.Label();
            this.lblPumpNine = new System.Windows.Forms.Label();
            this.lblVehServiced = new System.Windows.Forms.Label();
            this.lblCarInfo = new System.Windows.Forms.Label();
            this.runtimeTimer = new System.Windows.Forms.Timer(this.components);
            this.pumpOneTimer = new System.Windows.Forms.Timer(this.components);
            this.pumpTwoTimer = new System.Windows.Forms.Timer(this.components);
            this.pumpThreeTimer = new System.Windows.Forms.Timer(this.components);
            this.pumpFourTimer = new System.Windows.Forms.Timer(this.components);
            this.pumpFiveTimer = new System.Windows.Forms.Timer(this.components);
            this.pumpSixTimer = new System.Windows.Forms.Timer(this.components);
            this.pumpSevenTimer = new System.Windows.Forms.Timer(this.components);
            this.pumpEightTimer = new System.Windows.Forms.Timer(this.components);
            this.pumpNineTimer = new System.Windows.Forms.Timer(this.components);
            this.carSpawnedTimer = new System.Windows.Forms.Timer(this.components);
            this.lblLitresDispensed = new System.Windows.Forms.Label();
            this.lblTakings = new System.Windows.Forms.Label();
            this.lblCommision = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPumpOne
            // 
            this.btnPumpOne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPumpOne.Enabled = false;
            this.btnPumpOne.Location = new System.Drawing.Point(78, 58);
            this.btnPumpOne.Name = "btnPumpOne";
            this.btnPumpOne.Size = new System.Drawing.Size(75, 23);
            this.btnPumpOne.TabIndex = 0;
            this.btnPumpOne.Tag = "pumpOne";
            this.btnPumpOne.Text = "Available";
            this.btnPumpOne.UseVisualStyleBackColor = true;
            this.btnPumpOne.Click += new System.EventHandler(this.btnPump_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Petrol Somewhat Unlimited M25";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPumpTwo
            // 
            this.btnPumpTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPumpTwo.Enabled = false;
            this.btnPumpTwo.Location = new System.Drawing.Point(159, 58);
            this.btnPumpTwo.Name = "btnPumpTwo";
            this.btnPumpTwo.Size = new System.Drawing.Size(75, 23);
            this.btnPumpTwo.TabIndex = 2;
            this.btnPumpTwo.Tag = "pumpTwo";
            this.btnPumpTwo.Text = "Available";
            this.btnPumpTwo.UseVisualStyleBackColor = true;
            this.btnPumpTwo.Click += new System.EventHandler(this.btnPump_Click);
            // 
            // btnPumpThree
            // 
            this.btnPumpThree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPumpThree.Enabled = false;
            this.btnPumpThree.Location = new System.Drawing.Point(240, 58);
            this.btnPumpThree.Name = "btnPumpThree";
            this.btnPumpThree.Size = new System.Drawing.Size(75, 23);
            this.btnPumpThree.TabIndex = 3;
            this.btnPumpThree.Tag = "pumpThree";
            this.btnPumpThree.Text = "Available";
            this.btnPumpThree.UseVisualStyleBackColor = true;
            this.btnPumpThree.Click += new System.EventHandler(this.btnPump_Click);
            // 
            // btnPumpFour
            // 
            this.btnPumpFour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPumpFour.Enabled = false;
            this.btnPumpFour.Location = new System.Drawing.Point(78, 112);
            this.btnPumpFour.Name = "btnPumpFour";
            this.btnPumpFour.Size = new System.Drawing.Size(75, 23);
            this.btnPumpFour.TabIndex = 4;
            this.btnPumpFour.Tag = "pumpFour";
            this.btnPumpFour.Text = "Available";
            this.btnPumpFour.UseVisualStyleBackColor = true;
            this.btnPumpFour.Click += new System.EventHandler(this.btnPump_Click);
            // 
            // btnPumpFive
            // 
            this.btnPumpFive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPumpFive.Enabled = false;
            this.btnPumpFive.Location = new System.Drawing.Point(159, 112);
            this.btnPumpFive.Name = "btnPumpFive";
            this.btnPumpFive.Size = new System.Drawing.Size(75, 23);
            this.btnPumpFive.TabIndex = 5;
            this.btnPumpFive.Tag = "pumpFive";
            this.btnPumpFive.Text = "Available";
            this.btnPumpFive.UseVisualStyleBackColor = true;
            this.btnPumpFive.Click += new System.EventHandler(this.btnPump_Click);
            // 
            // btnPumpSix
            // 
            this.btnPumpSix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPumpSix.Enabled = false;
            this.btnPumpSix.Location = new System.Drawing.Point(240, 112);
            this.btnPumpSix.Name = "btnPumpSix";
            this.btnPumpSix.Size = new System.Drawing.Size(75, 23);
            this.btnPumpSix.TabIndex = 6;
            this.btnPumpSix.Tag = "pumpSix";
            this.btnPumpSix.Text = "Available";
            this.btnPumpSix.UseVisualStyleBackColor = true;
            this.btnPumpSix.Click += new System.EventHandler(this.btnPump_Click);
            // 
            // btnPumpSeven
            // 
            this.btnPumpSeven.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPumpSeven.Enabled = false;
            this.btnPumpSeven.Location = new System.Drawing.Point(78, 167);
            this.btnPumpSeven.Name = "btnPumpSeven";
            this.btnPumpSeven.Size = new System.Drawing.Size(75, 23);
            this.btnPumpSeven.TabIndex = 7;
            this.btnPumpSeven.Tag = "pumpSeven";
            this.btnPumpSeven.Text = "Available";
            this.btnPumpSeven.UseVisualStyleBackColor = true;
            this.btnPumpSeven.Click += new System.EventHandler(this.btnPump_Click);
            // 
            // btnPumpEight
            // 
            this.btnPumpEight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPumpEight.Enabled = false;
            this.btnPumpEight.Location = new System.Drawing.Point(159, 167);
            this.btnPumpEight.Name = "btnPumpEight";
            this.btnPumpEight.Size = new System.Drawing.Size(75, 23);
            this.btnPumpEight.TabIndex = 8;
            this.btnPumpEight.Tag = "pumpEight";
            this.btnPumpEight.Text = "Available";
            this.btnPumpEight.UseVisualStyleBackColor = true;
            this.btnPumpEight.Click += new System.EventHandler(this.btnPump_Click);
            // 
            // btnPumpNine
            // 
            this.btnPumpNine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPumpNine.Enabled = false;
            this.btnPumpNine.Location = new System.Drawing.Point(240, 167);
            this.btnPumpNine.Name = "btnPumpNine";
            this.btnPumpNine.Size = new System.Drawing.Size(75, 23);
            this.btnPumpNine.TabIndex = 9;
            this.btnPumpNine.Tag = "pumpNine";
            this.btnPumpNine.Text = "Available";
            this.btnPumpNine.UseVisualStyleBackColor = true;
            this.btnPumpNine.Click += new System.EventHandler(this.btnPump_Click);
            // 
            // lblPumpTwo
            // 
            this.lblPumpTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPumpTwo.Location = new System.Drawing.Point(159, 42);
            this.lblPumpTwo.Name = "lblPumpTwo";
            this.lblPumpTwo.Size = new System.Drawing.Size(75, 13);
            this.lblPumpTwo.TabIndex = 11;
            this.lblPumpTwo.Text = "Pump Two";
            // 
            // lblPumpOne
            // 
            this.lblPumpOne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPumpOne.Location = new System.Drawing.Point(78, 42);
            this.lblPumpOne.Name = "lblPumpOne";
            this.lblPumpOne.Size = new System.Drawing.Size(75, 13);
            this.lblPumpOne.TabIndex = 12;
            this.lblPumpOne.Text = "Pump One";
            // 
            // lblPumpThree
            // 
            this.lblPumpThree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPumpThree.Location = new System.Drawing.Point(240, 42);
            this.lblPumpThree.Name = "lblPumpThree";
            this.lblPumpThree.Size = new System.Drawing.Size(75, 13);
            this.lblPumpThree.TabIndex = 13;
            this.lblPumpThree.Text = "Pump Three";
            // 
            // lblPumpFour
            // 
            this.lblPumpFour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPumpFour.Location = new System.Drawing.Point(78, 96);
            this.lblPumpFour.Name = "lblPumpFour";
            this.lblPumpFour.Size = new System.Drawing.Size(75, 13);
            this.lblPumpFour.TabIndex = 14;
            this.lblPumpFour.Text = "Pump Four";
            // 
            // lblPumpFive
            // 
            this.lblPumpFive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPumpFive.Location = new System.Drawing.Point(159, 96);
            this.lblPumpFive.Name = "lblPumpFive";
            this.lblPumpFive.Size = new System.Drawing.Size(75, 13);
            this.lblPumpFive.TabIndex = 15;
            this.lblPumpFive.Text = "Pump Five";
            // 
            // lblPumpSix
            // 
            this.lblPumpSix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPumpSix.Location = new System.Drawing.Point(240, 96);
            this.lblPumpSix.Name = "lblPumpSix";
            this.lblPumpSix.Size = new System.Drawing.Size(75, 13);
            this.lblPumpSix.TabIndex = 16;
            this.lblPumpSix.Text = "Pump Six";
            // 
            // lblPumpSeven
            // 
            this.lblPumpSeven.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPumpSeven.Location = new System.Drawing.Point(78, 151);
            this.lblPumpSeven.Name = "lblPumpSeven";
            this.lblPumpSeven.Size = new System.Drawing.Size(75, 13);
            this.lblPumpSeven.TabIndex = 17;
            this.lblPumpSeven.Text = "Pump Seven";
            // 
            // lblPumpEight
            // 
            this.lblPumpEight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPumpEight.Location = new System.Drawing.Point(159, 151);
            this.lblPumpEight.Name = "lblPumpEight";
            this.lblPumpEight.Size = new System.Drawing.Size(75, 13);
            this.lblPumpEight.TabIndex = 18;
            this.lblPumpEight.Text = "Pump Eight";
            // 
            // lblPumpNine
            // 
            this.lblPumpNine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPumpNine.Location = new System.Drawing.Point(237, 151);
            this.lblPumpNine.Name = "lblPumpNine";
            this.lblPumpNine.Size = new System.Drawing.Size(75, 13);
            this.lblPumpNine.TabIndex = 19;
            this.lblPumpNine.Text = "Pump Nine";
            // 
            // lblVehServiced
            // 
            this.lblVehServiced.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblVehServiced.Location = new System.Drawing.Point(30, 207);
            this.lblVehServiced.Name = "lblVehServiced";
            this.lblVehServiced.Size = new System.Drawing.Size(123, 23);
            this.lblVehServiced.TabIndex = 20;
            this.lblVehServiced.Text = "Vehicles Serviced:";
            // 
            // lblCarInfo
            // 
            this.lblCarInfo.Location = new System.Drawing.Point(78, 270);
            this.lblCarInfo.Name = "lblCarInfo";
            this.lblCarInfo.Size = new System.Drawing.Size(237, 59);
            this.lblCarInfo.TabIndex = 21;
            this.lblCarInfo.Text = "Waiting for a car to appear...";
            // 
            // runtimeTimer
            // 
            this.runtimeTimer.Interval = 120000;
            this.runtimeTimer.Tick += new System.EventHandler(this.runtimeTimer_Tick);
            // 
            // pumpOneTimer
            // 
            this.pumpOneTimer.Interval = 1500;
            this.pumpOneTimer.Tag = "pumpOne";
            this.pumpOneTimer.Tick += new System.EventHandler(this.pumpTimer_Tick);
            // 
            // pumpTwoTimer
            // 
            this.pumpTwoTimer.Interval = 18000;
            this.pumpTwoTimer.Tag = "pumpTwo";
            this.pumpTwoTimer.Tick += new System.EventHandler(this.pumpTimer_Tick);
            // 
            // pumpThreeTimer
            // 
            this.pumpThreeTimer.Interval = 18000;
            this.pumpThreeTimer.Tag = "pumpThree";
            this.pumpThreeTimer.Tick += new System.EventHandler(this.pumpTimer_Tick);
            // 
            // pumpFourTimer
            // 
            this.pumpFourTimer.Interval = 18000;
            this.pumpFourTimer.Tag = "pumpFour";
            this.pumpFourTimer.Tick += new System.EventHandler(this.pumpTimer_Tick);
            // 
            // pumpFiveTimer
            // 
            this.pumpFiveTimer.Interval = 18000;
            this.pumpFiveTimer.Tag = "pumpFive";
            this.pumpFiveTimer.Tick += new System.EventHandler(this.pumpTimer_Tick);
            // 
            // pumpSixTimer
            // 
            this.pumpSixTimer.Interval = 18000;
            this.pumpSixTimer.Tag = "pumpSix";
            this.pumpSixTimer.Tick += new System.EventHandler(this.pumpTimer_Tick);
            // 
            // pumpSevenTimer
            // 
            this.pumpSevenTimer.Interval = 18000;
            this.pumpSevenTimer.Tag = "pumpSeven";
            this.pumpSevenTimer.Tick += new System.EventHandler(this.pumpTimer_Tick);
            // 
            // pumpEightTimer
            // 
            this.pumpEightTimer.Interval = 18000;
            this.pumpEightTimer.Tag = "pumpEight";
            this.pumpEightTimer.Tick += new System.EventHandler(this.pumpTimer_Tick);
            // 
            // pumpNineTimer
            // 
            this.pumpNineTimer.Interval = 18000;
            this.pumpNineTimer.Tag = "pumpNine";
            this.pumpNineTimer.Tick += new System.EventHandler(this.pumpTimer_Tick);
            // 
            // carSpawnedTimer
            // 
            this.carSpawnedTimer.Interval = 1500;
            this.carSpawnedTimer.Tick += new System.EventHandler(this.carSpawnedTimer_Tick);
            // 
            // lblLitresDispensed
            // 
            this.lblLitresDispensed.Location = new System.Drawing.Point(30, 230);
            this.lblLitresDispensed.Name = "lblLitresDispensed";
            this.lblLitresDispensed.Size = new System.Drawing.Size(110, 23);
            this.lblLitresDispensed.TabIndex = 22;
            this.lblLitresDispensed.Text = "Litres Dispensed: ";
            // 
            // lblTakings
            // 
            this.lblTakings.Location = new System.Drawing.Point(156, 207);
            this.lblTakings.Name = "lblTakings";
            this.lblTakings.Size = new System.Drawing.Size(110, 23);
            this.lblTakings.TabIndex = 23;
            this.lblTakings.Text = "Takings:  ";
            // 
            // lblCommision
            // 
            this.lblCommision.Location = new System.Drawing.Point(156, 230);
            this.lblCommision.Name = "lblCommision";
            this.lblCommision.Size = new System.Drawing.Size(110, 23);
            this.lblCommision.TabIndex = 24;
            this.lblCommision.Text = "1% Commision: £0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(400, 338);
            this.Controls.Add(this.lblCommision);
            this.Controls.Add(this.lblTakings);
            this.Controls.Add(this.lblLitresDispensed);
            this.Controls.Add(this.lblCarInfo);
            this.Controls.Add(this.lblVehServiced);
            this.Controls.Add(this.lblPumpNine);
            this.Controls.Add(this.lblPumpEight);
            this.Controls.Add(this.lblPumpSeven);
            this.Controls.Add(this.lblPumpSix);
            this.Controls.Add(this.lblPumpFive);
            this.Controls.Add(this.lblPumpFour);
            this.Controls.Add(this.lblPumpThree);
            this.Controls.Add(this.lblPumpOne);
            this.Controls.Add(this.lblPumpTwo);
            this.Controls.Add(this.btnPumpNine);
            this.Controls.Add(this.btnPumpEight);
            this.Controls.Add(this.btnPumpSeven);
            this.Controls.Add(this.btnPumpSix);
            this.Controls.Add(this.btnPumpFive);
            this.Controls.Add(this.btnPumpFour);
            this.Controls.Add(this.btnPumpThree);
            this.Controls.Add(this.btnPumpTwo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnPumpOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Petrol Somewhat Unlimited M25 Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPumpOne;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPumpTwo;
        private System.Windows.Forms.Button btnPumpThree;
        private System.Windows.Forms.Button btnPumpFour;
        private System.Windows.Forms.Button btnPumpFive;
        private System.Windows.Forms.Button btnPumpSix;
        private System.Windows.Forms.Button btnPumpSeven;
        private System.Windows.Forms.Button btnPumpEight;
        private System.Windows.Forms.Button btnPumpNine;
        private System.Windows.Forms.Label lblPumpTwo;
        private System.Windows.Forms.Label lblPumpOne;
        private System.Windows.Forms.Label lblPumpThree;
        private System.Windows.Forms.Label lblPumpFour;
        private System.Windows.Forms.Label lblPumpFive;
        private System.Windows.Forms.Label lblPumpSix;
        private System.Windows.Forms.Label lblPumpSeven;
        private System.Windows.Forms.Label lblPumpEight;
        private System.Windows.Forms.Label lblPumpNine;
        private System.Windows.Forms.Label lblVehServiced;
        private System.Windows.Forms.Label lblCarInfo;
        private System.Windows.Forms.Timer runtimeTimer;
        private System.Windows.Forms.Timer pumpTwoTimer;
        private System.Windows.Forms.Timer pumpThreeTimer;
        private System.Windows.Forms.Timer pumpFourTimer;
        private System.Windows.Forms.Timer pumpFiveTimer;
        private System.Windows.Forms.Timer pumpSixTimer;
        private System.Windows.Forms.Timer pumpSevenTimer;
        private System.Windows.Forms.Timer pumpEightTimer;
        private System.Windows.Forms.Timer pumpNineTimer;
        private System.Windows.Forms.Timer carSpawnedTimer;
        private System.Windows.Forms.Label lblLitresDispensed;
        private System.Windows.Forms.Timer pumpOneTimer;
        private System.Windows.Forms.Label lblTakings;
        private System.Windows.Forms.Label lblCommision;
    }
}

