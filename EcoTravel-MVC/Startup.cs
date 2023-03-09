using EcoTravel_Common.Repositories;
using DO = EcoTravel_DAL.Entities;
using BO = EcoTravel_BLL.Entities;
using DS = EcoTravel_DAL.Services;
using BS = EcoTravel_BLL.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel_MVC
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
            #region Injection de dépendances
            services.AddScoped<IClientRepository<DO.Client, int>, DS.ClientService>();
            services.AddScoped<IClientRepository<BO.Client, int>, BS.ClientService>();

            services.AddScoped<IProprietaireRepository<DO.Proprietaire, int>, DS.ProprietaireService>();
            //services.AddScoped<IProprietaireRepository<BO.Proprietaire, int>, BS.ProprietaireService>();

            services.AddScoped<ILogementRepository<DO.Logement, int>, DS.LogementService>();
            services.AddScoped<ILogementRepository<BO.Logement, int>, BS.LogementService>();

            //services.AddScoped<ITypeRepository<DO.Type, int>, DS.TypeService>();
            //services.AddScoped<ITypeRepository<BO.Type, int>, BS.TypeService>();

            #endregion

            services.AddControllersWithViews();
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
