using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITKurs.DBConnection;

namespace ITKurs
{
    public partial class DataBaseForm : Form
    {

        int idClient = -1;
        int idCustomer = -1;
        int idGood = -1;
        int idDeal = -1;
        int idDealGoods = -1;
        int permissions = -1;
        public DataBaseForm(int permissions)
        {
            InitializeComponent();
            this.permissions=permissions;
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
       {
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form ifrm = Application.OpenForms[0];
            ifrm.Close(); // отображаем Form1
        }

        private void Form2_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form ifrm = Application.OpenForms[0];
            //ifrm.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            //ifrm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            //ifrm.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            ifrm.Close(); // отображаем Form1
        }
        
        private void DataBaseForm_Load(object sender, EventArgs e)
        {
            tabClientShow();
            tabCustomerShow();
            tabGoodsShow();
            tabDealShow();
            switch (permissions)
             {
                case 1:
                    {
                        Deal_buttonAdd.Enabled = true;
                        Deal_buttonDelete.Enabled = true;
                        Deal_buttonEdit.Enabled = true;
                        Deal_Goods_ButtonAdd.Enabled = true;
                        Deal_Goods_ButtonDelete.Enabled = true;
                        client_buttonAdd.Enabled = true;
                        client_buttonDelete.Enabled = true;
                        client_buttonEdit.Enabled = true;
                        customer_ButtonAdd.Enabled = true;
                        customer_buttonDelete.Enabled = true;
                        customer_ButtonEdit.Enabled = true;
                        goods_ButtonAdd.Enabled = true;
                        goods_ButtonDelete.Enabled = true;
                        goods_ButtonEdit.Enabled = true;
                        Deal_buttonPay.Enabled = true;
                    }
                    break;
                case 2:
                    {
                        Deal_buttonAdd.Enabled = true;
                        Deal_buttonDelete.Enabled = true;
                        Deal_buttonEdit.Enabled = true;
                        Deal_Goods_ButtonAdd.Enabled = true;
                        Deal_Goods_ButtonDelete.Enabled = true;
                        client_buttonAdd.Enabled = true;
                        client_buttonDelete.Enabled = false;
                        client_buttonEdit.Enabled = true;
                        customer_ButtonAdd.Enabled = false;
                        customer_buttonDelete.Enabled = false;
                        customer_ButtonEdit.Enabled = false;
                        goods_ButtonAdd.Enabled = false;
                        goods_ButtonDelete.Enabled = false;
                        goods_ButtonEdit.Enabled = false;
                        Deal_buttonPay.Enabled = false;
                    }
                    break;
                case 3:
                    {
                        Deal_buttonAdd.Enabled = false;
                        Deal_buttonDelete.Enabled = false;
                        Deal_buttonEdit.Enabled = false;
                        Deal_Goods_ButtonAdd.Enabled = false;
                        Deal_Goods_ButtonDelete.Enabled = false;
                        client_buttonAdd.Enabled = false;
                        client_buttonDelete.Enabled = false;
                        client_buttonEdit.Enabled = false;
                        customer_ButtonAdd.Enabled = false;
                        customer_buttonDelete.Enabled = false;
                        customer_ButtonEdit.Enabled = false;
                        goods_ButtonAdd.Enabled = false;
                        goods_ButtonDelete.Enabled = false;
                        goods_ButtonEdit.Enabled = false;
                        Deal_buttonPay.Enabled = false;
                    }
                    break;
             }
        }
        //=====================================-Клиенты-======================================================
        private void tabClientShow()
        {
            client_dataGridView.Rows.Clear();
            clientDataGridShow();
            idClient = -1;
        }

        private void clientDataGridShow()
        {
            List<Client> lst = Client.getAll();
            client_dataGridView.RowCount = lst.Count;
            client_dataGridView.ColumnCount = 5;
            for (int i = 0; i < lst.Count; i++)
            {
                client_dataGridView[0, i].Value = lst[i].ID;
                client_dataGridView[1, i].Value = lst[i].NameOrg;
                client_dataGridView[2, i].Value = lst[i].ManagerFullName;
                client_dataGridView[3, i].Value = lst[i].ManagerBirthDate;
                client_dataGridView[4, i].Value = lst[i].Address;
            }
        }
        //=====================================-Клиенты-======================================================

        //=====================================-Продавцы-======================================================
        private void tabCustomerShow()
        {
           customer_dataGridView.Rows.Clear();
           customerDataGridShow();
        }

        private void customerDataGridShow()
        {
            List<Customer> lst = Customer.getAll();
            customer_dataGridView.RowCount = lst.Count;
            customer_dataGridView.ColumnCount = 5;
            for (int i = 0; i < lst.Count;i++)
            {
                customer_dataGridView[0, i].Value = lst[i].ID;
                customer_dataGridView[1, i].Value = lst[i].FullName;
                customer_dataGridView[2, i].Value = lst[i].BirthDate;
                customer_dataGridView[3, i].Value = lst[i].PassportData;
                customer_dataGridView[4, i].Value = lst[i].HireDate;
            }
        }
        //=====================================-Продавцы-======================================================

        //=====================================-Товары-======================================================
        private void tabGoodsShow()
        {
            goods_dataGridView.Rows.Clear();
            goodsDataGridShow();
        }
        private void goodsDataGridShow()
        {
            List<Good> lst = Good.getAll();
            goods_dataGridView.RowCount = lst.Count;
            goods_dataGridView.ColumnCount = 5;
            for (int i=0; i<lst.Count; i++)
            {
                goods_dataGridView[0, i].Value = lst[i].ID;
                goods_dataGridView[1, i].Value = lst[i].Name;
                goods_dataGridView[2, i].Value = lst[i].BuyPrice;
                goods_dataGridView[3, i].Value = lst[i].SellPrice;
                goods_dataGridView[4, i].Value = lst[i].OnStorage;

            }
        }


        //=====================================-Товары-======================================================

        //=====================================-Сделки-======================================================
        private void tabDealShow()
        {
            Deal_dataGridView.Rows.Clear();
            List<Deal> lst = Deal.getAll();
            Deal_dataGridView.RowCount = lst.Count;
            Deal_dataGridView.ColumnCount = 12;
            for (int i = 0; i < lst.Count; i++)
            {
                Deal_dataGridView[0, i].Value = lst[i].ID;
                Deal_dataGridView[1, i].Value = lst[i].Customer.ID;
                Deal_dataGridView[2, i].Value = lst[i].Client.ID;
                Deal_dataGridView[3, i].Value = lst[i].Customer.FullName;
                Deal_dataGridView[4, i].Value = lst[i].Client.NameOrg;
                Deal_dataGridView[5, i].Value = lst[i].DateOfDeal;
                Deal_dataGridView[6, i].Value = lst[i].Summ;
                if (lst[i].Summ > 10000.0)
                {
                    if (lst[i].Discount == 0)
                    {
                        lst[i].Discount = 10;
                        lst[i].SummWithDiscount = lst[i].Summ * ((100.0 - lst[i].Discount) / 100.0);
                        List<DealGoods> gd = DealGoods.getByDeal(lst[i].ID);
                        double costs=0.0;
                        for (int j = 0; j < gd.Count; j++)
                        {
                            costs += (gd[j].count * gd[j].Good.BuyPrice);
                        }
                        lst[i].Profit = lst[i].SummWithDiscount - costs;
                        lst[i].update();
                    }
                }
                Deal_dataGridView[7, i].Value = lst[i].Discount;
                Deal_dataGridView[8, i].Value = lst[i].SummWithDiscount;
                Deal_dataGridView[9, i].Value = lst[i].Profit;
                Deal_dataGridView[10, i].Value = lst[i].Banks.ID;
                if (lst[i].IsPayed <= 0)
                    Deal_dataGridView[11, i].Value = "Не Оплачено";
                else
                    Deal_dataGridView[11, i].Value = "Оплачено";
                //Deal_dataGridView[8, i].Value = lst[i].OnStorage;
            }
        }



        //=====================================-Сделки-======================================================

        //======================================-Инфо-=======================================================
        private void InfoDealShow()
        {
            Deal_Goods_dataGridView.Rows.Clear();
            if (idDeal != -1)
            {
                List<InfoDeal> lst = InfoDeal.getAll(idDeal);
                Deal_Goods_dataGridView.RowCount = lst.Count;
                Deal_Goods_dataGridView.ColumnCount = 6;
                for (int i = 0; i<lst.Count;i++)
                {
                    Deal_Goods_dataGridView[0, i].Value = lst[i].Deal.ID;
                    Deal_Goods_dataGridView[1, i].Value = lst[i].Name;
                    Deal_Goods_dataGridView[2, i].Value = lst[i].SellPrice;
                    Deal_Goods_dataGridView[3, i].Value = lst[i].Count;
                    Deal_Goods_dataGridView[4, i].Value = lst[i].Summ;
                    Deal_Goods_dataGridView[5, i].Value = lst[i].DealGoods.ID;
                }
            }
        }
        //======================================-Инфо-=======================================================
        private void client_buttonAdd_Click(object sender, EventArgs e)
        {
            Form ifrm = new ClientModForm(permissions);
            ifrm.Text = "Добавить клиента";
            ifrm.Show();
            this.Hide();
        }

        private void client_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          //  idClient = -1;
            string s = client_dataGridView.SelectedRows[0].Cells["IDD"].Value.ToString();
            idClient = Convert.ToInt32(s);
            //textBox2.Text = s;
        }

        private void client_buttonEdit_Click(object sender, EventArgs e)
        {
            if (idClient == -1)
            {
                MessageBox.Show("Не выбрана клиент! :с", "Ошибка");
                //textBox1.Text = idClient.ToString();
            }
            else
            {
                if (Client.getById(idClient) != null)
                {
                    
                    Form ifrm = new ClientModForm(permissions,idClient);
                    ifrm.Text = "Изменить клиента";
                    ifrm.Show();
                    this.Hide();
                }                
            }
        }

        private void client_buttonDelete_Click(object sender, EventArgs e)
        {
            if (idClient == -1)
            {
                MessageBox.Show("Не выбран клиент!", "Ошибка");
                //textBox1.Text = idClient.ToString();
            }
            else
            {
                if (Client.getById(idClient) != null)
                {
                    Client cli = Client.getById(idClient);
                    if (cli.delete())
                    {
                        MessageBox.Show("Запись удалена!", "Успешно");
                        tabClientShow();
                    }
                }
            }
            idClient = -1;
            tabClientShow();
        }

        private void customer_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string s = customer_dataGridView.SelectedRows[0].Cells["IDСustomer"].Value.ToString();
            idCustomer = Convert.ToInt32(s);
        }

        private void customer_ButtonAdd_Click(object sender, EventArgs e)
        {
            Form ifrm = new CustomerModForm(permissions);
            ifrm.Text = "Добавить продавца ";
            ifrm.Show();
            this.Hide();
        }

        private void customer_ButtonEdit_Click(object sender, EventArgs e)
        {
            if (idCustomer == -1)
            {
                MessageBox.Show("Не выбран продавец!", "Ошибка");
                //textBox1.Text = idClient.ToString();
            }
            else
            {
                Form ifrm = new CustomerModForm(permissions,idCustomer);
                ifrm.Text = "Изменить продавца ";
                ifrm.Show();
                this.Hide();
            }
        }

        private void customer_buttonDelete_Click(object sender, EventArgs e)
        {
            if (idCustomer == -1)
            {
                MessageBox.Show("Не выбран продавец!", "Ошибка");
                //textBox1.Text = idClient.ToString();
            }
            else
            {
                if (Customer.getById(idCustomer) != null)
                {
                    Customer cli = Customer.getById(idCustomer);
                    if (cli.delete())
                    {
                        MessageBox.Show("Запись удалена!", "Успешно");
                        tabCustomerShow();
                    }
                }
            }
            idCustomer = -1;
            tabCustomerShow();
        }

        private void goods_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string s = goods_dataGridView.SelectedRows[0].Cells["IDGood"].Value.ToString();
            idGood = Convert.ToInt32(s);
        }
        private void goods_ButtonAdd_Click(object sender, EventArgs e)
        {
            Form ifrm = new GoodsModForm(permissions);
            ifrm.Text = "Добавить товар ";
            ifrm.Show();
            this.Hide();
        }

        private void goods_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void goods_ButtonEdit_Click(object sender, EventArgs e)
        {
            if (idGood == -1)
            {
                MessageBox.Show("Не выбран товар!", "Ошибка");
                //textBox1.Text = idClient.ToString();
            }
            else
            {
                Form ifrm = new GoodsModForm(permissions,idGood);
                ifrm.Text = "Изменить товар ";
                ifrm.Show();
                this.Hide();
            }
        }

        private void goods_ButtonDelete_Click(object sender, EventArgs e)
        {
            if (idGood == -1)
            {
                MessageBox.Show("Не выбран товар!", "Ошибка");
                //textBox1.Text = idClient.ToString();
            }
            else
            {
                if (Good.getById(idGood) != null)
                {
                    Good cli = Good.getById(idGood);
                    if (cli.delete())
                    {
                        MessageBox.Show("Запись удалена!", "Успешно");
                        tabCustomerShow();
                    }
                }
            }
            idGood = -1;
            tabGoodsShow();
        }

        private void Deal_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string s = Deal_dataGridView.SelectedRows[0].Cells["DealID"].Value.ToString();
            idDeal = Convert.ToInt32(s);
            InfoDealShow();
        }

        private void Deal_buttonAdd_Click(object sender, EventArgs e)
        {
            Form ifrm = new DealModForm(permissions);
            ifrm.Text = "Добавить сделку ";
            ifrm.Show();
            this.Hide();
        }

        private void Deal_buttonEdit_Click(object sender, EventArgs e)
        {
            if (idDeal == -1)
                MessageBox.Show("Не выбрана сделка!", "Ошибка");
            else
            {
                Form ifrm = new DealModForm(permissions,idDeal);
                ifrm.Text = "Отредактировать сделку ";
                ifrm.Show();
                this.Hide();
            }
        }

        private void Deal_buttonDelete_Click(object sender, EventArgs e)
        {
            if (idDeal == -1)
            {
                MessageBox.Show("Не выбрана сделка!", "Ошибка");
                //textBox1.Text = idClient.ToString();
            }
            else
            {
                if (Deal.getById(idDeal) != null)
                {
                    Deal cli = Deal.getById(idDeal);
                    if (cli.delete())
                    {
                        MessageBox.Show("Запись удалена!", "Успешно");
                        tabDealShow();
                    }
                }
            }
            idDeal = -1;
            tabDealShow();
            InfoDealShow();
        }

        private void Deal_Goods_ButtonAdd_Click(object sender, EventArgs e)
        {
            if (idDeal == -1)
                MessageBox.Show("Не выбрана сделка!", "Ошибка");
            else
            {
                Form ifrm = new DealGoodsModForm(permissions,idDeal);
                ifrm.Text = "Добавить товары в сделку ";
                ifrm.Show();
                this.Hide();
            }
        }


        private void Deal_Goods_ButtonDelete_Click(object sender, EventArgs e)
        {
            if (idDealGoods == -1)
                MessageBox.Show("Не выбрана запись!", "Ошибка");
            else
            {
                if (DealGoods.getById(idDealGoods) != null)
                {
                    DealGoods cli = DealGoods.getById(idDealGoods);
                    Deal deal = new Deal();
                    deal = Deal.getById(cli.Deal.ID);
                    deal.Summ -= cli.Good.SellPrice * cli.count;
                    if (deal.Summ < 10000)
                        deal.Discount = 0;
                    deal.SummWithDiscount -= (cli.Good.SellPrice * cli.count * ((100.0 - cli.Deal.Discount) / 100.0));
                    deal.Profit = deal.Profit - (cli.Good.SellPrice * cli.count * ((100.0 - cli.Deal.Discount) / 100.0)) + (cli. Good.BuyPrice * cli.count);
                    deal.update();
                    if (cli.delete())
                    {
                        MessageBox.Show("Запись удалена!", "Успешно");
                        InfoDealShow();
                        tabDealShow();
                    }
                }
            }
            idDealGoods = -1;
        }

        private void Deal_Goods_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string s = Deal_Goods_dataGridView.SelectedRows[0].Cells["DGID"].Value.ToString();
            idDealGoods = Convert.ToInt32(s);
        }

        private void Deal_buttonPay_Click(object sender, EventArgs e)
        {
            if (idDeal == -1)
                MessageBox.Show("Не выбрана сделка!", "Ошибка");
            else
            {
                Deal newDeal = new Deal();
                newDeal = Deal.getById(idDeal);
                if (newDeal.IsPayed == 0)
                    newDeal.IsPayed = 1;
                else
                    newDeal.IsPayed = 0;
                newDeal.payCommited();
                tabDealShow();
            }
        }

        private void Deal_buttonFiltr_Click(object sender, EventArgs e)
        {
            Form ifrm = new FiltrationForm(permissions);
            ifrm.Show();
            this.Hide();
        }
    }
}
