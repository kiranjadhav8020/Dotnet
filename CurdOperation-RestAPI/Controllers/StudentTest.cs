using Microsoft.AspNetCore.Mvc;

namespace CurdOperation_RestAPI.Controllers
{
    [ApiController]
    [Route("/test")]
    public class StudentTest : ControllerBase
    {

        [HttpGet]   
        public ActionResult<String> getMessange() { 
            
             DateTime dateTime = DateTime.Now;

                int time= dateTime.Hour;

            Console.WriteLine(dateTime);

            if (time >= 5 && time < 12)
                return "Good Morning KIRAN "+time;

            else if (time >= 12 && time < 17)
                return "Good Afternoon KIRAN "+time;

            else if (time >= 17 && time < 22)
                return "Good Evening KIRAN " + time;

            else
                return "Good Night KIRAN " + time;
        
        }
    }
}
