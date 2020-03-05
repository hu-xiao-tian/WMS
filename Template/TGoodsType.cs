using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 仓库管理系统.Template
{
    /// <summary>
    /// 货物类型
    /// </summary>
    class TGoodsType
    {
        /// <summary>
        /// 自增id
        /// </summary>
        public int AutoId { get; set; }
        /// <summary>
        /// 类型名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 排序码
        /// </summary>
        public int RankNum { get; set; }

    }
}
