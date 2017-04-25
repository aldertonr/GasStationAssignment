// Author: Ryan Alderton
// SID: 1609275

// Log.cs is used for logging messages to log.txt, stored in the root directory for the program.
using System;

namespace GasStationForms
{
    public class Log
    {

        // String to hold the logLines, initialise it as empty
        string logLines = "";

        /// <summary>
        /// Basic CreateLog
        /// </summary>
        /// <param name="message">The message to log</param>
        public void CreateLog(string message)
        {
            // Set the logLines string to be the date and time with the message
            logLines = $"{DateTime.Now}: MESSAGE: {message}";

            // Call the AddLines method with the logLines as the argument
            AddLines(logLines);
        }

        /// <summary>
        /// Used to create a log if the car has been fuelled or sent to an occupied pump
        /// </summary>
        /// <param name="pump">The Pump number</param>
        public void CreateStatusLog(string brand, string vehType, string fuel, string pump, bool fuelled)
        {
            // Switch statement based on the fulled boolean
            switch (fuelled)
            {
                // If fuelled is true, do this
                case true:
                    // Set logLines to be the date and time with the fuelled message, and pass in the brand, vehicleType, fuel and pump
                    logLines = $"{DateTime.Now}: FUELLED: {brand} {vehType} with {fuel} fuel has been fuelled at {pump}";
                    break;
                // If fuelled is false, do this
                case false:
                    // Set the logLines to be the date and time with the occupied pump message, and pass in the parameters
                    logLines = $"{DateTime.Now}: OCCUPIED PUMP: {brand} {vehType} with {fuel} fuel at {pump}";
                    break;
                // The default case to fall into if the parameters are incorrect
                default:
                    // Call the create error log method and supply it a message
                    CreateErrorLog("CreateLog Params incorrect");
                    break;
            }

            // Call the addLines method with the logLines parameter
            AddLines(logLines);

        }

        /// <summary>
        /// Creates a fuellingLog to show a vehicle has been fuelled
        /// </summary>
        public void CreateFuellingLog(string vehType, float litresDispensed, string pump)
        {
            // Set the logLines to be the date and time with the fuelled message with the parameters
            logLines = $"{DateTime.Now}: FUELLED: {vehType} with {litresDispensed} litres at {pump}";

            // call the addLines method with the logLines parameter
            AddLines(logLines);
        }

        /// <summary>
        /// Create a log to show a vehicle has arrived
        /// </summary>
        public void CreateArrivedLog(string brand, string vehType, string fuel)
        { 
            // Set the logLines to be the date and time with an arrived message with parameters
            logLines = $"{DateTime.Now}: ARRIVED: {brand} {vehType} with {fuel}, Waiting to be serviced";

            // Call the AddLines method with the logLines parameter
            AddLines(logLines);

        }

        /// <summary>
        /// Create a log to show errors
        /// </summary>
        /// <param name="errorMessage">The reason for the error log</param>
        public void CreateErrorLog(string errorMessage)
        {
            // Set the logLines variable to be the date and time with an error message, and show the message that was 
            // supplied when the method was called
            logLines = $"{DateTime.Now}: ERROR: {errorMessage}";

            // call the AddLines method with the logLines as the parameter
            AddLines(logLines);
            
        }
        
        /// <summary>
        /// Create a log if a vehicle drives off
        /// </summary>
        public void CreateDriveOffLog()
        {
            // Set the logLines to be the date and time and a drive off message
            logLines = $"{DateTime.Now}: DRIVE-OFF: Vehicle got bored of waiting and drove off";
            // Call the AddLines method with the logLines parameters
            AddLines(logLines);
        }

        /// <summary>
        /// Appends all text, adds a new line - protected by try catch
        /// </summary>
        /// <param name="text">The text to add</param>
        void AddLines(string text)
        {
            // Try to do this,
            try
            {
                // Append all of the text into log.txt and add a new line
                System.IO.File.AppendAllText("log.txt", text + Environment.NewLine);
            }
            // If it cannot do the above code, then catch the exception called e and do this;
            catch (Exception e)
            {
                // Write to the console that there was an exception, and print the stack trace of e
                Console.WriteLine("EXCEPTION: " + e);
            }
        }


    }

    

}
