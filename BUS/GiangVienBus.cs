using Microsoft.Data.SqlClient;
using System.Data;

public static class GiangVienBus {
    public static DataTable getSome() {
        string sql = @"
            SELECT 
                gv.MaCB      AS N'Mã cán bộ',
                gv.HoTen     AS N'Họ và tên',
                cb.TenCapBac AS N'Cấp bậc',
                gv.NgaySinh  AS N'Ngày sinh'
            FROM GiangVien gv
            LEFT JOIN CapBac cb ON gv.CapBacId = cb.CapBacId
            ORDER BY gv.MaCB
        ";
        return DbHelper.GetData(sql);
    }

    public static DataTable GetById(string maCB) {
        return DbHelper.GetData(
            $"SELECT * FROM GiangVien WHERE MaCB = N'{maCB}'"
        );
    }

    public static void Insert(GiangVien gv) {
        string sql = @"
        INSERT INTO GiangVien (
            MaCB, HoTen, GioiTinh, NgaySinh,
            TinhId, XaId, DanTocId, TonGiaoId,
            SDT, TrinhDoCMId, TrinhDoLLCTId,
            DonViCongTac, ChucVuId, CapBacId,
            HeSoLuong, ChucDanhId, HocHamId, HocViId,
            LinhVucChuyenMon
        )
        VALUES (
            @MaCB, @HoTen, @GioiTinh, @NgaySinh,
            @TinhId, @XaId, @DanTocId, @TonGiaoId,
            @SDT, @TrinhDoCMId, @TrinhDoLLCTId,
            @DonViCongTac, @ChucVuId, @CapBacId,
            @HeSoLuong, @ChucDanhId, @HocHamId, @HocViId,
            @LinhVucChuyenMon
        )
    ";

        DbHelper.Execute(sql,
            new SqlParameter("@MaCB", gv.MaCB),
            new SqlParameter("@HoTen", gv.HoTen),
            new SqlParameter("@GioiTinh", gv.GioiTinh),
            new SqlParameter("@NgaySinh", gv.NgaySinh),

            new SqlParameter("@TinhId", (object?)gv.TinhId ?? DBNull.Value),
            new SqlParameter("@XaId", (object?)gv.XaId ?? DBNull.Value),
            new SqlParameter("@DanTocId", (object?)gv.DanTocId ?? DBNull.Value),
            new SqlParameter("@TonGiaoId", (object?)gv.TonGiaoId ?? DBNull.Value),

            new SqlParameter("@SDT", gv.SDT),
            new SqlParameter("@TrinhDoCMId", (object?)gv.TrinhDoCMId ?? DBNull.Value),
            new SqlParameter("@TrinhDoLLCTId", (object?)gv.TrinhDoLLCTId ?? DBNull.Value),

            new SqlParameter("@DonViCongTac", gv.DonViCongTac),
            new SqlParameter("@ChucVuId", (object?)gv.ChucVuId ?? DBNull.Value),
            new SqlParameter("@CapBacId", (object?)gv.CapBacId ?? DBNull.Value),

            new SqlParameter("@HeSoLuong", (object?)gv.HeSoLuong ?? DBNull.Value),
            new SqlParameter("@ChucDanhId", (object?)gv.ChucDanhId ?? DBNull.Value),
            new SqlParameter("@HocHamId", (object?)gv.HocHamId ?? DBNull.Value),
            new SqlParameter("@HocViId", (object?)gv.HocViId ?? DBNull.Value),

            new SqlParameter("@LinhVucChuyenMon", gv.LinhVucChuyenMon)
        );
    }

    public static int Update(string maCB, GiangVien gv) {
        string sql = @"
        UPDATE GiangVien SET
            HoTen = @HoTen,
            GioiTinh = @GioiTinh,
            NgaySinh = @NgaySinh,
            TinhId = @TinhId,
            XaId = @XaId,
            DanTocId = @DanTocId,
            TonGiaoId = @TonGiaoId,
            SDT = @SDT,
            TrinhDoCMId = @TrinhDoCMId,
            TrinhDoLLCTId = @TrinhDoLLCTId,
            DonViCongTac = @DonViCongTac,
            ChucVuId = @ChucVuId,
            CapBacId = @CapBacId,
            HeSoLuong = @HeSoLuong,
            ChucDanhId = @ChucDanhId,
            HocHamId = @HocHamId,
            HocViId = @HocViId,
            LinhVucChuyenMon = @LinhVucChuyenMon
        WHERE MaCB = @MaCB
    ";

        return DbHelper.Execute(sql,
            new SqlParameter("@MaCB", maCB),
            new SqlParameter("@MaCB", gv.MaCB),
            new SqlParameter("@HoTen", gv.HoTen),
            new SqlParameter("@GioiTinh", gv.GioiTinh),
            new SqlParameter("@NgaySinh", gv.NgaySinh),

            new SqlParameter("@TinhId", (object?)gv.TinhId ?? DBNull.Value),
            new SqlParameter("@XaId", (object?)gv.XaId ?? DBNull.Value),
            new SqlParameter("@DanTocId", (object?)gv.DanTocId ?? DBNull.Value),
            new SqlParameter("@TonGiaoId", (object?)gv.TonGiaoId ?? DBNull.Value),

            new SqlParameter("@SDT", gv.SDT),
            new SqlParameter("@TrinhDoCMId", (object?)gv.TrinhDoCMId ?? DBNull.Value),
            new SqlParameter("@TrinhDoLLCTId", (object?)gv.TrinhDoLLCTId ?? DBNull.Value),

            new SqlParameter("@DonViCongTac", gv.DonViCongTac),
            new SqlParameter("@ChucVuId", (object?)gv.ChucVuId ?? DBNull.Value),
            new SqlParameter("@CapBacId", (object?)gv.CapBacId ?? DBNull.Value),

            new SqlParameter("@HeSoLuong", (object?)gv.HeSoLuong ?? DBNull.Value),
            new SqlParameter("@ChucDanhId", (object?)gv.ChucDanhId ?? DBNull.Value),
            new SqlParameter("@HocHamId", (object?)gv.HocHamId ?? DBNull.Value),
            new SqlParameter("@HocViId", (object?)gv.HocViId ?? DBNull.Value),

            new SqlParameter("@LinhVucChuyenMon", gv.LinhVucChuyenMon)
        );
    }


    public static int Delete(string maCB) {
        string sql = "DELETE FROM GiangVien WHERE MaCB = @MaCB";
        return DbHelper.Execute(sql,
            new SqlParameter("@MaCB", maCB));
    }
}
