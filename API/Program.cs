using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(opt =>
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));  // Ensure you have a connection string named "DefaultConnection" in your appsettings.json
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapControllers();

app.Run();
