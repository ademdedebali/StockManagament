using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StockManagament
{
    class DatabaseOperations
    {
        SqlConnection con;
        public DatabaseOperations ()
        {
            con = new SqlConnection("server =.; Initial Catalog = stock; Integrated Security = SSPI");
        }

        public void AddCustomer (string name, string surname, string address, string telephone, string telephone2, string explanation)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = this.con;

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "usp_AddCustomer";
            cmd.Parameters.Add("name", System.Data.SqlDbType.NVarChar, 40).Value = name;
            cmd.Parameters.Add("surname", System.Data.SqlDbType.NVarChar, 30).Value = surname;
            cmd.Parameters.Add("telephone", System.Data.SqlDbType.NVarChar, 13).Value = telephone;
            cmd.Parameters.Add("telephone2", System.Data.SqlDbType.NVarChar, 13).Value = telephone2;
            cmd.Parameters.Add("address", System.Data.SqlDbType.NVarChar, 150).Value = address;
            cmd.Parameters.Add("explanation", System.Data.SqlDbType.NVarChar, 500).Value = explanation;

            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
