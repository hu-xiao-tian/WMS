using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 仓库管理系统.Template
{
    /// <summary>
    /// 客户
    /// </summary>
    public class TClient
    {
        /// <summary>
        /// 客户id
        /// </summary>
        public int AutoId { get; set; }
        /// <summary>
        /// 公司名称
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        /// 拼音码
        /// </summary>
        public string PinyinCode { get; set; }
        /// <summary>
        /// 联系人名字
        /// </summary>
        public string ContactName { get; set; }
        /// <summary>
        /// 客户所在区域
        /// </summary>
        public string Area { get; set; }
        /// <summary>
        /// 客户地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 官网地址
        /// </summary>
        public string WebSite { get; set; }
        /// <summary>
        /// 客户电话
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// 电子邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 类型id
        /// </summary>
        public int TypeId { get; set; }
        /// <summary>
        /// 类型名称
        /// </summary>
        public string TypeName { get; set; }
        /// <summary>
        /// 显示排行
        /// </summary>
        public int RankNum { get; set; }
    }
}
