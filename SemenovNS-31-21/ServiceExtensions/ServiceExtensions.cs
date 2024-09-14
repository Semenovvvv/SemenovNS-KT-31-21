using SemenovNS_31_21.Interfaces;
using SemenovNS_31_21.Services;

namespace SemenovNS_31_21.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IGroupService, GroupService>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IDisciplineService, DisciplineService>();

            return services;
        }
    }
}
