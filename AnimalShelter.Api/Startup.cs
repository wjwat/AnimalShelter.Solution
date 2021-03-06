using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Http;
using Microsoft.OpenApi.Models;
using Microsoft.Net.Http.Headers;
using System;
using System.IO;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

using AnimalShelter.Api.Models;
using AnimalShelter.Api.Services;
using AnimalShelter.Api.Swagger;

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

      services.AddCors(options => options
          .AddPolicy("CorsPolicy", builder => builder
              .AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod()
          )
      );

      services.AddHttpContextAccessor();
      services.AddSingleton<IUriService>(o =>
      {
        var accessor = o.GetRequiredService<IHttpContextAccessor>();
        var request = accessor.HttpContext.Request;
        var uri = string.Concat(
            request.Scheme,
            "://",
            request.Host.ToUriComponent()
          );
        
        return new UriService(uri);
      });

      services.AddControllers()
          .AddJsonOptions(options =>
          {
            options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
          });

      services.AddVersionedApiExplorer(o =>
      {
        o.GroupNameFormat = "'v'V.v";
        o.SubstituteApiVersionInUrl = true;
      });

      services.AddApiVersioning(o =>
      {
        // Our headers incorrectly report which endpoints are available for which
        // endpoints. This comment describes what's going on in detail. Will
        // need to do some further exploration later.
        // https://github.com/dotnet/aspnet-api-versioning/issues/643#issuecomment-653623330
        //o.ReportApiVersions = true;
        o.AssumeDefaultVersionWhenUnspecified = true;
        o.DefaultApiVersion = new ApiVersion(2, 0);
      });

      services.AddSwaggerGen(c =>
      {
        c.EnableAnnotations();

        // It would be nice to automagically generate these as we version our API.
        c.SwaggerDoc("v1.0",
        new OpenApiInfo {
            Title = "AnimalShelterApi",
            Version = "v1.0",
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
        c.SwaggerDoc("v2.0",
        new OpenApiInfo {
            Title = "AnimalShelterApi",
            Version = "v2.0",
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

        c.DocumentFilter<RemoveDefaultApiVersionRouteDocumentFilter>();
        c.OperationFilter<RemoveQueryApiVersionParamOperationFilter>();
      });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();

        app.UseSwagger();

        var provider = app.ApplicationServices.GetService<IApiVersionDescriptionProvider>();

        app.UseSwaggerUI(c =>
        {
          c.DocumentTitle = "AnimalAPI -- It really whips the Llama's Ass";
          c.IndexStream = () => GetType().Assembly.GetManifestResourceStream("AnimalShelter.Api.Swagger.index.html");

          foreach (var d in provider.ApiVersionDescriptions)
          {
            c.SwaggerEndpoint($"/swagger/{d.GroupName}/swagger.json",
                d.GroupName.ToUpperInvariant());
          }
          // First argument is name of CSS file, second argument is media type
          c.InjectStylesheet("/swagger-override.css");
        });
      }

      // Necessary to inject style sheet to control the look of swagger-ui
      app.UseStaticFiles();

      app.UseRouting();

      // With endpoint routing, the CORS middleware must be configured to
      // execute between the calls to UseRouting and UseEndpoints.
      // ref: https://docs.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-5.0
      app.UseCors("CorsPolicy");

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints
          .MapControllers()
          .RequireCors("CorsPolicy");
      });

    }
  }
}
