using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Meeting_room
{
    public static class User
    {
        public static int Ping { get; set; }
        public static int Role { get; set; }
        public readonly static ConnectionStringSettingsCollection connectionLine = ConfigurationManager.ConnectionStrings;
    }
}
