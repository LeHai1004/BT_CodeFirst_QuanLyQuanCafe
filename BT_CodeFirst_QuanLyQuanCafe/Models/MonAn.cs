using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BT_CodeFirst_QuanLyQuanCafe.Models
{
    public class MonAn
    {
        [Key]
        public int MaMon { get; set; }
        [Required]
        public string TenMon { get; set; }
        public double Gia { get; set; }
        public int MaLoai { get; set; }
        [ForeignKey("MaLoai")]
        public virtual LoaiMon LoaiMon { get; set; }
    }
}