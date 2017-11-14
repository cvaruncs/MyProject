using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentPortal.BusinessLogicManager.Modules.StudentDetails;
using StudentPortal.EntityManager;
using StudentPortal.WebAPI.Interfaces;

namespace StudentPortal.WebAPI.Facade
{
    public class StudentFacade : IStudentFacade
    {
        private StudentBusinessLogic studentBusinessLogic;
        public StudentFacade()
        {
            studentBusinessLogic = new StudentBusinessLogic();
            
        }
        public List<Student> GetAllStudents()
        {
            studentBusinessLogic.GetAllStudents();
            return studentBusinessLogic.GetAllStudents();
        }

        public Student GetStudentByID(string id)
        {
            throw new NotImplementedException();
        }

        public bool UpadteStudentByID(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
