using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 仓库管理系统.Template
{
    /// <summary>
    /// 入库表，表信息，主要用于记录统计，故货品细节可以省略（主要信息应该基于货物种类表）
    /// </summary>
    class TInWarehouse
    {
        /// <summary>
        /// 入库id(自增，用于统计)
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
        /// 供应商Id
        /// </summary>
        public int SId { get; set; }
        /// <summary>
        /// 供应商名字
        /// </summary>
        public string SName { get; set; }
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
        /// 入库数量
        /// </summary>
        public int InCount { get; set; }
        /// <summary>
        /// 购入单价
        /// </summary>
        public double InPrice { get; set; }
        /// <summary>
        /// 入库时间
        /// </summary>
        public DateTime InDate { get; set; }
    }
}
