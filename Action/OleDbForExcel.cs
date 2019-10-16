using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace 仓库管理系统
{
    class OleDbForExcel
    {
        /*
         * 注：
         *OleDb对Excel表格xmls的输出会报错，必须使用老版本xls。输入无问题
         * sheet不可重名创建
         * 打开数据库操作时：文件存在则追加sheet，不存在会自动创建
         *varchar 只支持 256 字符 长字符用备注：Memo
         * 插入时 表名跟字段会报错，直接values不用的字段输null，显示为空
         * sign:璀璨
         */
        //excel输出
        //自动创建文件模式，未完善
        //两种方案权衡：
        //1.一次导出整个DataSet所有表
        //2.一次导出一个表
        /*
        * 1.查询字段必须可变-字段从DataTable字段
        * 2.sheet表名从DataTable
        * 3.DateSet导出遍历调datatable
        * 4.DateSet文件存在判断，sheet不存在则新建，存在则直接在xls文件插sheet
        */
        public void OutputSheet(string path,string sheetName,DataTable dataTable)
        {
            string OleDbConnStr = $"Provider=Microsoft.Jet.OLEDB.4.0; Data Source={path};Extended Properties=Excel 8.0;";
            using(var conn = new OleDbConnection(OleDbConnStr))
            {

                string sql = "";
                conn.Execute("");
            }
        }
        public void OutputExcel(string Path, string sheetName,DataSet dataSet)
        {
            String OleDbConnStr = $"Provider=Microsoft.Jet.OLEDB.4.0; Data Source={Path};Extended Properties=Excel 8.0;";

            OleDbConnection cn = new OleDbConnection(OleDbConnStr);

            string sqlCreate = $"CREATE TABLE {sheetName} ([words] VarChar,[count] INTEGER,[state] INTEGER,[partCount] INTEGER,[awemeId] VarChar,[awemeUrl] Memo)";

            OleDbCommand cmd = new OleDbCommand(sqlCreate, cn);

            //创建Excel文件

            cn.Open();

            //创建TestSheet工作表
            cmd.ExecuteNonQuery();


            int count = 0;

            //添加数据
            //foreach (var item in myExcelTables)
            //{
            //    cmd.CommandText = $"INSERT INTO {sheetName} VALUES('{item.Word}',{item.Count},{item.State},{item.PartCount},null,null)";
            //    cmd.ExecuteNonQuery();

            //    count++;
            //}


            //关闭连接
            cn.Close();
        }


        #region excel输入(参数：文件路径 返回值：DataSet) 19/10/16 大体完成非必须不做大改 sign:璀璨
        public static DataSet LoadDataFromExcel(string fileName)
        {
            try
            {
                List<string> names = new List<string>();
                System.Data.DataTable dtNames = GetExcelTableName(fileName);
                for (int i = 0; i < dtNames.Rows.Count; i++)
                {
                    string str = dtNames.Rows[i]["Table_Name"].ToString();
                    if (str.Substring(str.LastIndexOf("$") + 1) == "_xlnm#_FilterDatabase") continue;
                    names.Add(str);
                }
                string strConn = GetConString(fileName);


                DataSet OleDsExcle = new DataSet();
                OleDbConnection OleConn = new OleDbConnection(strConn);
                OleDbDataAdapter OleDaExcel = null; OleConn.Open();
                for (int i = 0; i < names.Count; i++)
                {
                    DataSet dsTmp = new DataSet();
                    String sql = String.Empty;
                    sql += String.Format("SELECT * FROM  [{0}];", names[i]);


                    OleDaExcel = new OleDbDataAdapter(sql, OleConn);
                    OleDaExcel.Fill(dsTmp, names[i]);
                    OleDsExcle.Tables.Add(dsTmp.Tables[0].Copy());


                }
                OleConn.Close();
                return OleDsExcle;
            }
            catch
            {
                return null;
            }
        }
        public static System.Data.DataTable GetExcelTableName(string fileName)
        {
            try
            {
                if (System.IO.File.Exists(fileName))
                {
                    OleDbConnection _ExcelConn = new OleDbConnection(GetConString(fileName));
                    _ExcelConn.Open();
                    System.Data.DataTable _Table = _ExcelConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    _ExcelConn.Close();
                    return _Table;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
        private static string GetConString(string fileName)
        {
            return "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
                      + fileName + ";Extended Properties='Excel 8.0;HDR=False;IMEX=1'";
        }
    }
    #endregion
}

