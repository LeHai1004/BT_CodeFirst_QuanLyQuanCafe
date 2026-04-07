using Microsoft.EntityFrameworkCore;
using BT_CodeFirst_QuanLyQuanCafe.Models;

namespace BT_CodeFirst_QuanLyQuanCafe
{
    public class CafeDbContext : DbContext
    {
        public DbSet<LoaiMon> LoaiMons { get; set; }
        public DbSet<MonAn> MonAns { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-JJUNDI09;Database=QuanLyQuanCafeDB;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}