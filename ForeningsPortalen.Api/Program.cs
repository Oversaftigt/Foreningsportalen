using ForeningsPortalen.Application;
using ForeningsPortalen.Domain.Validation;
using ForeningsPortalen.Crosscut.TransactionHandling;
using ForeningsPortalen.Crosscut.TransactionHandling.Implementations;
using ForeningsPortalen.Infrastructure;
using ForeningsPortalen.Infrastructure.ThirdPartyIntegrations;
using ForeningsPortalen.Infrastructure.Database.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddHttpClient<IDawaAddressValidationService, DawaAddressValidationService>(client =>
//client.BaseAddress = new Uri(builder.Configuration["DawaBaseUri"]));
builder.Services.AddHttpClient();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>(p =>
{
    var db = p.GetService<ForeningsPortalenContext>();
    return new UnitOfWork(db);
});


var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
//app.UseHttpsRedirection();


app.Run();
