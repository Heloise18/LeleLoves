using LeleLoves.Models;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<LeleLovesDbContext>(
    options => options.UseSqlServer(
        Environment.GetEnvironmentVariable("SQL_CONNCETION")
    )
);

// builder.Services.AddTransient<>();

// builder.Services.
var app = builder.Build();

app.Run();
