using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using OC.Core.UnitOfWork;
using OC.Data;
using OC.Data.MongoDB.Setting;

namespace NatixisOC
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
            services.AddControllers();
            //Sql Server Configuration 
            services.AddDbContext<NatixisDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DevNatixisOdc"), x => x.MigrationsAssembly("OC.Data")));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            //MongoDB Configuration
            services.Configure<Settings>(
                options =>
                {
                    options.ConnectionString = Configuration.GetValue<string>("MongoDB:ConnectionString");
                    options.Database = Configuration.GetValue<string>("MongoDB:Database");
                });
            services.AddSingleton<IMongoClient, MongoClient>(
                x => new MongoClient(Configuration.GetValue<string>("MongoDB:ConnectionString")));
            services.AddTransient<IDatabaseSettings, DatabaseSetting>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
