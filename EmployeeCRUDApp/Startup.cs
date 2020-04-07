//-----------------------------------------------------------------------
// <copyright file="Startup.cs" company="BridgeLabz">
//     Copyright © 2020
// </copyright>
// <creator name="Mayank Sachdeva"/>
//-----------------------------------------------------------------------

namespace EmployeeCRUDApp
{
    using Manager;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.OpenApi.Models;
    using Repository;
    using Repository.DBContext;

    /// <summary>
    /// startup class
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// initialize instance of Startup
        /// </summary>
        /// <param name="configuration">
        /// configuration 
        /// </param>
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        /// <summary>
        /// GETS interface IConfiguration 
        /// </summary>
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        /// <summary>
        /// configure service method
        /// </summary>
        /// <param name="services">service</param>
        public void ConfigureServices(IServiceCollection services)
        {
           services.AddDbContextPool<UserDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("UserDbConnection")));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddTransient<IEmployeeManager, EmployeeManager>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.

        /// <summary>
        /// configure method
        /// </summary>
        /// <param name="app"> application  </param>
        /// <param name="env"> environment </param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "myapi v1"); });
            }
            else
            { 
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            //app.UseMvc();
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=EmployeeController}/{action=LoginEmployee}/{id?}"
                    );
            });
        }
    }   
}
