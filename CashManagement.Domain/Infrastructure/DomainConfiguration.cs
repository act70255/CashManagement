using CashManagement.Domain.Interface;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CashManagement.Domain.Infrastructure
{
    public static class DomainConfiguration
    {
        public static void AddDomain(this IServiceCollection serviceCollection)
        {
            //RegisterService
            serviceCollection.AddScoped(typeof(IWeatherForecastService), typeof(WeatherForecastService));
            serviceCollection.AddScoped(typeof(ICcyService), typeof(CcyService));
            serviceCollection.AddScoped(typeof(IUserService), typeof(UserService));
            serviceCollection.AddScoped(typeof(IRoleService), typeof(RoleService));
        }
    }
}
