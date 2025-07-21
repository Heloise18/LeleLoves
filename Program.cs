
using Microsoft.EntityFrameworkCore;

using LeleLoves.Models;


var builder = WebApplication.CreateBuilder(args);


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