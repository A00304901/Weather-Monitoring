namespace WMS_lib;
public class Weather_Station
{
 public static I_Display selectview (string option)   
 {
    switch (option)
    {
        case "a":
            I_Display ds = new Statistics_Display();
            return ds;
            //break; 
        

        case "b":
            I_Display df = new Forecast_Display();
            return df;
            //break;
            
        default:
        throw new Exception("Wrong Input");
    }
 }
}