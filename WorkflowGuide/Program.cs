using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Elsa;
//using Elsa.Persistence.EntityFramework.SqlServer;
using Elsa.Persistence.EntityFramework.Core.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
var connectionString = builder.Configuration.GetConnectionString("sqlServer");

builder.Services.AddDbContextPool<WorkflowGuideDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});

builder.Services.AddScoped<IPartNumberService, PartNumberService>();

//builder.Services.AddElsa(config => config.UseEntityFrameworkPersistence<WorkflowGuideDbContext>(ef => ef.UseSqlServer(connectionString)));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();

});
app.Run();
