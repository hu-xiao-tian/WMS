using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 仓库管理系统.Template
{
    /// <summary>
    /// 同种货物模板表
    /// </summary>
    public class TGoodsTemplate
    {
        /// <summary>
        /// 表自增id
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
        /// 同货物ID（条形码）
        /// </summary>
        public string BarCode { get; set; }
        /// <summary>
        /// 货物图片路径（Data/Image/Goods/ImageName.jpg）
        /// </summary>
        public string ImageName { get; set; }
        /// <summary>
        /// 类型ID
        /// </summary>
        public int TId { get; set; }
        /// <summary>
        /// 类型名字
        /// </summary>
        public string TName { get; set; }
        /// <summary>
        /// 供应商Id
        /// </summary>
        public int SId { get; set; }
        /// <summary>
        /// 供应商名字
        /// </summary>
        public string SName { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
    }
}
