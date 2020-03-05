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
        /// 客户名
        /// </summary>
        public string CName { get; set; }
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
        /// 售出单价
        /// </summary>
        public double OutPrice { get; set; }
        /// <summary>
        /// 出库类型
        /// </summary>
        public string OutType { get; set; }
        /// <summary>
        /// 出库时间
        /// </summary>
        public DateTime OutTime { get; set; }
    }
}
