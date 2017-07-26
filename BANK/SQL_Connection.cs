using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BANK
{
    class SQL_Connection
    {
        public static SqlConnection connstring = null;

        public void Connection()
        {
            connstring = new SqlConnection(@"Data Source=ROGUEBOY-VAIO;Initial Catalog=BANK Management; Integrated Security=True");
            connstring.Open();
        }
        
        public void Close_Connection()
        {
            connstring.Close();
        }
    }
}
