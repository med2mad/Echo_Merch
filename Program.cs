using Echo_Merch.Data;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Echo_MerchContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("Echo_MerchContext") ?? throw new InvalidOperationException("Connection string 'Echo_MerchContext' not found.")));

builder.Services.AddControllersWithViews();
//builder.Services.AddControllers();
var app = builder.Build();

app.MapRazorPages();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();


app.Run();
