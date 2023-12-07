using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class DataAccessServiceRegistration
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<NorthwindContext>(options => options.UseInMemoryDatabase("nArchitecture"));
            //services.AddDbContext<BaseDbContext>(options => options.UseSq lServer(configuration.GetConnectionString("RentACar")));
            services.AddScoped<IProductDal, EfProductDal>();
            return services;
        }
    }
}
