﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Core_APIApp
{
    public class Startup
    {
        /// <summary>
        /// IComnfiguration :--> Reads configuration from appsettings.json
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        /// <summary>
        /// The method for managing objects in DI Container
        /// 1. MVC Options
        ///     Filters
        /// 2. Authentication and Authorization
        ///     Users
        ///     Roles
        ///             Role Policies
        ///     JSON Web Token aka JWT        
        /// 3. Cookies
        /// 4. Session
        /// 5. CORS
        /// 6. Custom Services
        /// 7. Messaging Formatters
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// <summary>
        /// The method taht represent the HTTP Pileline
        /// IApplicationBuilder: Contarct that builds and add additional objects in HTTP
        /// pipeline e.g. Custom Exceptions/ Custom Security as 'Middleware'
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
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