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
    class InfoDeal
    {
        public Deal Deal { get; set; }
        public DealGoods DealGoods { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public int SellPrice { get; set; }
        public float Summ { get; set; }
        public static List<InfoDeal> getAll(int id)
        {
            List<InfoDeal> list = new List<InfoDeal>();
            DBConn dbc = new DBConn();
            try
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                using (SqlConnection conn = new SqlConnection())
                {
                    dbc.OpenConn(sb, conn);
                    string str = @"SELECT * FROM InfoDeal WHERE ID = @id";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            InfoDeal info = new InfoDeal();
                            info.Deal = Deal.getById(Convert.ToInt32(reader["ID"]));
                            info.DealGoods = DealGoods.getById(Convert.ToInt32(reader["DGID"]));
                            info.Name = reader["Name"].ToString();
                            info.SellPrice = Convert.ToInt32(reader["SellPrice"]);
                            info.Count = Convert.ToInt32(reader["Count"]);
                            info.Summ = Convert.ToInt32(reader["Summ"]);
                            list.Add(info);
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
    }
}
