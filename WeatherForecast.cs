using System;
using System.ComponentModel.DataAnnotations;

namespace dotnet_api_docs_redoc
{
  public class WeatherForecast
  {
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }


    /// <summary>
    /// Deletes a specific TodoItem.
    /// </summary>
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    [Required]
    public string Summary { get; set; }
  }
}
