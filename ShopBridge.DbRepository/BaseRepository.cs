using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.DbRepository
{
    public class BaseRepository
    {

        public Microsoft.Data.Sqlite.SqliteConnection GetConnection()
        {
             var connection = new Microsoft.Data.Sqlite.SqliteConnection(@"Data Source=fire_data.db");
            //var connection = new Microsoft.Data.Sqlite.SqliteConnection(@"Data Source=D:\Home\Site\wwwroot\Data\fire_data.db");
            connection.Open();
            return connection;
        }
    }
}
