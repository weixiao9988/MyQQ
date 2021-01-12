using System;
using System.Data;
using System.Data.SqlClient;

namespace MyQQ
{
    //���ݿ������
    class DataOperator
    {
        //���ݿ������ַ���
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
        //���ݿ����Ӷ���
        public static SqlConnection sqlCnn;// = new SqlConnection(cnnStr);

        /// <summary>
        /// �������ݿ�����.;
        /// </summary>
        /// <returns>����SqlConnection����</returns>
        public void OpenSqlCnn()
        {
            sqlCnn = new SqlConnection(cnnStr);
            sqlCnn.Open();            
        }

        ///<summary>
        ///ִ��SQL��䣬�����ؽ���еĵ�һ�е�һ��
        ///</summary>
        ///<param name="sql">Ҫִ�е�SQL���</param>
        ///<returns>����еĵ�һ�е�һ��</returns>
        public int ExecSQL(string sql)
        {
            if (sqlCnn == null || sqlCnn.State == ConnectionState.Closed)//�����ǰ�������Ӵ��ڹر�״̬
                OpenSqlCnn();   //�����ݿ�����
            SqlCommand command = new SqlCommand(sql, sqlCnn);//ָ��Ҫִ�е�SQL���            
            int num = Convert.ToInt32(command.ExecuteScalar());//ִ�в�ѯ
            CloseCnn();//�ر����ݿ�����
            return num;//���ؽ���еĵ�һ�е�һ��
        }

        /// <summary>
        /// ִ��SQL��䣬��������Ӱ�������
        /// </summary>
        /// <param name="sql">Ҫִ�е�SQL���</param>
        /// <returns>��Ӱ�������</returns>
        public int ExecSQLResult(string sql)
        {
            if (sqlCnn == null || sqlCnn.State == ConnectionState.Closed)//�����ǰ�������Ӵ��ڹر�״̬
                OpenSqlCnn();   //�����ݿ�����
            SqlCommand command = new SqlCommand(sql, sqlCnn);//ָ��Ҫִ�е�SQL���            
            int result = command.ExecuteNonQuery();//ִ��SQL���
            CloseCnn();//�ر����ݿ�����
            return result;//������Ӱ�������
        }

        ///<summary>
        ///ִ��SQL��ѯ��䣬������DataSet���ݼ�
        ///</summary>
        ///<param name="sql">Ҫִ�е�SQL���</param>
        ///<returns>DataSet���ݼ����洢��ѯ���</returns>
        public DataSet GetDataSet(string sql)
        {
            if (sqlCnn == null || sqlCnn.State == ConnectionState.Closed)//�����ǰ�������Ӵ��ڹر�״̬
                OpenSqlCnn();   //�����ݿ�����
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlCnn);//ָ��Ҫִ�е�SQL���
            DataSet ds = new DataSet();//�������ݼ�����
            sqlda.Fill(ds);//������ݼ�
            return ds;//�������ݼ�
        }

        /// <summary>
        /// ִ��SQL��ѯ��������SqlDataReader
        /// </summary>
        /// <param name="sql">Ҫִ�е�SQL���</param>
        /// <returns>SqlDataReader���ݼ�</returns>
        public SqlDataReader GetDataReader(string sql)
        {
            CloseCnn();  //�ر����ݿ�����
            OpenSqlCnn();//�����ݿ�����
            SqlCommand command = new SqlCommand(sql, sqlCnn);//ָ��Ҫִ�е�SQL���            
            SqlDataReader datareader = command.ExecuteReader();//����SqlDataReader
            return datareader;//����SqlDataReader
        }

        /// <summary>
        /// �ر����ݿ������.;
        /// </summary>
        public void CloseCnn()
        {
            if (sqlCnn.State == ConnectionState.Open)  //�ж��Ƿ�������ݿ������;
            {
                sqlCnn.Close();  //�ر����ݿ������;
                sqlCnn.Dispose();    //�ͷ�myCon���������пռ�;
            }
        }

    }
}
