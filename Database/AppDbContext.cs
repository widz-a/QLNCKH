using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext {

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
    public DbSet<DonViCongTac> DonViCongTac { get; set; }

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
    public DbSet<HoiDong_ChuyenDe> HoiDong_ChuyenDe { get; set; }

    public DbSet<PhieuCham> PhieuCham { get; set; }

    public DbSet<KetQua_DeTai> KetQua_DeTai { get; set; }
    public DbSet<KetQua_ChuyenDe> KetQua_ChuyenDe { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer(ConnectionString.connectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);
        foreach (var entityType in modelBuilder.Model.GetEntityTypes()) {
            foreach (var fk in entityType.GetForeignKeys()) {
                fk.DeleteBehavior = DeleteBehavior.Cascade;
            }
        }
        modelBuilder.Entity<DeTai_SinhVien>()
            .HasKey(x => new { x.MaDT, x.MaSV});

        modelBuilder.Entity<HoiDong_ThanhVien>()
            .HasKey(x => new { x.MaHD, x.MaCB });

        modelBuilder.Entity<HoiDong_DeTai>()
            .HasKey(x => new { x.MaHD, x.MaDT });

        modelBuilder.Entity<HoiDong_ChuyenDe>()
            .HasKey(x => new { x.MaHD, x.MaCD });

        modelBuilder.Entity<KetQua_ChuyenDe>()
            .HasKey(x => new { x.MaCD, x.Vong });
    }
}

public static class DbContextExtensions {
    public static IQueryable GetDbSet(this DbContext db, Type entityType) {
        var method = typeof(DbContext)
            .GetMethod(nameof(DbContext.Set), Type.EmptyTypes)!;

        var generic = method.MakeGenericMethod(entityType);
        return (IQueryable)generic.Invoke(db, null)!;
    }
}