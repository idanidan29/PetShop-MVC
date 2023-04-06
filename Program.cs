using Microsoft.EntityFrameworkCore;
using PetShop.Data;
using PetShop.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MyDBContext>
    (options => options.UseLazyLoadingProxies()
    .UseSqlite("Data Source=Data/myDatabase.db"));

builder.Services.AddScoped<IRepository, MyRepository>();

var app = builder.Build();

using (var scope = app.Services.CreateScope()) 
{ 
    var dbContext = scope.ServiceProvider.GetRequiredService<MyDBContext>(); 
    dbContext?.Database.EnsureDeleted(); 
    dbContext?.Database.EnsureCreated();
}


app.UseStaticFiles();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}/{text?}/");


app.Run();
