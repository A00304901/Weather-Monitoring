namespace WMS_lib
{
    /// <summary>
    /// Observer for displaying weather forecast.
    /// </summary>
    public class Forecast_Display : I_Display
    {
        public void Display (float temperature, float humidity)
        {
            // Implement weather forecast logic and display here
            Console.WriteLine("Weather Forecast Display:");
            Console.WriteLine("I like all weathers....!!!");
        }
    }
}

