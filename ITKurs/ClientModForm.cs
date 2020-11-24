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
    public partial class ClientModForm : Form
    {
        private int permissions;
        private bool exitflag = false;
        private int idClient = -1;
        Client client = new Client();
        public ClientModForm(int permissions)
        {
            
            InitializeComponent();
            this.permissions = permissions;
        }

        public ClientModForm(int permissions, int idClient)
        {
            InitializeComponent();
            this.permissions = permissions;
            this.idClient = idClient;
            this.client = Client.getById(this.idClient);
        }

        private void ClientModForm_Load(object sender, EventArgs e)
        {
            AdresEr.Clear();
            ManagerEr.Clear();
            NameEr.Clear();
            if (idClient == -1)
                showToInsert();
            else
                showToUpdate();
        }

        private void showToUpdate()
        {
            Name_textBox.Clear();
            Adres_textBox.Clear();
            Manager_textBox.Clear();

            Name_textBox.Text = client.NameOrg;
            Adres_textBox.Text = client.Address;
            Manager_textBox.Text = client.ManagerFullName;
            BirthDate.Value = client.ManagerBirthDate;
        }

        private void showToInsert()
        {
            Name_textBox.Clear();
            Adres_textBox.Clear();
            Manager_textBox.Clear();
        }

        private void insertIntoClient()
        {
            bool flag = chekTextBox();
            if (flag)
            {
                Client newClient = new Client();
                newClient.NameOrg = Name_textBox.Text;
                newClient.Address = Adres_textBox.Text;
                newClient.ManagerBirthDate = BirthDate.Value;
                newClient.ManagerFullName = Manager_textBox.Text;
                newClient.insert();
                MessageBox.Show("Информация была добавлена", "Успешно");
                exitflag = true;
                Form ifrm = new DataBaseForm(permissions);
                ifrm.Show();
                this.Close();
            }
            
        }

        private void updateInfoClient()
        {
            bool flag = chekTextBox();
            if (flag)
            {
                client.NameOrg = Name_textBox.Text;
                client.Address = Adres_textBox.Text;
                client.ManagerBirthDate = BirthDate.Value;
                client.ManagerFullName = Manager_textBox.Text;
                if (client.update())
                {
                    MessageBox.Show("Информация была изменена", "Успешно");
                    exitflag = true;
                    Form ifrm = new DataBaseForm(permissions);
                    ifrm.Show();
                    this.Close();
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            AdresEr.Clear();
            ManagerEr.Clear();
            NameEr.Clear();
            if (idClient == -1)
                insertIntoClient();
            else
                updateInfoClient();
        }

        private bool chekTextBox()
        {
            bool flag = true;

            if (Name_textBox.Text=="")
            {
                NameEr.SetError(Name_textBox, "Не указано имя");
                flag = false;
            }
            if (Adres_textBox.Text == "")
            {
                AdresEr.SetError(Adres_textBox, "Не указан адрес");
                flag = false;
            }
            if (Manager_textBox.Text == "")
            {
                ManagerEr.SetError(Manager_textBox, "Не указано имя управляющего");
                flag = false;
            }
            return flag;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ClosingForm();
            exitflag = true;
            this.Close();
        }

        private void ClientModForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!exitflag)
                ClosingForm();
        }

        private void ClosingForm()
        {
            Form ifrm = new DataBaseForm(permissions);
            ifrm.Show();
        }
    }
}
