using MyFinancialCrm.EntityLayer.Context;
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
    public partial class FrmBankTransactions : Form
    {
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        public FrmBankTransactions()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmBankTransactions_Load(object sender, EventArgs e)
        {
            cmbCategoryFilter.SelectedIndexChanged -= cmbCategoryFilter_SelectedIndexChanged;
            CategoryList();
            cmbCategoryFilter.SelectedIndexChanged += cmbCategoryFilter_SelectedIndexChanged;

            //using (db)
            //{
            var query = from s in db.Spendings
                            join c in db.Categories on s.CategoryId equals c.CategoyId 
                            select new
                            {
                                Harcama = s.SpendingTitle,
                                Harcama_Tutarı = s.SpendingAmount,
                                Harcama_Tarih= s.SpendingDate,
                                CategoryName = c.CatogoryName
                            };

                dataGridView1.DataSource = query.ToList();
            //}
            var values = db.Bills.ToList();
            dataGridView2.DataSource = values;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (var context = new FinansalCrmContext())
            {
                var query = from h in context.Spendings
                            join k in context.Categories on h.CategoryId equals k.CategoyId
                            where k.CatogoryName.Contains(txtMetinFilter.Text) || h.SpendingTitle.Contains(txtMetinFilter.Text)
                            orderby h.SpendingDate descending
                            select new
                            {
                                Harcama = h.SpendingTitle,
                                HarcamaTarihi = h.SpendingDate,
                                HarcamaMiktari = h.SpendingAmount,
                                KategoriAdi = k.CatogoryName
                            };

                dataGridView1.DataSource = query.ToList();
            }
        }

        private void cmbCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCategoryFilter.DropDownStyle = ComboBoxStyle.DropDownList; // Elle veri girişini engellemek için 

            if (cmbCategoryFilter.SelectedValue == null)
                return; // Seçim yapılmadıysa çık

            // ComboBox’tan seçilen değeri int olarak al
            int selectedKategoriId = cmbCategoryFilter.SelectedValue as int? ?? 0;

                var query = from h in db.Spendings
                            join k in db.Categories on h.CategoryId equals k.CategoyId
                            orderby h.SpendingDate descending
                            select new
                            {
                                Harcama = h.SpendingTitle,
                                HarcamaTarihi = h.SpendingDate,
                                HarcamaMiktari = h.SpendingAmount,
                                KategoriAdi = k.CatogoryName
                            };

                // Eğer "Tümü" seçili değilse, belirli kategoriye göre filtrele
                if (selectedKategoriId > 0)
                {
                    query = query.Where(h => h.KategoriAdi == cmbCategoryFilter.Text);
                }

                dataGridView1.DataSource = query.ToList();
        }
        private void CategoryList()
        {
            var categories = db.Categories.ToList();
            categories.Insert(0, new Categories { CategoyId = 0, CatogoryName = "Tümü" });
            cmbCategoryFilter.DataSource = categories;
            cmbCategoryFilter.DisplayMember = "CatogoryName";
            cmbCategoryFilter.ValueMember = "CategoyId";
        }

        private void cmbBillsFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMetinFiltre_TextChanged(object sender, EventArgs e)
        {
                var query = from h in db.Bills
                            where h.BillTitle.Contains(txtBillsMetinFiltre.Text) || h.BillPeriod.Contains(txtBillsMetinFiltre.Text)
                            orderby h.BillPeriod descending
                            select new
                            {
                                Ödeme = h.BillTitle,
                                Tarih = h.BillPeriod,
                                Miktar = h.BillAmount
                            };

                dataGridView2.DataSource = query.ToList();
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

        private void button8_Click(object sender, EventArgs e)
        {
                Environment.Exit(0);
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

        private void button6_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Close();
        }
    }
}
