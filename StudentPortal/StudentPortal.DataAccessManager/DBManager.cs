using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace StudentPortal.DataAccessManager
{
    public class DBManager : IDBManager
    {
        private string _connectionstring;

        public DBManager(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        public DBManager()
        {
        }

        public DataTable ExecuteQuery( string storedProcName,  Dictionary<string, string> procParameters)
        {
            DataTable ds = new DataTable();
            using (SqlConnection cn = new SqlConnection(_connectionstring))
            {
                using (SqlCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = storedProcName;
                    // assign parameters passed in to the command
                    foreach (var procParameter in procParameters)
                    {
                        cmd.Parameters.Add(procParameter.Value);
                    }
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                }
            }
            return ds;
        }
    }
}
