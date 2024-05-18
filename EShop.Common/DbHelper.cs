using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using SqlConnection = Microsoft.Data.SqlClient.SqlConnection;

namespace EShop.Common
{
    public static class DbHelper
    {
        public static SqlConnection GetSqlConnection()
        {
            SqlConnection sqlConnection = null;
            string connectionString = "Data Source=LAPTOP-GS7QPAK3\\SQLEXPRESS;Initial Catalog=QuanLyKho";
            sqlConnection = new SqlConnection(connectionString);
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            return sqlConnection;
        }

    }
}