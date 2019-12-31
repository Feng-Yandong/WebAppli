using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppli.Models
{
    //Add-Migration   1.0  //其中Init是你的版本名称
    //update-database 1.0  //更新数据库操作 init为版本名称
    public class CRMContext:DbContext
    {
        public CRMContext() { }
        public CRMContext(DbContextOptions<CRMContext> options):base(options) { }

        /// <summary>
        /// 重写基类，指定连接字符串
        /// </summary>
        /// <param name = "optionsBuilder" ></ param >
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                //读取json配置文件的字符串的方法（也可以在startup中，项目启动运行时获取）
                var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
                var config = builder.Build();
                string connStr = config["ConnectionStrings:DefaultConnection"];

                optionsBuilder.UseSqlServer(connStr);
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Addupto> Addupto { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Merchant> Merchant { get; set; }
        public DbSet<Orderform> Orderform { get; set; }
        public DbSet<Shopping> Shopping { get; set; }
        public DbSet<TypeGoods> TypeGoods { get; set; }
        public DbSet<Location> Location { get; set; }


    }
}
