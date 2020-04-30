using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Benefits_Backend.Domain.Context;
using Benefits_Backend.Repository.GenericRepository;
using Benefits_Backend.Repository.IRepositories;
using Benefits_Backend.Repository.Repositories;
using Benefits_Backend.Repository.UnitOFWork;
using Benefits_Backend.Service.IServices;
using Benefits_Backend.Service.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace Benefits_Backend.API
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
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IEmployeeService, EmployeeService>();

            services.AddScoped<IVestingRulesService, VestingRulesService>();
            services.AddScoped<IVestingRulesRepository, VestingRulesRepository>();

            services.AddScoped<IPensionEnrollmentRulesRepository, PensionEnrollmentRulesRepository>();
            services.AddScoped<IPensionEnrollmentRulesService, PensionEnrollmentRulesService>();

            services.AddScoped<IAppSettingService, AppSettingService>();
            services.AddScoped<IAppSettingRepository, AppSettingRepository>();


            services.AddScoped<IPhoneProgramRequestRepository, PhoneProgramRequestRepository>();
            services.AddScoped<IPhoneProgramRequestService, PhoneProgramRequestService>();

            services.AddScoped<IPensionRequestRepository, PensionRequestRepository>();
            services.AddScoped<IPensionRequestService, PensionRequestService>();

            services.AddScoped<IMetlifeDataRepository, MetlifeDataRepository>();


            //services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddControllers();
            services.AddAutoMapper(typeof(Startup));
            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });
            services.AddCors(); // Make sure you call this previous to AddMvc
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            using (var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())

            using (var context = scope.ServiceProvider.GetService<ApplicationContext>())
                context.Database.Migrate();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            //app.UseMvc();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
