using CashManagement.Domain.Interface;
using CashManagement.Domain.Model;
//using CashManagement.Repository.Entity;
using CashManagement.Repository.Interface;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CashManagement.Domain
{
    public class WeatherForecastService : IWeatherForecastService
    {
        //IRepository<inv_bnd_bal> repository;
        public WeatherForecastService()//IRepository<inv_bnd_bal> _repository)
        {
            //repository = _repository;
        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecastModel[]> GetForecastAsync(DateTime startDate)
        {
            //var ss = repository.GetEntities().Take(20).ToList();
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecastModel
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}
