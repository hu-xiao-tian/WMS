using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 仓库管理系统.Template
{
    /// <summary>
    /// 仓库类
    /// </summary>
    public class TWarehouse
    {
        public int AutoId { get; set; }
        /// <summary>
        /// 仓库Id（编号）
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 仓库名字
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 仓库地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 仓库面积（暂定单位平方米）
        /// </summary>
        public double Area { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// 联系人
        /// </summary>
        public string Contacts { get; set; }
        /// <summary>
        /// 是否停用
        /// </summary>
        public bool IsUse { get; set; }
        /// <summary>
        /// 是否为默认仓库
        /// </summary>
        public bool IsDefault { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Description { get; set; }
    }
}
