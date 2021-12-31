using Gremlin.Net.Driver;
using Gremlin.Net.Process.Traversal;
using Microsoft.Extensions.DependencyInjection;
using resturant_for_you.Services;
using System;

namespace resturant_for_you.Bootstrapping
{
    public static class Services
    {
        public static IServiceCollection CustomServices(this IServiceCollection services)
        => services.AddTransient((s) => s.GetCityService())
                .AddTransient((s) => s.GetUserService());


        private static ICityService GetCityService(this IServiceProvider serviceProvider)
            => new CityService(serviceProvider.GetService<GraphTraversalSource>());

        private static IUserService GetUserService(this IServiceProvider serviceProvider)
            => new UserService(serviceProvider.GetService<ICityService>(), serviceProvider.GetService<GraphTraversalSource>());


    }
}
