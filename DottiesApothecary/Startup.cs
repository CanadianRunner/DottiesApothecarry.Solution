using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder; // in lesson plan
using Microsoft.AspNetCore.Hosting; // in lesson plan
using Microsoft.AspNetCore.Http; // in lesson plan, new to project
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration; // in lesson plan
using Microsoft.Extensions.DependencyInjection; // in lesson plan
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore; // in lesson plan
using Microsoft.AspNetCore.Identity; // in lesson plan
using DottiesApothecary.Models; // in lesson plan

namespace DottiesApothecary
{
    public class Startup
    {
        // **** As Constructed with Scaffolding ****
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // **** BELOW IS WHAT IS IN THE LESSON PLAN ****
        // public Startup(IWebHostEnvironment env)
        // {
        //     var builder = new ConfigurationBuilder()
        //         .SetBasePath(env.ContentRootPath)
        //             .AddJsonFile("appsetting.json"); 
        //     Configuration = builder.Build();
        // }

        
        public IConfiguration Configuration { get; }  
        // public IConfigurationRoot Configuration { get; set; } // adding a setter here will allow us to set our apps connection string.     

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            //services.AddMvc; // from lesson plan

            services.AddEntityFrameworkMySql()
                .AddDbContext<DottiesApothecaryContext>(options => options
                .UseMySql(Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(Configuration["ConnectionStrings:DefaultConnection"])));


            //added code - grafting identity 
            services.AddIdentity<ApplicationUser, IdentityRole>()
                    .AddEntityFrameworkStores<DottiesApothecaryContext>()
                    .AddDefaultTokenProviders();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)  //Responsible for telling our app how to handle requests to the server
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            
            app.UseStaticFiles(); // in lession plan

            app.UseAuthorization(); // required for identity 
            
            app.UseAuthentication(); // require for identity 

            // UseRouting and UseEndpoints tells our app to use the MVC framework to respond to HTTP request.
            app.UseRouting();

            app.UseAuthorization(); // required for identity 

            //warning ASP0001: The call to UseAuthorization should appear between app.UseRouting() and app.UseEndpoints(..) for authorization to be correctly evaluated 

            app.UseEndpoints(endpoints =>
            {
                // **** As Constructed with Scaffolding ****
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                //endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
