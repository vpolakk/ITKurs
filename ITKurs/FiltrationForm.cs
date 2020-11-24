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
    public partial class FiltrationForm : Form
    {
        int permissions;
        public FiltrationForm(int permissions)
        {
            InitializeComponent();
            this.permissions = permissions;
        }

        private void FiltrationForm_Load(object sender, EventArgs e)
        {
            OnClient_Combo.Items.Clear();
            OnCustomer_Combo.Items.Clear();
            List<Client> clients = Client.getAll();
            for (int i = 0; i < clients.Count; i++)
            {
                OnClient_Combo.Items.Add(clients[i].NameOrg);
            }
            List<Customer> lst = Customer.getAll();
            for (int i = 0; i < lst.Count; i++)
            {
                OnCustomer_Combo.Items.Add(lst[i].FullName);
            }
        }

        private void OnSumm_filt_Click(object sender, EventArgs e)
        {
            Deal_dataGridView.Rows.Clear();
            if ((Convert.ToInt32(OnSumm.Text) == 0) || (OnSumm.Text != ""))
            {
                switch (OnSummCombo.Text)
                {
                    case "Меньше":
                        {
                            Deal_dataGridView.Rows.Clear();
                            List<Deal> lst = Deal.filterOnSummBigger(Convert.ToInt32(OnSumm.Text));
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
                        break;
                    case "Больше":
                        {
                            Deal_dataGridView.Rows.Clear();
                            List<Deal> lst = Deal.filterOnSummSmaller(Convert.ToInt32(OnSumm.Text));
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
                        break;
                    case "Равно":
                        {
                            Deal_dataGridView.Rows.Clear();
                            List<Deal> lst = Deal.filterOnSummEqual(Convert.ToInt32(OnSumm.Text));
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
                        break;
                }
            }
            else
            {
                OnSummEr.SetError(OnSumm, "Введите число");
            }
        }

        private void OnCustomer_filt_Click(object sender, EventArgs e)
        {
            Customer customer = Customer.getByTitle(OnCustomer_Combo.Text);
            Deal_dataGridView.Rows.Clear();
            List<Deal> lst = Deal.filterOnCustomer(customer.ID);
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

        private void OnClient_filt_Click(object sender, EventArgs e)
        {
            Client client = Client.getByTitle(OnClient_Combo.Text);
            Deal_dataGridView.Rows.Clear();
            List<Deal> lst = Deal.filterOnClient(client.ID);
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

        private void FiltrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = new DataBaseForm(permissions);
            ifrm.Show();
        }
    }
}
