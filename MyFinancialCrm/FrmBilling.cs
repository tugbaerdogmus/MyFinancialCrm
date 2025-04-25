using System;
using System.Collections.Generic;
using MyFinancialCrm.BusinessLayer.Concrete;
using MyFinancialCrm.DataAccessLayer.EntityFramework;
using MyFinancialCrm.EntityLayer.Models;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFinancialCrm
{
    public partial class FrmBilling : Form
    {
        private BillsManager _billManager = new BillsManager(new EfBillsDal());

        public FrmBilling()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmBilling_Load(object sender, EventArgs e)
        {
            var values = _billManager.TGetAll();
            dataGridView1.DataSource = values;
        }

        private void btnOdemeList_Click(object sender, EventArgs e)
        {
            var values = _billManager.TGetAll();
            dataGridView1.DataSource = values;
        }

        private void btnYeniOdeme_Click(object sender, EventArgs e)
        {
            string title = txtOdemeBaslik.Text;
            decimal amount = decimal.Parse(txtOdemeMiktar.Text);
            string period = txtPeriyot.Text;

            Bills veri = new Bills
            {
                BillTitle = txtOdemeBaslik.Text,
                BillAmount = decimal.Parse(txtOdemeMiktar.Text),
                BillPeriod = txtPeriyot.Text
            };
            _billManager.TInsert(veri);
            MessageBox.Show("Ödeme Başarılı Bir Şekilde Eklendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = _billManager.TGetAll();
            dataGridView1.DataSource = values;
        }

        private void btnOdemeSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtOdemeId.Text);
            var entity = _billManager.TGetById(id);
            _billManager.TDelete(id);
            MessageBox.Show("Ödeme Başarılı Bir Şekilde Silindi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnGuncelleme_Click(object sender, EventArgs e)
        {
            string title = txtOdemeBaslik.Text;
            decimal amount = decimal.Parse(txtOdemeMiktar.Text);
            string period = txtPeriyot.Text;
            int id = int.Parse(txtOdemeId.Text);

            var values = db.Bills.Find(id);

            values.BillTitle = title;
            values.BillAmount = amount;
            values.BillPeriod = period;
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir Şekilde Güncellendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var veri = _billManager.TGetById(id);
            veri.BillTitle = txtOdemeBaslik.Text;
            veri.BillAmount = decimal.Parse(txtOdemeMiktar.Text);
            veri.BillPeriod = txtPeriyot.Text;


            _billManager.TUpdate(veri);
            var values2 = _billManager.TGetAll();
            dataGridView1.DataSource = values2;
        }

        #region butonlar 
        private void button6_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }
        private void btnBankForm_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion 
    }
}
