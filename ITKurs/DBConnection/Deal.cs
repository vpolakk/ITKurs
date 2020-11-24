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
    class Deal
    {
        public int ID { get; set; }
        public Client Client { get; set; }
        public Customer Customer { get; set; }
        public Banks Banks { get; set; }
        public DateTime DateOfDeal { get; set; }
        public double Summ { get; set; }
        public double Discount { get; set; }
        public double SummWithDiscount { get; set; }
        public double Profit { get; set; }
        public int IsPayed { get; set; }
        public static List<Deal> getAll()
        {
            List<Deal> list = new List<Deal>();
            DBConn dbc = new DBConn();
            try
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                using (SqlConnection conn = new SqlConnection())
                {
                    dbc.OpenConn(sb, conn);
                    string str = @"SELECT * FROM Deal";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Deal deal = new Deal();
                            deal.ID = Convert.ToInt32(reader["ID"]);
                            deal.Customer = Customer.getById(Convert.ToInt32(reader["IDCustomer"]));
                            deal.Client = Client.getById(Convert.ToInt32(reader["IDClient"]));
                            deal.Banks = Banks.getById(Convert.ToInt32(reader["IDBanks"]));
                            deal.DateOfDeal = Convert.ToDateTime(reader["DateOfDeal"]).Date;
                            deal.Summ = Convert.ToDouble(reader["Summ"]);
                            deal.Discount = Convert.ToDouble(reader["Discount"]);
                            deal.SummWithDiscount = Convert.ToDouble(reader["SummWithDiscount"]);
                            deal.Profit = Convert.ToDouble(reader["Profit"]);
                            deal.IsPayed = Convert.ToInt32(reader["Payed"]);
                            list.Add(deal);
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
        public static Deal getById(int id)
        {
            DBConn dbc = new DBConn();
            try
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                using (SqlConnection conn = new SqlConnection())
                {
                    dbc.OpenConn(sb, conn);
                    string str = @"SELECT * FROM Deal WHERE ID = @id";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        Deal dep = new Deal();
                        dep.ID = Convert.ToInt32(reader["ID"]);
                        dep.Customer = Customer.getById(Convert.ToInt32(reader["IDCustomer"]));
                        dep.Client = Client.getById(Convert.ToInt32(reader["IDClient"]));
                        dep.Banks = Banks.getById(Convert.ToInt32(reader["IDBanks"]));
                        dep.DateOfDeal = Convert.ToDateTime(reader["DateOfDeal"]).Date;
                        dep.Summ = Convert.ToDouble(reader["Summ"]);
                        dep.Discount = Convert.ToDouble(reader["Discount"]);
                        dep.SummWithDiscount = Convert.ToDouble(reader["SummWithDiscount"]);
                        dep.Profit = Convert.ToDouble(reader["Profit"]);
                        dep.IsPayed = Convert.ToInt32(reader["Payed"]);
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
        public static List<Deal> filterOnSummBigger(int sum)
        {
            List<Deal> list = new List<Deal>();
            DBConn dbc = new DBConn();
            try
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                using (SqlConnection conn = new SqlConnection())
                {
                    dbc.OpenConn(sb, conn);
                    string str = @"SELECT * FROM Deal WHERE Summ < @sum";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("sum", sum);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Deal deal = new Deal();
                            deal.ID = Convert.ToInt32(reader["ID"]);
                            deal.Customer = Customer.getById(Convert.ToInt32(reader["IDCustomer"]));
                            deal.Client = Client.getById(Convert.ToInt32(reader["IDClient"]));
                            deal.Banks = Banks.getById(Convert.ToInt32(reader["IDBanks"]));
                            deal.DateOfDeal = Convert.ToDateTime(reader["DateOfDeal"]).Date;
                            deal.Summ = Convert.ToDouble(reader["Summ"]);
                            deal.Discount = Convert.ToDouble(reader["Discount"]);
                            deal.SummWithDiscount = Convert.ToDouble(reader["SummWithDiscount"]);
                            deal.Profit = Convert.ToDouble(reader["Profit"]);
                            deal.IsPayed = Convert.ToInt32(reader["Payed"]);
                            list.Add(deal);
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
        public static List<Deal> filterOnSummSmaller(int sum)
        {
            List<Deal> list = new List<Deal>();
            DBConn dbc = new DBConn();
            try
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                using (SqlConnection conn = new SqlConnection())
                {
                    dbc.OpenConn(sb, conn);
                    string str = @"SELECT * FROM Deal WHERE Summ > @sum";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("sum", sum);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Deal deal = new Deal();
                            deal.ID = Convert.ToInt32(reader["ID"]);
                            deal.Customer = Customer.getById(Convert.ToInt32(reader["IDCustomer"]));
                            deal.Client = Client.getById(Convert.ToInt32(reader["IDClient"]));
                            deal.Banks = Banks.getById(Convert.ToInt32(reader["IDBanks"]));
                            deal.DateOfDeal = Convert.ToDateTime(reader["DateOfDeal"]).Date;
                            deal.Summ = Convert.ToDouble(reader["Summ"]);
                            deal.Discount = Convert.ToDouble(reader["Discount"]);
                            deal.SummWithDiscount = Convert.ToDouble(reader["SummWithDiscount"]);
                            deal.Profit = Convert.ToDouble(reader["Profit"]);
                            deal.IsPayed = Convert.ToInt32(reader["Payed"]);
                            list.Add(deal);
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
        public static List<Deal> filterOnSummEqual(int sum)
        {
            List<Deal> list = new List<Deal>();
            DBConn dbc = new DBConn();
            try
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                using (SqlConnection conn = new SqlConnection())
                {
                    dbc.OpenConn(sb, conn);
                    string str = @"SELECT * FROM Deal WHERE Summ = @sum";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("sum", sum);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Deal deal = new Deal();
                            deal.ID = Convert.ToInt32(reader["ID"]);
                            deal.Customer = Customer.getById(Convert.ToInt32(reader["IDCustomer"]));
                            deal.Client = Client.getById(Convert.ToInt32(reader["IDClient"]));
                            deal.Banks = Banks.getById(Convert.ToInt32(reader["IDBanks"]));
                            deal.DateOfDeal = Convert.ToDateTime(reader["DateOfDeal"]).Date;
                            deal.Summ = Convert.ToDouble(reader["Summ"]);
                            deal.Discount = Convert.ToDouble(reader["Discount"]);
                            deal.SummWithDiscount = Convert.ToDouble(reader["SummWithDiscount"]);
                            deal.Profit = Convert.ToDouble(reader["Profit"]);
                            deal.IsPayed = Convert.ToInt32(reader["Payed"]);
                            list.Add(deal);
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
        public static List<Deal> filterOnCustomer(int idCust)
        {
            List<Deal> list = new List<Deal>();
            DBConn dbc = new DBConn();
            try
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                using (SqlConnection conn = new SqlConnection())
                {
                    dbc.OpenConn(sb, conn);
                    string str = @"SELECT * FROM Deal WHERE IDCustomer = @sum";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("sum", idCust);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Deal deal = new Deal();
                            deal.ID = Convert.ToInt32(reader["ID"]);
                            deal.Customer = Customer.getById(Convert.ToInt32(reader["IDCustomer"]));
                            deal.Client = Client.getById(Convert.ToInt32(reader["IDClient"]));
                            deal.Banks = Banks.getById(Convert.ToInt32(reader["IDBanks"]));
                            deal.DateOfDeal = Convert.ToDateTime(reader["DateOfDeal"]).Date;
                            deal.Summ = Convert.ToDouble(reader["Summ"]);
                            deal.Discount = Convert.ToDouble(reader["Discount"]);
                            deal.SummWithDiscount = Convert.ToDouble(reader["SummWithDiscount"]);
                            deal.Profit = Convert.ToDouble(reader["Profit"]);
                            deal.IsPayed = Convert.ToInt32(reader["Payed"]);
                            list.Add(deal);
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
        public static List<Deal> filterOnClient(int idCli)
        {
            List<Deal> list = new List<Deal>();
            DBConn dbc = new DBConn();
            try
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                using (SqlConnection conn = new SqlConnection())
                {
                    dbc.OpenConn(sb, conn);
                    string str = @"SELECT * FROM Deal WHERE IDClient = @sum";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("sum", idCli);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Deal deal = new Deal();
                            deal.ID = Convert.ToInt32(reader["ID"]);
                            deal.Customer = Customer.getById(Convert.ToInt32(reader["IDCustomer"]));
                            deal.Client = Client.getById(Convert.ToInt32(reader["IDClient"]));
                            deal.Banks = Banks.getById(Convert.ToInt32(reader["IDBanks"]));
                            deal.DateOfDeal = Convert.ToDateTime(reader["DateOfDeal"]).Date;
                            deal.Summ = Convert.ToDouble(reader["Summ"]);
                            deal.Discount = Convert.ToDouble(reader["Discount"]);
                            deal.SummWithDiscount = Convert.ToDouble(reader["SummWithDiscount"]);
                            deal.Profit = Convert.ToDouble(reader["Profit"]);
                            deal.IsPayed = Convert.ToInt32(reader["Payed"]);
                            list.Add(deal);
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
                    string str = @"INSERT INTO Deal 
                        (IDCustomer, IDClient, IDBanks, DateOfDeal, Summ, Discount, SummWithDiscount, Profit, Payed) 
                        VALUES (@IDCus, @IDCli,@IDBan, @Dd, @Sm, @Dc, @Swd, @Pf,@Pd)";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("IDCus", Customer.ID);
                    cmd.Parameters.AddWithValue("IDCli", Client.ID);
                    cmd.Parameters.AddWithValue("IDBan", Banks.ID);
                    cmd.Parameters.AddWithValue("Dd", DateOfDeal);
                    cmd.Parameters.AddWithValue("Sm", Summ);
                    cmd.Parameters.AddWithValue("Dc", Discount);
                    cmd.Parameters.AddWithValue("Swd", SummWithDiscount);
                    cmd.Parameters.AddWithValue("Pf", Profit);
                    cmd.Parameters.AddWithValue("Pd", IsPayed);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Ошибка соединения", "Ошибка!");
            }
        }
        public static void insert(Deal deal)
        {
            deal.insert();
        }
        public static Deal insert(int idcl, int idcast, int idban, DateTime dt,double sum, double disc, double sumwdisc,double profit,int payed)
        {
            Deal dep = new Deal();
            dep.Client = Client.getById(idcl);
            dep.Customer = Customer.getById(idcast);
            dep.Banks = Banks.getById(idban);
            dep.DateOfDeal = dt;
            dep.Summ = sum;
            dep.Discount = disc;
            dep.SummWithDiscount = sumwdisc;
            dep.Profit = profit;
            dep.IsPayed = payed;
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
                    string str = @"UPDATE Deal SET 
                         DateOfDeal = @Dd, Discount = @Dc, Summ = @Sm, SummWithDiscount = @Swd, Profit = @Pf
                        WHERE ID = @nn";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("Dd", DateOfDeal);
                    cmd.Parameters.AddWithValue("Dc", Discount);
                    cmd.Parameters.AddWithValue("Swd", SummWithDiscount);
                    cmd.Parameters.AddWithValue("Sm", Summ);
                    cmd.Parameters.AddWithValue("Pf", Profit);
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
        public bool payCommited()
        {
            DBConn dbc = new DBConn();
            try
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                using (SqlConnection conn = new SqlConnection())
                {
                    dbc.OpenConn(sb, conn);
                    string str = @"UPDATE Deal SET 
                         Payed = @pd
                        WHERE ID = @nn";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("pd", IsPayed);
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
                        cmd.CommandText = @"SELECT COUNT(*) FROM Deal_Goods WHERE IDDeal = @id";
                        cmd.Parameters.Add(new SqlParameter("@id", ID));
                        int count = (int)cmd.ExecuteScalar();
                        cmd.CommandText = @"DELETE FROM Deal_Goods WHERE IDDeal = @id";
                        cmd.ExecuteNonQuery();
                        if (MessageBox.Show("Будет удалено записей о товарах в сделках: " + count.ToString() + ". Вы уверены?", "Информация", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                        {
                            cmd.CommandText = @"DELETE FROM Deal WHERE ID = @id";
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
