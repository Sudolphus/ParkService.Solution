using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ParkService.Models;

namespace ParkService
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
      services.AddDbContext<ParkContext>(opt =>
        opt.UseMySql(Configuration.GetConnectionString("DefaultConnection")));
        
      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

      services.AddSwaggerDocument(config =>
      {
        config.PostProcess = document =>
        {
          document.Info.Version = "v1";
          document.Info.Title = "Park Service API";
          document.Info.Description = "An api for storing and retrieving data about parks";
          document.Info.Contact = new NSwag.OpenApiContact
          {
            Name = "Micheal Hansen",
            Url = "https://github.com/sudolphus"
          };
          document.Info.License = new NSwag.OpenApiLicense
          {
            Name = "Use under MIT",
            Url = "https://opensource.org/licenses/MIT"
          };
        };
      });
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
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
      }

      app.UseOpenApi();
      app.UseSwaggerUi3();
      // app.UseHttpsRedirection();
      app.UseMvc();
    }
  }
}
