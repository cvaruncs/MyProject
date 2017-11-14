using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentPortal.EntityManager;

namespace StudentPortal.WebAPI.Interfaces
{
    interface IStudentFacade
    {
        List<Student> GetAllStudents();

        Student GetStudentByID(string id);

        bool UpadteStudentByID(Student student);
    }
}
