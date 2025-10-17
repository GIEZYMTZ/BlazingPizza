using BlazingPizza.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Register the database context with SQLite using AddSqlite
builder.Services.AddSqlite<PizzaStoreContext>("Data Source=pizza.db");

// Register a service for HTTP commands
builder.Services.AddHttpClient();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();
app.UseRouting();



app.MapRazorPages();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

// Initialize the database context using IServiceScopeFactory
using (var scope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<PizzaStoreContext>();
    if (dbContext.Database.EnsureCreated())
    {
        SeedData.Initialize(dbContext);
    }
}
app.Run();