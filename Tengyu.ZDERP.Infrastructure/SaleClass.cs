using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Tengyu.ZDERP.Data;
using Tengyu.ZDERP.Data.Enum;

namespace Tengyu.ZDERP.Infrastructure
{
    public class SaleClass
    {
        private string Connection = "Data Source=.;Initial Catalog=Tengyu.ZDERP;Integrated Security=True;MultipleActiveResultSets=True";
        public bool AddSale(SalesOrder model)
        {
            using (IDbConnection conn = new SqlConnection(Connection))
            {
                var sql = @"INSERT INTO [dbo].[SalesOrder]
                                   ([CustomerId]
                                   ,[OrderTypeId]
                                   ,[OrderNumber]
                                   ,[OrderFileName]
                                   ,[ServerFileName]
                                   ,[ConfirmId]
                                   ,[ConfirmStatus]
                                   ,[CreatedTime]
                                   ,[CreatedId]
                                   ,[UpdateTime]
                                   ,[UpdateId]
                                   ,[Remark]
                                   ,[Recycled])
                             VALUES
                                   (@CustomerId
                                   ,@OrderTypeId
                                   ,@OrderNumber
                                   ,@OrderFileName
                                   ,@ServerFileName
                                   ,@ConfirmId
                                   ,@ConfirmStatus
                                   ,@CreatedTime
                                   ,@CreatedId
                                   ,@UpdateTime
                                   ,@UpdateId
                                   ,@Remark
                                   ,@Recycled)";

                var result = conn.Execute(sql, model);

                return result == 1 ? true : false;
            }
        }
        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="user"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool SubmitSale(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Connection))
            {
                var sql = string.Format(@"UPDATE [dbo].[SalesOrder]
                                SET  [ConfirmStatus] = {0}
                                WHERE Id = @Id AND [ConfirmStatus] = {1} || [ConfirmStatus] = {2}  AND Recycled = 0", ConfirmStatus.待审核, ConfirmStatus.保存, ConfirmStatus.已驳回);

                var ret = conn.Execute(sql, new{ Id = Id });
                return ret == 1 ? true : false;
            }
        }
        /// <summary>
        /// 撤回
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool WithDrawSale(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Connection))
            {
                var sql = string.Format(@"UPDATE [dbo].[SalesOrder]
                                SET  [ConfirmStatus] = {0}
                                WHERE Id = @Id AND [ConfirmStatus] = {1} AND Recycled = 0", ConfirmStatus.保存, ConfirmStatus.待审核);

                var ret = conn.Execute(sql, new { Id = Id });
                return ret == 1 ? true : false;
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool RecycledSale(int Id)
        {
            using (IDbConnection conn = new SqlConnection(Connection))
            {
                var sql = string.Format(@"UPDATE [dbo].[SalesOrder]
                                SET  [ConfirmStatus] = {0}
                                WHERE Id = @Id AND [ConfirmStatus] = {1} AND Recycled = 0");
            }
        }
    }
}
