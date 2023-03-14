using BLLService = Exo_Travel_BLL.Services;
using DALService = Exo_Travel_DAL.BLLService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exo_Travel_common.Repository;
using DALEntities = Exo_Travel_DAL.Entities;
using BLLEntities = Exo_Travel_BLL.Entities;


namespace Exo_Travel_MVC
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
            services.AddControllersWithViews();
            //services.AddScoped<BLLService.ClientService>();
            services.AddScoped<IClientRepository<BLLEntities.Client, int>, BLLService.ClientService>();
            services.AddScoped<IClientRepository<DALEntities.Client,int>, DALService.ClientService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
