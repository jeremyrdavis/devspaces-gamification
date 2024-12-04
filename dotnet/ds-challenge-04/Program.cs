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

app.MapGet("/challenge04", () =>
{
    string name = "OpenShift DevSpaces";
    int length = name.Length;

        for (int index = 0; index < length; index++)
        {
            char myChar = name[index];
            if (index == 4) // Index 4 represents the fifth character in a zero-based index system
            {
                char fifthCharacter = name[index];
                return $"The Fifth Character in the word \"OpenShift\"=[{fifthCharacter}]\n";
            }
        }
        return "String is shorter than length 5 \n";
})
.WithName("ChallengeMethod");

app.Run();