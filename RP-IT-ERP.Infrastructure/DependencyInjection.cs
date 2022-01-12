using Microsoft.Extensions.DependencyInjection;
using RP_IT_ERP.Domain.Interfaces;
using RP_IT_ERP.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<ITaskRepository, TaskRepository>();
            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<IElementRepository, ElementRepository>();
            services.AddTransient<IRaportTypeRepository, RaportTypeRepository>();
            services.AddTransient<IRaportRepository, RaportRepository>();
            services.AddTransient<ITaskStatusRepository, TaskStatusRepository>();
            services.AddTransient<ITaskTypeRepository, TaskTypeRepository>();
            services.AddTransient<IWarehouseRepository, WarehouseRepository>();
            return services;
        }
    }
}
