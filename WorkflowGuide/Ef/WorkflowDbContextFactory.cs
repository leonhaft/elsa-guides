using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WorkflowGuide.Ef
{
    public class WorkflowDbContextFactory : IDesignTimeDbContextFactory<WorkflowGuideDbContext>
    {
        public WorkflowGuideDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false)
                .Build();

            var dbContextBuilder = new DbContextOptionsBuilder();
            var connectionString = configuration.GetConnectionString("sqlServer");

            dbContextBuilder.UseSqlServer(connectionString);

            return new WorkflowGuideDbContext(dbContextBuilder.Options);
        }
    }
}
