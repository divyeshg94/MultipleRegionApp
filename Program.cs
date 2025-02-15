var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    string region = Environment.GetEnvironmentVariable("REGION_NAME") ?? "Unknown";
    return $"Hello from Azure App Service running in {region}!";
});

app.Run();
