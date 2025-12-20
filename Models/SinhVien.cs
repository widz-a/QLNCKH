using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("SinhVien")]
public class SinhVien {
    [Key]
    [StringLength(20)]
    public string MaSV { get; set; }

    [StringLength(100)]
    public string HoTen { get; set; }

    [StringLength(10)]
    public string GioiTinh { get; set; }

    public DateTime NgaySinh { get; set; }

    public int TinhId { get; set; }
    public int XaId { get; set; }
    public int DanTocId { get; set; }
    public int TonGiaoId { get; set; }

    [StringLength(20)]
    public string SDT { get; set; }

    [StringLength(50)]
    public string Lop { get; set; }

    public int ChucVuId { get; set; }

    [StringLength(100)]
    public string Nganh { get; set; }

    [StringLength(100)]
    public string ChuyenNganh { get; set; }

    /* ===== Navigation ===== */

    public Tinh Tinh { get; set; }
    public Xa Xa { get; set; }
    public DanToc DanToc { get; set; }
    public TonGiao TonGiao { get; set; }
    public ChucVu ChucVu { get; set; }
}

public class SinhVienDTO {
    public string MaSV { get; set; }
    public string HoTen { get; set; }
    public DateTime NgaySinh { get; set; }
    public string Lop { get; set; }

}
