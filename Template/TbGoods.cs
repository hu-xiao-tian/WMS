using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 仓库管理系统.Template
{
    /// <summary>
    /// 货物表类
    /// 每个货物即使类型厂家都一样，生产日期也会有所不同，即每一个货物都应该为单独的个体
    /// 货物统计时，再跟据货物所要的需求去做总计，故删除旧用的货物数量字段，新立了同种货物表
    /// 相同类型的货物，图片应该是一样的，不可能去做一个货物用一张图，故同类型货物的应指向同一张图片，考虑后将图片属性归入同种货物表
    /// 货物各项属性应该都存在于货物属性中，此处为表格属性，为节省存储空间，厂商种类等，使用ID关联多表获取
    /// 最终确定后，本类暂时舍去
    /// </summary>
    class TbGoods
    {
        /// <summary>
        /// 货物id（自增）
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 货物名字
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 仓库ID
        /// </summary>
        public int WId { get; set; }
        /// <summary>
        /// 类别ID（条形码）
        /// </summary>
        public int TId { get; set; }
        /// <summary>
        /// 供应商Id
        /// </summary>
        public int SId { get; set; }
        /// <summary>
        /// 生产时间
        /// </summary>
        public DateTime ProducedDate { get; set; }
        /// <summary>
        /// 有效时间（单位天）
        /// </summary>
        public int EffectiveTime { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Description { get; set; }
    }
}
