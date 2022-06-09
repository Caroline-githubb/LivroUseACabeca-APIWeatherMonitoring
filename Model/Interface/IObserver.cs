namespace ApiWeatherMonitoring.Model
{
    public interface IObserver : ISubject
    {
         void Update();
    }
}