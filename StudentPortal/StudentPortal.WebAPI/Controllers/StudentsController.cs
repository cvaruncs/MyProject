using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentPortal.EntityManager;
using StudentPortal.WebAPI.Interfaces;
using StudentPortal.WebAPI.Facade;
using Microsoft.AspNetCore.Cors;

namespace StudentPortal.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Students")]
    [EnableCors("MyPolicy")]
    public class StudentsController : Controller
    {
        private IStudentFacade _studentFacade = new StudentFacade();
        // GET: api/Students
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _studentFacade.GetAllStudents();
        }

        // GET: api/Students/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Students
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Students/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
