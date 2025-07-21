namespace LeleLove.EndPoints;

using LeleLoves.Models;
using LeleLoves.Payloads;
using LeleLoves.Services;
using Microsoft.AspNetCore.Mvc;

public static class UsuarioEndpoints
{
    public static void ConfigureUsuarioEndPoints(this WebApplication app)
    {
        app.MapPost("Users", async ([FromBody] UserCreatePayload payload, [FromServices]IUserRepository repo) =>
        {
            await repo.Create(new User
            {
                Username = payload.Username,
                Bio = payload.Bio,
                Password = payload.Password,
                Description = payload.Description
            });
            return Results.Ok();
        });
    }
}