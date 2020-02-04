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
    class TClient
    {
        /// <summary>
        /// 客户id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 客户名字
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 客户地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 客户电话
        /// </summary>
        public string Tel { get; set; }
    }
}
