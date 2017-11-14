using StudentPortal.EntityManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentPortal.RepositoryAccessManager.Interfaces
{
    interface IRepositoryStudent
    {
        List<Student> GetAllStudents();
    }
}
