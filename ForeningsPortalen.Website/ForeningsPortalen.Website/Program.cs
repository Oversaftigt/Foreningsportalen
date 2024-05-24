using ForeningsPortalen.Website.Contract;
using ForeningsPortalen.Website.Contract.Proxy_s;
using ForeningsPortalen.Website.Data;
using ForeningsPortalen.Website.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("ForeningsPortalenWebDbConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDbContext<MyDbContext>();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddScoped<IUnionService, UnionService>();
builder.Services.AddScoped<IAddressService, AddressService>();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdministratorPolicy", policy =>
    {
        policy.RequireClaim("UnionRole", "Administrator");
    });
});

builder.Services.AddRazorPages();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.User.RequireUniqueEmail = true;
});


builder.Services.AddSession(options => 
{
    options.IOTimeout = TimeSpan.FromMinutes(60);
    options.IdleTimeout = TimeSpan.FromMinutes(30);
});


builder.Services.AddHttpClient("ApiClient", client =>
{
    client.BaseAddress = new Uri("http://localhost:5256"); //ForeningsPortalenBaseUrl
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
    app.UseSession();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
