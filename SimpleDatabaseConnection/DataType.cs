using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDatabaseConnection
{
    class DataType
    {
        public string firstname;
        public string lastname;
        public string email;

        public DataType()
        {
        }

        public DataType (string firstname, string lastname, string email)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
        }

        public override string ToString()
        {
            return string.Format("firstname = {0}, lastname = {1}, email = {2})", firstname, lastname, email);
        }

        public string ToSqlString()
        {
            return string.Format("(firstname, lastname, email) VAlUES ('{0}', '{1}', '{2}')", firstname, lastname, email);
        }

        public static string TableString()
        {
            return "(id INT(6) UNSIGNED AUTO_INCREMENT PRIMARY KEY,firstname VARCHAR(30) NOT NULL,lastname VARCHAR(30) NOT NULL,email VARCHAR(50),timestamp TIMESTAMP)";
        }
    }
}
