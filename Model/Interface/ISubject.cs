namespace ApiWeatherMonitoring.Model
{
    public interface ISubject
    {
        public void RegisterObserver(IObserver o); //objeto a ser registrado
        void RemoveObserver(IObserver o);//objeto a ser removido
        void NotifyObservers();//notificará todos os observers quando o estado Subject for alterado
         
    }
}