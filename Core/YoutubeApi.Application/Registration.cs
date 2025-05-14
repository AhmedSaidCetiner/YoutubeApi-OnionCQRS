using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using YoutubeApi.Application.Exceptions;

namespace YoutubeApi.Application
{
    public static class Registration
    {
        public static void AddApplication(this IServiceCollection services)
        {
            var asssembly = Assembly.GetExecutingAssembly();

            services.AddTransient<ExceptionMiddleware>();

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(asssembly));
        }
    }
}
