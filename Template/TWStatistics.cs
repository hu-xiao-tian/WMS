using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 仓库管理系统.Template
{
    public class TWStatistics
    {
        public int AutoId { get; set; }
        public double InPrice { get; set; }
        public double OutPrice { get; set; }
        public double BadPrice { get; set; }
        public double ProfitPrice { get; set; }
        public int DateCode { get; set; }
    }
}
