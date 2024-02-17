using Microsoft.EntityFrameworkCore;
using Repositories;

namespace Store.Infrastructe.Extensions
{
    public static class AplicationExtension
    {
        public static void ConfigureAndCheckMigrations(this IApplicationBuilder app)
        {
            RepositoryContext context = app
                .ApplicationServices
                .CreateScope()
                .ServiceProvider
                .GetRequiredService<RepositoryContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
        }
    }
}
