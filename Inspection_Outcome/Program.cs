using Inspection_Outcome.Models;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;
using QuestPDF.Infrastructure;
var builder = WebApplication.CreateBuilder(args);

QuestPDF.Settings.License = LicenseType.Community;
// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ErpDataContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddSession();
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseSession();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dispatched}/{action=Dispatch}/{id?}");

app.Run();
