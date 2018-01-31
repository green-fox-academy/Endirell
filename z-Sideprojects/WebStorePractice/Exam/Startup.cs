using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using WebStore.Entities;
using WebStore.Services;
using WebStore.Repositories;

namespace WebStore
{
    public class Startup
    {        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<WebStoreContext>(options => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=warehouse;Integrated Security=True;Connect Timeout=30;"));
            services.AddScoped<WebStoreService>();
            services.AddScoped<WebStoreRepository>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
