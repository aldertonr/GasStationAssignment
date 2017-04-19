using System;

namespace GasStationForms
{
    public class Log
    {

        string logLines = "";

        public void CreateLog(string message)
        {
            logLines = $"{DateTime.Now}: MESSAGE: {message}";

            AddLines(logLines);
        }

        /// <summary>
        /// Used to create a log if the car has been fuelled or sent to an occupied pump
        /// </summary>
        /// <param name="pump">The Pump number</param>
        public void CreateStatusLog(string brand, string vehType, string fuel, string pump, bool fuelled)
        {
            switch (fuelled)
            {
                case true:
                    logLines = $"{DateTime.Now}: FUELLED: {brand} {vehType} with {fuel} fuel has been fuelled at {pump}";
                    break;
                case false:
                    logLines = $"{DateTime.Now}: OCCUPIED PUMP: {brand} {vehType} with {fuel} fuel at {pump}";
                    break;
                default:
                    Console.WriteLine("CreateLog Params incorrect");
                    break;
            }

            AddLines(logLines);

        }

        public void CreateFuellingLog(string vehType, float litresDispensed, string pump)
        {
            logLines = $"{DateTime.Now}: FUELLED: {vehType} with {litresDispensed} litres at {pump}";

            AddLines(logLines);
        }

        public void CreateArrivedLog(string brand, string vehType, string fuel)
        { 
            logLines = $"{DateTime.Now}: ARRIVED: {brand} {vehType} with {fuel}, Waiting to be serviced";

            AddLines(logLines);

        }

        public void CreateErrorLog(string errorMessage)
        {
            logLines = $"{DateTime.Now}: ERROR: {errorMessage}";

            AddLines(logLines);
            
        }
        
        public void CreateDriveOffLog()
        {
            logLines = $"{DateTime.Now}: DRIVE-OFF: Vehicle got bored of waiting and drove off";
            AddLines(logLines);
        }

        /// <summary>
        /// Appends all text, adds a new line - protected by try catch
        /// </summary>
        /// <param name="text">The lines to add</param>
        void AddLines(string text)
        {
            try
            {
                System.IO.File.AppendAllText("log.txt", text + Environment.NewLine);
            }
            catch (Exception e)
            {
                Console.WriteLine("EXCEPTION: " + e);
            }
        }


    }

    

}
