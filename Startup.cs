using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Stream.API.Domain.Repositories;
using Stream.API.Domain.Services;
using Stream.API.Persistence.Contexts;
using Stream.API.Persistence.Repositories;
using Stream.API.Services;
using AutoMapper;

namespace Stream.API
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            //Uses in memory database
            services.AddDbContext<AppDbContext>(options => {
                options.UseInMemoryDatabase("Stream-api-in-memory");
            });
            //bind service and repository
            services.AddScoped<IResultRepository, ResultRepository>();
            services.AddScoped<IResultsService, ResultService>();

            services.AddAutoMapper(typeof(Startup));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
