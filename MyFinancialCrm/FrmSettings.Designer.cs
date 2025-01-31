namespace MyFinancialCrm
{
    partial class FrmSettings
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUserSifre = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.btnGuncelleme = new System.Windows.Forms.Button();
            this.btnOdemeList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnSpendingsForm = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBankForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(259, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1074, 303);
            this.dataGridView1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(155)))), ((int)(((byte)(254)))));
            this.panel2.Controls.Add(this.txtUserSifre);
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Controls.Add(this.txtUserId);
            this.panel2.Controls.Add(this.btnGuncelleme);
            this.panel2.Controls.Add(this.btnOdemeList);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(259, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1074, 275);
            this.panel2.TabIndex = 15;
            // 
            // txtUserSifre
            // 
            this.txtUserSifre.Location = new System.Drawing.Point(117, 101);
            this.txtUserSifre.Name = "txtUserSifre";
            this.txtUserSifre.Size = new System.Drawing.Size(536, 20);
            this.txtUserSifre.TabIndex = 23;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(117, 67);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(536, 20);
            this.txtUserName.TabIndex = 22;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(117, 29);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(536, 20);
            this.txtUserId.TabIndex = 21;
            // 
            // btnGuncelleme
            // 
            this.btnGuncelleme.Location = new System.Drawing.Point(197, 195);
            this.btnGuncelleme.Name = "btnGuncelleme";
            this.btnGuncelleme.Size = new System.Drawing.Size(137, 23);
            this.btnGuncelleme.TabIndex = 20;
            this.btnGuncelleme.Text = "Güncelleme";
            this.btnGuncelleme.UseVisualStyleBackColor = true;
            this.btnGuncelleme.Click += new System.EventHandler(this.btnGuncelleme_Click);
            // 
            // btnOdemeList
            // 
            this.btnOdemeList.Location = new System.Drawing.Point(37, 195);
            this.btnOdemeList.Name = "btnOdemeList";
            this.btnOdemeList.Size = new System.Drawing.Size(137, 23);
            this.btnOdemeList.TabIndex = 17;
            this.btnOdemeList.Text = "Listele";
            this.btnOdemeList.UseVisualStyleBackColor = true;
            this.btnOdemeList.Click += new System.EventHandler(this.btnOdemeList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kullanıcı ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(79)))), ((int)(((byte)(129)))));
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnSpendingsForm);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnBankForm);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 620);
            this.panel1.TabIndex = 14;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(79)))), ((int)(((byte)(129)))));
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(38, 434);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(162, 45);
            this.button8.TabIndex = 7;
            this.button8.Text = "Çıkış Yap";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(79)))), ((int)(((byte)(129)))));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(38, 383);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(162, 45);
            this.button7.TabIndex = 6;
            this.button7.Text = "Ayarlar";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(79)))), ((int)(((byte)(129)))));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(38, 332);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(162, 45);
            this.button6.TabIndex = 5;
            this.button6.Text = "Dashboard";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(79)))), ((int)(((byte)(129)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(38, 281);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(162, 45);
            this.button5.TabIndex = 4;
            this.button5.Text = "Banka Hareketleri";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnSpendingsForm
            // 
            this.btnSpendingsForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(79)))), ((int)(((byte)(129)))));
            this.btnSpendingsForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpendingsForm.ForeColor = System.Drawing.Color.White;
            this.btnSpendingsForm.Location = new System.Drawing.Point(38, 230);
            this.btnSpendingsForm.Name = "btnSpendingsForm";
            this.btnSpendingsForm.Size = new System.Drawing.Size(162, 45);
            this.btnSpendingsForm.TabIndex = 3;
            this.btnSpendingsForm.Text = "Giderler";
            this.btnSpendingsForm.UseVisualStyleBackColor = false;
            this.btnSpendingsForm.Click += new System.EventHandler(this.btnSpendingsForm_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(79)))), ((int)(((byte)(129)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(38, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "Faturalar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBankForm
            // 
            this.btnBankForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(79)))), ((int)(((byte)(129)))));
            this.btnBankForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankForm.ForeColor = System.Drawing.Color.White;
            this.btnBankForm.Location = new System.Drawing.Point(38, 128);
            this.btnBankForm.Name = "btnBankForm";
            this.btnBankForm.Size = new System.Drawing.Size(162, 45);
            this.btnBankForm.TabIndex = 1;
            this.btnBankForm.Text = "Bankalar";
            this.btnBankForm.UseVisualStyleBackColor = false;
            this.btnBankForm.Click += new System.EventHandler(this.btnBankForm_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(79)))), ((int)(((byte)(129)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(38, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kategoriler";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 646);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSettings";
            this.Text = "FrmSettings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUserSifre;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Button btnGuncelleme;
        private System.Windows.Forms.Button btnOdemeList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnSpendingsForm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBankForm;
        private System.Windows.Forms.Button button1;
    }
}