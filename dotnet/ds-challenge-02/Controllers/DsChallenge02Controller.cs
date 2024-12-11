using Microsoft.AspNetCore.Mvc;

namespace ds_challenge_02.Controllers;

[ApiController]
[Route("api/hello")]
public class DsChallenge02Controller : ControllerBase
{

    [HttpGet(Name = "GreetChallengeAttendees")]
    public string GreetChallengeAttendees()
    {
        return "Hello Challenge Attendees";
    }
}