﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dos.ORM;
using System.Data.SqlClient;
using System.Data.Common;


namespace IeidjtuKCB.DBSession
{   /// <summary>
    /// 数据库连接上下文
    /// </summary>
    public  class DataBase
    {
        public static DbSession Context = new DbSession(DatabaseType.SqlServer9, @"Data Source=125.222.144.16,1444;Database=Education;User Id=sa;Password=52Xuguoxu;");//笔记本
        public static DbSession Context1 = new DbSession(DatabaseType.SqlServer9, @"Data Source=DataServer;Database=Education;User Id=sa;Password=52Xuguoxu;");//服务器
        
        
        
        
        /// <summary>
        /// 执行带参数的SQL语句
        /// </summary>
        /// <param name="sql">要执行的SQL语句</param>
        /// <param name="parameters">参数</param>
        /// <returns>返回影响的数目</returns>
        public static int ExecutNoneQuery(string sql, IList<DbParameter> parameters)
        {
            DbCommand db = Context.Db.GetSqlStringCommand(sql);
            if (!(parameters == null || parameters.Count == 0))
            {
                foreach (DbParameter parameter in parameters)
                {
                    db.Parameters.Add(parameter);
                }
            }
           
            return Context.ExecuteNonQuery(db);
        }
    }
}
