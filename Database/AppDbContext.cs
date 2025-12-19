using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext {

    //
    private static string ConnectionString = "Server=DESKTOP-9BRK4F9; Database=QLNCKH;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;";


    //Đăng ký
    public DbSet<DanToc> DanToc { get; set; }
    public DbSet<TonGiao> TonGiao { get; set; }
    public DbSet<ChucVu> ChucVu { get; set; }
    public DbSet<CapBac> CapBac { get; set; }
    public DbSet<ChucDanh> ChucDanh { get; set; }
    public DbSet<TrinhDoChuyenMon> TrinhDoChuyenMon { get; set; }
    public DbSet<TrinhDoLLCT> TrinhDoLLCT { get; set; }
    public DbSet<HocHam> HocHam { get; set; }
    public DbSet<HocVi> HocVi { get; set; }
    public DbSet<LinhVuc> LinhVuc { get; set; }
    public DbSet<VaiTroDeTai> VaiTroDeTai { get; set; }
    public DbSet<TrangThaiDeTai> TrangThaiDeTai { get; set; }
    public DbSet<GiaiThuong> GiaiThuong { get; set; }

    public DbSet<Tinh> Tinh { get; set; }
    public DbSet<Xa> Xa { get; set; }

    public DbSet<SinhVien> SinhVien { get; set; }
    public DbSet<GiangVien> GiangVien { get; set; }
    public DbSet<DeTai> DeTai { get; set; }
    public DbSet<DeTai_SinhVien> DeTai_SinhVien { get; set; }

    public DbSet<ChuyenDe> ChuyenDe { get; set; }

    public DbSet<NopSanPham> NopSanPham { get; set; }

    public DbSet<DaoVan> DaoVan { get; set; }

    public DbSet<HoiDong> HoiDong { get; set; }
    public DbSet<HoiDong_ThanhVien> HoiDong_ThanhVien { get; set; }
    public DbSet<HoiDong_DeTai> HoiDong_DeTai { get; set; }

    public DbSet<PhieuCham> PhieuCham { get; set; }

    public DbSet<KetQua> KetQua { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer(ConnectionString);
}

public static class DbContextExtensions {
    public static IQueryable GetDbSet(this DbContext db, Type entityType) {
        var method = typeof(DbContext)
            .GetMethod(nameof(DbContext.Set), Type.EmptyTypes)!;

        var generic = method.MakeGenericMethod(entityType);
        return (IQueryable)generic.Invoke(db, null)!;
    }
}