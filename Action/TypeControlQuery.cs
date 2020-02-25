using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 仓库管理系统.Template;
using System.Data.SqlClient;
using Dapper;

namespace 仓库管理系统
{
    class TypeControlQuery
    {
        public static string conStr = ConfigurationManager.ConnectionStrings["WMSDBconStr"].ConnectionString;

        public static List<TSupplierType> GetSupplierTypes()
        {
            using(var conn = new SqlConnection(conStr))
            {
                string sql = "SELECT [AutoId],[Name],[RankNum] FROM SupplierType(nolock) ORDER BY [RankNum]";
                return conn.Query<TSupplierType>(sql).ToList();
            }
        }

        public static TSupplierType GetSupplierTypesById(string id)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = $@"SELECT [AutoId],[Name],[RankNum] 
                    FROM SupplierType(nolock) 
                    WHERE AutoId = @Id";
                    return conn.Query<TSupplierType>(sql,new {Id = id }).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("SelectSupplierTypesInfoError.txt", info);
                return null;
            }
        }

        public static TSupplierType GetSupplierTypesByName(string name)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = $@"SELECT [AutoId],[Name],[RankNum] 
                    FROM SupplierType(nolock) 
                    WHERE Name = @Name";
                    return conn.Query<TSupplierType>(sql,new { Name = name}).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("SelectSupplierTypesInfoError.txt", info);
                return null;
            }
        }

        public static int DeleteSupplierTypeInfo(List<TSupplierType> supplierTypes)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = $"delete from SupplierType Where AutoId=@AutoId";
                    return conn.Execute(sql, supplierTypes);
                }
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("DeleteSupplierTypesInfoError.txt", info);
                return 0;
            }
        }
        

        public static bool InserSupplierTypeInfo(TSupplierType supplierType)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = $"Insert into SupplierType (Name,RankNum) values(@Name,@RankNum)";
                    conn.Execute(sql, supplierType);
                }
                return true;
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("InsertSupplierTypesInfoError.txt", info);
                return false;
            }
        }

        public static int TypeNameCheck(string typeName,string DBName,int autoId)
        {
            using (var conn = new SqlConnection(conStr))
            {
                string sql = $"select count(*) from {DBName}(nolock) Where Name=@TypeName";
                if (autoId > 0)
                {
                    sql += $" And AutoId!={autoId}";
                }
                return conn.ExecuteScalar<int>(sql, new { TypeName = typeName });
            }
        }

        public static bool UpdateSupplierTypeInfo(TSupplierType supplierType)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = $"UPDATE SupplierType SET Name = @Name,RankNum=@RankNum WHERE AutoId = @AutoId;";
                    conn.Execute(sql, supplierType);
                }
                return true;
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("AlterSupplierTypesInfoError.txt", info);
                return false;
            }
        }

        public static bool UpdateSupplierTypesInfo(List<TSupplierType> supplierTypes)
        {
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    string sql = $"UPDATE SupplierType SET Name = @Name,RankNum=@RankNum WHERE AutoId = @AutoId;";
                    conn.Execute(sql, supplierTypes);
                }
                return true;
            }
            catch (Exception ex)
            {
                String info = $"异常:{ex}";
                IOStream.WriteErrorLog("AlterSupplierTypesInfoError.txt", info);
                return false;
            }
        }
    }
}
