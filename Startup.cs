using AirportTicketBookingSystem.Core.Interfaces;
using AirportTicketBookingSystem.Infrastructure.Data;
using AirportTicketBookingSystem.Infrastructure.Repositories;
using AirportTicketBookingSystem.Services.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportTicketBookingSystem.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            // Add DbContext
            services.AddDbContext<AppDbContext>(options =>
                options.UseMySql(Configuration.GetConnectionString("DefaultConnection"),
                    new MySqlServerVersion(new Version(8, 0, 21))));

            // Register repositories
            services.AddScoped<IFlightRepository, FlightRepository>();
            services.AddScoped<IBookingRepository, BookingRepository>();
            services.AddScoped<IPassengerRepository, PassengerRepository>();
            services.AddScoped<IManagerRepository, ManagerRepository>();

            // Register services
            services.AddScoped<IPassengerService, PassengerService>();
            services.AddScoped<IManagerService, ManagerService>();

            // Other service configurations
        }

        

    }
}
