using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#region ĐỀ TÀI NCKH

[Table("DeTai")]
public class DeTai
{
    [Key]
    [StringLength(20)]
    public string MaDT { get; set; }

    [StringLength(200)]
    public string TenDT { get; set; }

    public int? LinhVucId { get; set; }

    [StringLength(20)]
    public string MaGVHuongDan { get; set; }

    public DateTime ThoiGianDuKien { get; set; }

    public int? TrangThaiId { get; set; }

    [ForeignKey(nameof(LinhVucId))]
    public LinhVuc LinhVuc { get; set; }

    [ForeignKey(nameof(MaGVHuongDan))]
    public GiangVien GiangVienHuongDan { get; set; }

    [ForeignKey(nameof(TrangThaiId))]
    public TrangThaiDeTai TrangThai { get; set; }

    public ICollection<DeTai_SinhVien> SinhViens { get; set; }
    public ICollection<HoiDong_DeTai> HoiDongs { get; set; }
}

public class DeTaiDto {
    public string MaDT { get; set; }
    public string TenDT { get; set; }
    public int SoLuongSv { get; set; }
    public string TrangThai { get; set; }

}

[Table("DeTai_SinhVien")]
public class DeTai_SinhVien
{
    [StringLength(20)]
    public string MaDT { get; set; }

    [StringLength(20)]
    public string MaSV { get; set; }

    public int VaiTroId { get; set; }

    [ForeignKey(nameof(MaDT))]
    public DeTai DeTai { get; set; }

    [ForeignKey(nameof(MaSV))]
    public SinhVien SinhVien { get; set; }

    [ForeignKey(nameof(VaiTroId))]
    public VaiTroDeTai VaiTro { get; set; }
}

public class DeTai_SinhVienDto {
    public string MaSV { get; set; }

    public string HoTen { get; set; }
    public string Lop { get; set; }

    public string VaiTro { get; set; }
}

#endregion

#region CHUYÊN ĐỀ NCKH

[Table("ChuyenDe")]
public class ChuyenDe
{
    [Key]
    [StringLength(20)]
    public string MaCD { get; set; }

    [StringLength(200)]
    public string TenCD { get; set; }

    [StringLength(20)]
    public string MaSV { get; set; }

    public int? LinhVucId { get; set; }

    [ForeignKey(nameof(MaSV))]
    public SinhVien SinhVien { get; set; }

    [ForeignKey(nameof(LinhVucId))]
    public LinhVuc LinhVuc { get; set; }
}

public class ChuyenDeTdo {
    public string MaCD { get; set; }

    public string TenCD { get; set; }

    public string TenSV { get; set; }
    public string LinhVuc { get; set; }
}

#endregion

#region NỘP SẢN PHẨM

[Table("NopSanPham")]
public class NopSanPham
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [StringLength(20)]
    public string MaSo { get; set; }

    [StringLength(10)]
    public string Loai { get; set; } // DT / CD

    [StringLength(100)]
    public string TrangThaiNop { get; set; }

    [StringLength(20)]
    public string NguoiNop { get; set; }

    public DateTime? NgayNop { get; set; }
}

#endregion

#region RÀ QUÉT ĐẠO VĂN

[Table("DaoVan")]
public class DaoVan
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [StringLength(20)]
    public string MaDT { get; set; }

    public int LanQuet { get; set; }

    public double TyLeTrungLap { get; set; }

    [StringLength(50)]
    public string KetLuan { get; set; }

    [ForeignKey(nameof(MaDT))]
    public DeTai DeTai { get; set; }
}

public class DaoVanDto {
    public int Id { get; set; }
    public string TenDT { get; set; }
    public int LanQuet { get; set; }
    public double TyLeTrungLap { get; set; }
    public string KetLuan { get; set; }
}

#endregion

#region HỘI ĐỒNG CHẤM

[Table("HoiDong")]
public class HoiDong
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int MaHD { get; set; }

    public DateTime? NgayCham { get; set; }

    public ICollection<HoiDong_ThanhVien> ThanhViens { get; set; }
    public ICollection<HoiDong_DeTai> DeTais { get; set; }
}

[Table("HoiDong_ThanhVien")]
public class HoiDong_ThanhVien
{
    public int MaHD { get; set; }

    [StringLength(20)]
    public string MaCB { get; set; }

    [StringLength(50)]
    public string VaiTroHoiDong { get; set; }

    [ForeignKey(nameof(MaHD))]
    public HoiDong HoiDong { get; set; }

    [ForeignKey(nameof(MaCB))]
    public GiangVien GiangVien { get; set; }
}

[Table("HoiDong_DeTai")]
public class HoiDong_DeTai
{
    public int MaHD { get; set; }

    [StringLength(20)]
    public string MaDT { get; set; }

    [ForeignKey(nameof(MaHD))]
    public HoiDong HoiDong { get; set; }

    [ForeignKey(nameof(MaDT))]
    public DeTai DeTai { get; set; }
}

#endregion

#region CHẤM ĐIỂM

[Table("PhieuCham")]
public class PhieuCham
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [StringLength(20)]
    public string MaSo { get; set; }

    [StringLength(10)]
    public string Loai { get; set; } // DT / CD

    [StringLength(20)]
    public string MaCB { get; set; }

    [StringLength(50)]
    public string VaiTroHoiDong { get; set; }

    public double Diem { get; set; }

    [ForeignKey(nameof(MaCB))]
    public GiangVien GiangVien { get; set; }
}

#endregion

#region KẾT QUẢ – XẾP GIẢI

[Table("KetQua")]
public class KetQua
{
    [Key]
    [StringLength(20)]
    public string MaSo { get; set; }

    [StringLength(10)]
    public string Loai { get; set; }

    public double DiemTrungBinh { get; set; }

    public int? GiaiId { get; set; }

    [ForeignKey(nameof(GiaiId))]
    public GiaiThuong GiaiThuong { get; set; }
}

#endregion