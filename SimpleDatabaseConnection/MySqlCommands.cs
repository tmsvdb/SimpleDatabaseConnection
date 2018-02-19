using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDatabaseConnection
{
    class MySqlCommands
    {
        public static string ListAllDatabases()
        {
            return "SHOW DATABASES";
        }

        public static string CreateNewDatabase(string databaseName)
        {
            return string.Format("CREATE DATABASE {0}", databaseName);
        }

        public static string RemoveDatabase(string databaseName)
        {
            return string.Format("DROP DATABASE {0}", databaseName);
        }

        public static string ListAllTables(string databaseName)
        {
            return string.Format("SHOW TABLES IN {0}", databaseName);
        }

        public static string CreateNewTable(string databaseName, string tableName)
        {
            return string.Format("CREATE TABLE {0} {1}", tableName, DataType.TableString());
        }

        public static string RemoveTable(string tableName)
        {
            return string.Format("DROP TABLE {0}", tableName);
        }

        public static string ListAllTableContent(string tableName)
        {
            return string.Format("SELECT * FROM {0}", tableName);
        }

        public static string InsertTableContent(string tableName, DataType data)
        {
            return string.Format("INSERT INTO {0} {1}", tableName, data.ToSqlString());
        }
        public static string RemoveTableContent(string tableName, int row)
        {
            return string.Format("DELETE FROM {0} WHERE id = {1} LIMIT 1", tableName, row);
        }


        public static string LookupTableContent(string selection, string tableName, string conditions)
        {
            return string.Format("SELECT {0} FROM {1} WHERE {2}", selection, tableName, conditions);
        }
    }
}
