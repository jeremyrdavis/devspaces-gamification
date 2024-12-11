using Microsoft.AspNetCore.Mvc;

namespace ds_challenge_03.Controllers;

[ApiController]
[Route("api/greet")]
public class GreetChallengeAttendeesController : ControllerBase
{
    [HttpGet(Name = "GreetChallengeAttendees")]
    public string GreetChallengeAttendees()
    {
        return "Hello Challenge Attendees";
    }
}

[ApiController]
[Route("api/greetuser")]
public class GreetChallengeAttendeeWithNameController : ControllerBase
{
    [HttpGet(Name = "GreetChallengeAttendeeWithName")]
    public string GreetChallengeAttendeeWithName(string name)
    {
        string user = name;
        return $"Hello {user}\n";
    }
}