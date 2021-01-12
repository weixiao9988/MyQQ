using System;
using System.Data;
using System.Data.SqlClient;

namespace MyQQ
{
    //数据库操作类
    class DataOperator
    {
        //数据库连接字符串
        private static string cnnStr = @"Data Source=WEIXIAO\MYSQLSERVER;Database=db_MyQQ;User ID=sa;Pwd=;";
        //private static string cnnStr = @"Data Source=(localdb)\MSSQLLocalDB;" +
        //    "Initial Catalog=db_MyQQ;" +
        //    "Integrated Security=True;" +
        //    "Connect Timeout=30;" +
        //    "Encrypt=False;" +
        //    "TrustServerCertificate=False;" +
        //    "ApplicationIntent=ReadWrite;" +
        //    "MultiSubnetFailover=False";
        //private static string cnnStr = "Persist Security Info=False;"
        //                                + "Integrated Security=SSPI;"
        //                                + "database=db_MyQQ;"
        //                                + "server=(local)";
        //数据库连接对象
        public static SqlConnection sqlCnn;// = new SqlConnection(cnnStr);

        /// <summary>
        /// 建立数据库连接.;
        /// </summary>
        /// <returns>返回SqlConnection对象</returns>
        public void OpenSqlCnn()
        {
            sqlCnn = new SqlConnection(cnnStr);
            sqlCnn.Open();            
        }

        ///<summary>
        ///执行SQL语句，并返回结果中的第一行第一列
        ///</summary>
        ///<param name="sql">要执行的SQL语句</param>
        ///<returns>结果中的第一行第一列</returns>
        public int ExecSQL(string sql)
        {
            if (sqlCnn == null || sqlCnn.State == ConnectionState.Closed)//如果当前数据连接处于关闭状态
                OpenSqlCnn();   //打开数据库连接
            SqlCommand command = new SqlCommand(sql, sqlCnn);//指定要执行的SQL语句            
            int num = Convert.ToInt32(command.ExecuteScalar());//执行查询
            CloseCnn();//关闭数据库连接
            return num;//返回结果中的第一行第一列
        }

        /// <summary>
        /// 执行SQL语句，并返回受影响的行数
        /// </summary>
        /// <param name="sql">要执行的SQL语句</param>
        /// <returns>受影响的行数</returns>
        public int ExecSQLResult(string sql)
        {
            if (sqlCnn == null || sqlCnn.State == ConnectionState.Closed)//如果当前数据连接处于关闭状态
                OpenSqlCnn();   //打开数据库连接
            SqlCommand command = new SqlCommand(sql, sqlCnn);//指定要执行的SQL语句            
            int result = command.ExecuteNonQuery();//执行SQL语句
            CloseCnn();//关闭数据库连接
            return result;//返回受影响的行数
        }

        ///<summary>
        ///执行SQL查询语句，并返回DataSet数据集
        ///</summary>
        ///<param name="sql">要执行的SQL语句</param>
        ///<returns>DataSet数据集，存储查询结果</returns>
        public DataSet GetDataSet(string sql)
        {
            if (sqlCnn == null || sqlCnn.State == ConnectionState.Closed)//如果当前数据连接处于关闭状态
                OpenSqlCnn();   //打开数据库连接
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlCnn);//指定要执行的SQL语句
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
            CloseCnn();  //关闭数据库连接
            OpenSqlCnn();//打开数据库连接
            SqlCommand command = new SqlCommand(sql, sqlCnn);//指定要执行的SQL语句            
            SqlDataReader datareader = command.ExecuteReader();//生成SqlDataReader
            return datareader;//返回SqlDataReader
        }

        /// <summary>
        /// 关闭数据库的连接.;
        /// </summary>
        public void CloseCnn()
        {
            if (sqlCnn.State == ConnectionState.Open)  //判断是否打开与数据库的连接;
            {
                sqlCnn.Close();  //关闭数据库的连接;
                sqlCnn.Dispose();    //释放myCon变量的所有空间;
            }
        }

    }
}
