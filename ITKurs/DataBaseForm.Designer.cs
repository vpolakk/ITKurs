namespace ITKurs
{
    partial class DataBaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Deal_buttonFiltr = new System.Windows.Forms.Button();
            this.Deal_buttonPay = new System.Windows.Forms.Button();
            this.Deal_Goods_ButtonDelete = new System.Windows.Forms.Button();
            this.Deal_Goods_ButtonAdd = new System.Windows.Forms.Button();
            this.Deal_buttonDelete = new System.Windows.Forms.Button();
            this.Deal_buttonEdit = new System.Windows.Forms.Button();
            this.Deal_buttonAdd = new System.Windows.Forms.Button();
            this.Deal_Goods_dataGridView = new System.Windows.Forms.DataGridView();
            this.InfoDealID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoSellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoSumm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deal_dataGridView = new System.Windows.Forms.DataGridView();
            this.DealID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DealsCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DealsClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfDeal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SummWithDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDBanks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.client_buttonDelete = new System.Windows.Forms.Button();
            this.client_buttonEdit = new System.Windows.Forms.Button();
            this.client_buttonAdd = new System.Windows.Forms.Button();
            this.client_dataGridView = new System.Windows.Forms.DataGridView();
            this.IDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.customer_buttonDelete = new System.Windows.Forms.Button();
            this.customer_ButtonEdit = new System.Windows.Forms.Button();
            this.customer_ButtonAdd = new System.Windows.Forms.Button();
            this.customer_dataGridView = new System.Windows.Forms.DataGridView();
            this.IDСustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassportData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.goods_ButtonDelete = new System.Windows.Forms.Button();
            this.goods_ButtonEdit = new System.Windows.Forms.Button();
            this.goods_ButtonAdd = new System.Windows.Forms.Button();
            this.goods_dataGridView = new System.Windows.Forms.DataGridView();
            this.IDGood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnStorage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Deal_Goods_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Deal_dataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.client_dataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_dataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goods_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(648, 590);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Deal_buttonFiltr);
            this.tabPage1.Controls.Add(this.Deal_buttonPay);
            this.tabPage1.Controls.Add(this.Deal_Goods_ButtonDelete);
            this.tabPage1.Controls.Add(this.Deal_Goods_ButtonAdd);
            this.tabPage1.Controls.Add(this.Deal_buttonDelete);
            this.tabPage1.Controls.Add(this.Deal_buttonEdit);
            this.tabPage1.Controls.Add(this.Deal_buttonAdd);
            this.tabPage1.Controls.Add(this.Deal_Goods_dataGridView);
            this.tabPage1.Controls.Add(this.Deal_dataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(640, 564);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сделки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Deal_buttonFiltr
            // 
            this.Deal_buttonFiltr.Location = new System.Drawing.Point(335, 207);
            this.Deal_buttonFiltr.Name = "Deal_buttonFiltr";
            this.Deal_buttonFiltr.Size = new System.Drawing.Size(75, 23);
            this.Deal_buttonFiltr.TabIndex = 9;
            this.Deal_buttonFiltr.Text = "Поиск...";
            this.Deal_buttonFiltr.UseVisualStyleBackColor = true;
            this.Deal_buttonFiltr.Click += new System.EventHandler(this.Deal_buttonFiltr_Click);
            // 
            // Deal_buttonPay
            // 
            this.Deal_buttonPay.Location = new System.Drawing.Point(253, 207);
            this.Deal_buttonPay.Name = "Deal_buttonPay";
            this.Deal_buttonPay.Size = new System.Drawing.Size(75, 23);
            this.Deal_buttonPay.TabIndex = 8;
            this.Deal_buttonPay.Text = "Оплата";
            this.Deal_buttonPay.UseVisualStyleBackColor = true;
            this.Deal_buttonPay.Click += new System.EventHandler(this.Deal_buttonPay_Click);
            // 
            // Deal_Goods_ButtonDelete
            // 
            this.Deal_Goods_ButtonDelete.Location = new System.Drawing.Point(170, 432);
            this.Deal_Goods_ButtonDelete.Name = "Deal_Goods_ButtonDelete";
            this.Deal_Goods_ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.Deal_Goods_ButtonDelete.TabIndex = 7;
            this.Deal_Goods_ButtonDelete.Text = "Удалить";
            this.Deal_Goods_ButtonDelete.UseVisualStyleBackColor = true;
            this.Deal_Goods_ButtonDelete.Click += new System.EventHandler(this.Deal_Goods_ButtonDelete_Click);
            // 
            // Deal_Goods_ButtonAdd
            // 
            this.Deal_Goods_ButtonAdd.Location = new System.Drawing.Point(7, 432);
            this.Deal_Goods_ButtonAdd.Name = "Deal_Goods_ButtonAdd";
            this.Deal_Goods_ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.Deal_Goods_ButtonAdd.TabIndex = 5;
            this.Deal_Goods_ButtonAdd.Text = "Добавить";
            this.Deal_Goods_ButtonAdd.UseVisualStyleBackColor = true;
            this.Deal_Goods_ButtonAdd.Click += new System.EventHandler(this.Deal_Goods_ButtonAdd_Click);
            // 
            // Deal_buttonDelete
            // 
            this.Deal_buttonDelete.Location = new System.Drawing.Point(171, 207);
            this.Deal_buttonDelete.Name = "Deal_buttonDelete";
            this.Deal_buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.Deal_buttonDelete.TabIndex = 4;
            this.Deal_buttonDelete.Text = "Удалить";
            this.Deal_buttonDelete.UseVisualStyleBackColor = true;
            this.Deal_buttonDelete.Click += new System.EventHandler(this.Deal_buttonDelete_Click);
            // 
            // Deal_buttonEdit
            // 
            this.Deal_buttonEdit.Location = new System.Drawing.Point(89, 207);
            this.Deal_buttonEdit.Name = "Deal_buttonEdit";
            this.Deal_buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.Deal_buttonEdit.TabIndex = 3;
            this.Deal_buttonEdit.Text = "Изменить";
            this.Deal_buttonEdit.UseVisualStyleBackColor = true;
            this.Deal_buttonEdit.Click += new System.EventHandler(this.Deal_buttonEdit_Click);
            // 
            // Deal_buttonAdd
            // 
            this.Deal_buttonAdd.Location = new System.Drawing.Point(7, 207);
            this.Deal_buttonAdd.Name = "Deal_buttonAdd";
            this.Deal_buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.Deal_buttonAdd.TabIndex = 2;
            this.Deal_buttonAdd.Text = "Добавить";
            this.Deal_buttonAdd.UseVisualStyleBackColor = true;
            this.Deal_buttonAdd.Click += new System.EventHandler(this.Deal_buttonAdd_Click);
            // 
            // Deal_Goods_dataGridView
            // 
            this.Deal_Goods_dataGridView.AllowUserToAddRows = false;
            this.Deal_Goods_dataGridView.AllowUserToDeleteRows = false;
            this.Deal_Goods_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Deal_Goods_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Deal_Goods_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InfoDealID,
            this.InfoName,
            this.InfoSellPrice,
            this.InfoCount,
            this.InfoSumm,
            this.DGID});
            this.Deal_Goods_dataGridView.Location = new System.Drawing.Point(7, 236);
            this.Deal_Goods_dataGridView.Name = "Deal_Goods_dataGridView";
            this.Deal_Goods_dataGridView.ReadOnly = true;
            this.Deal_Goods_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Deal_Goods_dataGridView.Size = new System.Drawing.Size(627, 189);
            this.Deal_Goods_dataGridView.TabIndex = 1;
            this.Deal_Goods_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Deal_Goods_dataGridView_CellClick);
            // 
            // InfoDealID
            // 
            this.InfoDealID.HeaderText = "ID";
            this.InfoDealID.Name = "InfoDealID";
            this.InfoDealID.ReadOnly = true;
            this.InfoDealID.Visible = false;
            // 
            // InfoName
            // 
            this.InfoName.HeaderText = "Наименование";
            this.InfoName.Name = "InfoName";
            this.InfoName.ReadOnly = true;
            // 
            // InfoSellPrice
            // 
            this.InfoSellPrice.HeaderText = "Цена";
            this.InfoSellPrice.Name = "InfoSellPrice";
            this.InfoSellPrice.ReadOnly = true;
            // 
            // InfoCount
            // 
            this.InfoCount.HeaderText = "Количество";
            this.InfoCount.Name = "InfoCount";
            this.InfoCount.ReadOnly = true;
            // 
            // InfoSumm
            // 
            this.InfoSumm.HeaderText = "Сумма";
            this.InfoSumm.Name = "InfoSumm";
            this.InfoSumm.ReadOnly = true;
            // 
            // DGID
            // 
            this.DGID.HeaderText = "DGID";
            this.DGID.Name = "DGID";
            this.DGID.ReadOnly = true;
            this.DGID.Visible = false;
            // 
            // Deal_dataGridView
            // 
            this.Deal_dataGridView.AllowUserToAddRows = false;
            this.Deal_dataGridView.AllowUserToDeleteRows = false;
            this.Deal_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Deal_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Deal_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DealID,
            this.CustomerID,
            this.ClientID,
            this.DealsCustomerName,
            this.DealsClientName,
            this.DateOfDeal,
            this.Summ,
            this.Discount,
            this.SummWithDiscount,
            this.Profit,
            this.IDBanks,
            this.IsPayed});
            this.Deal_dataGridView.Location = new System.Drawing.Point(7, 7);
            this.Deal_dataGridView.Name = "Deal_dataGridView";
            this.Deal_dataGridView.ReadOnly = true;
            this.Deal_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Deal_dataGridView.Size = new System.Drawing.Size(627, 193);
            this.Deal_dataGridView.TabIndex = 0;
            this.Deal_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Deal_dataGridView_CellClick);
            // 
            // DealID
            // 
            this.DealID.HeaderText = "ID";
            this.DealID.Name = "DealID";
            this.DealID.ReadOnly = true;
            this.DealID.Visible = false;
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "IDCustomer";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Visible = false;
            // 
            // ClientID
            // 
            this.ClientID.HeaderText = "IDClient";
            this.ClientID.Name = "ClientID";
            this.ClientID.ReadOnly = true;
            this.ClientID.Visible = false;
            // 
            // DealsCustomerName
            // 
            this.DealsCustomerName.HeaderText = "Менеджер по продажам";
            this.DealsCustomerName.Name = "DealsCustomerName";
            this.DealsCustomerName.ReadOnly = true;
            // 
            // DealsClientName
            // 
            this.DealsClientName.HeaderText = "Покупатель";
            this.DealsClientName.Name = "DealsClientName";
            this.DealsClientName.ReadOnly = true;
            // 
            // DateOfDeal
            // 
            this.DateOfDeal.HeaderText = "Дата Сделки";
            this.DateOfDeal.Name = "DateOfDeal";
            this.DateOfDeal.ReadOnly = true;
            // 
            // Summ
            // 
            this.Summ.HeaderText = "Сумма сделки";
            this.Summ.Name = "Summ";
            this.Summ.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Скидка";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // SummWithDiscount
            // 
            this.SummWithDiscount.HeaderText = "Сумма с учётом скидки";
            this.SummWithDiscount.Name = "SummWithDiscount";
            this.SummWithDiscount.ReadOnly = true;
            // 
            // Profit
            // 
            this.Profit.HeaderText = "Прибыль предприятию ";
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            // 
            // IDBanks
            // 
            this.IDBanks.HeaderText = "IDBanks";
            this.IDBanks.Name = "IDBanks";
            this.IDBanks.ReadOnly = true;
            this.IDBanks.Visible = false;
            // 
            // IsPayed
            // 
            this.IsPayed.HeaderText = "Оплата проведена";
            this.IsPayed.Name = "IsPayed";
            this.IsPayed.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.client_buttonDelete);
            this.tabPage2.Controls.Add(this.client_buttonEdit);
            this.tabPage2.Controls.Add(this.client_buttonAdd);
            this.tabPage2.Controls.Add(this.client_dataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(640, 564);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Клиенты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // client_buttonDelete
            // 
            this.client_buttonDelete.Location = new System.Drawing.Point(184, 227);
            this.client_buttonDelete.Name = "client_buttonDelete";
            this.client_buttonDelete.Size = new System.Drawing.Size(83, 23);
            this.client_buttonDelete.TabIndex = 3;
            this.client_buttonDelete.Text = "Удалить";
            this.client_buttonDelete.UseVisualStyleBackColor = true;
            this.client_buttonDelete.Click += new System.EventHandler(this.client_buttonDelete_Click);
            // 
            // client_buttonEdit
            // 
            this.client_buttonEdit.Location = new System.Drawing.Point(95, 227);
            this.client_buttonEdit.Name = "client_buttonEdit";
            this.client_buttonEdit.Size = new System.Drawing.Size(83, 23);
            this.client_buttonEdit.TabIndex = 2;
            this.client_buttonEdit.Text = "Изменить";
            this.client_buttonEdit.UseVisualStyleBackColor = true;
            this.client_buttonEdit.Click += new System.EventHandler(this.client_buttonEdit_Click);
            // 
            // client_buttonAdd
            // 
            this.client_buttonAdd.Location = new System.Drawing.Point(6, 227);
            this.client_buttonAdd.Name = "client_buttonAdd";
            this.client_buttonAdd.Size = new System.Drawing.Size(83, 23);
            this.client_buttonAdd.TabIndex = 1;
            this.client_buttonAdd.Text = "Добавить";
            this.client_buttonAdd.UseVisualStyleBackColor = true;
            this.client_buttonAdd.Click += new System.EventHandler(this.client_buttonAdd_Click);
            // 
            // client_dataGridView
            // 
            this.client_dataGridView.AllowUserToAddRows = false;
            this.client_dataGridView.AllowUserToDeleteRows = false;
            this.client_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.client_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.client_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.client_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDD,
            this.NameOrg,
            this.MFullName,
            this.MBirthDate,
            this.Adres});
            this.client_dataGridView.Location = new System.Drawing.Point(6, 6);
            this.client_dataGridView.MultiSelect = false;
            this.client_dataGridView.Name = "client_dataGridView";
            this.client_dataGridView.ReadOnly = true;
            this.client_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.client_dataGridView.Size = new System.Drawing.Size(628, 214);
            this.client_dataGridView.TabIndex = 0;
            this.client_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.client_dataGridView_CellContentClick);
            this.client_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.client_dataGridView_CellContentClick);
            // 
            // IDD
            // 
            this.IDD.HeaderText = "IDD";
            this.IDD.Name = "IDD";
            this.IDD.ReadOnly = true;
            this.IDD.Visible = false;
            // 
            // NameOrg
            // 
            this.NameOrg.HeaderText = "Наименвоание организации";
            this.NameOrg.Name = "NameOrg";
            this.NameOrg.ReadOnly = true;
            // 
            // MFullName
            // 
            this.MFullName.HeaderText = "Имя управляющего";
            this.MFullName.Name = "MFullName";
            this.MFullName.ReadOnly = true;
            // 
            // MBirthDate
            // 
            this.MBirthDate.HeaderText = "Дата рождения";
            this.MBirthDate.Name = "MBirthDate";
            this.MBirthDate.ReadOnly = true;
            // 
            // Adres
            // 
            this.Adres.HeaderText = "Адрес организации";
            this.Adres.Name = "Adres";
            this.Adres.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.customer_buttonDelete);
            this.tabPage3.Controls.Add(this.customer_ButtonEdit);
            this.tabPage3.Controls.Add(this.customer_ButtonAdd);
            this.tabPage3.Controls.Add(this.customer_dataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(640, 564);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Продавцы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // customer_buttonDelete
            // 
            this.customer_buttonDelete.Location = new System.Drawing.Point(169, 223);
            this.customer_buttonDelete.Name = "customer_buttonDelete";
            this.customer_buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.customer_buttonDelete.TabIndex = 3;
            this.customer_buttonDelete.Text = "Удалить";
            this.customer_buttonDelete.UseVisualStyleBackColor = true;
            this.customer_buttonDelete.Click += new System.EventHandler(this.customer_buttonDelete_Click);
            // 
            // customer_ButtonEdit
            // 
            this.customer_ButtonEdit.Location = new System.Drawing.Point(88, 224);
            this.customer_ButtonEdit.Name = "customer_ButtonEdit";
            this.customer_ButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.customer_ButtonEdit.TabIndex = 2;
            this.customer_ButtonEdit.Text = "Изменить";
            this.customer_ButtonEdit.UseVisualStyleBackColor = true;
            this.customer_ButtonEdit.Click += new System.EventHandler(this.customer_ButtonEdit_Click);
            // 
            // customer_ButtonAdd
            // 
            this.customer_ButtonAdd.Location = new System.Drawing.Point(7, 224);
            this.customer_ButtonAdd.Name = "customer_ButtonAdd";
            this.customer_ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.customer_ButtonAdd.TabIndex = 1;
            this.customer_ButtonAdd.Text = "Добавить";
            this.customer_ButtonAdd.UseVisualStyleBackColor = true;
            this.customer_ButtonAdd.Click += new System.EventHandler(this.customer_ButtonAdd_Click);
            // 
            // customer_dataGridView
            // 
            this.customer_dataGridView.AllowUserToAddRows = false;
            this.customer_dataGridView.AllowUserToDeleteRows = false;
            this.customer_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customer_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDСustomer,
            this.CustomerName,
            this.CustomerBirthDate,
            this.PassportData,
            this.HireDate});
            this.customer_dataGridView.Location = new System.Drawing.Point(6, 6);
            this.customer_dataGridView.Name = "customer_dataGridView";
            this.customer_dataGridView.ReadOnly = true;
            this.customer_dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.customer_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customer_dataGridView.Size = new System.Drawing.Size(628, 211);
            this.customer_dataGridView.TabIndex = 0;
            this.customer_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customer_dataGridView_CellClick);
            // 
            // IDСustomer
            // 
            this.IDСustomer.HeaderText = "ID";
            this.IDСustomer.Name = "IDСustomer";
            this.IDСustomer.ReadOnly = true;
            this.IDСustomer.Visible = false;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Имя";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // CustomerBirthDate
            // 
            this.CustomerBirthDate.HeaderText = "Дата рождения";
            this.CustomerBirthDate.Name = "CustomerBirthDate";
            this.CustomerBirthDate.ReadOnly = true;
            // 
            // PassportData
            // 
            this.PassportData.HeaderText = "Паспортные данные";
            this.PassportData.Name = "PassportData";
            this.PassportData.ReadOnly = true;
            // 
            // HireDate
            // 
            this.HireDate.HeaderText = "Дата найма";
            this.HireDate.Name = "HireDate";
            this.HireDate.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.goods_ButtonDelete);
            this.tabPage4.Controls.Add(this.goods_ButtonEdit);
            this.tabPage4.Controls.Add(this.goods_ButtonAdd);
            this.tabPage4.Controls.Add(this.goods_dataGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(640, 564);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Товары";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // goods_ButtonDelete
            // 
            this.goods_ButtonDelete.Location = new System.Drawing.Point(169, 220);
            this.goods_ButtonDelete.Name = "goods_ButtonDelete";
            this.goods_ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.goods_ButtonDelete.TabIndex = 3;
            this.goods_ButtonDelete.Text = "Удалить";
            this.goods_ButtonDelete.UseVisualStyleBackColor = true;
            this.goods_ButtonDelete.Click += new System.EventHandler(this.goods_ButtonDelete_Click);
            // 
            // goods_ButtonEdit
            // 
            this.goods_ButtonEdit.Location = new System.Drawing.Point(88, 220);
            this.goods_ButtonEdit.Name = "goods_ButtonEdit";
            this.goods_ButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.goods_ButtonEdit.TabIndex = 2;
            this.goods_ButtonEdit.Text = "Изменить";
            this.goods_ButtonEdit.UseVisualStyleBackColor = true;
            this.goods_ButtonEdit.Click += new System.EventHandler(this.goods_ButtonEdit_Click);
            // 
            // goods_ButtonAdd
            // 
            this.goods_ButtonAdd.Location = new System.Drawing.Point(6, 220);
            this.goods_ButtonAdd.Name = "goods_ButtonAdd";
            this.goods_ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.goods_ButtonAdd.TabIndex = 1;
            this.goods_ButtonAdd.Text = "Добавить";
            this.goods_ButtonAdd.UseVisualStyleBackColor = true;
            this.goods_ButtonAdd.Click += new System.EventHandler(this.goods_ButtonAdd_Click);
            // 
            // goods_dataGridView
            // 
            this.goods_dataGridView.AllowUserToAddRows = false;
            this.goods_dataGridView.AllowUserToDeleteRows = false;
            this.goods_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.goods_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goods_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDGood,
            this.GoodName,
            this.BuyPrice,
            this.SellPrice,
            this.OnStorage});
            this.goods_dataGridView.Location = new System.Drawing.Point(7, 7);
            this.goods_dataGridView.Name = "goods_dataGridView";
            this.goods_dataGridView.ReadOnly = true;
            this.goods_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.goods_dataGridView.Size = new System.Drawing.Size(627, 207);
            this.goods_dataGridView.TabIndex = 0;
            this.goods_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.goods_dataGridView_CellClick);
            this.goods_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.goods_dataGridView_CellContentClick);
            // 
            // IDGood
            // 
            this.IDGood.HeaderText = "ID";
            this.IDGood.Name = "IDGood";
            this.IDGood.ReadOnly = true;
            this.IDGood.Visible = false;
            // 
            // GoodName
            // 
            this.GoodName.HeaderText = "Наименова";
            this.GoodName.Name = "GoodName";
            this.GoodName.ReadOnly = true;
            // 
            // BuyPrice
            // 
            this.BuyPrice.HeaderText = "Цена закупки";
            this.BuyPrice.Name = "BuyPrice";
            this.BuyPrice.ReadOnly = true;
            // 
            // SellPrice
            // 
            this.SellPrice.HeaderText = "Цена реализации";
            this.SellPrice.Name = "SellPrice";
            this.SellPrice.ReadOnly = true;
            // 
            // OnStorage
            // 
            this.OnStorage.HeaderText = "В наличии (шт.)";
            this.OnStorage.Name = "OnStorage";
            this.OnStorage.ReadOnly = true;
            // 
            // DataBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 614);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DataBaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База данных";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed_1);
            this.Load += new System.EventHandler(this.DataBaseForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Deal_Goods_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Deal_dataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.client_dataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customer_dataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.goods_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView client_dataGridView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView customer_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDСustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassportData;
        private System.Windows.Forms.DataGridViewTextBoxColumn HireDate;
        private System.Windows.Forms.DataGridView goods_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDGood;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnStorage;
        private System.Windows.Forms.Button client_buttonDelete;
        private System.Windows.Forms.Button client_buttonEdit;
        private System.Windows.Forms.Button client_buttonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn MFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.Button customer_buttonDelete;
        private System.Windows.Forms.Button customer_ButtonEdit;
        private System.Windows.Forms.Button customer_ButtonAdd;
        private System.Windows.Forms.Button goods_ButtonDelete;
        private System.Windows.Forms.Button goods_ButtonEdit;
        private System.Windows.Forms.Button goods_ButtonAdd;
        private System.Windows.Forms.Button Deal_buttonDelete;
        private System.Windows.Forms.Button Deal_buttonEdit;
        private System.Windows.Forms.Button Deal_buttonAdd;
        private System.Windows.Forms.DataGridView Deal_Goods_dataGridView;
        private System.Windows.Forms.DataGridView Deal_dataGridView;
        private System.Windows.Forms.Button Deal_Goods_ButtonDelete;
        private System.Windows.Forms.Button Deal_Goods_ButtonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfoDealID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfoSellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfoCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfoSumm;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DealID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DealsCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DealsClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfDeal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SummWithDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDBanks;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsPayed;
        private System.Windows.Forms.Button Deal_buttonPay;
        private System.Windows.Forms.Button Deal_buttonFiltr;
    }
}