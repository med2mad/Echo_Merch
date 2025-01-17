using Echo_Merch.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<dataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("dataContext") ?? throw new InvalidOperationException("Connection string 'dataContext' not found.")));

builder.Services.AddControllersWithViews();

var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

//app.UseRouting();
//builder.Services.AddControllers();
app.MapControllerRoute(name: "default", pattern: "{controller=Clients}/{action=index}");

app.Run();
