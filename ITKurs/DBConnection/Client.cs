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
    class Client
    {
        public int ID { get; set; }
        public string NameOrg { get; set; }
        public string Address { get; set; }
        public string ManagerFullName { get; set; }
        public DateTime ManagerBirthDate { get; set; }
        public static List<Client> getAll()
        {
            List<Client> list = new List<Client>();
            DBConn dbc = new DBConn();
            try
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                using (SqlConnection conn = new SqlConnection())
                {
                    dbc.OpenConn(sb, conn);
                    string str = @"SELECT * FROM Client";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Client client = new Client();
                            client.ID = Convert.ToInt32(reader["ID"]);
                            client.NameOrg = reader["Name"].ToString();
                            client.Address = reader["Address"].ToString();
                            client.ManagerFullName = reader["ManagerFullName"].ToString();
                            client.ManagerBirthDate = Convert.ToDateTime(reader["ManaherBirthDate"]).Date;
                            list.Add(client);
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
                    string str = @"INSERT INTO Client 
                        (Name, Address, ManagerFullName, ManaherBirthDate) 
                        VALUES (@Nm, @Ad, @Mn, @Mb)";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("Nm", NameOrg);
                    cmd.Parameters.AddWithValue("Ad", Address);
                    cmd.Parameters.AddWithValue("Mn", ManagerFullName);
                    cmd.Parameters.AddWithValue("Mb", ManagerBirthDate);                    
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Ошибка соединения", "Ошибка!");
            }
        }

        public static void insert(Client dep)
        {
            dep.insert();
        }

        public static Client insert(string name, string adres, string manager, DateTime dt)
        {
            Client dep = new Client();
            dep.NameOrg = name;
            dep.Address = adres;
            dep.ManagerFullName = manager;
            dep.ManagerBirthDate = dt;
            dep.insert();
            return dep;
        }

        public static Client getById(int id)
        {
            DBConn dbc = new DBConn();
            try
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                using (SqlConnection conn = new SqlConnection())
                {
                    dbc.OpenConn(sb, conn);
                    string str = @"SELECT * FROM Client WHERE ID = @id";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        Client dep = new Client();
                        dep.ID = Convert.ToInt32(reader["ID"]);
                        dep.NameOrg = reader["Name"].ToString();
                        dep.ManagerFullName = reader["ManagerFullName"].ToString();
                        dep.Address = reader["Address"].ToString();
                        dep.ManagerBirthDate = Convert.ToDateTime(reader["ManaherBirthDate"]).Date;
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
        public static Client getByTitle(string s)
        {
            DBConn dbc = new DBConn();
            try
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                using (SqlConnection conn = new SqlConnection())
                {
                    dbc.OpenConn(sb, conn);
                    string str = @"SELECT * FROM Client WHERE Name = @s";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("s", s);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        Client dep = new Client();
                        dep.ID = Convert.ToInt32(reader["ID"]);
                        dep.NameOrg = reader["Name"].ToString();
                        dep.ManagerFullName = reader["ManagerFullName"].ToString();
                        dep.Address = reader["Address"].ToString();
                        dep.ManagerBirthDate = Convert.ToDateTime(reader["ManaherBirthDate"]).Date;
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
                    string str = @"UPDATE Client SET 
                        Name = @Nm, Address = @Ad, ManagerFullName = @Mn, ManaherBirthDate = @Mb 
                        WHERE ID = @nn";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("Nm", NameOrg);
                    cmd.Parameters.AddWithValue("Ad", Address);
                    cmd.Parameters.AddWithValue("Mn", ManagerFullName);
                    cmd.Parameters.AddWithValue("Mb", ManagerBirthDate);
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
                        cmd.CommandText = @"SELECT COUNT(*) FROM Deal WHERE IDClient = @id";
                        cmd.Parameters.Add(new SqlParameter("@id", ID));
                        int count = (int)cmd.ExecuteScalar();
                        cmd.CommandText = @"DELETE FROM Deal WHERE IDClient = @id";
                        cmd.ExecuteNonQuery();
                        if (MessageBox.Show("Будет удалено сделок: " + count.ToString() + ". Вы уверены?", "Информация", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                        {
                            cmd.CommandText = @"DELETE FROM Client WHERE ID = @id";
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
