using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StriveApi.Database;
using System.ComponentModel.DataAnnotations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOptions<TestOptions>().BindConfiguration("Test").ValidateDataAnnotations().ValidateOnStart();
builder.Services.AddSingleton(r => r.GetRequiredService<IOptions<TestOptions>>().Value);

builder.Services.AddDbContextPool<MtisiteContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MTISite"), serverOptions =>
    {
        serverOptions.EnableRetryOnFailure(1);
    });
    options.EnableSensitiveDataLogging(true);
});

var app = builder.Build();

// Configure the HTTP request pipeline.

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/", (TestOptions options) =>
{
    return Results.Ok(new
    {
        Message = "Hello World!",
        TestString = options.TestString ?? "No test string configured."
    });
});

app.MapGet("/brokers", async (MtisiteContext db) =>
{
    var brokers = await db.BrokerDirectories.Take(1).ToListAsync();
    return Results.Ok(brokers);
});

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
});

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}

class TestOptions
{
    public string? TestString { get; set; }
}