using CashManagement.Domain.Interface;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashManagement.Domain.Infrastructure
{
    public static class AuthConfiguration
    {
        public static void AddAuth(this IServiceCollection serviceCollection)
        {
            //SKLAuthenticatorProvider
            serviceCollection.AddScoped<SKLAuthenticator>();
            serviceCollection.AddScoped<AuthenticationStateProvider>(sp => sp.GetRequiredService<SKLAuthenticator>());
        }
    }
}
