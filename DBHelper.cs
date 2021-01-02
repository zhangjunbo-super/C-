using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace test7
{
    class DBHelper
    {
        private MySqlConnection conn;
        public DBHelper(String connetStr)
        {
            conn = new MySqlConnection(connetStr);
            conn.Open();
            Console.WriteLine("====数据库连接成功====");
        }
        ~DBHelper()
        {
            conn.Close();
            Console.WriteLine("====数据库连接关闭====");
        }
        public DataTable Select(String sql)
        {
            DataSet ds = new DataSet();
            DataTable dt;
            MySqlCommand comm = new MySqlCommand(sql,conn);
            MySqlDataAdapter msda = new MySqlDataAdapter(comm);
            msda.Fill(ds, "sheet");
            dt = ds.Tables["sheet"];
            return dt;
        }

        public int Update(String sql)
        {
            MySqlCommand comm = new MySqlCommand(sql, conn);
            try
            {
                int rs = comm.ExecuteNonQuery();
                Console.WriteLine("---------------"+rs);
                return rs;
            }
            catch (Exception e)
            {
                Console.WriteLine("主键重复");
            } 
            return 0;
        }
        public int  Delete(String sql)
        {
            MySqlCommand comm = new MySqlCommand(sql, conn);
            try
            {
                int rs = comm.ExecuteNonQuery();
                return rs;
            }catch(Exception e)
            {
                Console.WriteLine("主键重复");
            }
            return 0;
        }
        public int Insert(String sql)
        {
            MySqlCommand comm = new MySqlCommand(sql, conn);
            try
            {

                int rs=comm.ExecuteNonQuery();
                return rs;
            }
              catch (Exception e)
            {
                Console.WriteLine("主键重复");
            }
            return 0;
        }
    }
}
