namespace ApiWeatherMonitoring.Model
{
    //Implementa a interface Observer para que essa classe possa receber todas as mudanças do obj WeatherData
    //Implementa a interface IDisplayelement pq a API vai exigir que todos os elementos de exibição implemeta essa interface
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;
        
        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        //Quando chama o Update, é salvo a temperatura e umidade, e chama o display
        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;       
            Display();     
        }

        //Exibe na tela a temperatura e umidade mais recente
        public void Display()
        {
            System.Console.WriteLine("Current conditions: " + temperature + "C degress and " + humidity + "% humidity");
        }
    }
}