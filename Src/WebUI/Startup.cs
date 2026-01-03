using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using FluentValidation.AspNetCore;
using Application.Common.Interfaces;
using Application;
using Persistence;
using Infrastructure;
using WebUI.Common;
using WebUI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Http;
using System;
using XOKA.WebUI.Repos;
//using LUCY_CONNECTION_STRING;

namespace WebUI
{
    public class Startup
    {
        private IServiceCollection _services;
        readonly string AllowAnyOrigin = "CorsPolicy";
        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Environment { get; }

        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;
            //SqlHelper.conStr = ConfigurationExtensions.GetConnectionString(this.Configuration, "XOKADatabase");
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //services.AddDbContext<teleDbContext>(options =>
            //   options.UseSqlServer(Configuration.GetConnectionString("Server=192.168.0.105\\XOKASQL2017;Database=xokaERP;Uid=dev;Pwd=dev; TrustServerCertificate=True; Encrypt=true;")));
            //services.AddControllers(options =>
            //{
            //    // Configure input and output formatters for XML
            //    options.InputFormatters.Add(new XmlSerializerInputFormatter(new MvcOptions()));
            //    options.OutputFormatters.Add(new XmlSerializerOutputFormatter());
            //});
            services.AddSession(options =>
            {
                // Set a timeout for the session
                options.IdleTimeout = TimeSpan.FromMinutes(30);

                // Specify a custom cookie name
                options.Cookie.Name = "MyApp.Session";

                // Set the secure flag, ensuring the cookie is only sent over HTTPS
                options.Cookie.SecurePolicy = CookieSecurePolicy.Always;

                // Enable sliding expiration, renewing the session if the user is active
                options.Cookie.HttpOnly = true;


                // Configure other session options as needed...
            });
            // services.AddScoped<DataAccessor>();

            services.AddScoped<SoapService>();
            services.AddScoped<SoapServiceTelbirr>();
            services.AddScoped<PaymentValidationSoapService>();
            services.AddScoped<PaymentConfirmationSoapService>();
            services.AddScoped<SoapSecuredService>();
            services.AddScoped<PaymentValidationSoapSecuredService>();
            services.AddScoped<PaymentConfirmationSoapSecuredService>();
            services.AddScoped<B2CSoapService>();
            services.AddScoped<B2CResponseSoapService>();
            services.AddApplication();
            services.AddHttpClient();
            //services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddInfrastructure(Configuration, Environment);
            services.AddPersistence(Configuration);
            services.AddPersistenceServices();
            services.AddHealthChecks()
                .AddDbContextCheck<XOKADbContext>();
            services.AddScoped<ICurrentUserService, CurrentUserService>();
            services.AddHttpContextAccessor();
            services
                .AddControllersWithViews()
                .AddNewtonsoftJson()
                .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<IXOKADbContext>());



            // Customise default API behaviour
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
            services.AddOpenApiDocument(configure =>
            {
                configure.Title = "XOKA ERP API";
            });

            _services = services;

            services.AddCors(options =>
            {
                options.AddPolicy(AllowAnyOrigin,
                builder =>
                {
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
               .AllowAnyHeader();
                });
            });
            services.AddMvc(option => option.EnableEndpointRouting = false).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddSingleton<IJWTRepos, JwtRepos>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            if (Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            // Content Security Policy (CSP) middleware
            app.Use(async (context, next) =>
            {
                // Add CSP header to the response
                //context.Response.Headers.Add("Content-Security-Policy", "default-src 'self';");
                //context.Response.Headers.Add("Content-Security-Policy", "default-src 'self'; script-src 'self' https://trusted-scripts.com; style-src 'self' https://trusted-styles.com");
                // Continue processing the request
                await next.Invoke();
            });

            app.UseHttpsRedirection();
            app.UseCustomExceptionHandler();
            app.UseHealthChecks("/health");
            app.UseCors(AllowAnyOrigin);
            app.UseAuthentication();
            //app.UseHttpsRedirection();
            app.UseOpenApi();
            app.UseSwaggerUi3(settings =>
            {
                settings.Path = "/api";
                //    settings.DocumentPath = "/api/specification.json";   Enable when NSwag.MSBuild is upgraded to .NET Core 3.0
            });

            app.UseRouting();
            // app.UseAuthentication();
            //app.UseAuthorization();
            app.UseMvc();
            //app.UseSession();
        }
    }
}
