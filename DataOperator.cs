using System;
using System.Data;
using System.Data.SqlClient;

namespace MyQQ
{
    //���ݿ������
    class DataOperator
    {
        //���ݿ������ַ���
        private static string connString = @"Data Source=WEIXIAO\MYSQLSERVER;Database=db_MyQQ;User ID=sa;Pwd=;";
        //���ݿ����Ӷ���
        public static SqlConnection connection = new SqlConnection(connString);

        ///<summary>
        ///ִ��SQL��䣬�����ؽ���еĵ�һ�е�һ��
        ///</summary>
        ///<param name="sql">Ҫִ�е�SQL���</param>
        ///<returns>����еĵ�һ�е�һ��</returns>
        public int ExecSQL(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);//ָ��Ҫִ�е�SQL���
            if (connection.State == ConnectionState.Closed)//�����ǰ�������Ӵ��ڹر�״̬
                connection.Open();  //�����ݿ�����
            int num = Convert.ToInt32(command.ExecuteScalar());//ִ�в�ѯ
            connection.Close();//�ر����ݿ�����
            return num;//���ؽ���еĵ�һ�е�һ��
        }

        /// <summary>
        /// ִ��SQL��䣬��������Ӱ�������
        /// </summary>
        /// <param name="sql">Ҫִ�е�SQL���</param>
        /// <returns>��Ӱ�������</returns>
        public int ExecSQLResult(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);//ָ��Ҫִ�е�SQL���
            if (connection.State == ConnectionState.Closed)//�����ǰ�������Ӵ��ڹر�״̬
                connection.Open();  //�����ݿ�����
            int result = command.ExecuteNonQuery();//ִ��SQL���
            connection.Close();//�ر����ݿ�����
            return result;//������Ӱ�������
        }

        ///<summary>
        ///ִ��SQL��ѯ��䣬������DataSet���ݼ�
        ///</summary>
        ///<param name="sql">Ҫִ�е�SQL���</param>
        ///<returns>DataSet���ݼ����洢��ѯ���</returns>
        public DataSet GetDataSet(string sql)
        {
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, connection);//ָ��Ҫִ�е�SQL���
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
            SqlCommand command = new SqlCommand(sql, connection);//ָ��Ҫִ�е�SQL���
            if (connection.State == ConnectionState.Open)//�����ǰ�������Ӵ��ڴ�״̬
                connection.Close();  //�ر����ݿ�����
            connection.Open();//�����ݿ�����
            SqlDataReader datareader = command.ExecuteReader();//����SqlDataReader
            return datareader;//����SqlDataReader
        }
    }
}
