using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 仓库管理系统
{
    class IOStream
    {
        /// <summary>
        /// 写错误日志
        /// </summary>
        /// <param name="path"></param>
        /// <param name="info"></param>
        public static void WriteErrorLog(string path,string info)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(info);
            if (File.Exists(path))
            {
                File.AppendAllText(path, sb.ToString());
            }
            else
            {
                File.Create(path);
                File.AppendAllText(path, sb.ToString());
            }
        }
        /// <summary>
        /// 打开图片文件
        /// </summary>
        /// <returns></returns>
        public static string OpenImage()
        {
            string filePath = "";
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C:\\";    //打开对话框后的初始目录
            fileDialog.Filter = "图片文件|*.jpg;*.png;*.jpeg;*.bmp;*.gif|所有文件|*.*";
            fileDialog.RestoreDirectory = false;    //若为false，则打开对话框后为上次的目录。若为true，则为初始目录
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = System.IO.Path.GetFullPath(fileDialog.FileName);
            }
            return filePath;
        }
        /// <summary>
        /// 保存图片文件
        /// </summary>
        /// <param name="savePath"></param>
        /// <param name="image"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool SaveImage(string savePath, Image image, string fileName)
        {
            if (!File.Exists(savePath))
            {
                if (!CreateDirectory(savePath))
                {
                    return false;
                }
            }
            try
            {
                image.Save($"{savePath}{fileName}");
                return true;
            }
            catch (Exception ex)
            {
                IOStream.WriteErrorLog("图片保存失败.txt", $"错误内容：{ex.ToString()}");
                return false;
            }
        }
        /// <summary>
        /// 创建文件夹
        /// </summary>
        /// <param name="savePath"></param>
        /// <returns></returns>
        public static bool CreateDirectory(string savePath)
        {
            try
            {
                Directory.CreateDirectory(savePath);
                return true;
            }
            catch (Exception ex)
            {
                IOStream.WriteErrorLog("文件夹创建失败.txt", $"错误内容：{ex.ToString()}");
                MessageBox.Show("文件夹创建失败，详情请查看日记");
                return false;
            }
        }
        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static bool DeleteFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("文件不存在，删除失败");
                return false;
            }
            try
            {
                File.Delete(filePath);
                MessageBox.Show("删除成功");
                return true;
            }
            catch (Exception ex)
            {
                IOStream.WriteErrorLog("文件删除失败.txt", $"错误内容：{ex.ToString()}");
                MessageBox.Show("文件删除失败，详情请查看日记");
                return false;
            }

        }
        /// <summary>
        /// 保存文本
        /// </summary>
        /// <param name="savePath"></param>
        /// <param name="text">文本内容</param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool SaveText(string savePath, string text, string fileName)
        {
            if (!File.Exists(savePath))
            {
                if (!CreateDirectory(savePath))
                {
                    return false;
                }
            }
            try
            {
                File.WriteAllText($"{savePath}{fileName}",text);
                return true;
            }
            catch (Exception ex)
            {
                IOStream.WriteErrorLog("图片保存失败.txt", $"错误内容：{ex.ToString()}");
                return false;
            }
        }
    }
}
