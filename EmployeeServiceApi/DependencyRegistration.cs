using BusinessLayer.Core;
using BusinessLayer.Interfaces;
using Common.AdoUtils.Core;
using Common.AdoUtils.Interfaces;
using DBContextLayer.Core;
using DBContextLayer.Interfaces;
using EmployeeServiceApi.Services.Core;
using EmployeeServiceApi.Services.Interfaces;

namespace EmployeeServiceApi
{
    public static class DependencyRegistration
    {
        #region Public Methods

        public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddCors(p => p.AddPolicy("corsapp", builder =>
            {
                builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
            }));

            SqlServerDal sqlServerDal = new SqlServerDal();
            sqlServerDal.ConnectionString = configuration.GetValue<string>("SqlConnectionString");
            services.AddSingleton<IAdoDal>(sqlServerDal);
            
            //Repositories
            services.AddSingleton<IEmployeeRepository, EmployeeRepository>();
            //DBContext
            services.AddSingleton<IEmployeeDBContext, EmployeeDBContext>();
            //Services
            services.AddSingleton<IEmployeeService, EmployeeService>();

            return services;
        }

        #endregion Public Methods
    }
}
