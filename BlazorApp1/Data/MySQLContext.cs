using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BlazorApp1.Data
{
    /// <summary>
    /// MYSQL数据库
    /// </summary>
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 32));
            optionsBuilder.UseMySql("server=localhost;user=root;password=123456;database=chat", serverVersion);
        }

        /// <summary>
        /// 聊天记录
        /// </summary>
        public DbSet<Data.ChatRecordTb> ChatRecordTb { set; get; }
    }
}
