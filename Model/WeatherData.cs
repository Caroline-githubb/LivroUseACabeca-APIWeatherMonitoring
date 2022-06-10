using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiWeatherMonitoring.Model
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observers; //adicionado uma lista para conter os Observadores
        private float temperature, humidity, pressure;
        public WeatherData ()
        {
            observers = new List<IObserver>(); //criei a lista no construtor
        }
        public void RegisterObserver(IObserver o)
        {
            observers.Add(o); //cada vez que um observador fazer um registro, é adicionado no final da lista
        }
        public void RemoveObserver(IObserver o)
        {
            if (observers != null && observers.Count() > 0)
            {
                observers.Remove(o);
            }
        }

        public void NotifyObservers()
        {   
            foreach (var observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }

		}        

        public void MeasurementsChanged()
        {
            NotifyObservers();         
        }

        public void SetMeasurementsChanged(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }

        public float GetTemperature()
        {
            return temperature;

        }

        public float GetHumidity()
        {
            return humidity;
        }

        public float GetPressure()
        {
            return pressure;
        }
   
    }
}