using Microsoft.EntityFrameworkCore;

namespace ECommerce.Data;


public static class DbExtensions
{

    public static void AddAppDbContext(this WebApplicationBuilder builder)
    {
        var defaultConnection = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

        builder.Services.AddDbContext<AppDbContext>(
            options => options.UseNpgsql(defaultConnection)
        );

    }

    public static void MigrateDatabase(this IServiceProvider services)
    {
        var scope = services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        dbContext.Database.Migrate();
    }
}