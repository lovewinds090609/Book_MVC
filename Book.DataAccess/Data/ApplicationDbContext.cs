using Book.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Book.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        /// <summary>
        /// 創建名為Categories資料表 資料格式為Models中的Category
        /// </summary>
        public DbSet<Category> Categories { get; set; }
        /// <summary>
        /// 創建產品資料表
        /// </summary>
        public DbSet<Product> Products { get; set; }
        /// <summary>
        /// 新增資料
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ///新增3筆資料 動作 科幻 歷史
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "間諜海岸",
                    Description = "一日間諜，一世間諜",
                    ISBN = "9789577419057",
                    Author = "泰絲．格里森",
                    ListPrice = 520,
                    Price = 410,
                    Price50 = 410,
                    Price100 = 410,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Title = "謊言裡的魔術師",
                    Description = "‖他的謊言，是操弄人心的陷阱，\r\n　　‖也能召喚她們的覺醒──",
                    ISBN = "9789573341802",
                    Author = "東野圭吾",
                    ListPrice = 480,
                    Price = 379,
                    Price50 = 379,
                    Price100 = 379,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Title = "情緒流動",
                    Description = "絕大多數的問題行為，都源自於情緒問題。\r\n　　你可以陪伴孩子，學習覺察情緒、安頓情緒， \r\n　　讓情緒如溪水般潺潺流動……",
                    ISBN = "9786263618268",
                    Author = "胡展詰",
                    ListPrice = 380,
                    Price = 300,
                    Price50 = 300,
                    Price100 = 300,
                    CategoryId = 1
                }
                );
        }

    }
}
