using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class DbHelper {
    private static string connectionString = "Server=DESKTOP-9BRK4F9; Database=QLNCKH;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;";

    public static DataTable GetData(string sql) {
        using (SqlConnection conn = new SqlConnection(connectionString)) {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }

    public static int Execute(string sql) {
        using (SqlConnection conn = new SqlConnection(connectionString)) {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            return cmd.ExecuteNonQuery();
        }
    }
}