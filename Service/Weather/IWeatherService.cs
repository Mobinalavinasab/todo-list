using TodoSample;

namespace Service.Weather;

public interface IWeatherService
{
    IEnumerable<WeatherForecast> GetAllWeather();
}