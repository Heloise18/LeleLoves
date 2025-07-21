
using Microsoft.EntityFrameworkCore;

using LeleLoves.Models;
using LeleLove.Implementations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<EFUsuarioRepository, EFUsuarioRepository>();

builder.Services.AddDbContext<LeleLovesDbContext>(
    options => options.UseSqlServer(
        Environment.GetEnvironmentVariable("SQL_CONNCETION")
    )
);

// builder.Services.AddTransient<>();

// builder.Services.
var app = builder.Build();

app.ConfigureUsuarioEndPoints();

app.Run();