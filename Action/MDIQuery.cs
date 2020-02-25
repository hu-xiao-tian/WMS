using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using Dapper;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading;
using 仓库管理系统.Template;
using System.Data;

namespace 仓库管理系统
{
    class MDIQuery
    {
        public static string conStr = ConfigurationManager.ConnectionStrings["WMSDBconStr"].ConnectionString;

        public static bool UpdateUserLvInfo(List<TLoginUser> loginUsers)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = $@"update LoginUser SET 
                    UserLv = @UserLv
                    Where UserName=@UserName";
                    conn.Execute(sql, loginUsers);
                    return true;
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("UserLvAlterError.txt", info);
                return false;
            }

        }
        /// <summary>
        /// 获取供应商数据
        /// </summary>
        /// <returns></returns>
        public static List<TSupplier> GetSuppliers(string typeId=null)
        {
            try
            {
                List<TSupplier> suppliers = new List<TSupplier>();
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = $@"select Supplier.[AutoId],[CompanyName],[PinyinCode],[ContactName],[Area],[Address],[WebSite],[Tel],[Email],[TypeId],[Name] as TypeName,Supplier.[RankNum] 
from Supplier inner join SupplierType on Supplier.TypeId = SupplierType.AutoId";
                    if (!string.IsNullOrEmpty(typeId))
                    {
                        sql += $" where Supplier.TypeId ={typeId}";
                    }
                    sql += " Order by Supplier.[RankNum]";
                    return conn.Query<TSupplier>(sql).ToList();
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("GetSuppliersError.txt", info);
                return null;
            }
        }
        public static bool AlterSupplierInfo(TSupplier supplier)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = @"UPDATE Supplier SET 
                    [CompanyName]=@CompanyName,[PinyinCode]=@PinyinCode,[ContactName]=@ContactName,
                    [Area]=@Area,[Address]=@Address,[WebSite]=@WebSite,[Tel]=@Tel,
                    [Email]=@Email,[TypeId]=@TypeId,[RankNum]=@RankNum 
                     WHERE [AutoId]=@AutoId ";
                        
                    conn.Execute(sql, supplier);
                    return true;
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("SupplierAlterError.txt", info);
                return false;
            }
        }
        public static bool InsertSupplierInfo(TSupplier supplier)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = "insert into " +
                        "Supplier([CompanyName],[PinyinCode],[ContactName],[Area],[Address],[WebSite],[Tel],[Email],[TypeId],[RankNum]) " +
                        "Values(@CompanyName,@PinyinCode,@ContactName,@Area,@Address,@WebSite,@Tel,@Email,@TypeId,@RankNum)";
                    conn.Execute(sql, supplier);
                    return true;
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("SupplierAlterError.txt", info);
                return false;
            }
        }

        /// <summary>
        /// 根据用户名获取用户数据
        /// </summary>
        /// <param name="loginUsers">用户对象列表</param>
        /// <returns></returns>
        public static List<TLoginUser> GetUserInfo(List<TLoginUser> loginUsers)
        {
            try
            {
                List<TLoginUser> tLoginUsers = new List<TLoginUser>();
                foreach (var user in loginUsers)
                {
                    using (var conn = new SqlConnection(conStr))
                    {
                        string sql = $@"select LoginUser.[AutoId],[UserName],[UserEmail],[UserNickname],[UserSignature],[UserPortraitUrl],LoginUser.[UserLv],[UserTel],[LvInstructions] 
                from LoginUser inner join LvInfo on LoginUser.UserLV = LvInfo.UserLv
                where LoginUser.UserName =@UserName";
                        tLoginUsers.AddRange(conn.Query<TLoginUser>(sql, user).ToList());
                    }
                }
                return tLoginUsers;
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("GetUserInfoError.txt", info);
                return null;
            }
        }
        /// <summary>
        /// 用户信息查询
        /// </summary>
        /// <param name="keyword">关键字，用户名/邮箱/电话</param>
        /// <returns></returns>
        public static List<TLoginUser> SelectUserInfo(string keyword = null)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = @"select LoginUser.[AutoId],[UserName],[UserEmail],[UserNickname],[UserSignature],[UserPortraitUrl],LoginUser.[UserLv],[UserTel],[LvInstructions] 
                from LoginUser inner join LvInfo on LoginUser.UserLV = LvInfo.UserLv";
                    if (!string.IsNullOrEmpty(keyword))
                    {
                        sql += $@" where LoginUser.UserName like '%'+@Keyword+'%' 
                                or LoginUser.UserEmail like '%'+@Keyword+'%' 
                                or LoginUser.UserTel like '%'+@Keyword+'%' ";
                    }
                    return conn.Query<TLoginUser>(sql,new { Keyword = keyword }).ToList();
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("SelectUserInfoError.txt", info);
                return null;
            }

        }
        /// <summary>
        /// 获取用户数据
        /// </summary>
        /// <returns></returns>
        public static List<TLoginUser> GetUserInfo(string lv=null)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = @"select LoginUser.[AutoId],[UserName],[UserEmail],[UserNickname],[UserSignature],[UserPortraitUrl],LoginUser.[UserLv],[UserTel],[LvInstructions] 
                from LoginUser inner join LvInfo on LoginUser.UserLV = LvInfo.UserLv";
                    if (!string.IsNullOrEmpty(lv))
                    {
                        sql += $" where LoginUser.UserLV ={lv}";
                    }
                    return conn.Query<TLoginUser>(sql).ToList();
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("GetUserInfoError.txt", info);
                return null;
            }

        }
        /// <summary>
        /// 获取仓库数据
        /// </summary>
        /// <returns></returns>
        public static List<TWarehouse> GetWarehouseInfo()
        {
            using (var conn = new SqlConnection(conStr))
            {
                string sql = @"select [Id],[Name],[Address],[Area],[Tel],[Contacts],[IsUse],[IsDefault],[Description] 
                from Warehouse(nolock) ";
                return conn.Query<TWarehouse>(sql).ToList();
            }
        }
        /// <summary>
        /// id重复检查
        /// </summary>
        /// <param name="id">要检查的id</param>
        /// <param name="DBName">在那个数据表检查</param>
        /// <returns></returns>
        public static int NoCheck(string id,string DBName)
        {
            using (var conn = new SqlConnection(conStr))
            {
                string sql = $"select count(*) from {DBName}(nolock) Where Id=@Id";
                return conn.ExecuteScalar<int>(sql, new { Id = id });
            }
        }
        public static bool InsertWarehouseInfo(TWarehouse warehouse)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    if (warehouse.IsDefault)
                    {
                        string setDefault = "update Warehouse SET IsDefault=0 Where IsDefault=1";
                        conn.Execute(setDefault);
                    }
                    string sql = "insert into " +
                        "Warehouse(Id, Name, Address,Area,Tel,Contacts,IsUse,IsDefault,Description) " +
                        "Values(@Id,@Name,@Address,@Area,@Tel,@Contacts,@IsUse,@IsDefault,@Description)";
                    conn.Execute(sql, warehouse);
                    return true;
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("WarehouseAlterError.txt", info);
                return false;
            }

        }
        public static bool UpdateWarehouseInfo(TWarehouse warehouse, TWarehouse warehouseOld)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    if (warehouse.IsDefault)
                    {
                        string setDefault = "update Warehouse SET IsDefault=0 Where IsDefault=1";
                        conn.Execute(setDefault);
                    }
                    string sql = $@"update Warehouse SET 
                    Id=@Id, Name=@Name, Address=@Address,Area=@Area,Tel=@Tel,Contacts=@Contacts,IsUse=@IsUse,IsDefault=@IsDefault,Description=@Description 
                    Where Id='{warehouseOld.Id}'";
                    conn.Execute(sql, warehouse);
                    return true;
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("WarehouseAlterError.txt", info);
                return false;
            }

        }

        public static int DeleteWarehouseInfo(List<TWarehouse> warehouses)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = $"delete from Warehouse Where Id=@Id";
                    return conn.Execute(sql, warehouses);
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("DeleteWarehouseInfoError.txt", info);
                return 0;
            }

        }
        public static int DeleteSupplierInfo(List<TSupplier> suppliers)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = $"delete from Supplier Where AutoId=@AutoId";
                    return conn.Execute(sql, suppliers);
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("DeleteSupplierInfoError.txt", info);
                return 0;
            }

        }
        public static List<TLoginUser> DataRowToLoginUser(List<DataRow> dataRows)
        {
            ModelHandlerA.ModelHandler<TLoginUser> modelHandler = new ModelHandlerA.ModelHandler<TLoginUser>();
            List<TLoginUser> loginUsers = new List<TLoginUser>();
            foreach (var dataRow in dataRows)
            {
                TLoginUser loginUser = modelHandler.FillModel(dataRow);
                loginUsers.Add(loginUser);
            }
            return loginUsers;
        }
        public static List<TWarehouse> DataRowToWarehouse(List<DataRow> dataRows)
        {
            ModelHandlerA.ModelHandler<TWarehouse> modelHandler = new ModelHandlerA.ModelHandler<TWarehouse>();
            List<TWarehouse> warehouses = new List<TWarehouse>();
            foreach (var dataRow in dataRows)
            {
                TWarehouse warehouse = modelHandler.FillModel(dataRow);
                warehouses.Add(warehouse);
            }
            return warehouses;
        }

        public static List<TWarehouse> GetWarehouseByName(string keyWord)
        {
            using (var conn = new SqlConnection(conStr))
            {
                string sql = "select * from Warehouse(nolock) Where name like '%'+@KeyWord+'%'";
                return conn.Query<TWarehouse>(sql,new { KeyWord = keyWord }).ToList();
            }
        }
        public static List<TSupplier> GetSupplierByName(string keyWord)
        {
            using (var conn = new SqlConnection(conStr))
            {
                string sql = @"select * from Supplier(nolock) 
                                Where CompanyName like '%'+@KeyWord+'%'
                                OR PinyinCode like '%'+@KeyWord+'%'";
                return conn.Query<TSupplier>(sql,new { KeyWord = keyWord}).ToList();
            }
        }
        public static List<TLvInfo> GetLvInfos(int lv)
        {
            using (var conn = new SqlConnection(conStr))
            {
                string sql = $"select * from LvInfo(nolock) Where UserLv > {lv}";
                return conn.Query<TLvInfo>(sql).ToList();
            }
        }
        /// <summary>
        /// 获取指定数据库中的最大排名数据
        /// </summary>
        /// <param name="dbName">数据库名</param>
        /// <returns></returns>
        public static int GetMaxRankNum(string dbName)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = $"SELECT top 1 [RankNum] FROM {dbName}(nolock) Order By [RankNum] desc";
                    int rankNum = conn.Query<int>(sql).FirstOrDefault();
                    return ++rankNum;
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("GetDBRankNumError.txt", info);
                return -1;
            }
        }
    }
}
