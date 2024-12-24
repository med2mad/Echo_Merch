var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute("default", "{controller=home1}/{action=privacy}/{id?}");
app.MapControllerRoute("zzz", "{controller=test}/{action=Index}/{id?}");
app.MapControllerRoute("xxx", "{controller=f}/{action=xxl}/{id?}");

app.MapGet("/test/index", (HttpContext x) =>{ x.Response.WriteAsync("2222222"); } );

//app.Use(async (HttpContext x, RequestDelegate y)=>{ Console.WriteLine("qwe1111"); await y(x); });

//app.Run(async (HttpContext x) => { Console.WriteLine("qwe1111"); });

app.Run();
