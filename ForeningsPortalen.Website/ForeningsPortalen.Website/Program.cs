using ForeningsPortalen.Website.Data;
using ForeningsPortalen.Website.HelperServices;
using ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices;
using ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices.Implementations;
using ForeningsPortalen.Website.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Database Config
var connectionString = builder.Configuration.GetConnectionString("ForeningsPortalenWebDbConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));


builder.Services.AddDatabaseDeveloperPageExceptionFilter();
//Identity Config
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddScoped<IUserEmailStore<IdentityUser>, UserStore<IdentityUser, IdentityRole, ApplicationDbContext>>();



// Dependency Injection Config
builder.Services.AddScoped<IUnionService, UnionService>();
builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<IUserClaimsService, UserClaimsService>();
builder.Services.AddScoped<IMemberService, MemberService>();
builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>(); 
builder.Services.AddScoped<ICategoryService, CategoryService>();



builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdministratorAccess", policy =>
    {
        policy.RequireClaim("UnionRole", "Administrator");
    });
    options.AddPolicy("ChairmanAndTreasurerAccess", policy =>
    {
        policy.RequireClaim("UnionRole", "Administrator"
                                       , "Chairman"
                                       , "Treasurer");
    });
    options.AddPolicy("BoardMemberAccess", policy =>
    {
        policy.RequireClaim("UnionRole", "Administrator"
                                       , "Chairman"
                                       , "Treasurer"
                                       , "BoardMember");
    });
    options.AddPolicy("UnionMemberAccess", policy =>
    {
        policy.RequireClaim("UnionRole", "Administrator"
                                       , "Chairman"
                                       , "Treasurer"
                                       , "BoardMember"
                                       , "UnionMember");
    });
});

builder.Services.Configure<IdentityOptions>(options =>
{
    //options.User.RequireUniqueEmail = true;
});

//Frontend config
builder.Services.AddRazorPages();

builder.Services.AddHttpClient("ApiClient", client =>
{
    client.BaseAddress = new Uri("http://localhost:5256"); //ForeningsPortalenBaseUrl
});

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
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
