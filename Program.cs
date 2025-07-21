
using Microsoft.EntityFrameworkCore;

using LeleLoves.Models;

using LeleLove.EndPoints;

using LeleLoves.Services;



var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<LeleLovesDbContext>(
    options => options.UseSqlServer(
        Environment.GetEnvironmentVariable("SQL_CONNCETION")
    )
);


// builder.Services.AddTransient<IUserRepository, >();
// builder.Services.AddTransient<ILikeRepository, >();


var app = builder.Build();

app.ConfigureUsuarioEndPoints();

app.Run();