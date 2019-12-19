using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using WebApplication1.DataAccess;

namespace WebApplication1.DependencyInjection
{
    public static class IoCExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped<IToDoRepository, ToDoRepository>();
            services.AddScoped<IToDoRepository, ToDoRepository2>();
        }

        public static void AddConfigs(this IServiceCollection services)
        {
            // ToDo implement
        }
    }
}
