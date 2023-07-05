using CashManagement.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CashManagement.Repository.Infrastructure
{
    public static class RepositoryConfiguration
    {
        public static void AddRepository(this IServiceCollection service, IConfiguration configuration)
        {
            var connectstring = configuration.GetConnectionString("dbConnection");
            service.AddDbContext<CashManagement.Entity.Test_BlazorContext>(options => options.UseSqlServer(connectstring));
            service.AddScoped(typeof(IRepository<>), typeof(Repository<>));     //使用到時建立
        }
    }
}
