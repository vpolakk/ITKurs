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
    class Customer
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PassportData { get; set; }
        public DateTime HireDate { get; set; }
        public static List<Customer> getAll()
        {
            List<Customer> list = new List<Customer>();
            DBConn dbc = new DBConn();
            try
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                using (SqlConnection conn = new SqlConnection())
                {
                    dbc.OpenConn(sb, conn);
                    string str = @"SELECT * FROM Customer";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Customer customer = new Customer();
                            customer.ID = Convert.ToInt32(reader["ID"]);
                            customer.FullName = reader["FullName"].ToString();
                            customer.BirthDate = Convert.ToDateTime(reader["BirthDate"]);
                            customer.HireDate = Convert.ToDateTime(reader["HireDate"]);
                            customer.PassportData = reader["PassportData"].ToString();
                            list.Add(customer);
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
                    string str = @"INSERT INTO Customer
                        (FullName, BirthDate, PassportData, HireDate) 
                        VALUES (@Nm, @Bd, @Pd, @Hd)";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("Nm", FullName);
                    cmd.Parameters.AddWithValue("Bd", BirthDate);
                    cmd.Parameters.AddWithValue("Pd", PassportData);
                    cmd.Parameters.AddWithValue("Hd", HireDate);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Ошибка соединения", "Ошибка!");
            }
        }
        public static void insert(Customer dep)
        {
            dep.insert();
        }

        public static Customer insert(string name, DateTime bt, string passport, DateTime hd)
        {
            Customer dep = new Customer();
            dep.FullName = name;
            dep.BirthDate = bt;
            dep.PassportData = passport;
            dep.HireDate = hd;
            dep.insert();
            return dep;
        }
        public static Customer getById(int id)
        {
            DBConn dbc = new DBConn();
            try
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                using (SqlConnection conn = new SqlConnection())
                {
                    dbc.OpenConn(sb, conn);
                    string str = @"SELECT * FROM Customer WHERE ID = @id";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        Customer dep = new Customer();
                        dep.ID = Convert.ToInt32(reader["ID"]);
                        dep.FullName = reader["FullName"].ToString();
                        dep.BirthDate = Convert.ToDateTime(reader["BirthDate"]).Date;
                        dep.PassportData = reader["PassportData"].ToString();
                        dep.HireDate = Convert.ToDateTime(reader["HireDate"]).Date;
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
        public static Customer getByTitle(string s)
        {
            DBConn dbc = new DBConn();
            try
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                using (SqlConnection conn = new SqlConnection())
                {
                    dbc.OpenConn(sb, conn);
                    string str = @"SELECT * FROM Customer WHERE FullName = @s";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("s", s);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        Customer dep = new Customer();
                        dep.ID = Convert.ToInt32(reader["ID"]);
                        dep.FullName = reader["FullName"].ToString();
                        dep.BirthDate = Convert.ToDateTime(reader["BirthDate"]).Date;
                        dep.PassportData = reader["PassportData"].ToString();
                        dep.HireDate = Convert.ToDateTime(reader["HireDate"]).Date;
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
                    string str = @"UPDATE Customer SET FullName = @Nm, BirthDate = @Bd, PassportData = @Pd, HireDate = @Hd WHERE ID = @nn";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("Nm", FullName);
                    cmd.Parameters.AddWithValue("Bd", BirthDate);
                    cmd.Parameters.AddWithValue("Pd", PassportData);
                    cmd.Parameters.AddWithValue("Hd", HireDate);
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
                        cmd.CommandText = @"SELECT COUNT(*) FROM Deal WHERE IDCustomer = @id";
                        cmd.Parameters.Add(new SqlParameter("@id", ID));
                        int count = (int)cmd.ExecuteScalar();
                        cmd.CommandText = @"DELETE FROM Deal WHERE IDCustomer = @id";
                        cmd.ExecuteNonQuery();
                        if (MessageBox.Show("Будет удалено сделок: " + count.ToString() + ". Вы уверены?", "Информация", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                        {
                            cmd.CommandText = @"DELETE FROM Customer WHERE ID = @id";
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
