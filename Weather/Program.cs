using WMS_lib;


        weather_data a = weather_data.Instance;
        a.RegisterObserver(new Current_Conditions_Display());
        a.RegisterObserver(new Forecast_Display());
        a.RegisterObserver(new Statistics_Display());

        Random ran = new Random();
        float temperature = ran.Next(-30, 30);
        float humidity = ran.Next(-30, 30);
        a.SetData(temperature, humidity);
