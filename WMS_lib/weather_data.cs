namespace WMS_lib;
using System.Collections.Generic;


    /// <summary>
    /// Singleton class for collecting weather data and notifying observers.
    /// </summary>
    public class weather_data
    {
        private static weather_data instance;
        private List<I_Display> ws = new List<I_Display>();
        private float temperature;
        private float humidity;
        
        private weather_data()
        {
        
        }

        public static weather_data Instance
        {
            get
            {
              if (instance == null)
                {
                    instance = new weather_data();
                }
                return instance;
            }
        }

        public void RegisterObserver(I_Display watchs)
        {
            ws.Add(watchs);
        }

        public void RemoveObserver(I_Display watchs)
        {
            ws.Remove(watchs);
        }

        public void NotifyObservers()
        {
            foreach (var watchs in ws)
            {
                watchs.Display(temperature, humidity);
            }
        }   

        public void SetData(float temperature, float humidity)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            NotifyObservers();
        }
    }
