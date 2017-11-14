using StudentPortal.DataAccessManager;
using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using Microsoft.IdentityModel.Protocols;

namespace StudentPortal.RepositoryAccessManager.Infrastructure
{
    public class RepositoryManagerBase
    {
        protected DBManager _dBManager;
        private String _connectionstring;
        public RepositoryManagerBase()
        {
            //_connectionstring = ConfigurationManager.ConnectionStrings["StudentPortalDB"].ConnectionString;
            _connectionstring = "";
            _dBManager = new DBManager(_connectionstring);

        }
    }
}
