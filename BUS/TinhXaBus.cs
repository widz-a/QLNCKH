using Microsoft.Data.SqlClient;
using System.Data;

public static class TinhXaBus {

    //Tinh (TinhId, TenTinh)
    //Xa (XaId, TenXa, TinhId) 
    public static DataTable GetTinhs() {
        string sql = @"
            SELECT TinhId, TenTinh
            FROM Tinh
        ";

        return DbHelper.GetData(sql);
    }

    public static DataTable GetXasFromTinh(int tinhId) {
        string sql = $@"
            SELECT XaId, TenXa
            FROM Xa
            WHERE TinhId=@tinhId
        ";

        return DbHelper.GetData(sql, new SqlParameter("@tinhId", tinhId));
    }
}
