namespace ITKurs
{
    partial class GoodsModForm
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
            this.Name = new System.Windows.Forms.TextBox();
            this.Buy = new System.Windows.Forms.TextBox();
            this.Sell = new System.Windows.Forms.TextBox();
            this.OnStorage = new System.Windows.Forms.TextBox();
            this.Наименование = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameEr = new System.Windows.Forms.ErrorProvider(this.components);
            this.BuyEr = new System.Windows.Forms.ErrorProvider(this.components);
            this.SellEr = new System.Windows.Forms.ErrorProvider(this.components);
            this.StorageEr = new System.Windows.Forms.ErrorProvider(this.components);
            this.Accept = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NameEr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuyEr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellEr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StorageEr)).BeginInit();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(123, 13);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(141, 20);
            this.Name.TabIndex = 0;
            // 
            // Buy
            // 
            this.Buy.Location = new System.Drawing.Point(123, 39);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(141, 20);
            this.Buy.TabIndex = 1;
            // 
            // Sell
            // 
            this.Sell.Location = new System.Drawing.Point(123, 65);
            this.Sell.Name = "Sell";
            this.Sell.Size = new System.Drawing.Size(141, 20);
            this.Sell.TabIndex = 2;
            // 
            // OnStorage
            // 
            this.OnStorage.Location = new System.Drawing.Point(123, 91);
            this.OnStorage.Name = "OnStorage";
            this.OnStorage.Size = new System.Drawing.Size(141, 20);
            this.OnStorage.TabIndex = 3;
            // 
            // Наименование
            // 
            this.Наименование.AutoSize = true;
            this.Наименование.Location = new System.Drawing.Point(13, 19);
            this.Наименование.Name = "Наименование";
            this.Наименование.Size = new System.Drawing.Size(86, 13);
            this.Наименование.TabIndex = 4;
            this.Наименование.Text = "Наименование:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Цена закупки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Цена реализации:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "В наличии:";
            // 
            // NameEr
            // 
            this.NameEr.ContainerControl = this;
            // 
            // BuyEr
            // 
            this.BuyEr.ContainerControl = this;
            // 
            // SellEr
            // 
            this.SellEr.ContainerControl = this;
            // 
            // StorageEr
            // 
            this.StorageEr.ContainerControl = this;
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(15, 128);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(75, 23);
            this.Accept.TabIndex = 8;
            this.Accept.Text = "Сохранить";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(189, 128);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Отменить";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // GoodsModForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 166);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Наименование);
            this.Controls.Add(this.OnStorage);
            this.Controls.Add(this.Sell);
            this.Controls.Add(this.Buy);
            this.Controls.Add(this.Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //this.Name = "GoodsModForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GoodsModForm_FormClosed);
            this.Load += new System.EventHandler(this.GoodsModForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NameEr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuyEr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellEr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StorageEr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Buy;
        private System.Windows.Forms.TextBox Sell;
        private System.Windows.Forms.TextBox OnStorage;
        private System.Windows.Forms.Label Наименование;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider NameEr;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.ErrorProvider BuyEr;
        private System.Windows.Forms.ErrorProvider SellEr;
        private System.Windows.Forms.ErrorProvider StorageEr;
    }
}