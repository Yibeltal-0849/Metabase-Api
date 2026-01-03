using System.Reflection;
using Application.Common.Behaviours;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            // Register MediatR handlers in this assembly (your Application project)
            services.AddMediatR(Assembly.GetExecutingAssembly());

            // Register AutoMapper profiles in this assembly
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            // Register pipeline behaviors for validation and performance logging
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestPerformanceBehaviour<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));

            return services;
        }
    }
}
