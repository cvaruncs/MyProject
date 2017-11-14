using StudentPortal.BusinessLogicManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using StudentPortal.EntityManager;
using StudentPortal.RepositoryAccessManager.Repositories;
using System.Linq;

namespace StudentPortal.BusinessLogicManager.Modules.StudentDetails
{
    public class StudentBusinessLogic : IStudentBusinessLogic
    {
        private RepositoryStudent repositoryStudent;
        public StudentBusinessLogic()
        {
            repositoryStudent = new RepositoryStudent();
        }
        public List<Student> GetAllStudents()
        {
            //
            var studentList = repositoryStudent.GetAllStudents();
            //A simple business logic applied to display data in order.
            return studentList.OrderBy(X => X.Name).ToList();
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
