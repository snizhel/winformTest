using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayer_DAL
{
    public class GeneralDAO
    {

        public string connectionString = "Data source =.; user id = sa; " + "password=1; initial catalog =COMPANY_PTPMUD";
        SqlConnection con = null;

        public DataSet getAll(string tblName)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from " + tblName, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public DataSet search(string tblName, string whereSql)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from " + tblName + " Where  " + whereSql, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public SqlConnection getConnection()
        {
            if (con == null)
                con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }

        public void closeConnection()
        {
            if (con != null)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con = null;

            }

        }
        public void closeConnection(SqlConnection con)
        {
            if (con != null)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con = null;

            }

        }
        public SqlDataReader findById(string tblName, string where_primarykey_id)
        {
            string sql = "select * from " + tblName + " Where  " + where_primarykey_id;
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;

        }

        public int insert_update_delete(string sql)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            int result = cmd.ExecuteNonQuery();
            closeConnection(con);
            return result;

        }
        public SqlDataReader dropList(string tblName)
        {
            string sql = "select * from " + tblName;
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;

        }
    }
}
