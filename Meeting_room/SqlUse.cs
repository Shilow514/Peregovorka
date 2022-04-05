using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Meeting
{
    public static class SqlUse
    {
        public readonly static ConnectionStringSettingsCollection connectionLine = ConfigurationManager.ConnectionStrings;
        public static SqlConnection connection = new SqlConnection(connectionLine[1].ToString());
    }
}
