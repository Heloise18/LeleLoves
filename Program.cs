
using Microsoft.EntityFrameworkCore;

using LeleLoves.Models;
using LeleLoves.Services;
using LeleLove.Implementations;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<LeleLovesDbContext>(
    options => options.UseSqlServer(
        Environment.GetEnvironmentVariable("SQL_CONNCETION")
    )
);


builder.Services.AddTransient<IUserRepository, EFUsuarioRepository>();
builder.Services.AddTransient<ILikeRepository, EfLikeRepository>();


var app = builder.Build();

app.ConfigureUsuarioEndPoints();

app.Run();