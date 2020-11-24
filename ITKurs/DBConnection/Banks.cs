using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using ITKurs.DBConnection;

namespace ITKurs.DBConnection
{
    class Banks
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static List<Banks> getAll()
        {
            List<Banks> list = new List<Banks>();
            DBConn dbc = new DBConn();
            try
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                using (SqlConnection conn = new SqlConnection())
                {
                    dbc.OpenConn(sb, conn);
                    string str = @"SELECT * FROM Banks";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Banks Bank = new Banks();
                            Bank.ID = Convert.ToInt32(reader["ID"]);
                            Bank.Name = reader["Name"].ToString();
                            list.Add(Bank);
                        }
                    }
                    conn.Close();
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Ошибка соединения", "Ошибка!");
            }
            return list;
        }
        public static Banks getById(int id)
        {
            DBConn dbc = new DBConn();
            try
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                using (SqlConnection conn = new SqlConnection())
                {
                    dbc.OpenConn(sb, conn);
                    string str = @"SELECT * FROM Banks WHERE ID = @id";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        Banks dep = new Banks();
                        dep.ID = Convert.ToInt32(reader["ID"]);
                        dep.Name = reader["Name"].ToString();
                        return dep;
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Ошибка соединения", "Ошибка!");
            }
            return null;
        }
        public static Banks getByTitle (string s)
        {
            DBConn dbc = new DBConn();
            try
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                using (SqlConnection conn = new SqlConnection())
                {
                    dbc.OpenConn(sb, conn);
                    string str = @"SELECT * FROM Banks WHERE Name = @nm";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("nm", s);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        Banks dep = new Banks();
                        dep.ID = Convert.ToInt32(reader["ID"]);
                        dep.Name = reader["Name"].ToString();
                        return dep;
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Ошибка соединения", "Ошибка!");
            }
            return null;
        }
    }
}
