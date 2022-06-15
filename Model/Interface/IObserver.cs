namespace ApiWeatherMonitoring.Model
{
    public interface IObserver 
    {
        //valores que de estado que os Observadores recebem do Subject quando as medições mudam
        public void Update(float temperature, float humidity, float pressure); 
    }
}