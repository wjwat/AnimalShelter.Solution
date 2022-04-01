using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;

using AnimalShelter.Api.Models;

namespace AnimalShelter.Api
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
      services.AddDbContext<AnimalShelterApiContext>(opt =>
          opt.UseMySql(Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(Configuration["ConnectionStrings:DefaultConnection"])));
      services.AddControllers();

      services.AddApiVersioning(o =>
      {
        o.ReportApiVersions = true;
        o.AssumeDefaultVersionWhenUnspecified = true;
        o.DefaultApiVersion = new ApiVersion(1, 0);
      });

      services.AddSwaggerGen(c =>
      {
        c.SwaggerDoc("v1",
        new OpenApiInfo {
            Title = "AnimalShelterApi - v1",
            Version = "v1",
            Description = "Epicodus Week 13 Independent Project -- C# Building An API",
            TermsOfService = new Uri("http://example.com/FakeTermsOfService"),
            Contact = new OpenApiContact
            {
              Name = "Will Watkins",
              Email = "wjwat@onionslice.org"
            },
            License = new OpenApiLicense
            {
              Name = "MIT",
              Url = new Uri("https://mit-license.org/")
            }
        });

        // Generate XML comments for use with Swagger.
        var xml = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xml), includeControllerXmlComments: true);
      });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
        app.UseSwagger();
        app.UseSwaggerUI(c => {
          c.SwaggerEndpoint("/swagger/v1/swagger.json", "AnimalShelterApi v1");
          // First argument is name of CSS file, second argument is media type
          //c.InjectStylesheet("/test.css");
        });
      }

      // Necessary to inject style sheet to control the look of swagger-ui
      app.UseStaticFiles();

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
