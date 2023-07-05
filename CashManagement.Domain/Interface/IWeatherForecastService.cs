using CashManagement.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CashManagement.Domain.Interface
{
    public interface IWeatherForecastService
    {
        Task<WeatherForecastModel[]> GetForecastAsync(DateTime startDate);
    }
}
