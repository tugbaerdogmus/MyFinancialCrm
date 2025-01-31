namespace MyFinancialCrm
{
    partial class FrmBankTransactions
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
            this.button3 = new System.Windows.Forms.Button();
            this.btnBankForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnSpendingsForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategoryFilter = new System.Windows.Forms.ComboBox();
            this.txtMetinFilter = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBillsMetinFiltre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(260, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1078, 136);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.button7.Click += new System.EventHandler(this.button7_Click);
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
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 620);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(260, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(273, 40);
            this.panel5.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Son harcama işlemlerini buradan takip edebilirsiniz";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(260, 344);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1078, 136);
            this.dataGridView2.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(260, 282);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 45);
            this.panel2.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Son ödeme işlemlerini buradan takip edebilirsiniz";
            // 
            // cmbCategoryFilter
            // 
            this.cmbCategoryFilter.FormattingEnabled = true;
            this.cmbCategoryFilter.Location = new System.Drawing.Point(3, 36);
            this.cmbCategoryFilter.Name = "cmbCategoryFilter";
            this.cmbCategoryFilter.Size = new System.Drawing.Size(156, 21);
            this.cmbCategoryFilter.TabIndex = 8;
            this.cmbCategoryFilter.SelectedIndexChanged += new System.EventHandler(this.cmbCategoryFilter_SelectedIndexChanged);
            // 
            // txtMetinFilter
            // 
            this.txtMetinFilter.Location = new System.Drawing.Point(179, 36);
            this.txtMetinFilter.Name = "txtMetinFilter";
            this.txtMetinFilter.Size = new System.Drawing.Size(145, 20);
            this.txtMetinFilter.TabIndex = 24;
            this.txtMetinFilter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cmbCategoryFilter);
            this.panel3.Controls.Add(this.txtMetinFilter);
            this.panel3.Location = new System.Drawing.Point(541, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(797, 60);
            this.panel3.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Kategoriye Göre Filtre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Metne Göre Filtre";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtBillsMetinFiltre);
            this.panel4.Location = new System.Drawing.Point(539, 278);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(797, 60);
            this.panel4.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Metne Göre Filtre";
            // 
            // txtBillsMetinFiltre
            // 
            this.txtBillsMetinFiltre.Location = new System.Drawing.Point(8, 37);
            this.txtBillsMetinFiltre.Name = "txtBillsMetinFiltre";
            this.txtBillsMetinFiltre.Size = new System.Drawing.Size(145, 20);
            this.txtBillsMetinFiltre.TabIndex = 24;
            this.txtBillsMetinFiltre.TextChanged += new System.EventHandler(this.txtMetinFiltre_TextChanged);
            // 
            // FrmBankTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 646);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBankTransactions";
            this.Text = "FrmBankTransactions";
            this.Load += new System.EventHandler(this.FrmBankTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBankForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnSpendingsForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategoryFilter;
        private System.Windows.Forms.TextBox txtMetinFilter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBillsMetinFiltre;
    }
}