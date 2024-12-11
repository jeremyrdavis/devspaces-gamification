using Microsoft.AspNetCore.Mvc;

namespace ds_challenge_01.Controllers;


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


[ApiController]
[Route("api/[controller]")]
public class CalculateAndPrintStatisticsController : ControllerBase
{

    [HttpGet(Name = "CalculateAndPrintStatistics")]
    public String calculateandprintstatistics([FromQuery]int[] numbers)
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

    }
}