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
        /// 获取指定名称供应商数据
        /// </summary>
        /// <returns></returns>
        public static TSupplier GetSupplierByCompanyName(string name)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = $@"select Supplier.[AutoId],[CompanyName],[PinyinCode],[ContactName],[Area],[Address],[WebSite],[Tel],[Email],[TypeId],[Name] as TypeName,Supplier.[RankNum] 
from Supplier inner join SupplierType on Supplier.TypeId = SupplierType.AutoId
where Supplier.CompanyName =@CompanyName";
                    sql += " Order by Supplier.[RankNum]";
                    return conn.Query<TSupplier>(sql,new { CompanyName =name}).ToList().FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("GetSuppliersError.txt", info);
                return null;
            }
        }
        /// <summary>
        /// 获取指定id供应商数据
        /// </summary>
        /// <returns></returns>
        public static TSupplier GetSupplierById(string id)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = $@"select Supplier.[AutoId],[CompanyName],[PinyinCode],[ContactName],[Area],[Address],[WebSite],[Tel],[Email],[TypeId],[Name] as TypeName,Supplier.[RankNum] 
from Supplier inner join SupplierType on Supplier.TypeId = SupplierType.AutoId
where Supplier.AutoId ={id}";
                    sql += " Order by Supplier.[RankNum]";
                    return conn.Query<TSupplier>(sql).ToList().FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("GetSuppliersError.txt", info);
                return null;
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
        /// <summary>
        /// 获取客户数据
        /// </summary>
        /// <returns></returns>
        public static List<TClient> GetClients(string typeId = null)
        {
            try
            {
                List<TClient> clients = new List<TClient>();
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = $@"select Client.[AutoId],[CompanyName],[PinyinCode],[ContactName],[Area],[Address],[WebSite],[Tel],[Email],[TypeId],[Name] as TypeName,Client.[RankNum] 
from Client inner join ClientType on Client.TypeId = ClientType.AutoId";
                    if (!string.IsNullOrEmpty(typeId))
                    {
                        sql += $" where Client.TypeId ={typeId}";
                    }
                    sql += " Order by Client.[RankNum]";
                    return conn.Query<TClient>(sql).ToList();
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("GetClientError.txt", info);
                return null;
            }
        }
        /// <summary>
        /// 获取商品模板数据
        /// </summary>
        /// <returns></returns>
        public static List<TGoodsTemplate> GetGoodsTemplate(string typeId = null)
        {
            try
            {
                List<TGoodsTemplate> clients = new List<TGoodsTemplate>();
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = $@"select GoodsTemplate.[AutoId],GoodsTemplate.[Name],GoodsTemplate.[PinyinCode],[BarCode],[ImageName], 
GoodsType.[AutoId] as TId,GoodsType.[Name] as TName,
Supplier.[AutoId] as SId,Supplier.[CompanyName] as SName
from GoodsTemplate inner join GoodsType on GoodsTemplate.TId = GoodsType.AutoId
inner join Supplier on GoodsTemplate.SId = Supplier.AutoId";
                    if (!string.IsNullOrEmpty(typeId))
                    {
                        sql += $" where GoodsTemplate.TId ={typeId}";
                    }
                    sql += " Order by GoodsTemplate.[AutoId]";
                    return conn.Query<TGoodsTemplate>(sql).ToList();
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("GetGoodsTemplateError.txt", info);
                return null;
            }
        }
        /// <summary>
        /// 获取商品数据
        /// </summary>
        /// <returns></returns>
        public static List<TGoods> GetGoods(string typeId = null)
        {
            try
            {
                List<TGoods> clients = new List<TGoods>();
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = $@"select Goods.[AutoId],Goods.[Name],Goods.[PinyinCode],[BarCode],[ImageName], 
[ProducedDate],[EffectiveTime],[InPrice],[OutPrice],
GoodsType.[AutoId] as TId,GoodsType.[Name] as TName,
Supplier.[AutoId] as SId,Supplier.[CompanyName] as SName,
Warehouse.[Id] as WId,Warehouse.[Name] as WName
from Goods inner join GoodsType on Goods.TId = GoodsType.AutoId
inner join Supplier on Goods.SId = Supplier.AutoId
inner join Warehouse on Goods.WId = Warehouse.Id";
                    if (!string.IsNullOrEmpty(typeId))
                    {
                        sql += $" where Goods.TId ={typeId}";
                    }
                    sql += " Order by Goods.[AutoId]";
                    return conn.Query<TGoods>(sql).ToList();
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("GetGoodsError.txt", info);
                return null;
            }
        }
        /// <summary>
         /// 获取入库数据
         /// </summary>
         /// <returns></returns>
        public static List<TInWarehouse> GetInWarehouse(DateTime startTime, DateTime endTime,string keyWord=null)
        {
            try
            {
                List<TGoods> clients = new List<TGoods>();
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = $@"
SELECT [AutoId],[Name],[PinyinCode],[BarCode],[ProducedDate],[SName],[TName],[WId],[InPrice],[InType],[InCount],[InTime]
FROM InWarehouse WHERE [InTime]>'{startTime}' AND [InTime]<'{endTime}' 
";
                    if (!string.IsNullOrEmpty(keyWord))
                    {
                        sql+= @" AND 
(Name like '%' + @KeyWord + '%'
OR PinyinCode like '%' + @KeyWord + '%'
OR BarCode like '%' + @KeyWord + '%')";
                    }
                    return conn.Query<TInWarehouse>(sql,new{KeyWord = keyWord }).ToList();
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("GetInWarehouseError.txt", info);
                return null;
            }
        }
        /// <summary>
        /// 获取出库数据
        /// </summary>
        /// <returns></returns>
        public static List<TOutWarehouse> GetOutWarehouse(DateTime startTime, DateTime endTime, string keyWord = null)
        {
            try
            {
                List<TGoods> clients = new List<TGoods>();
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = $@"
SELECT [AutoId],[Name],[PinyinCode],[BarCode],[ProducedDate],[SName],[CName],[TName],[WId],[InPrice],[OutPrice],[OutType],[OutTime]
FROM OutWarehouse WHERE [OutTime]>'{startTime}' AND [OutTime]<'{endTime}' 
";
                    if (!string.IsNullOrEmpty(keyWord))
                    {
                        sql += @" AND 
(Name like '%' + @KeyWord + '%'
OR PinyinCode like '%' + @KeyWord + '%'
OR BarCode like '%' + @KeyWord + '%')";
                    }
                    return conn.Query<TOutWarehouse>(sql, new { KeyWord = keyWord }).ToList();
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("GetInWarehouseError.txt", info);
                return null;
            }
        }
        /// <summary>
        /// 获取商品库存数据
        /// </summary>
        /// <returns></returns>
        public static List<TGoodsCount> GetGoodsCount(string lastDay, string keyWord = null)
        {
            try
            {
                List<TGoods> clients = new List<TGoods>();
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = $@"select [Name],[PinyinCode],[BarCode],[ProducedDate],[EffectiveTime],COUNT(BarCode) as Count from
(select * from Goods 
";
                    if (!lastDay.Equals("全部"))
                    {
                        sql += $" WHERE [EffectiveTime]>0 AND datediff(day,GETDATE(),dateadd(day,[EffectiveTime],[ProducedDate]))<{lastDay}";
                    }
                    sql += ")as TempTB";
                    if (!string.IsNullOrEmpty(keyWord))
                    {
                        sql += @" Where 
(Name like '%' + @KeyWord + '%'
OR PinyinCode like '%' + @KeyWord + '%'
OR BarCode like '%' + @KeyWord + '%')";
                    }
                    sql += " group by Name,BarCode,PinyinCode,[ProducedDate],[EffectiveTime]";
                    return conn.Query<TGoodsCount>(sql, new { KeyWord = keyWord }).ToList();
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("GetGoodsCountError.txt", info);
                return null;
            }
        }
        /// <summary>
        /// 获取统计报表数据
        /// </summary>
        /// <returns></returns>
        public static List<TWStatistics> GetWStatisticsCount(string keyWord = null)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = $@"select [AutoId],[InPrice],[OutPrice],[BadPrice],[ProfitPrice],[DateCode] From WStatistics";
                    if (!string.IsNullOrEmpty(keyWord))
                    {
                        sql += @" Where DateCode like '%' + @KeyWord + '%'";
                    }
                    return conn.Query<TWStatistics>(sql, new { KeyWord = keyWord }).ToList();
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("GetGoodsCountError.txt", info);
                return null;
            }
        }
        /// <summary>
        /// 获取统计报表数据
        /// </summary>
        /// <returns></returns>
        public static List<TWStatistics> GetWStatistics()
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = $@"select [AutoId],[InPrice],[OutPrice],[BadPrice],[ProfitPrice],[DateCode]
from WStatistics  Order by DateCode desc";
                    return conn.Query<TWStatistics>(sql).ToList();
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("GetWStatisticsError.txt", info);
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
        public static bool AlterGoodsTemplateInfo(TGoodsTemplate goodsTemplate)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = @"UPDATE GoodsTemplate SET 
                    [Name]=@Name,[PinyinCode]=@PinyinCode,[BarCode]=@BarCode,
                    [ImageName]=@ImageName,[TId]=@TId,[SId]=@SId,[Description]=@Description
                     WHERE [AutoId]=@AutoId ";

                    conn.Execute(sql, goodsTemplate);
                    return true;
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("GoodsTemplateAlterError.txt", info);
                return false;
            }
        }
        public static bool AlterGoods(TGoods goods)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = @"UPDATE Goods SET 
                    [Name]=@Name,[PinyinCode]=@PinyinCode,[BarCode]=@BarCode,
                    [ImageName]=@ImageName,[TId]=@TId,[SId]=@SId,[ProducedDate]=@ProducedDate,
                    [EffectiveTime]=@EffectiveTime,[InPrice]=@InPrice,[OutPrice]=@OutPrice,
                    [WId]=@WId,[Description]=@Description
                     WHERE [AutoId]=@AutoId ";

                    conn.Execute(sql, goods);
                    return true;
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("GoodsAlterError.txt", info);
                return false;
            }
        }
        public static bool AlterClientInfo(TClient client)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = @"UPDATE Client SET 
                    [CompanyName]=@CompanyName,[PinyinCode]=@PinyinCode,[ContactName]=@ContactName,
                    [Area]=@Area,[Address]=@Address,[WebSite]=@WebSite,[Tel]=@Tel,
                    [Email]=@Email,[TypeId]=@TypeId,[RankNum]=@RankNum 
                     WHERE [AutoId]=@AutoId ";

                    conn.Execute(sql, client);
                    return true;
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("ClientAlterError.txt", info);
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
        public static bool InsertGoodsTemplateInfo(TGoodsTemplate goodsTemplate)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = "insert into " +
                        "GoodsTemplate([Name],[PinyinCode],[BarCode],[ImageName],[TId],[SId],[Description]) " +
                        "Values(@Name,@PinyinCode,@BarCode,@ImageName,@TId,@SId,@Description)";
                    conn.Execute(sql, goodsTemplate);
                    return true;
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("goodsTemplateAlterError.txt", info);
                return false;
            }
        }
        public static bool InsertGoodsInfo(TGoods goods)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = @"
Insert into Goods( [Name],[PinyinCode],[BarCode],[ImageName],[TId],[SId],[ProducedDate],[EffectiveTime],[InPrice],[OutPrice],[WId],[Description])
Values(@Name,@PinyinCode,@BarCode,@ImageName,@TId,@SId,@ProducedDate,@EffectiveTime,@InPrice,@OutPrice,@WId,@Description)";
                    conn.Execute(sql, goods);
                    return true;
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("goodsAlterError.txt", info);
                return false;
            }
        }
        public static bool InsertClientInfo(TClient client)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = "insert into " +
                        "Client([CompanyName],[PinyinCode],[ContactName],[Area],[Address],[WebSite],[Tel],[Email],[TypeId],[RankNum]) " +
                        "Values(@CompanyName,@PinyinCode,@ContactName,@Area,@Address,@WebSite,@Tel,@Email,@TypeId,@RankNum)";
                    conn.Execute(sql, client);
                    return true;
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("ClientAlterError.txt", info);
                return false;
            }
        }
        public static bool InsertInWarehouseInfo(TInWarehouse inWarehouse)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = @"insert into InWarehouse
([Name],[PinyinCode],[BarCode],[ProducedDate],[SName],[TName],[WId],[InPrice],[InType],[InCount])
values
(@Name,@PinyinCode,@BarCode,@ProducedDate,@SName,@TName,@WId,@InPrice,@InType,@InCount)";
                    conn.Execute(sql, inWarehouse);
                    return true;
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("InWarehouseAlterError.txt", info);
                return false;
            }
        }
        public static bool InsertOutWarehouseInfo(TOutWarehouse outWarehouse)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = @"insert into OutWarehouse
([Name],[PinyinCode],[BarCode],[ProducedDate],[SName],[CName],[TName],[WId],[InPrice],[OutPrice],[OutType])
values
(@Name,@PinyinCode,@BarCode,@ProducedDate,@SName,@CName,@TName,@WId,@InPrice,@OutPrice,@OutType)";
                    conn.Execute(sql, outWarehouse);
                    return true;
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("OutWarehouseAlterError.txt", info);
                return false;
            }
        }
        public static bool InsertWStatisticsInfo(TWStatistics statistics)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = @"
Insert into WStatistics([InPrice],[OutPrice],[BadPrice],[ProfitPrice],[DateCode])
Values(@InPrice,@OutPrice,@BadPrice,@ProfitPrice,@DateCode)";
                    conn.Execute(sql, statistics);
                    return true;
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("WStatisticsAlterError.txt", info);
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
        /// 获取启用的仓库数据
        /// </summary>
        /// <param name="AutoId"></param>
        /// <returns></returns>
        public static List<TWarehouse> GetUsingWarehouseInfo()
        {
            using (var conn = new SqlConnection(conStr))
            {
                string sql = @"select [AutoId],[Id],[Name],[Address],[Area],[Tel],[Contacts],[IsUse],[IsDefault],[Description] 
                from Warehouse(nolock)  Where [IsUse] = 1
                Order By IsDefault Desc";
                return conn.Query<TWarehouse>(sql).ToList();
            }
        }
        /// <summary>
        /// 获取仓库数据
        /// </summary>
        /// <returns></returns>
        public static List<TWarehouse> GetWarehouseInfo(int AutoId = -1)
        {
            using (var conn = new SqlConnection(conStr))
            {
                string sql = @"select [AutoId],[Id],[Name],[Address],[Area],[Tel],[Contacts],[IsUse],[IsDefault],[Description] 
                from Warehouse(nolock) ";
                if (AutoId>0)
                {
                    sql += $" Where [AutoId] = {AutoId}";
                }
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
        public static bool UpdateWarehouseInfo(TWarehouse warehouse)
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
                    Where Id=@Id";
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
        public static bool UpdateWStatisticsInfo(TWStatistics statistics)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = $@"update WStatistics SET 
                    InPrice=@InPrice, OutPrice=@OutPrice,BadPrice=@BadPrice,ProfitPrice=@ProfitPrice
                    Where DateCode=@DateCode";
                    conn.Execute(sql, statistics);
                    return true;
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("WStatisticsAlterError.txt", info);
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
        public static int DeleteClientInfo(List<TClient> clients)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = $"delete from Client Where AutoId=@AutoId";
                    return conn.Execute(sql, clients);
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("DeleteClientInfoError.txt", info);
                return 0;
            }

        }
        public static int DeleteGoodsTemplateInfo(List<TGoodsTemplate> goodsTemplates)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = $"delete from GoodsTemplate Where AutoId=@AutoId";
                    return conn.Execute(sql, goodsTemplates);
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("DeleteGoodsTemplateInfoError.txt", info);
                return 0;
            }

        }
        public static int DeleteGoods(List<TGoods> goods)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = $"delete from Goods Where AutoId=@AutoId";
                    return conn.Execute(sql, goods);
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("DeleteGoodsInfoError.txt", info);
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
                string sql = "select * from Warehouse(nolock) Where Id like '%'+@KeyWord+'%' Or Name like '%'+@KeyWord+'%'";
                return conn.Query<TWarehouse>(sql,new { KeyWord = keyWord }).ToList();
            }
        }
        public static List<TSupplier> GetSupplierByName(string keyWord)
        {
            using (var conn = new SqlConnection(conStr))
            {
                string sql = @"select Supplier.[AutoId],[CompanyName],[PinyinCode],[ContactName],[Area],[Address],[WebSite],[Tel],[Email],[TypeId],[Name] as TypeName,Supplier.[RankNum] 
from Supplier inner join SupplierType on Supplier.TypeId = SupplierType.AutoId
                                Where CompanyName like '%'+@KeyWord+'%'
                                OR PinyinCode like '%'+@KeyWord+'%'
Order by Supplier.[RankNum]";
                return conn.Query<TSupplier>(sql,new { KeyWord = keyWord}).ToList();
            }
        }
        public static List<TClient> GetClientByName(string keyWord)
        {
            using (var conn = new SqlConnection(conStr))
            {
                string sql = @"select Client.[AutoId],[CompanyName],[PinyinCode],[ContactName],[Area],[Address],[WebSite],[Tel],[Email],[TypeId],[Name] as TypeName,Client.[RankNum] 
from Client inner join ClientType on Client.TypeId = ClientType.AutoId
                                Where CompanyName like '%'+@KeyWord+'%'
                                OR PinyinCode like '%'+@KeyWord+'%'
Order by Client.[RankNum]";
                return conn.Query<TClient>(sql, new { KeyWord = keyWord }).ToList();
            }
        }
        public static List<TGoodsTemplate> GetGoodsTemplateByName(string keyWord)
        {
            using (var conn = new SqlConnection(conStr))
            {
                string sql = @"
select GoodsTemplate.[AutoId],GoodsTemplate.[Name],GoodsTemplate.[PinyinCode],[BarCode],[ImageName], 
GoodsType.[AutoId] as TId,GoodsType.[Name] as TName,
Supplier.[AutoId] as SId,Supplier.[CompanyName] as SName
from GoodsTemplate inner join GoodsType on GoodsTemplate.TId = GoodsType.AutoId
inner join Supplier on GoodsTemplate.SId = Supplier.AutoId  
Where [GoodsTemplate].Name like '%'+@KeyWord+'%'
OR [GoodsTemplate].PinyinCode like '%'+@KeyWord+'%'
OR [GoodsTemplate].BarCode like '%'+@KeyWord+'%'";
                return conn.Query<TGoodsTemplate>(sql, new { KeyWord = keyWord }).ToList();
            }
        }
        public static List<TGoods> GetGoodsByName(string keyWord)
        {
            using (var conn = new SqlConnection(conStr))
            {
                string sql = @"select Goods.[AutoId],Goods.[Name],Goods.[PinyinCode],[BarCode],[ImageName], 
[ProducedDate],[EffectiveTime],[InPrice],[OutPrice],
GoodsType.[AutoId] as TId,GoodsType.[Name] as TName,
Supplier.[AutoId] as SId,Supplier.[CompanyName] as SName,
Warehouse.[Id] as WId,Warehouse.[Name] as WName
from Goods(nolock) inner join GoodsType on Goods.TId = GoodsType.AutoId
inner join Supplier on Goods.SId = Supplier.AutoId
inner join Warehouse on Goods.WId = Warehouse.Id
Where [Goods].Name like '%'+@KeyWord+'%'
OR [Goods].PinyinCode like '%'+@KeyWord+'%'
OR [Goods].BarCode like '%'+@KeyWord+'%'";
                return conn.Query<TGoods>(sql, new { KeyWord = keyWord }).ToList();
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
        /// <summary>
        /// 查询数据库中是否有关联的类型ID,返回值为关联总数
        /// </summary>
        /// <param name="types">类型ID列表</param>
        /// <param name="dbName">数据库名</param>
        /// <returns></returns>
        public static int GetCountInfoByTypeId(List<int> types, string dbName,string colName= "TypeId")
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = $"SELECT COUNT(*) FROM {dbName}(nolock) WHERE [{colName}] IN @Types";
                    return conn.ExecuteScalar<int>(sql,new {Types = types });
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("GetDBCountInfoError.txt", info);
                return 1;
            }
        }
        public static int GetCountInfoByWId(List<string> ids, string dbName, string colName)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = $"SELECT COUNT(*) FROM {dbName}(nolock) WHERE [{colName}] IN @Ids";
                    return conn.ExecuteScalar<int>(sql, new { Ids = ids });
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("GetDBCountInfoError.txt", info);
                return 1;
            }
        }
    }
}
