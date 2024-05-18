using btvnADO.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btvnADO.DBContext
{
    public class EProductDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-GS7QPAK3\\SQLEXPRESS;Initial Catalog=QuanLyKho");
        }

        public virtual DbSet<Product>product {  get; set; }
        public virtual DbSet<Category> category { get; set; }
        public virtual DbSet<Warehouse> warehouse { get; set; }

    }
}
