using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 仓库管理系统.Template
{
    /// <summary>
    /// 入库表，表信息，主要用于记录统计，故货品细节可以省略
    /// </summary>
    public class TInWarehouse
    {
        /// <summary>
        /// 入库id(自增，用于统计)
        /// </summary>
        public int AutoId { get; set; }
        /// <summary>
        /// 货物名字
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 拼音码
        /// </summary>
        public string PinyinCode { get; set; }
        /// <summary>
        /// 货物id（条码）
        /// </summary>
        public string BarCode { get; set; }
        /// <summary>
        /// 生产时间(日期编号)
        /// </summary>
        public string ProducedDate { get; set; }
        /// <summary>
        /// 供应商名字
        /// </summary>
        public string SName { get; set; }
        /// <summary>
        /// 货物类型
        /// </summary>
        public string TName { get; set; }

        /// <summary>
        /// 仓库Id
        /// </summary>
        public string WId { get; set; }
        /// <summary>
        /// 购入单价
        /// </summary>
        public double InPrice { get; set; }
        /// <summary>
        /// 入库类型
        /// </summary>
        public string InType { get; set; }
        /// <summary>
        /// 入库数量
        /// </summary>
        public int InCount { get; set; }
        /// <summary>
        /// 入库时间
        /// </summary>
        public DateTime InTime { get; set; }
    }
}
