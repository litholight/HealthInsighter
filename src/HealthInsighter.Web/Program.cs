using HealthInsighter.Data; // Adjust namespace based on your actual project structure
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Register your DbContext with PostgreSQL
builder.Services.AddDbContext<HealthInsighterDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("HealthInsighterDb"))
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
