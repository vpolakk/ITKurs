namespace ITKurs
{
    partial class ClientModForm
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
            this.Cancel = new System.Windows.Forms.Button();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Adres_textBox = new System.Windows.Forms.TextBox();
            this.Manager_textBox = new System.Windows.Forms.TextBox();
            this.BirthDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ManagerEr = new System.Windows.Forms.ErrorProvider(this.components);
            this.AdresEr = new System.Windows.Forms.ErrorProvider(this.components);
            this.NameEr = new System.Windows.Forms.ErrorProvider(this.components);
            this.Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ManagerEr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdresEr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameEr)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(177, 186);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(114, 26);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(138, 20);
            this.Name_textBox.TabIndex = 1;
            // 
            // Adres_textBox
            // 
            this.Adres_textBox.Location = new System.Drawing.Point(114, 65);
            this.Adres_textBox.Name = "Adres_textBox";
            this.Adres_textBox.Size = new System.Drawing.Size(138, 20);
            this.Adres_textBox.TabIndex = 2;
            // 
            // Manager_textBox
            // 
            this.Manager_textBox.Location = new System.Drawing.Point(114, 110);
            this.Manager_textBox.Name = "Manager_textBox";
            this.Manager_textBox.Size = new System.Drawing.Size(138, 20);
            this.Manager_textBox.TabIndex = 3;
            // 
            // BirthDate
            // 
            this.BirthDate.Location = new System.Drawing.Point(114, 147);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(138, 20);
            this.BirthDate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Имя управляющего";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата рождения";
            // 
            // ManagerEr
            // 
            this.ManagerEr.ContainerControl = this;
            // 
            // AdresEr
            // 
            this.AdresEr.ContainerControl = this;
            // 
            // NameEr
            // 
            this.NameEr.ContainerControl = this;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(5, 186);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 9;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ClientModForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 221);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BirthDate);
            this.Controls.Add(this.Manager_textBox);
            this.Controls.Add(this.Adres_textBox);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientModForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientModForm_FormClosed);
            this.Load += new System.EventHandler(this.ClientModForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ManagerEr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdresEr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameEr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.TextBox Adres_textBox;
        private System.Windows.Forms.TextBox Manager_textBox;
        private System.Windows.Forms.DateTimePicker BirthDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider ManagerEr;
        private System.Windows.Forms.ErrorProvider AdresEr;
        private System.Windows.Forms.ErrorProvider NameEr;
        private System.Windows.Forms.Button Save;
    }
}