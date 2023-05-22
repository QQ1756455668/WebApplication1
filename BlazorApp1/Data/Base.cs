using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data
{
    /// <summary>
    /// 基础实体
    /// </summary>
    public class Base
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        public Guid ID { set; get; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { set; get; }
    }
}
