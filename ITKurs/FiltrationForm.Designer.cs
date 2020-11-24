namespace ITKurs
{
    partial class FiltrationForm
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
            this.components = new System.ComponentModel.Container();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.OnSumm_filt = new System.Windows.Forms.Button();
            this.OnSumm = new System.Windows.Forms.TextBox();
            this.OnSummCombo = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.OnCustomer_filt = new System.Windows.Forms.Button();
            this.OnCustomer_Combo = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.OnClient_filt = new System.Windows.Forms.Button();
            this.OnClient_Combo = new System.Windows.Forms.ComboBox();
            this.OnSummEr = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Deal_dataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OnSummEr)).BeginInit();
            this.SuspendLayout();
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
            this.Deal_dataGridView.Location = new System.Drawing.Point(12, 12);
            this.Deal_dataGridView.Name = "Deal_dataGridView";
            this.Deal_dataGridView.ReadOnly = true;
            this.Deal_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Deal_dataGridView.Size = new System.Drawing.Size(627, 193);
            this.Deal_dataGridView.TabIndex = 1;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 212);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(379, 82);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.OnSumm_filt);
            this.tabPage1.Controls.Add(this.OnSumm);
            this.tabPage1.Controls.Add(this.OnSummCombo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(371, 56);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "По Сумме";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // OnSumm_filt
            // 
            this.OnSumm_filt.Location = new System.Drawing.Point(277, 5);
            this.OnSumm_filt.Name = "OnSumm_filt";
            this.OnSumm_filt.Size = new System.Drawing.Size(88, 23);
            this.OnSumm_filt.TabIndex = 2;
            this.OnSumm_filt.Text = "Фильтровать";
            this.OnSumm_filt.UseVisualStyleBackColor = true;
            this.OnSumm_filt.Click += new System.EventHandler(this.OnSumm_filt_Click);
            // 
            // OnSumm
            // 
            this.OnSumm.Location = new System.Drawing.Point(135, 7);
            this.OnSumm.Name = "OnSumm";
            this.OnSumm.Size = new System.Drawing.Size(100, 20);
            this.OnSumm.TabIndex = 1;
            // 
            // OnSummCombo
            // 
            this.OnSummCombo.FormattingEnabled = true;
            this.OnSummCombo.Items.AddRange(new object[] {
            "Больше",
            "Меньше",
            "Равно"});
            this.OnSummCombo.Location = new System.Drawing.Point(7, 7);
            this.OnSummCombo.Name = "OnSummCombo";
            this.OnSummCombo.Size = new System.Drawing.Size(121, 21);
            this.OnSummCombo.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.OnCustomer_filt);
            this.tabPage2.Controls.Add(this.OnCustomer_Combo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(371, 56);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "По Продавцам";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // OnCustomer_filt
            // 
            this.OnCustomer_filt.Location = new System.Drawing.Point(170, 5);
            this.OnCustomer_filt.Name = "OnCustomer_filt";
            this.OnCustomer_filt.Size = new System.Drawing.Size(91, 23);
            this.OnCustomer_filt.TabIndex = 1;
            this.OnCustomer_filt.Text = "Фильтровать";
            this.OnCustomer_filt.UseVisualStyleBackColor = true;
            this.OnCustomer_filt.Click += new System.EventHandler(this.OnCustomer_filt_Click);
            // 
            // OnCustomer_Combo
            // 
            this.OnCustomer_Combo.FormattingEnabled = true;
            this.OnCustomer_Combo.Location = new System.Drawing.Point(4, 7);
            this.OnCustomer_Combo.Name = "OnCustomer_Combo";
            this.OnCustomer_Combo.Size = new System.Drawing.Size(160, 21);
            this.OnCustomer_Combo.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.OnClient_filt);
            this.tabPage3.Controls.Add(this.OnClient_Combo);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(371, 56);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "По Покупателям";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // OnClient_filt
            // 
            this.OnClient_filt.Location = new System.Drawing.Point(183, 5);
            this.OnClient_filt.Name = "OnClient_filt";
            this.OnClient_filt.Size = new System.Drawing.Size(87, 23);
            this.OnClient_filt.TabIndex = 1;
            this.OnClient_filt.Text = "Фильтровать";
            this.OnClient_filt.UseVisualStyleBackColor = true;
            this.OnClient_filt.Click += new System.EventHandler(this.OnClient_filt_Click);
            // 
            // OnClient_Combo
            // 
            this.OnClient_Combo.FormattingEnabled = true;
            this.OnClient_Combo.Location = new System.Drawing.Point(7, 7);
            this.OnClient_Combo.Name = "OnClient_Combo";
            this.OnClient_Combo.Size = new System.Drawing.Size(170, 21);
            this.OnClient_Combo.TabIndex = 0;
            // 
            // OnSummEr
            // 
            this.OnSummEr.ContainerControl = this;
            // 
            // FiltrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 305);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Deal_dataGridView);
            this.Name = "FiltrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фильтрация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FiltrationForm_FormClosed);
            this.Load += new System.EventHandler(this.FiltrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Deal_dataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OnSummEr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Deal_dataGridView;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox OnSummCombo;
        private System.Windows.Forms.TextBox OnSumm;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button OnSumm_filt;
        private System.Windows.Forms.ComboBox OnCustomer_Combo;
        private System.Windows.Forms.Button OnCustomer_filt;
        private System.Windows.Forms.Button OnClient_filt;
        private System.Windows.Forms.ComboBox OnClient_Combo;
        private System.Windows.Forms.ErrorProvider OnSummEr;
    }
}