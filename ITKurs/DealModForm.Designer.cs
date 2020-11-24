namespace ITKurs
{
    partial class DealModForm
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
            this.Dt = new System.Windows.Forms.DateTimePicker();
            this.ClientCombo = new System.Windows.Forms.ComboBox();
            this.CustomerCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Accept = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DiscEr = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.BankCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DiscEr)).BeginInit();
            this.SuspendLayout();
            // 
            // Dt
            // 
            this.Dt.Location = new System.Drawing.Point(152, 65);
            this.Dt.Name = "Dt";
            this.Dt.Size = new System.Drawing.Size(189, 20);
            this.Dt.TabIndex = 3;
            // 
            // ClientCombo
            // 
            this.ClientCombo.FormattingEnabled = true;
            this.ClientCombo.Location = new System.Drawing.Point(152, 11);
            this.ClientCombo.Name = "ClientCombo";
            this.ClientCombo.Size = new System.Drawing.Size(189, 21);
            this.ClientCombo.TabIndex = 4;
            // 
            // CustomerCombo
            // 
            this.CustomerCombo.FormattingEnabled = true;
            this.CustomerCombo.Location = new System.Drawing.Point(152, 38);
            this.CustomerCombo.Name = "CustomerCombo";
            this.CustomerCombo.Size = new System.Drawing.Size(189, 21);
            this.CustomerCombo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Заказщик:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Менеджер по продажам:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Дата  сделки:";
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(16, 144);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(75, 23);
            this.Accept.TabIndex = 10;
            this.Accept.Text = "Сохранить";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Отменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DiscEr
            // 
            this.DiscEr.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Банк:";
            // 
            // BankCombo
            // 
            this.BankCombo.FormattingEnabled = true;
            this.BankCombo.Location = new System.Drawing.Point(152, 91);
            this.BankCombo.Name = "BankCombo";
            this.BankCombo.Size = new System.Drawing.Size(189, 21);
            this.BankCombo.TabIndex = 13;
            // 
            // DealModForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 179);
            this.Controls.Add(this.BankCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerCombo);
            this.Controls.Add(this.ClientCombo);
            this.Controls.Add(this.Dt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DealModForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DealModForm_FormClosed);
            this.Load += new System.EventHandler(this.DealModForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DiscEr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker Dt;
        private System.Windows.Forms.ComboBox ClientCombo;
        private System.Windows.Forms.ComboBox CustomerCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider DiscEr;
        private System.Windows.Forms.ComboBox BankCombo;
        private System.Windows.Forms.Label label5;
    }
}