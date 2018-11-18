using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSpiderServer.BLL.Services;
using CSpiderServer.DAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;

namespace CSpiderServer
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
            ConfigureDbContext(services);
            ConfigureServicesDI(services);
            ConfigureSwagger(services);
        }
        // Configure Swagger
        private void ConfigureSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info
                {
                    Version = "v1",
                    Title = "CSpiderServer",
                    Description = "A spider server",
                    TermsOfService = "None",
                    Contact = new Swashbuckle.AspNetCore.Swagger.Contact() { Name = "Big.guo", Email = "az999897@hotmail.com", Url = "www.google.com" }
                });
            });
        }
        // Configure DbContext
        private void ConfigureDbContext(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("CSpider");
            services.AddDbContextPool<CSpiderContext>(options => options.UseMySql(connectionString));
        }
        private void ConfigureServicesDI(IServiceCollection services) {
            services.AddScoped<UserService>();
            services.AddScoped<TokenService>();
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
            UseSwagger(app);
        }
        private void UseSwagger(IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "CSpiderServer V1");
            });
        }
    }
}
