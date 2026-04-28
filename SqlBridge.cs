using System;
using System.Data.SqlClient;

class SqlBridge
{
    static void Main()
    {
        string conn = "your_connection_string";

        using (SqlConnection con = new SqlConnection(conn))
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Students", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
                Console.WriteLine(dr[0]);
        }
    }
}