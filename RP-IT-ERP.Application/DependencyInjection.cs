using Microsoft.Extensions.DependencyInjection;
using RP_IT_ERP.Application.Interfaces;
using RP_IT_ERP.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<ITaskService, TaskService>();
            services.AddTransient<IClientService, ClientService>();
            services.AddTransient<IElementService, ElementService>();
            services.AddTransient<IRaportTypeService, RaportTypeService>();
            services.AddTransient<IRaportService, RaportService>();
            services.AddTransient<ITaskStatusService, TaskStatusService>();
            services.AddTransient<ITaskTypeService, TaskTypeService>();
            services.AddTransient<IWarehouseService, WarehouseService>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
