using System;
using System.Data;
using System.Data.SqlClient;

namespace MyQQ
{
    //数据库操作类
    class DataOperator
    {
        //数据库连接字符串
        private static string connString = @"Data Source=WEIXIAO\MYSQLSERVER;Database=db_MyQQ;User ID=sa;Pwd=;";
        //数据库连接对象
        public static SqlConnection connection = new SqlConnection(connString);

        ///<summary>
        ///执行SQL语句，并返回结果中的第一行第一列
        ///</summary>
        ///<param name="sql">要执行的SQL语句</param>
        ///<returns>结果中的第一行第一列</returns>
        public int ExecSQL(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);//指定要执行的SQL语句
            if (connection.State == ConnectionState.Closed)//如果当前数据连接处于关闭状态
                connection.Open();  //打开数据库连接
            int num = Convert.ToInt32(command.ExecuteScalar());//执行查询
            connection.Close();//关闭数据库连接
            return num;//返回结果中的第一行第一列
        }

        /// <summary>
        /// 执行SQL语句，并返回受影响的行数
        /// </summary>
        /// <param name="sql">要执行的SQL语句</param>
        /// <returns>受影响的行数</returns>
        public int ExecSQLResult(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);//指定要执行的SQL语句
            if (connection.State == ConnectionState.Closed)//如果当前数据连接处于关闭状态
                connection.Open();  //打开数据库连接
            int result = command.ExecuteNonQuery();//执行SQL语句
            connection.Close();//关闭数据库连接
            return result;//返回受影响的行数
        }

        ///<summary>
        ///执行SQL查询语句，并返回DataSet数据集
        ///</summary>
        ///<param name="sql">要执行的SQL语句</param>
        ///<returns>DataSet数据集，存储查询结果</returns>
        public DataSet GetDataSet(string sql)
        {
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, connection);//指定要执行的SQL语句
            DataSet ds = new DataSet();//创建数据集对象
            sqlda.Fill(ds);//填充数据集
            return ds;//返回数据集
        }

        /// <summary>
        /// 执行SQL查询，并返回SqlDataReader
        /// </summary>
        /// <param name="sql">要执行的SQL语句</param>
        /// <returns>SqlDataReader数据集</returns>
        public SqlDataReader GetDataReader(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);//指定要执行的SQL语句
            if (connection.State == ConnectionState.Open)//如果当前数据连接处于打开状态
                connection.Close();  //关闭数据库连接
            connection.Open();//打开数据库连接
            SqlDataReader datareader = command.ExecuteReader();//生成SqlDataReader
            return datareader;//返回SqlDataReader
        }
    }
}
