using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public static class DanhMucMap {
    public static readonly Dictionary<string, Type> Map =
        new() {
            ["Dân tộc"] = typeof(DanToc),
            ["Tôn giáo"] = typeof(TonGiao),
            ["Cấp bậc"] = typeof(CapBac),
            ["Chức danh"] = typeof(ChucDanh),
            ["Chức vụ"] = typeof(ChucVu),
            ["Học hàm"] = typeof(HocHam),
            ["Học vị"] = typeof(HocVi),
            ["Trình độ CM"] = typeof(TrinhDoChuyenMon),
            ["Trình độ LLCT"] = typeof(TrinhDoLLCT),
            ["Lĩnh vực"] = typeof(LinhVuc),
            ["Vai trò đề tài"] = typeof(VaiTroDeTai),
            ["Trạng thái đề tài"] = typeof(TrangThaiDeTai),
            ["Giải thưởng"] = typeof(GiaiThuong),
            ["Đơn vị công tác"] = typeof(DonViCongTac),
        };
}

public interface IDanhMuc {
    int Id { get; set; }
    string Ten { get; set; }
}

[Table("DanToc")]
public class DanToc : IDanhMuc {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int DanTocId { get; set; }

    [StringLength(100)]
    public string TenDanToc { get; set; }

    [NotMapped]
    public int Id {
        get => DanTocId;
        set => DanTocId = value;
    }

    [NotMapped]
    public string Ten {
        get => TenDanToc;
        set => TenDanToc = value;
    }
}

[Table("TonGiao")]
public class TonGiao : IDanhMuc {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TonGiaoId { get; set; }

    [StringLength(100)]
    public string TenTonGiao { get; set; }

    [NotMapped]
    public int Id {
        get => TonGiaoId;
        set => TonGiaoId = value;
    }

    [NotMapped]
    public string Ten {
        get => TenTonGiao;
        set => TenTonGiao = value;
    }
}

[Table("ChucVu")]
public class ChucVu : IDanhMuc {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ChucVuId { get; set; }

    [StringLength(100)]
    public string TenChucVu { get; set; }

    [NotMapped]
    public int Id {
        get => ChucVuId;
        set => ChucVuId = value;
    }

    [NotMapped]
    public string Ten {
        get => TenChucVu;
        set => TenChucVu = value;
    }
}

[Table("CapBac")]
public class CapBac : IDanhMuc {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CapBacId { get; set; }

    [StringLength(100)]
    public string TenCapBac { get; set; }

    [NotMapped]
    public int Id {
        get => CapBacId;
        set => CapBacId = value;
    }

    [NotMapped]
    public string Ten {
        get => TenCapBac;
        set => TenCapBac = value;
    }
}

[Table("ChucDanh")]
public class ChucDanh : IDanhMuc {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ChucDanhId { get; set; }

    [StringLength(100)]
    public string TenChucDanh { get; set; }

    [NotMapped]
    public int Id {
        get => ChucDanhId;
        set => ChucDanhId = value;
    }

    [NotMapped]
    public string Ten {
        get => TenChucDanh;
        set => TenChucDanh = value;
    }
}

[Table("TrinhDoChuyenMon")]
public class TrinhDoChuyenMon : IDanhMuc {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TrinhDoCMId { get; set; }

    [StringLength(100)]
    public string TenTrinhDo { get; set; }

    [NotMapped]
    public int Id {
        get => TrinhDoCMId;
        set => TrinhDoCMId = value;
    }

    [NotMapped]
    public string Ten {
        get => TenTrinhDo;
        set => TenTrinhDo = value;
    }
}

[Table("TrinhDoLLCT")]
public class TrinhDoLLCT : IDanhMuc {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TrinhDoLLCTId { get; set; }

    [StringLength(100)]
    public string TenTrinhDo { get; set; }

    [NotMapped]
    public int Id {
        get => TrinhDoLLCTId;
        set => TrinhDoLLCTId = value;
    }

    [NotMapped]
    public string Ten {
        get => TenTrinhDo;
        set => TenTrinhDo = value;
    }
}

[Table("HocHam")]
public class HocHam : IDanhMuc {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int HocHamId { get; set; }

    [StringLength(100)]
    public string TenHocHam { get; set; }

    [NotMapped]
    public int Id {
        get => HocHamId;
        set => HocHamId = value;
    }

    [NotMapped]
    public string Ten {
        get => TenHocHam;
        set => TenHocHam = value;
    }
}

[Table("HocVi")]
public class HocVi : IDanhMuc {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int HocViId { get; set; }

    [StringLength(100)]
    public string TenHocVi { get; set; }

    [NotMapped]
    public int Id {
        get => HocViId;
        set => HocViId = value;
    }

    [NotMapped]
    public string Ten {
        get => TenHocVi;
        set => TenHocVi = value;
    }
}

[Table("LinhVuc")]
public class LinhVuc : IDanhMuc {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int LinhVucId { get; set; }

    [StringLength(200)]
    public string TenLinhVuc { get; set; }

    [NotMapped]
    public int Id {
        get => LinhVucId;
        set => LinhVucId = value;
    }

    [NotMapped]
    public string Ten {
        get => TenLinhVuc;
        set => TenLinhVuc = value;
    }
}

[Table("VaiTroDeTai")]
public class VaiTroDeTai : IDanhMuc {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int VaiTroId { get; set; }

    [StringLength(50)]
    public string TenVaiTro { get; set; }

    [NotMapped]
    public int Id {
        get => VaiTroId;
        set => VaiTroId = value;
    }

    [NotMapped]
    public string Ten {
        get => TenVaiTro;
        set => TenVaiTro = value;
    }
}

[Table("TrangThaiDeTai")]
public class TrangThaiDeTai : IDanhMuc {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TrangThaiId { get; set; }

    [StringLength(100)]
    public string TenTrangThai { get; set; }

    [NotMapped]
    public int Id {
        get => TrangThaiId;
        set => TrangThaiId = value;
    }

    [NotMapped]
    public string Ten {
        get => TenTrangThai;
        set => TenTrangThai = value;
    }
}

[Table("GiaiThuong")]
public class GiaiThuong : IDanhMuc {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int GiaiId { get; set; }

    [StringLength(50)]
    public string TenGiai { get; set; }

    [NotMapped]
    public int Id {
        get => GiaiId;
        set => GiaiId = value;
    }

    [NotMapped]
    public string Ten {
        get => TenGiai;
        set => TenGiai = value;
    }
}

[Table("DonViCongTac")]
public class DonViCongTac : IDanhMuc {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int MaDV { get; set; }

    [StringLength(50)]
    public string TenDV { get; set; }

    [NotMapped]
    public int Id {
        get => MaDV;
        set => MaDV = value;
    }

    [NotMapped]
    public string Ten {
        get => TenDV;
        set => TenDV = value;
    }
}

[Table("Tinh")]
public class Tinh {
    [Key]
    public int TinhId { get; set; }

    [Required]
    [StringLength(100)]
    public string TenTinh { get; set; }

    public ICollection<Xa> Xas { get; set; }
}

[Table("Xa")]
public class Xa {
    [Key]
    public int XaId { get; set; }

    [StringLength(100)]
    public string TenXa { get; set; }

    [ForeignKey(nameof(Tinh))]
    public int TinhId { get; set; }

    public Tinh Tinh { get; set; }
}