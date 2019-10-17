using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 仓库管理系统
{
    /*
     * DateSet输出Excel：GetExcelByDataSet(DataSet ds, string file) 新建文件，若已存在会覆盖
     * DateTable输出Excel:GetExcelByDataTable(DataTable dt, string file) 文件不存在时新建文件，存在时追加sheet,若sheet同名会在名字后+1,若仍然重名+2以此类推
     * Excel导入成DateTable:GetDataTable(string filePath, int sheetIndex) 
     * Excel导入成GetDataSet:GetDataSet(string filePath, int? sheetIndex = null)
     */

    public class ExcelHelper
    {
        public static bool isXls = true;
        /// <summary>
        /// 根据文件名判断:xls和xlsx
        /// </summary>
        /// <param name="filePath"></param>
        private static void SetIsXls(string filePath)
        {
            if (filePath.Last() == 's')
            {
                isXls = true;
            }
            else
            {
                isXls = false;
            }
        }
        /// <summary>
        /// 根据Excel和Sheet返回DataTable
        /// </summary>
        /// <param name="filePath">Excel文件地址</param>
        /// <param name="sheetIndex">Sheet索引</param>
        /// <returns>DataTable</returns>
        public static DataTable GetDataTable(string filePath, int sheetIndex)
        {
            return GetDataSet(filePath, sheetIndex).Tables[0];
        }

        /// <summary>
        /// 根据Excel返回DataSet
        /// </summary>
        /// <param name="filePath">Excel文件地址</param>
        /// <param name="sheetIndex">Sheet索引，可选，默认返回所有Sheet</param>
        /// <returns>DataSet</returns>
        public static DataSet GetDataSet(string filePath, int? sheetIndex = null)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show($"{filePath}文件不存在");
                return null;
            }
            DataSet ds = new DataSet();
            IWorkbook fileWorkbook;
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    SetIsXls(filePath);
                    if (isXls)
                    {
                        try
                        {
                            fileWorkbook = new HSSFWorkbook(fs);
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                    else
                    {
                        try
                        {
                            fileWorkbook = new XSSFWorkbook(fs);
                        }
                        catch
                        {
                            fileWorkbook = new HSSFWorkbook(fs);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载文件异常，请检查文件是否损坏或被占用：{ex}");
                return null;
            }
            

            for (int i = 0; i < fileWorkbook.NumberOfSheets; i++)
            {
                if (sheetIndex != null && sheetIndex != i)
                    continue;
                DataTable dt = new DataTable();
                ISheet sheet = fileWorkbook.GetSheetAt(i);
                dt.TableName = sheet.SheetName;
                //表头
                IRow header = sheet.GetRow(sheet.FirstRowNum);
                List<int> columns = new List<int>();
                for (int j = 0; j < header.LastCellNum; j++)
                {
                    object obj=new object();
                    if (isXls)
                    {
                        obj = GetValueTypeForXLS(header.GetCell(j) as HSSFCell);
                    }
                    else
                    {
                        obj = GetValueTypeForXLSX(header.GetCell(j) as XSSFCell);
                    }
                    if (obj == null || obj.ToString() == string.Empty)
                    {
                        dt.Columns.Add(new DataColumn("Columns" + j.ToString()));
                    }
                    else
                        dt.Columns.Add(new DataColumn(obj.ToString()));
                    columns.Add(j);
                }
                //数据
                IEnumerator rows = sheet.GetEnumerator();
                int colIndex = sheet.FirstRowNum;
                while (rows.MoveNext())
                {
                    if (colIndex == 0)//去标题
                    {
                        colIndex++;
                        continue;
                    }
                    DataRow dr = dt.NewRow();
                    bool hasValue = false;
                    foreach (int K in columns)
                    {
                        if (isXls)
                        {
                            dr[K] = GetValueTypeForXLS(sheet.GetRow(colIndex).GetCell(K) as HSSFCell);
                        }
                        else
                        {
                            dr[K] = GetValueTypeForXLSX(sheet.GetRow(colIndex).GetCell(K) as XSSFCell);
                        }
                            
                        if (dr[K] != null && dr[K].ToString() != string.Empty)
                        {
                            hasValue = true;
                        }
                    }
                    if (hasValue)
                    {
                        dt.Rows.Add(dr);
                    }
                    colIndex++;
                }
                ds.Tables.Add(dt);
            }

            return ds;
        }

        /// <summary>
        /// 根据DataTable导出Excel
        /// </summary>
        /// <param name="dt">DataTable</param>
        /// <param name="file">保存地址</param>
        public static void GetExcelByDataTable(DataTable dt, string file)
        {
            DataTable dtfb = dt.Copy();
            DataSet ds;
            if (!File.Exists(file))
            {
                ds = new DataSet();
                ds.Tables.Add(dtfb);
                GetExcelByDataSet(ds, file);
            }
            else
            {
                ds = GetDataSet(file);
                int count = 0;
                dtfb.TableName=ReNameSheets(dtfb.TableName, ds, count);
                ds.Tables.Add(dtfb);
                GetExcelByDataSet(ds, file);
            }

        }

        private static string ReNameSheets(string tableName, DataSet ds,int count)
        {
            string tempName = tableName;
            if (count > 0)
            {
                tempName += count;
            }
            foreach (DataTable oldDT in ds.Tables)
            {
                if (tempName.Equals(oldDT.TableName))
                {
                    return ReNameSheets(tableName, ds,++count);
                }
            }
            return tempName;
        }

        /// <summary>
        /// 根据DataSet导出Excel
        /// </summary>
        /// <param name="ds">DataSet</param>
        /// <param name="file">保存地址</param>
        public static void GetExcelByDataSet(DataSet ds, string file)
        {
            SetIsXls(file);
            IWorkbook fileWorkbook ;
            if (isXls)
            {
                fileWorkbook = new HSSFWorkbook();
            }
            else
            {
                fileWorkbook = new XSSFWorkbook();
            }
            int index = 0;
            foreach (DataTable dt in ds.Tables)
            {
                index++;
                ISheet sheet;
                if (string.IsNullOrEmpty(dt.TableName))
                {
                    sheet = fileWorkbook.CreateSheet("Sheet" + index);
                }
                else
                {
                    sheet = fileWorkbook.CreateSheet(dt.TableName);
                }
                //表头
                IRow row = sheet.CreateRow(0);
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    ICell cell = row.CreateCell(i);
                    cell.SetCellValue(dt.Columns[i].ColumnName);
                }

                //数据
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    IRow row1 = sheet.CreateRow(i + 1);
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        ICell cell = row1.CreateCell(j);
                        cell.SetCellValue(dt.Rows[i][j].ToString());
                    }
                }
            }

            //转为字节数组
            MemoryStream stream = new MemoryStream();
            fileWorkbook.Write(stream);
            var buf = stream.ToArray();

            //保存为Excel文件
            using (FileStream fs = new FileStream(file, FileMode.Create, FileAccess.Write))
            {
                fs.Write(buf, 0, buf.Length);
                fs.Flush();
            }
        }

        /// <summary>
        /// 根据单元格将内容返回为对应类型的数据xls
        /// </summary>
        /// <param name="cell">单元格</param>
        /// <returns>数据</returns>
        private static object GetValueTypeForXLS(HSSFCell cell)
        {
            if (cell == null)
                return null;
            switch (cell.CellType)
            {
                case CellType.Blank: //BLANK:
                    return null;
                case CellType.Boolean: //BOOLEAN:
                    return cell.BooleanCellValue;
                case CellType.Numeric: //NUMERIC:
                    return cell.NumericCellValue;
                case CellType.String: //STRING:
                    return cell.StringCellValue;
                case CellType.Error: //ERROR:
                    return cell.ErrorCellValue;
                case CellType.Formula: //FORMULA:
                default:
                    return "=" + cell.CellFormula;
            }
        }
        /// <summary>
        /// 根据单元格将内容返回为对应类型的数据xlsx
        /// </summary>
        /// <param name="cell">单元格</param>
        /// <returns>数据</returns>
        private static object GetValueTypeForXLSX(XSSFCell cell)
        {
            if (cell == null)
                return null;
            switch (cell.CellType)
            {
                case CellType.Blank: //BLANK:
                    return null;
                case CellType.Boolean: //BOOLEAN:
                    return cell.BooleanCellValue;
                case CellType.Numeric: //NUMERIC:
                    return cell.NumericCellValue;
                case CellType.String: //STRING:
                    return cell.StringCellValue;
                case CellType.Error: //ERROR:
                    return cell.ErrorCellValue;
                case CellType.Formula: //FORMULA:
                default:
                    return "=" + cell.CellFormula;
            }
        }
    }
}
