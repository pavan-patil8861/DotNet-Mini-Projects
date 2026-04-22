using BankApi.Data;
using BankApi.Repositories.Implementation;
using BankApi.Repositories.Interfaces;
using BankApi.Services;
using BankApi.Services.Interfaces;

using BankApi.Data;
using BankApi.Repositories.Interfaces;
using BankApi.Services;
using BankApi.Services.Interfaces;
using BankApi.Repositories.Implementation;
using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("BankDB"));

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IAccountRepository, AccountRepository>();
builder.Services.AddScoped<IAccountService, AccountService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

WebApplication app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();