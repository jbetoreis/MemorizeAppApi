using MemorizeAppApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

ConfigureController(builder);
ConfigureServices(builder);

var app = builder.Build();

app.MapControllers();

app.Run();

void ConfigureController(WebApplicationBuilder builder)
{
    builder.Services.AddControllers();
}

void ConfigureServices(WebApplicationBuilder builder)
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString));
}