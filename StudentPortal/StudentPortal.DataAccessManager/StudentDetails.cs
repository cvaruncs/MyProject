using System;
using System.Collections.Generic;
using System.Text;
using StudentPortal.EntityManager;
using System.IO;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace StudentPortal.DataAccessManager
{
    public class StudentDetails
    {
        private DBManager dBUtility;
        public List<Student> GetAllStudents()
        {
            List<Student> items;
            using (StreamReader r = new StreamReader(@"..\StudentPortal.DataAccessManager\StudentData.json"))
            {
                string jsonData = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<Student>>(jsonData);
            }
            return items;
        }
        //public List<Student> GetAllStudentsFromDB()
        //{
        //    DataTable dt = new DataTable();
        //    dBUtility = new DBManager();
        //    List<Student> items = new List<Student>();
        //    dt = dBUtility.ExecuteQuery("connection", "USP_GetStudents", new Dictionary<string, string>());
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        items.Add(new Student
        //        {
        //            Name = row["name"].ToString(),
        //            Id = row["name"].ToString(),
        //            MainStream = new StudentPortal.EntityManager.Stream()
        //        });
        //    }

        //    return items;
        //}


}

}
