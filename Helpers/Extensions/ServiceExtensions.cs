using HackItAll_Backend.Helpers.Seeders;
using HackItAll_Backend.Repositories;
using HackItAll_Backend.Services;

namespace backend.Helpers.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        // services.AddTransient<ITestRepository, TestRepository>();
        services.AddTransient<ModelRepository>();
        services.AddTransient<CarRepository>();
        services.AddTransient<BatteryRepository>();
        services.AddTransient<StationRepository>();
        services.AddTransient<ReservationRepository>();

        return services;
    }

    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        // services.AddTransient<ITestService, TestService>();
        services.AddTransient<ModelService>();
        services.AddTransient<CarService>();
        services.AddTransient<StationService>();
        services.AddTransient<BatteryService>();
        services.AddTransient<ReservationService>();
        
        return services;
    }

    public static IServiceCollection AddSeeders(this IServiceCollection services)
    {
        // services.AddTransient<TestSeeder>();
        services.AddTransient<ModelSeeder>();
        services.AddTransient<CarSeeder>();
        services.AddTransient<StationSeeder>();
        services.AddTransient<BatterySeeder>();

        return services;
    }
}