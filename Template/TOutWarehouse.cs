using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 仓库管理系统.Template
{
    class TOutWarehouse
    {
        /// <summary>
        /// 出库id(自增，用于统计)
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 货物表中自增id（主要用于区分具体货物个体）
        /// </summary>
        public string Gid { get; set; }
        /// <summary>
        /// 货物id（条码）
        /// </summary>
        public string BarCode { get; set; }
        /// <summary>
        /// 货物名字
        /// </summary>
        public string GName { get; set; }
        /// <summary>
        /// 客户id
        /// </summary>
        public int CId { get; set; }
        /// <summary>
        /// 客户名字
        /// </summary>
        public string CName { get; set; }
        /// <summary>
        /// 仓库Id
        /// </summary>
        public int WId { get; set; }
        /// <summary>
        /// 仓库名
        /// </summary>
        public string WName { get; set; }
        /// <summary>
        /// 货物类型
        /// </summary>
        public string GType { get; set; }
        /// <summary>
        /// 出库数量
        /// </summary>
        public int OutCount { get; set; }
        /// <summary>
        /// 售出单价
        /// </summary>
        public double OutPrice { get; set; }
        /// <summary>
        /// 出库时间
        /// </summary>
        public DateTime OutDate { get; set; }
    }
}
