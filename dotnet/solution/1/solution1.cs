[ApiController]
[Route("api/[controller]")]
public class DateController : ControllerBase
{
    [HttpGet(Name = "GetCurrentDate")]
    public String getcurrentdate()
    {
       return $"Current Date=[{DateTime.Now:yyyy-MM-dd}]";
    }
}