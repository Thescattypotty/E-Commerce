using E_Commerce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authentication;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddAuthentication()
    .AddCookie(options => 
    {
        options.LoginPath = "/Admin/";
        options.AccessDeniedPath = "/Login";
    })
    /*.AddJwtBearer(
        Options=>
        {
            Options.Audience = "http://localhost:7060/";
            Options.Authority = "http://localhost:7061/";
        }
    )*/;
/*
builder.Services.AddAuthentication()
        .AddIdentityServerJwt();*/
builder.Services.AddDbContext<ECommerceDbContext>(
    options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))
);

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
app.UseRouting();

app.UseAuthentication();
//app.UseIdentityServer();
app.UseAuthorization();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
