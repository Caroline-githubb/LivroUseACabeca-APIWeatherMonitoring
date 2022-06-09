namespace ApiWeatherMonitoring.Model
{
    public interface ISubject
    {
        void RegisterObserver();
        void RemoveObserver();
        void NotifyObservers();
         
    }
}