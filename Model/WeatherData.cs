namespace ApiWeatherMonitoring.Model
{
    public class WeatherData : ISubject
    {
      
        public float GetTemperature()
        {
            return 10.5f;

        }

        public float GetHumidity()
        {
            return 57;
        }

        public float GetPressure()
        {
            return 8;
        }
        public void MeasurementsChanged()
        {
            float temp = GetTemperature();
            float humidity = GetHumidity();
            float pressure = GetPressure();          
        }

        public void RegisterObserver()
        {
            throw new NotImplementedException();
        }

        public void RemoveObserver()
        {
            throw new NotImplementedException();
        }

        public void NotifyObservers()
        {
            throw new NotImplementedException();
        }
    }
}