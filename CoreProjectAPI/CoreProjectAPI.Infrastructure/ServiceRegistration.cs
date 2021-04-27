
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dapper.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            //services.AddTransient<ICarRepository, CarRepository>();
            //services.AddTransient<IRentRepository, RentRepository>();
            //services.AddTransient<IRenterRepository, RenterRepository>();
            //services.AddTransient<IFirmRepository, FirmRepository>();
            //services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
