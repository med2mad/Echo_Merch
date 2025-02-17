using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ContextMerch>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ContextMerch") ?? throw new InvalidOperationException("Connection string 'ContextMerch' not found.")));

//builder.Services.AddControllers();
builder.Services.AddControllersWithViews();

var app = builder.Build();
//if (!app.Environment.IsDevelopment())
//{
//	app.UseExceptionHandler("/Home/Error");
//}
app.UseStaticFiles();
//app.UseRouting();
//app.MapControllers();
app.MapControllerRoute(name: "default", pattern: "{controller=Users}/{action=Index}/{id?}");

app.Run();
