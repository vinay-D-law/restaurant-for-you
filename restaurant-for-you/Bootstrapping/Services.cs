using Gremlin.Net.Driver;
using Gremlin.Net.Process.Traversal;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using restaurant_for_you.Services;
using restaurant_for_you.Services;
using System;

namespace restaurant_for_you.Bootstrapping
{
    public static class Services
    {
        public static IServiceCollection CustomServices(this IServiceCollection services)
        => services.AddTransient((s) => s.GetCityService())
                .AddTransient((s) => s.GetUserService())
                .AddTransient((s) => s.GetRestaurantService());


        private static ICityService GetCityService(this IServiceProvider serviceProvider)
            => new CityService(serviceProvider.GetService<GraphTraversalSource>());

        private static IUserService GetUserService(this IServiceProvider serviceProvider)
            => new UserService(serviceProvider.GetService<ICityService>(), serviceProvider.GetService<GraphTraversalSource>()
                ,serviceProvider.GetService<IHttpContextAccessor>());

        private static IRestaurantService GetRestaurantService(this IServiceProvider serviceProvider)
            => new RestaurantService(serviceProvider.GetService<GraphTraversalSource>(), serviceProvider.GetService<IUserService>());
    }
}
