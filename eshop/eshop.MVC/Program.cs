using eshop.Application.Services;
using eshop.CommonExtensions;
using eshop.Domain;
using eshop.Infrastructure.Data;
using eshop.Infrastructure.Repositories;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("db");
builder.Services.AddNecessaryInstances(connectionString);

builder.Services.AddSession(option=>option.IdleTimeout = TimeSpan.FromMinutes(1440));

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(option => {
                    option.LoginPath = "/Users/Login";
                    option.ReturnUrlParameter = "returnUrl";
                    option.AccessDeniedPath = "/Users/AccessDenied";
                });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseSession();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();


app.MapControllerRoute(
    name: "pagination",
    pattern: "Sayfa{pageNo}",
    defaults: new { controller = "Home", action = "Index", pageNo = 1 }
    );

app.MapControllerRoute(
    name: "paginationWithCatgory",
    pattern: "Kategori{categoryId}/Sayfa{pageNo}",
    defaults: new { controller = "Home", action = "Index", pageNo = 1, categoryId=1 }
    );


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
