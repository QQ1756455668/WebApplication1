namespace BlazorApp1.Data
{
    /// <summary>
    /// 聊天记录表
    /// </summary>
    public class ChatRecordTb : Base
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        public string? UserId { set; get; }

        /// <summary>
        /// 用户头像照
        /// </summary>
        public string? UserHeadPortrait { set; get; }

        /// <summary>
        /// 用户名字
        /// </summary>
        public string? UserName { set; get; }

        /// <summary>
        /// 内容类型(1一般内容，2名片图片，3商品图片，4其它图片，5文件)
        /// </summary>
        public int TextType { set; get; }

        /// <summary>
        /// 聊天内容
        /// </summary>
        public string? ChatText { set; get; }

        /// <summary>
        /// 文件地址
        /// </summary>
        public string? FileSrc { set; get; }

        /// <summary>
        /// 文件名称
        /// </summary>
        public string? FileName { set; get; }

        /// <summary>
        /// 缩略图地址
        /// </summary>
        public string? ThumbnailSrc { set; get; }
    }
}
