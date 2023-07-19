using CityInfo.API.Services;

namespace CityInfo.API
{
    public static class AddRepositories
    {
        public static IServiceCollection RegisterRepositoriesServices(
            this IServiceCollection services)
        {
            services.AddSingleton<CitiesDataStore>();
            services.AddScoped<ICityInfoRepository, CityInfoRepository>();

            return services;
        }
    }
}
