using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentPortal.BusinessLogicManager.Modules.StudentDetails;
using StudentPortal.EntityManager;
namespace StudentPortal.WebClient.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private StudentBusinessLogic studentBusinessLogic;
        public SampleDataController()
        {
            studentBusinessLogic = new StudentBusinessLogic();

        }
        //private IStudentFacade _studentFacade = new StudentFacade();
        // GET: api/Students
        [HttpGet("[action]")]
        public IEnumerable<Student> Get()
        {
            return studentBusinessLogic.GetAllStudents();
        }
        //[HttpGet("[action]")]
        //public IEnumerable<WeatherForecast> WeatherForecasts()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    });
        //}

        public class WeatherForecast
        {
            public string Name { get; set; }
            public String Id { get; set; }
        }
    }
}
