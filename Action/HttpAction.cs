using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace 仓库管理系统
{
    class HttpAction
    {
        internal static Image GetPicture(string userPortraitUrl)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(userPortraitUrl);
                request.Method = "GET";
                request.ContentType = "Content-Type:application/x-www-form-urlencoded";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                Image image = Image.FromStream(stream);
                stream.Close();
                return image;
            }
            catch(Exception ex)
            {
                IOStream.WriteErrorLog("网络图片获取失败.txt", $"错误信息：{ex}");
                return null;
            }
            
        }
    }
}
