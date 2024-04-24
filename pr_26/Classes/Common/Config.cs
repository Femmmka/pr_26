using Microsoft.EntityFrameworkCore;
using System.Text;

namespace pr_26.Classes.Common
{
    public class Config
    {
        public static string ConnectionConfig = "server=10.0.201.4;uid=root;pwd=;database=pcClub;";
        public static MySqlServerVersion Version = new MySqlServerVersion(new System.Version(8, 0, 11));
    }
}
