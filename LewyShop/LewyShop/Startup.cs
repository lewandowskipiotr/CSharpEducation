using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LewyShop.Models;

namespace LewyShop
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
            // Check differences between Scoped vs Singleton and dive deep in this methods!
            services.AddScoped<IItemRepository, ExampleItemRepository>();
            services.AddScoped<ICategoryRepository, ExampleCategoryRepository>();

            // services.AddSingleton - This will create a single object for entire program lifecycle
            // services.AddTransient - This will give a new instance of the object every time when you will ask for 
            // services.AddScoped - Something on the middle ground, a instance will be created when we will request for them, but when the object will goes out of the scope it will be removed. I need tp investigate it deeper


            services.AddControllersWithViews(); // This line is adding support for MVC pattern
            services.AddRazorPages();
           

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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();


            // There is a settign to adjust a routing I should take a look at details in the futre to better understand it. 
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
