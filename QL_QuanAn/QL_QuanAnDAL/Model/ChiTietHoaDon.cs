namespace QL_QuanAnDAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaCTHD { get; set; }

        public int SoLuong { get; set; }

        public decimal ThanhTien { get; set; }

        public int MaHD { get; set; }

        public int MaMonAn { get; set; }

        public virtual MonAn MonAn { get; set; }

        public virtual HoaDon HoaDon { get; set; }
    }
}
