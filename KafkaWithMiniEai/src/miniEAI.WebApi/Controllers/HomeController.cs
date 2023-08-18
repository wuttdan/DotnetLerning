using Application.Common.Models;
using Microsoft.AspNetCore.Mvc;
using MiniEAI.Api.Controllers;
using System.Net;

namespace miniEAI.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HomeController : ApiController
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

    [HttpGet("status")]
    public Task<IActionResult> GetStatusString()
    {
        var results = new Dictionary<string, string>();
        results.Add("PrimaryDatabase String", PrimaryDb.GetDbConnection().ConnectionString);
        results.Add("PrimaryDatabase CanConnect", PrimaryDb.CanConnect ? "Connected" : "Failed");
        results.Add("Server Name", Dns.GetHostName().Replace("FBBEAI", "XXXXXX"));
        results.Add("Server Time", DateTime.Now.ToString());
        results.Add("Server UtcTime", DateTime.UtcNow.ToString());
        results.Add("Server TimeZone", TimeZoneInfo.Local.DisplayName);
        var ok = Ok(results) as IActionResult;
        return Task.FromResult(ok);
    }
}