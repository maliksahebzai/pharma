using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PharmacyApp
{
    class connectivity
    {
        public static SqlConnection conn;
        
        public static void setconn()
        {
            conn = new SqlConnection("initial catalog = Pharmacy_MIS; DATA SOURCE =.; integrated security = true");

        }
        public static void setconn(string un, string pass)
        {
            conn = new SqlConnection("initial catalog = Pharmacy_MIS; DATA SOURCE = .; user = "+un+"; password = "+pass);

        }
        public static void openDb()
    {
        conn.Open();
    }
    public static void closeDb()
        {
            conn.Close();
        }

    }
}
