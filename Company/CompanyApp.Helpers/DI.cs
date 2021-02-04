using CompanyApp.Logic;
using CompanyApp.Repository.Abstractions;
using CompanyApp.Repository.Implementations;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CompanyApp.Helpers
{
    public static class DI
    {
        public static void InjectDependencies(IServiceCollection services)
        {
            services.AddTransient<IStoreRepo, StoreRepo>();
            services.AddTransient<IWarehouseRepo, WarehouseRepo>();
            services.AddTransient<IProductRepo, ProductRepo>();
            services.AddTransient<IDeliveryRepo, DeliveryRepo>();
            services.AddTransient<ISuply, SuplyImplentation>();
        }
    }
}
