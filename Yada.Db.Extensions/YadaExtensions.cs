using Yada;
using Yada.Abstraction;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class YadaExtensions
    {
        public static IServiceCollection AddYadaDb(this IServiceCollection services)
        {
            services.AddTransient<IMyService, MyService>();
            return services;
        }
    }
}
