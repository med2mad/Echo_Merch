using Echo_Merch.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<dataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("dataContext") ?? throw new InvalidOperationException("Connection string 'dataContext' not found.")));
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = null; // Use PascalCase if needed
});
builder.Services.AddControllers();
builder.Services.AddControllersWithViews();

var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseRouting();
app.MapControllers();
app.MapControllerRoute(name: "zzzzzzzzz", pattern: "{controller=Clients}/{action=index}/{r?}");

app.Run();
