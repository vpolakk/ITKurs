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

namespace ITKurs.DBConnection
{
    class DBConn
    {
        public void OpenConn(SqlConnectionStringBuilder sb, SqlConnection conn)
        {
            try
            {
                sb.DataSource = "DESKTOP-H0VT83B";                                                     
                sb.InitialCatalog = "Kurs_IT";
                sb.IntegratedSecurity = true;
                conn.ConnectionString = sb.ConnectionString;
                conn.Open();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Соединение не установлено", "Ошибка!");
            }
        }
    }
}
