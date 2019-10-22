using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementSoftware.Repository
{
    public class ConnectionDB
    {
        string connectionString = @"SERVER=DESKTOP-BDF5EPV; DATABASE=BusinessManagementSystemDb; INTEGRATED SECURITY=true";
        private SqlConnection sqlConnection = null;

        public SqlConnection CreateConnection()
        {
            sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        }
    }
}
