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


app.MapGet("/greet", () =>
{
    return "Hello Challenge Attendees";
})
.WithName("GreetChallengeAttendees");

app.MapGet("/greetuser", (string name) =>
{
    string user = name;
    return $"Hello {user}\n";
})
.WithName("GreetChallengeAttendeeWithName");

app.Run();