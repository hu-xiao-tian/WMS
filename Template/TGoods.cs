﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 仓库管理系统.Template
{
    /// <summary>
    /// 货物实体类
    /// 拥有货物所有属性
    /// </summary>
    public class TGoods
    {
        /// <summary>
        /// 货物id（自增）
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
        /// 同种货物ID（条形码）
        /// </summary>
        public string BarCode { get; set; }
        /// <summary>
        /// 货物图片URL
        /// </summary>
        public string ImageName { get; set; }
        /// <summary>
        /// 生产时间(日期编号)
        /// </summary>
        public string ProducedDate { get; set; }
        /// <summary>
        /// 有效时间（单位天）
        /// </summary>
        public int EffectiveTime { get; set; }
        /// <summary>
        /// 购入价格
        /// </summary>
        public double InPrice { get; set; }
        /// <summary>
        /// 出售价格（售出价格在未出库时应为预售价，到出库后才应改为真实出售价格）
        /// </summary>
        public double OutPrice { get; set; }
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
        /// 仓库ID
        /// </summary>
        public string WId { get; set; }
        /// <summary>
        /// 仓库名字
        /// </summary>
        public string WName { get; set; }
        
        /// <summary>
        /// 备注
        /// </summary>
        public string Description { get; set; }
    }
}
