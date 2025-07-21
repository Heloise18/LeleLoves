namespace LeleLoves.Payloads;

public record UserCreatePayload(
    string Username,
    string Bio,
    string Password,
    string Description
);