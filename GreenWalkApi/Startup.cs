using GreenWalkApi.Models;
using GreenWalkApi.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace GreenWalkApi
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

            services.AddDbContext<GreenWalkContext>(options => 
                options.UseSqlServer("Server=tcp:greenwalkapidbserver.database.windows.net,1433;Initial Catalog=GreenWalk_DB;Persist Security Info=False;User ID=GreenWalk_Admin;Password=ImGonnaCl€an4;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"));

            services.AddScoped<IContextService, ContextService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IJourneyService, JourneyService>();
            services.AddScoped<IPositionService, PositionService>();
            services.AddScoped<IEventService, EventService>();
            services.AddScoped<IBinService, BinService>();
            services.AddScoped<ISuccessService, SuccessService>();
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
