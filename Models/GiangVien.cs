using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("GiangVien")]
public class GiangVien {
    [Key]
    [StringLength(20)]
    public string MaCB { get; set; }

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

    public int TrinhDoCMId { get; set; }
    public int TrinhDoLLCTId { get; set; }

    public int MaDV { get; set; }

    public int ChucVuId { get; set; }
    public int CapBacId { get; set; }

    public double HeSoLuong { get; set; }

    public int ChucDanhId { get; set; }
    public int HocHamId { get; set; }
    public int HocViId { get; set; }

    [StringLength(200)]
    public string LinhVucChuyenMon { get; set; }

    /* ===== Navigation ===== */

    public Tinh Tinh { get; set; }
    public Xa Xa { get; set; }
    public DanToc DanToc { get; set; }
    public TonGiao TonGiao { get; set; }
    [ForeignKey(nameof(TrinhDoCMId))]
    public TrinhDoChuyenMon TrinhDoChuyenMon { get; set; }
    public TrinhDoLLCT TrinhDoLLCT { get; set; }

    public ChucVu ChucVu { get; set; }
    public CapBac CapBac { get; set; }
    public ChucDanh ChucDanh { get; set; }
    public HocHam HocHam { get; set; }
    public HocVi HocVi { get; set; }
    
    [ForeignKey(nameof(MaDV))]
    public DonViCongTac DonViCongTac { get; set; }
}

public class GiangVienDto {
    public string MaCB { get; set; }
    public string HoTen { get; set; }
    public DateTime NgaySinh { get; set; }
    public string TenDV { get; set; }

}