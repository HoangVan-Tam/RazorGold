using Microsoft.Extensions.DependencyInjection;
using RazorGold.Application.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RazorGold.Application
{
    public static class ApplicationServiceRegistration
    {
        public static void ConfigureApplicationServince(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
