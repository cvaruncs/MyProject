using StudentPortal.EntityManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentPortal.BusinessLogicManager.Interfaces
{
    interface IStudentBusinessLogic
    {
        List<Student> GetAllStudents();

        Student GetStudentByID(string id);

        bool UpadteStudentByID(Student student);
    }
}
