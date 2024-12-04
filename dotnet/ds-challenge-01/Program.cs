var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/getcurrentdate", () =>
{
    return $"Current Date=[{DateTime.Now:yyyy-MM-dd}]";
}).WithName("GetCurrentDate");

app.MapGet("/calculateandprintstatistics", (int[] numbers) =>
{
    if (numbers == null || numbers.Length == 0) return "No data provided.";
    
    int sum = 0;
    int max = int.MinValue;
    int min = int.MaxValue;

    foreach (int number in numbers)
    {
        sum += number;
        if (number > max)
        {
            max = number;
        }
        if (number < min)
        {
            min = number;
        }
    }
    double average = (double)sum / numbers.Length;
    return "Average: " + average + " | " + "Maximum: " + max + " | " + "Minimum: " + min;

}).WithName("CalculateAndPrintStatistics");

app.Run();