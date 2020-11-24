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
    public partial class DealGoodsModForm : Form
    {
        private int permissions;
        private bool exitflag = false;
        Deal deal = new Deal();
        private int idDeal = -1;
        public DealGoodsModForm(int permissions,int idDeal)
        {
            InitializeComponent();
            this.permissions = permissions;
            this.idDeal = idDeal;
            this.deal = Deal.getById(idDeal);
        }

        private void DealGoodsModForm_Load(object sender, EventArgs e)
        {
            CountEr.Clear();
            GoodCombo.Items.Clear();
            List<Good> good = Good.getAll();
            for (int i = 0; i < good.Count; i++)
            {
                GoodCombo.Items.Add(good[i].Name);
            }
        }
        private void ClosingForm()
        {
            Form ifrm = new DataBaseForm(permissions);
            ifrm.Show();
        }

        private void DealGoodsModForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!exitflag)
                ClosingForm();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ClosingForm();
            exitflag = true;
            this.Close();
        }
        private void insertIntoDealGoods()
        {
            bool flag = checkTextBox();
            if (flag)
            {
                DealGoods newDeal = new DealGoods();
                newDeal.Deal = Deal.getById(idDeal);
                newDeal.Good = Good.getByTitle(GoodCombo.Text);
                newDeal.count = (Convert.ToInt32(Count.Text));
                newDeal.insert();
                MessageBox.Show("Информация была добавлена", "Успешно");
                exitflag = true;
                ClosingForm();
                this.Close();
            }
        }
        private bool checkTextBox()
        {
            bool flag = true;

            if ((Count.Text == "") || (Convert.ToInt32(Count.Text) < 0))
            {
                CountEr.SetError(Count, "Кол-во введено неверно");
                flag = false;
            }

            return flag;
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            insertIntoDealGoods();
        }
    }
}
