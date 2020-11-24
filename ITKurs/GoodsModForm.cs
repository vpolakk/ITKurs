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
    public partial class GoodsModForm : Form
    {
        private int permissions;
        private bool exitflag = false;
        private int idGood=-1;
        Good good = new Good();
        public GoodsModForm(int permissions)
        {
            InitializeComponent();
            this.permissions = permissions;
        }

        public GoodsModForm(int permissions, int idGood)
        {
            InitializeComponent();
            this.permissions = permissions;
            this.idGood = idGood;
            this.good = Good.getById(this.idGood);
        }

        private void GoodsModForm_Load(object sender, EventArgs e)
        {
            NameEr.Clear();
            BuyEr.Clear();
            SellEr.Clear();
            StorageEr.Clear();
            if (idGood == -1)
                showToInsert();
            else
                showToUpdate();
        }
        private void showToInsert()
        {
            Name.Clear();
            Buy.Clear();
            Sell.Clear();
            OnStorage.Clear();
        }
        private void showToUpdate()
        {
            Name.Clear();
            Buy.Clear();
            Sell.Clear();
            OnStorage.Clear();

            Name.Text = good.Name;
            Buy.Text = Convert.ToString(good.BuyPrice);
            Sell.Text = Convert.ToString(good.SellPrice);
            OnStorage.Text = Convert.ToString(good.OnStorage);
        }

        private void GoodsModForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!exitflag)
                ClosingForm();
        }
        private void ClosingForm()
        {
            Form ifrm = new DataBaseForm(permissions);
            ifrm.Show();
        }

        private bool checkTextBox()
        {
            bool flag = true;

            if (Name.Text == "")
            {
                NameEr.SetError(Name, "Не указано наименование");
                flag = false;
            }
            if ((Buy.Text == "") || (Convert.ToInt32(Buy.Text)<=0))
            {
                BuyEr.SetError(Buy, "Не верно введена цена");
                flag = false;
            }
            if ((Sell.Text == "") || (Convert.ToInt32(Sell.Text) <= 0))
            {
                SellEr.SetError(Sell, "Не верно введена цена");
                flag = false;
            }
            if ((OnStorage.Text == "")|| (Convert.ToInt32(OnStorage.Text)<0))
            {
                StorageEr.SetError(OnStorage, "Число на складе не может быть отрицательным или пустым");
                flag = false;
            }
            return flag;
        }
        private void Accept_Click(object sender, EventArgs e)
        {
            NameEr.Clear();
            BuyEr.Clear();
            SellEr.Clear();
            StorageEr.Clear();
            if (idGood == -1)
                insertIntoGoods();
            else
                updateIntoGoods();
        }

        private void insertIntoGoods()
        {
            bool flag = checkTextBox();
            if (flag)
            {
                Good newGood = new Good();
                newGood.Name = Name.Text;
                newGood.BuyPrice = Convert.ToInt32(Buy.Text);
                newGood.SellPrice = Convert.ToInt32(Sell.Text);
                newGood.OnStorage = Convert.ToInt32(OnStorage.Text);
                newGood.insert();
                MessageBox.Show("Информация была добавлена", "Успешно");
                exitflag = true;
                ClosingForm();
                this.Close();
            }
        }
        private void updateIntoGoods()
        {
            bool flag = checkTextBox();
            if (flag)
            {
                good.Name = Name.Text;
                good.BuyPrice = Convert.ToInt32(Buy.Text);
                good.SellPrice = Convert.ToInt32(Sell.Text);
                good.OnStorage = Convert.ToInt32(OnStorage.Text);
                if (good.update())
                {
                    MessageBox.Show("Информация была обновлена", "Успешно");
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
    }
}
