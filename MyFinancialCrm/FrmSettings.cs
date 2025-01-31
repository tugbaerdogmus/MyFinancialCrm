using MyFinancialCrm.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFinancialCrm
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmSettings_Load(object sender, EventArgs e)
        {
            var values = db.Users.ToList();
            dataGridView1.DataSource = values;
        }
        private void btnOdemeList_Click(object sender, EventArgs e)
        {
            var values = db.Users.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnGuncelleme_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string userPassword = txtUserSifre.Text;
            int id = int.Parse(txtUserId.Text);

            var values = db.Users.Find(id);

            values.Username = userName;
            values.Password = userPassword;
            db.SaveChanges();
            MessageBox.Show("Kullanıcı Başarılı Bir Şekilde Güncellendi", "Kullanıcılar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values2 = db.Users.ToList();
            dataGridView1.DataSource = values2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();
        }

        private void btnBankForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void btnSpendingsForm_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmBankTransactions frm = new FrmBankTransactions();
            frm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
