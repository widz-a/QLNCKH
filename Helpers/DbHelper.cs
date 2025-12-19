using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class DbHelper {
    private static string ConnectionString = "Server=DESKTOP-9BRK4F9; Database=QLNCKH;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;";

    public static DataTable GetData(string sql, params SqlParameter[] parameters) {
        using var conn = new SqlConnection(ConnectionString);
        using var cmd = new SqlCommand(sql, conn);

        if (parameters != null && parameters.Length > 0)
            cmd.Parameters.AddRange(parameters);

        using var da = new SqlDataAdapter(cmd);
        var dt = new DataTable();
        da.Fill(dt);
        return dt;
    }

    /* =========================
       INSERT / UPDATE / DELETE
       ========================= */
    public static int Execute(string sql, params SqlParameter[] parameters) {
        using var conn = new SqlConnection(ConnectionString);
        using var cmd = new SqlCommand(sql, conn);

        if (parameters != null && parameters.Length > 0)
            cmd.Parameters.AddRange(parameters);

        conn.Open();
        return cmd.ExecuteNonQuery();
    }

    /* =========================
       SCALAR (COUNT, MAX, ...)
       ========================= */
    public static object ExecuteScalar(string sql, params SqlParameter[] parameters) {
        using var conn = new SqlConnection(ConnectionString);
        using var cmd = new SqlCommand(sql, conn);

        if (parameters != null && parameters.Length > 0)
            cmd.Parameters.AddRange(parameters);

        conn.Open();
        return cmd.ExecuteScalar();
    }

    /* =========================
       EXISTS (true / false)
       ========================= */
    public static bool Exists(string sql, params SqlParameter[] parameters) {
        var result = ExecuteScalar(sql, parameters);
        if (result == null || result == DBNull.Value) return false;
        return Convert.ToInt32(result) > 0;
    }
}
