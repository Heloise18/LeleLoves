var builder = WebApplication.CreatrBuilder(args);

builder.Services.AddTransient<IUsuarioRepository, EFUsuarioRepository>();

var app = builder.Build();

app.ConfigureUsuarioEndPoints();

app.run();