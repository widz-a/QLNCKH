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
public class HoiDong {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int MaHD { get; set; }

    [Required]
    public DateTime NgayCham { get; set; }

    [Required]
    [MaxLength(20)]
    public string Loai { get; set; } // "DETAI", "CHUYENDE"

    /* =====================
       NAVIGATION PROPERTIES
       ===================== */

    public ICollection<HoiDong_ThanhVien> HoiDong_ThanhViens { get; set; }
    public ICollection<HoiDong_DeTai> HoiDong_DeTais { get; set; }
    public ICollection<HoiDong_ChuyenDe> HoiDong_ChuyenDes { get; set; }
    public ICollection<PhieuCham> PhieuChams { get; set; }
}

public class HoiDongDto {
    public int MaHD { get; set; }
    public string Loai { get; set; } // "DETAI", "CHUYENDE"
    public DateTime NgayCham { get; set; }
    public int SoThanhVien { get; set; }
}

[Table("HoiDong_ThanhVien")]
public class HoiDong_ThanhVien {
    public int MaHD { get; set; }

    [MaxLength(20)]
    public string MaCB { get; set; }

    [MaxLength(30)]
    public string VaiTro { get; set; } // Chủ tịch, Thư ký, Thành viên

    // Navigation
    [ForeignKey(nameof(MaHD))]
    public HoiDong HoiDong { get; set; }

    [ForeignKey(nameof(MaCB))]
    public GiangVien GiangVien { get; set; }
}

[Table("HoiDong_DeTai")]
public class HoiDong_DeTai {
    public int MaHD { get; set; }

    [MaxLength(20)]
    public string MaDT { get; set; }

    // Navigation
    [ForeignKey(nameof(MaHD))]
    public HoiDong HoiDong { get; set; }

    [ForeignKey(nameof(MaDT))]
    public DeTai DeTai { get; set; }
}

[Table("HoiDong_ChuyenDe")]
public class HoiDong_ChuyenDe {
    public int MaHD { get; set; }

    [MaxLength(20)]
    public string MaCD { get; set; }

    public int Vong { get; set; } // 1 = sơ loại, 2 = lấy giải

    // Navigation
    [ForeignKey(nameof(MaHD))]
    public HoiDong HoiDong { get; set; }

    [ForeignKey(nameof(MaCD))]
    public ChuyenDe ChuyenDe { get; set; }
}

#endregion

#region CHẤM ĐIỂM

[Table("PhieuCham")]
public class PhieuCham {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int MaPhieu { get; set; }

    // ===== FK bắt buộc =====
    public int MaHD { get; set; }

    [MaxLength(20)]
    public string MaCB { get; set; }

    // ===== Phân loại =====
    [Required]
    [MaxLength(10)]
    public string Loai { get; set; } // "DETAI" | "CHUYENDE"

    // ===== FK nullable theo Loai =====
    [MaxLength(20)]
    public string? MaDT { get; set; }

    [MaxLength(20)]
    public string? MaCD { get; set; }

    public int? Vong { get; set; }

    [Column(TypeName = "decimal(4,2)")]
    public decimal Diem { get; set; }

    /* ========= NAVIGATION + FK ========= */

    [ForeignKey(nameof(MaHD))]
    public HoiDong HoiDong { get; set; }

    [ForeignKey(nameof(MaCB))]
    public GiangVien GiangVien { get; set; }

    [ForeignKey(nameof(MaDT))]
    public DeTai? DeTai { get; set; }

    [ForeignKey(nameof(MaCD))]
    public ChuyenDe? ChuyenDe { get; set; }
}


#endregion

#region KẾT QUẢ – XẾP GIẢI

[Table("KetQua_DeTai")]
public class KetQua_DeTai {
    [Key]
    [MaxLength(20)]
    public string MaDT { get; set; }

    [Column(TypeName = "decimal(4,2)")]
    public decimal? DiemTB { get; set; }

    [MaxLength(30)]
    public string Giai { get; set; }

    // Navigation
    [ForeignKey(nameof(MaDT))]
    public DeTai DeTai { get; set; }
}
[Table("KetQua_ChuyenDe")]
public class KetQua_ChuyenDe {
    [MaxLength(20)]
    public string MaCD { get; set; }

    public int Vong { get; set; } // cứ đề 1

    [Column(TypeName = "decimal(4,2)")]
    public decimal? DiemTB { get; set; }

    public bool? Dat { get; set; } // ignored ?

    [MaxLength(30)]
    public string Giai { get; set; }

    // Navigation
    [ForeignKey(nameof(MaCD))]
    public ChuyenDe ChuyenDe { get; set; }
}

#endregion