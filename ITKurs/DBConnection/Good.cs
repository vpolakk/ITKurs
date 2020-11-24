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
    class Good
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int BuyPrice { get; set; }
        public int SellPrice { get; set; }
        public int OnStorage { get; set; }
        public static List<Good> getAll()
        {
            List<Good> list = new List<Good>();
            DBConn dbc = new DBConn();
            try
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                using (SqlConnection conn = new SqlConnection())
                {
                    dbc.OpenConn(sb, conn);
                    string str = @"SELECT * FROM Goods";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Good Good = new Good();
                            Good.ID = Convert.ToInt32(reader["ID"]);
                            Good.Name = reader["Name"].ToString();
                            Good.SellPrice = Convert.ToInt32(reader["SellPrice"]);
                            Good.BuyPrice = Convert.ToInt32(reader["BuyPrice"]);
                            Good.OnStorage = Convert.ToInt32(reader["OnStorage"]);
                            list.Add(Good);
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
                    string str = @"INSERT INTO Goods 
                        (Name, BuyPrice, SellPrice, OnStorage) 
                        VALUES (@Nm, @Bp, @Sp, @Os)";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("Nm", Name);
                    cmd.Parameters.AddWithValue("Bp", BuyPrice);
                    cmd.Parameters.AddWithValue("Sp", SellPrice);
                    cmd.Parameters.AddWithValue("Os", OnStorage);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Ошибка соединения", "Ошибка!");
            }
        }

        public static void insert(Good dep)
        {
            dep.insert();
        }

        public static Good insert(string name, int buy, int sell, int storage)
        {
            Good dep = new Good();
            dep.Name = name;
            dep.BuyPrice = buy;
            dep.SellPrice = sell;
            dep.OnStorage = storage;
            dep.insert();
            return dep;
        }
        public static Good getById(int id)
        {
            DBConn dbc = new DBConn();
            try
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                using (SqlConnection conn = new SqlConnection())
                {
                    dbc.OpenConn(sb, conn);
                    string str = @"SELECT * FROM Goods WHERE ID = @id";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        Good dep = new Good();
                        dep.ID = Convert.ToInt32(reader["ID"]);
                        dep.Name = reader["Name"].ToString();
                        dep.BuyPrice = Convert.ToInt32(reader["BuyPrice"]);
                        dep.SellPrice = Convert.ToInt32(reader["SellPrice"]);
                        dep.OnStorage = Convert.ToInt32(reader["OnStorage"]);
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
        public static Good getByTitle(string s)
        {
            DBConn dbc = new DBConn();
            try
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                using (SqlConnection conn = new SqlConnection())
                {
                    dbc.OpenConn(sb, conn);
                    string str = @"SELECT * FROM Goods WHERE Name = @s";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("s", s);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        Good dep = new Good();
                        dep.ID = Convert.ToInt32(reader["ID"]);
                        dep.Name = reader["Name"].ToString();
                        dep.BuyPrice = Convert.ToInt32(reader["BuyPrice"]);
                        dep.SellPrice = Convert.ToInt32(reader["SellPrice"]);
                        dep.OnStorage = Convert.ToInt32(reader["OnStorage"]);
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
        public bool update()
        {
            DBConn dbc = new DBConn();
            try
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                using (SqlConnection conn = new SqlConnection())
                {
                    dbc.OpenConn(sb, conn);
                    string str = @"UPDATE Goods SET 
                        Name = @Nm, BuyPrice = @Bp, SellPrice = @Sp, OnStorage = @Os 
                        WHERE ID = @nn";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("Nm", Name);
                    cmd.Parameters.AddWithValue("Bp", BuyPrice);
                    cmd.Parameters.AddWithValue("Sp", SellPrice);
                    cmd.Parameters.AddWithValue("Os", OnStorage);
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
            bool flag = false;
            try
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                using (SqlConnection conn = new SqlConnection())
                {
                    SqlCommand cmd = new SqlCommand();
                    dbc.OpenConn(sb, conn);
                    SqlTransaction trap = conn.BeginTransaction();
                    try
                    {
                        cmd.Transaction = trap;
                        cmd.Connection = conn;
                        cmd.CommandText = @"SELECT COUNT(*) FROM Deal_Goods WHERE IDGoods = @id";
                        cmd.Parameters.Add(new SqlParameter("@id", ID));
                        int count = (int)cmd.ExecuteScalar();
                        cmd.CommandText = @"DELETE FROM Deal_Goods WHERE IDGoods = @id";
                        cmd.ExecuteNonQuery();
                        if (MessageBox.Show("Будет удалено записей о товарах в сделках: " + count.ToString() + ". Вы уверены?", "Информация", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                        {
                            cmd.CommandText = @"DELETE FROM Goods WHERE ID = @id";
                            cmd.ExecuteNonQuery();
                            flag = true;
                            trap.Commit();
                        }
                        else
                        {
                            trap.Rollback();
                        }
                    }
                    catch (Exception ex)
                    {
                        trap.Rollback();
                        throw ex;
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Ошибка соединения", "Ошибка!");
            }
            return flag;
        }
    }
}
