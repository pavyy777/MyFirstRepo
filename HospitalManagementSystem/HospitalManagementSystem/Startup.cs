using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using HMS.DAL.Registration;
using Microsoft.EntityFrameworkCore;
using HMS.DAL.Repository;
using HMS.BAL.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string connectionStr = Configuration.GetConnectionString("SqlConnection");
            services.AddDbContext<HMSDbContext>(options => options.UseSqlServer(connectionStr));
            services.AddControllers();
            services.AddTransient<IRegistrationIPDRepository, RegistrationIPDRepository>();
            services.AddTransient<RegistrationIPDServices, RegistrationIPDServices>();
            services.AddTransient<IRegistrationOPDRepository, RegistrationOPDRepository>();
            services.AddTransient<RegistrationOPDServices, RegistrationOPDServices>();
        }
       

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}