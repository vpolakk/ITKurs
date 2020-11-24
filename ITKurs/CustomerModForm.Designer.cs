namespace ITKurs
{
    partial class CustomerModForm
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
            this.Birth = new System.Windows.Forms.DateTimePicker();
            this.Passport = new System.Windows.Forms.TextBox();
            this.Hire = new System.Windows.Forms.DateTimePicker();
            this.Accept = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameEr = new System.Windows.Forms.ErrorProvider(this.components);
            this.passportEr = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NameEr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passportEr)).BeginInit();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(152, 13);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(213, 20);
            this.Name.TabIndex = 0;
            // 
            // Birth
            // 
            this.Birth.Location = new System.Drawing.Point(152, 40);
            this.Birth.Name = "Birth";
            this.Birth.Size = new System.Drawing.Size(213, 20);
            this.Birth.TabIndex = 1;
            // 
            // Passport
            // 
            this.Passport.Location = new System.Drawing.Point(152, 66);
            this.Passport.Name = "Passport";
            this.Passport.Size = new System.Drawing.Size(213, 20);
            this.Passport.TabIndex = 2;
            // 
            // Hire
            // 
            this.Hire.Location = new System.Drawing.Point(152, 92);
            this.Hire.Name = "Hire";
            this.Hire.Size = new System.Drawing.Size(213, 20);
            this.Hire.TabIndex = 3;
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(8, 118);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(75, 23);
            this.Accept.TabIndex = 4;
            this.Accept.Text = "Сохранить";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(290, 118);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Отменить";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ФИО:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Дата рождения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Пасспортные данные";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата найма:";
            // 
            // NameEr
            // 
            this.NameEr.ContainerControl = this;
            // 
            // passportEr
            // 
            this.passportEr.ContainerControl = this;
            // 
            // CustomerModForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 149);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.Hire);
            this.Controls.Add(this.Passport);
            this.Controls.Add(this.Birth);
            this.Controls.Add(this.Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //this.Name = "CustomerModForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить Продавца";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerModForm_FormClosed);
            this.Load += new System.EventHandler(this.CustomerModForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NameEr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passportEr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.DateTimePicker Birth;
        private System.Windows.Forms.TextBox Passport;
        private System.Windows.Forms.DateTimePicker Hire;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider NameEr;
        private System.Windows.Forms.ErrorProvider passportEr;
    }
}