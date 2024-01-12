using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Coding_Challenge_Petpals.Util
{
    internal class DBConnUtil
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeConnection"].ConnectionString);
        }
    }
}
