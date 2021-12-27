using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace SurveyResourcesAPI
{
    public class Startup
    {
        readonly string MyCORSPolicy = "_myCORSPolicy";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Models.SurveyResourcesContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("GISConnection")));
            services.AddControllers();

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "SurveyResourcesAPI",
                    Description = "An ASP.NET Core Web API for managing Survey Resources",
                    Contact = new OpenApiContact
                    {
                        Name = "Survey Resource API Administrator",
                        Url = new Uri("https://morrisgisapps.co.morris.nj.us")
                       
                    }
                });
                // using System.Reflection;
                var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
            });

            string[] hsts = Configuration.GetSection("CORSConfiguration:AllowedHosts").Get<string[]>();

            services.AddCors(options =>
            {
                options.AddPolicy(name: MyCORSPolicy,
                                  builder =>
                                  {
                                      builder.WithOrigins(hsts)
                                        .AllowAnyHeader()
                                        .AllowAnyMethod()
                                        .AllowCredentials();
                                  });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseSwagger();
            if (env.IsDevelopment())
            {

           
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/apis/survey-resources-api-dev/swagger/v1/swagger.json", "SurveyResourcesAPI v1"));
                app.UseDeveloperExceptionPage();

            }
            if (env.IsEnvironment("UAT"))
            {
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/apis/survey-resources-api-uat/swagger/v1/swagger.json", "SurveyResourcesAPI v1"));
             

            }

            if (env.IsEnvironment("Production"))
            {
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/apis/survey-resources/swagger/v1/swagger.json", "SurveyResourcesAPI v1"));
           

            }


            app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();
            
            app.UseStaticFiles();
            
            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(MyCORSPolicy);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
