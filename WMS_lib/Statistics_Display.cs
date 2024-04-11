using System;
using System.Collections.Generic;

namespace WMS_lib
{
    /// <summary>
    /// Observer for displaying weather statistics.
    /// </summary>
    public class Statistics_Display : I_Display
    {
        private List<float> temperature = new List<float>();
        private List<float> humidity = new List<float>();

        public void Update(float newTemperature, float newHumidity)
        {
            temperature.Add(newTemperature);
            humidity.Add(newHumidity);
            Display(newTemperature, newHumidity);
        }

        public void Display(float temperature, float humidity)
        {
            // Assuming temperature is a single float value
            float[] temperatures = new float[] { temperature }; // Convert temperature to an array

            float avg = CalculateAverage(temperatures);
            float high = FindHighestTemperature(temperatures);

            Console.WriteLine($"Statistic Average temperature: {avg}°C, Highest temperature: {high}°C");
        }

        private float CalculateAverage(float[] temperatures)
        {
            float sum = 0;
            foreach (float temp in temperatures)
            {
                sum += temp;
            }
            return temperatures.Length > 0 ? sum / temperatures.Length : 0; // Avoid division by zero
        }

        private float FindHighestTemperature(float[] temperatures)
        {
            if (temperatures.Length == 0)
            {
                return 0; // Return 0 if no temperatures are provided
            }

            float highest = temperatures[0];
            foreach (float temp in temperatures)
            {
                if (temp > highest)
                {
                    highest = temp;
                }
            }
            return highest;
        }
    }
}