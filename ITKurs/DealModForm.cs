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
    public partial class DealModForm : Form
    {
        private int permissions;
        private bool exitflag = false;
        Deal deal = new Deal();
        private int idDeal = -1;
        public DealModForm(int permissions)
        {
            InitializeComponent();
            this.permissions = permissions;
        }

        public DealModForm(int permissions,int idDeal)
        {
            InitializeComponent();
            this.permissions = permissions;
            this.idDeal = idDeal;
            this.deal = Deal.getById(idDeal);
        }

        private void DealModForm_Load(object sender, EventArgs e)
        {
            DiscEr.Clear();
            if (idDeal == -1)
                showToInsert();
            else
                showToUpdate();
        }
        private void showToInsert()
        {
            DiscEr.Clear();
            ClientCombo.Items.Clear();
            CustomerCombo.Items.Clear();
            List<Client> clients = Client.getAll();
            for (int i = 0; i < clients.Count; i++)
            {
                ClientCombo.Items.Add(clients[i].NameOrg);
            }
            List<Customer> lst = Customer.getAll();
            for (int i = 0; i < lst.Count; i++)
            {
                CustomerCombo.Items.Add(lst[i].FullName);
            }
            List<Banks> lst1 = Banks.getAll();
            for (int i = 0; i < lst1.Count; i++)
            {
                BankCombo.Items.Add(lst1[i].Name);
            }
        }
        private void showToUpdate()
        {
            DiscEr.Clear();
            ClientCombo.Items.Clear();
            CustomerCombo.Items.Clear();
            List<Client> clients = Client.getAll();
            string s = Deal.getById(idDeal).Client.NameOrg;
            ClientCombo.Items.Add(s);
            ClientCombo.SelectedIndex = ClientCombo.FindStringExact(s);
            s = Deal.getById(idDeal).Customer.FullName;
            CustomerCombo.Items.Add(s);
            CustomerCombo.SelectedIndex = CustomerCombo.FindStringExact(s);
            s = Deal.getById(idDeal).Banks.Name;
            BankCombo.Items.Add(s);
            BankCombo.SelectedIndex = BankCombo.FindStringExact(s);
            //ClientCombo
            Dt.Value = Deal.getById(idDeal).DateOfDeal;
            //Discount.Text = Deal.getById(idDeal).Discount.ToString();
        }


        private void ClosingForm()
        {
            Form ifrm = new DataBaseForm(permissions);
            ifrm.Show();
        }

        private void DealModForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!exitflag)
                ClosingForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClosingForm();
            exitflag = true;
            this.Close();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            DiscEr.Clear();
            if (idDeal == -1)
                insertIntoDeals();
            else
                updateIntoDeals();
        }
        private void insertIntoDeals()
        {
            bool flag = checkTextBox();
            if (flag)
            {
                Deal newDeal = new Deal();
                newDeal.Client = Client.getByTitle(ClientCombo.Text);
                newDeal.Customer = Customer.getByTitle(CustomerCombo.Text);
                newDeal.Banks = Banks.getByTitle(BankCombo.Text);
                newDeal.DateOfDeal = Dt.Value;
                //newDeal.Discount = (Convert.ToDouble(Discount.Text));
                newDeal.Discount = 0;
                newDeal.Summ = 0;
                newDeal.SummWithDiscount = 0;
                newDeal.Profit = 0;
                newDeal.IsPayed = 0;
                newDeal.insert();
                MessageBox.Show("Информация была добавлена", "Успешно");
                exitflag = true;
                ClosingForm();
                this.Close();
            }
        }
        private void updateIntoDeals()
        {
            deal.DateOfDeal = Dt.Value;
            //deal.Discount = (Convert.ToDouble(Discount.Text));
            deal.update();
            MessageBox.Show("Информация была обновлена", "Успешно");
            exitflag = true;
            ClosingForm();
            this.Close();
        }
        private bool checkTextBox()
        {
            bool flag = true;

            /*if ((Discount.Text == "")||(Convert.ToDouble(Discount.Text) < 0) || (Convert.ToDouble(Discount.Text) > 100))
            {
                if (Convert.ToDouble(Discount.Text) > 100)
                    DiscEr.SetError(Discount, "Скидка не может быть больше 100 процентов");
                else
                    DiscEr.SetError(Discount, "Скидка введена неверно");
                flag = false;
            }*/
           
            return flag;
        }
    }
}
