namespace QL_QuanAnDAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHD { get; set; }

        public DateTime? NgayLap { get; set; }

        public decimal? TongTien { get; set; }

        public int MaKH { get; set; }

        public int MaBan { get; set; }

        public int MaTT { get; set; }

        public int MaNV { get; set; }

        public virtual BanAn BanAn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual ThanhToan ThanhToan { get; set; }
    }
}
