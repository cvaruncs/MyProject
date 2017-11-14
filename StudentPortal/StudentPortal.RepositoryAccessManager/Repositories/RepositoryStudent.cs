using System.Collections.Generic;
using StudentPortal.DataAccessManager;
using StudentPortal.EntityManager;
using StudentPortal.RepositoryAccessManager.Interfaces;
using StudentPortal.RepositoryAccessManager.Infrastructure;
using System.Data.SqlClient;
using System.Data;

namespace StudentPortal.RepositoryAccessManager.Repositories
{
    public class RepositoryStudent : RepositoryManagerBase,IRepositoryStudent
    {
        public List<Student> GetAllStudents()
        {
            StudentDetails studentDetails = new StudentDetails();
            //List<Student> Temp = new List<Student>();
            var Temp = studentDetails.GetAllStudents();
            return Temp;
        }
        public List<Student> GetAllStudentsFromDB()
        {
            DataTable dt = new DataTable();
            //dBUtility = new DBManager();
            List<Student> items = new List<Student>();
            dt = _dBManager.ExecuteQuery("USP_Get_Students", new Dictionary<string, string>());
            foreach (DataRow row in dt.Rows)
            {
                items.Add(new Student
                {
                    Name = row["name"].ToString(),
                    Id = row["name"].ToString(),
                    MainStream = new StudentPortal.EntityManager.Stream()
                });
            }

            return items;
        }
    }
}
