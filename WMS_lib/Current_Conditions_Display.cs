namespace WMS_lib
{
    /// <summary>
    /// Observer for displaying weather forecast.
    /// </summary>
    public class Current_Conditions_Display : I_Display
    {
        public void Display (float temperature, float humidity)
        {
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine($"Current Condition at {currentDateTime} is:\n Temperature: {temperature} \n Humidity: {humidity}");
        }
    }
}

