namespace WeatherServiceLibrary.Models
{
    public class WeatherForecastModel
    {
        public DateOnly Date { get; set; }  // ✅ Add this property
        public int TemperatureC { get; set; }
        public string? Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}
