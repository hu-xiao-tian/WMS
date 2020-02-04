using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 仓库管理系统.Template
{
    public class TLoginUser
    {
        public int AutoId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserEmail { get; set; }
        public string UserNickname { get; set; }
        public string UserTel { get; set; }
        public string UserSignature { get; set; }
        public string UserPortraitUrl { get; set; }
        public int UserLV { get; set; }
        public string LvInstructions { get; set; }
    }
}
