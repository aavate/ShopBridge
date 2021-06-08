using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using ShopBridge.DbRepository.Interfaces;
namespace ShopBridge.DbRepository
{
    public static class RepositoryServiceCollection
    {
        public static IServiceCollection AddRepositoriesServiceCollection(this Microsoft.Extensions.DependencyInjection.IServiceCollection services)
        {
            services.AddTransient<IInventoryRepository, InventoryRepository>();
            return services;
        }
    }
}
