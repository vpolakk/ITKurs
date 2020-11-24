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
    class DealGoods
    {
        public int ID { get; set; }

        public Deal Deal { get; set; }

        public Good Good { get; set; }
        public int count { get; set; }
        public static List<DealGoods> getByDeal( int id)
        {
            List<DealGoods> list = new List<DealGoods>();
            DBConn dbc = new DBConn();
            try
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                using (SqlConnection conn = new SqlConnection())
                {
                    dbc.OpenConn(sb, conn);
                    string str = @"SELECT * FROM Deal_Goods WHERE IDDeal = @id";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DealGoods dealGoods = new DealGoods();
                            dealGoods.ID = Convert.ToInt32(reader["ID"]);
                            dealGoods.Deal = Deal.getById(Convert.ToInt32(reader["IDDeal"]));
                            dealGoods.Good = Good.getById(Convert.ToInt32(reader["IDGoods"]));
                            dealGoods.count = Convert.ToInt32(reader["Count"]);
                            list.Add(dealGoods);
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
        public static DealGoods getById(int id)
        {
            DBConn dbc = new DBConn();
            try
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                using (SqlConnection conn = new SqlConnection())
                {
                    dbc.OpenConn(sb, conn);
                    string str = @"SELECT * FROM Deal_Goods WHERE ID = @id";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        DealGoods dealGoods = new DealGoods();
                        dealGoods.ID = Convert.ToInt32(reader["ID"]);
                        dealGoods.Deal = Deal.getById(Convert.ToInt32(reader["IDDeal"]));
                        dealGoods.Good = Good.getById(Convert.ToInt32(reader["IDGoods"]));
                        dealGoods.count = Convert.ToInt32(reader["Count"]);
                        return dealGoods;
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Ошибка соединения", "Ошибка!");
            }
            return null;
        }
        public static List<DealGoods> getByGood(int id)
        {
            List<DealGoods> list = new List<DealGoods>();
            DBConn dbc = new DBConn();
            try
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                using (SqlConnection conn = new SqlConnection())
                {
                    dbc.OpenConn(sb, conn);
                    string str = @"SELECT * FROM Deal_Goods WHERE IDGoods = @id";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DealGoods dealGoods = new DealGoods();
                            dealGoods.ID = Convert.ToInt32(reader["ID"]);
                            dealGoods.Deal = Deal.getById(Convert.ToInt32(reader["IDDeal"]));
                            dealGoods.Good = Good.getById(Convert.ToInt32(reader["IDGoods"]));
                            dealGoods.count = Convert.ToInt32(reader["Count"]);
                            list.Add(dealGoods);
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
        public void insert()
        {
            DBConn dbc = new DBConn();
            try
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                using (SqlConnection conn = new SqlConnection())
                {
                    dbc.OpenConn(sb, conn);
                    string str = @"INSERT INTO Deal_Goods 
                        (IDDeal, IDGoods, Count) 
                        VALUES (@Id, @Ig, @Co)";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("Id", Deal.ID);
                    cmd.Parameters.AddWithValue("Ig", Good.ID);
                    cmd.Parameters.AddWithValue("Co", count);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Ошибка соединения", "Ошибка!");
            }
        }
        public static void insert(DealGoods dep)
        {
            dep.insert();
        }
        public static DealGoods insert(int IDDeal,int IDGoods, int Count)
        {
            DealGoods dep = new DealGoods();
            dep.Deal = Deal.getById(IDDeal);
            dep.Good = Good.getById(IDGoods);
            dep.count = Count;
            dep.insert();
            return dep;
        }
        public bool update()
        {
            DBConn dbc = new DBConn();
            try
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                using (SqlConnection conn = new SqlConnection())
                {
                    dbc.OpenConn(sb, conn);
                    string str = @"UPDATE Deal_Goods SET 
                         Count = @Co
                        WHERE ID = @nn";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("Co", count);
                    cmd.Parameters.AddWithValue("nn", ID);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Ошибка соединения", "Ошибка!");
                return false;
            }
        }
        public bool delete()
        {
            DBConn dbc = new DBConn();
            try
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                using (SqlConnection conn = new SqlConnection())
                {
                    

                    dbc.OpenConn(sb, conn);
                    string str = @"DELETE FROM Deal_Goods WHERE ID = @tit";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("tit", ID);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Ошибка соединения", "Ошибка!");
                return false;
            }
        }
    }
}
