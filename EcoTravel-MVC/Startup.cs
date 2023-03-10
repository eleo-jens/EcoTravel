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
using Microsoft.AspNetCore.Http;
using EcoTravel_MVC.Handlers;

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
            services.AddScoped<IProprietaireRepository<BO.Proprietaire, int>, BS.ProprietaireService>();

            services.AddScoped<ILogementRepository<DO.Logement, int>, DS.LogementService>();
            services.AddScoped<ILogementRepository<BO.Logement, int>, BS.LogementService>();

            services.AddScoped<ICategorieRepository<DO.Categorie, int>, DS.CategorieService>();
            services.AddScoped<ICategorieRepository<BO.Categorie, int>, BS.CategorieService>();

            services.AddScoped<SessionManager>();

            #endregion

            #region Création du Cookie de session
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.Cookie.Name = "EcoTravel.Session";
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
                options.IdleTimeout = TimeSpan.FromMinutes(50);
            });
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            #endregion

            #region Service d'accessibilité du HTTPCONTEXT par injection de dépendance
            services.AddHttpContextAccessor();
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

            // pour la SESSION
            app.UseSession();
            app.UseCookiePolicy();

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
