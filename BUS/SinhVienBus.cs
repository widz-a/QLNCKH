using Microsoft.Data.SqlClient;
using System.Data;

public static class SinhVienBUS {
    public static DataTable GetAll() {
        string sql = @"
            SELECT MaSV as N'Mã sinh viên', 
            HoTen as N'Họ và tên', 
            Lop as N'Lớp', 
            NgaySinh as N'Ngày sinh'
            FROM SinhVien
            ORDER BY MaSV
        ";
        return DbHelper.GetData(sql);
    }

    public static DataTable GetById(string maSV) {
        string sql = @"
            SELECT *
            FROM SinhVien
            WHERE MaSV = @maSV
        ";

        return DbHelper.GetData(sql,
            new SqlParameter("@maSV", maSV)
        );
    }

    public static int Insert(SinhVien sv) {
        string sql = @"
        INSERT INTO SinhVien (
            MaSV, HoTen, GioiTinh, NgaySinh,
            TinhId, XaId, DanTocId, TonGiaoId,
            SDT, Lop, ChucVuId, Nganh, ChuyenNganh
        )
        VALUES (
            @MaSV, @HoTen, @GioiTinh, @NgaySinh,
            @TinhId, @XaId, @DanTocId, @TonGiaoId,
            @SDT, @Lop, @ChucVuId, @Nganh, @ChuyenNganh
        )
    ";

        return DbHelper.Execute(sql,
            new SqlParameter("@MaSV", sv.MaSV),
            new SqlParameter("@HoTen", sv.HoTen),
            new SqlParameter("@GioiTinh", sv.GioiTinh),
            new SqlParameter("@NgaySinh", sv.NgaySinh),

            new SqlParameter("@TinhId", (object?)sv.TinhId ?? DBNull.Value),
            new SqlParameter("@XaId", (object?)sv.XaId ?? DBNull.Value),
            new SqlParameter("@DanTocId", (object?)sv.DanTocId ?? DBNull.Value),
            new SqlParameter("@TonGiaoId", (object?)sv.TonGiaoId ?? DBNull.Value),

            new SqlParameter("@SDT", sv.SDT),
            new SqlParameter("@Lop", sv.Lop),
            new SqlParameter("@ChucVuId", (object?)sv.ChucVuId ?? DBNull.Value),

            new SqlParameter("@Nganh", sv.Nganh),
            new SqlParameter("@ChuyenNganh", sv.ChuyenNganh)
        );
    }


    public static int Update(string maSV, SinhVien sv) {
        string sql = @"
        UPDATE SinhVien SET
            HoTen = @HoTen,
            GioiTinh = @GioiTinh,
            NgaySinh = @NgaySinh,
            TinhId = @TinhId,
            XaId = @XaId,
            DanTocId = @DanTocId,
            TonGiaoId = @TonGiaoId,
            SDT = @SDT,
            Lop = @Lop,
            ChucVuId = @ChucVuId,
            Nganh = @Nganh,
            ChuyenNganh = @ChuyenNganh
        WHERE MaSV = @MaSV
    ";

        return DbHelper.Execute(sql,
            new SqlParameter("@MaSV", maSV),

            new SqlParameter("@HoTen", sv.HoTen),
            new SqlParameter("@GioiTinh", sv.GioiTinh),
            new SqlParameter("@NgaySinh", sv.NgaySinh),

            new SqlParameter("@TinhId", (object?)sv.TinhId ?? DBNull.Value),
            new SqlParameter("@XaId", (object?)sv.XaId ?? DBNull.Value),
            new SqlParameter("@DanTocId", (object?)sv.DanTocId ?? DBNull.Value),
            new SqlParameter("@TonGiaoId", (object?)sv.TonGiaoId ?? DBNull.Value),

            new SqlParameter("@SDT", sv.SDT),
            new SqlParameter("@Lop", sv.Lop),
            new SqlParameter("@ChucVuId", (object?)sv.ChucVuId ?? DBNull.Value),

            new SqlParameter("@Nganh", sv.Nganh),
            new SqlParameter("@ChuyenNganh", sv.ChuyenNganh)
        );
    }
    public static int Delete(string maSV) {
        string sql = "DELETE FROM SinhVien WHERE MaSV = @MaSV";

        return DbHelper.Execute(sql,
            new SqlParameter("@MaSV", maSV)
        );
    }

}
