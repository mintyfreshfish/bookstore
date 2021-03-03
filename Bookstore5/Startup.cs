using Bookstore5.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore5
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

            services.AddDbContext<BookstoreContext>(options => // this builds the books database upon webpage load
            {
                options.UseSqlServer(Configuration.GetConnectionString("BooksConnection"));
            });

            services.AddScoped<IBookstoreRepository, BookstoreRepository>();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => //What do we want our URL to look like, and where do we want to send the user when he/she types it in
            {
                endpoints.MapControllerRoute("catpage", //URL if category and page inputted. {} denote variables. The gist of this is that we can keep the category filter as we navigate to different pages
                    "{category}/{page:int}",
                    new { Controller = "Home", action = "Index" }
                    );

                endpoints.MapControllerRoute("page", //URL if only a page (no category)
                    "{page:int}",
                    new { Controller = "Home", action = "Index" }
                    );

                endpoints.MapControllerRoute("category",
                    "{category}",
                    new { Controller = "Home", action = "Index", page = 1 }
                    );

                endpoints.MapControllerRoute( //pagination URLs
                    "pagination",
                    "/P{page}",
                    new { Controller = "Home", action = "Index" }
                    );

                endpoints.MapDefaultControllerRoute(); //default
            });

            SeedData.EnsurePopulated(app);
        }
    }
}
