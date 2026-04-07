using System.ComponentModel.DataAnnotations;

namespace BT_CodeFirst_QuanLyQuanCafe.Models
{
    public class LoaiMon
    {
        [Key]
        public int MaLoai { get; set; }
        [Required]
        public string TenLoai { get; set; }
        public ICollection<MonAn> MonAns { get; set; }
    }
}