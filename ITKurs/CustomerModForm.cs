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
    public partial class CustomerModForm : Form
    {
        Customer customer = new Customer();
        private int permissions;
        private bool exitflag = false;
        private int idCustomer = -1;
        public CustomerModForm(int permissions)
        {
            
            InitializeComponent();
            this.permissions = permissions;
        }
        public CustomerModForm(int permissions,int idCustomer)
        {
            InitializeComponent();
            this.permissions = permissions;
            this.idCustomer = idCustomer;
            this.customer = Customer.getById(this.idCustomer);
        }

        private void CustomerModForm_Load(object sender, EventArgs e)
        {
            NameEr.Clear();
            passportEr.Clear();
            if (idCustomer == -1)
                showToInsert();
            else
                showToUpdate();
        }
        private void showToUpdate()
        {
            NameEr.Clear();
            passportEr.Clear();
            Name.Text = customer.FullName;
            Passport.Text = customer.PassportData;
            Birth.Value = customer.BirthDate;
            Hire.Value = customer.HireDate;
        }
        private void showToInsert()
        {
            NameEr.Clear();
            passportEr.Clear();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            NameEr.Clear();
            passportEr.Clear();
            if (idCustomer == -1)
                insertIntoCustomer();
            else
                updateIntoCustomer();
        }
        private void insertIntoCustomer()
        {
            bool flag = checkTextBox();
            if (flag)
            {
                Customer newCustomer = new Customer();
                newCustomer.FullName = Name.Text;
                newCustomer.BirthDate = Birth.Value;
                newCustomer.PassportData = Passport.Text;
                newCustomer.HireDate = Hire.Value;
                newCustomer.insert();
                MessageBox.Show("Информация была добавлена", "Успешно");
                exitflag = true;
                Form ifrm = new DataBaseForm(permissions);
                ifrm.Show();
                this.Close();
            }
        }
        private void updateIntoCustomer()
        {
            bool flag = checkTextBox();
            if (flag)
            {
                //Customer customer = new Customer();
                customer.FullName = Name.Text;
                customer.BirthDate = Birth.Value;
                customer.PassportData = Passport.Text;
                customer.HireDate = Hire.Value;
               // customer.
                if (customer.update())
                {
                    MessageBox.Show("Информация была добавлена", "Успешно");
                    exitflag = true;
                    Form ifrm = new DataBaseForm(permissions);
                    ifrm.Show();
                    this.Close();
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ClosingForm();
            exitflag = true;
            this.Close();
        }
        private void ClosingForm()
        {
            Form ifrm = new DataBaseForm(permissions);
            ifrm.Show();
        }

        private void CustomerModForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!exitflag)
                ClosingForm();
        }
        private bool checkTextBox()
        {
            bool flag = true;

            if (Name.Text == "")
            {
                NameEr.SetError(Name, "Не указано имя");
                flag = false;
            }
            if (Passport.Text == "")
            {
                passportEr.SetError(Passport, "Не указаны пасспортные данные ");
                flag = false;
            }
            return flag;
        }
    }
}
