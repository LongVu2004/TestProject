namespace QL_QuanAnDAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string TenDN { get; set; }

        [StringLength(50)]
        public string MatKhau { get; set; }

        [StringLength(255)]
        public string LoaiTK { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNV { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
