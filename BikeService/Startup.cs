using BikeService.Interfaces;
using BikeService.Models;
using BikeService.Services;
using BikeService.Utility;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeService
{
    public class Startup
    {

        private readonly string connection;
        private string[] origins = { "http://localhost:8200", "http://localhost:8200", "http://10.20.40.31:8100" };
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            connection = Configuration.GetValue<string>("ConnectionStrings:DefaultConnection");
        }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddOptions();
            services.AddDbContext<BikeServiceContext>(opitions => opitions.UseSqlServer(connection));
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins",
                    builder =>
                    {
                        builder
                            .AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
            });
            //services.AddCors(); 
            //services.AddCors(options => options.AddPolicy("AllowCors", builder =>
            //{
            //    builder.AllowAnyOrigin().WithMethods("GET", "PUT", "POST", "DELETE").AllowAnyHeader().AllowCredentials();
            //}));



            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //adding custom dependencies
            services.Configure<EmailSettings>(Configuration.GetSection("EmailSettings"));
            services.Configure<SmsSettings>(Configuration.GetSection("SmsSettings"));
            services.AddScoped<ILogService, LogService>();
            services.AddScoped<IAuthService, AuthServices>();        
            services.AddScoped<ICommonService, CommonService>();
            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
           .AddJwtBearer(options =>
           {
               options.TokenValidationParameters = new TokenValidationParameters
               {
                   ValidateIssuer = true,
                   ValidateAudience = true,
                   ValidateLifetime = true,
                   ValidateIssuerSigningKey = true,
                   ValidIssuer = Configuration["Jwt:Issuer"],
                   ValidAudience = Configuration["Jwt:Issuer"],
                   IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))

               };
           });

            // Register the Swagger generator, defining 1 or more Swagger documents
            //services.AddSwaggerGen();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

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
