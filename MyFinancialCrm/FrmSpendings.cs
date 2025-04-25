using MyFinancialCrm.BusinessLayer.Concrete;
using MyFinancialCrm.DataAccessLayer.EntityFramework;
using MyFinancialCrm.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFinancialCrm
{
    public partial class FrmSpendings : Form
    {
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        string conString;
        private readonly SpendingManager _spendingManager = new SpendingManager(new EfSpendingDal());
        private readonly CategoriesManager _categoryManager = new CategoriesManager(new EfCategoriesDal());


        public FrmSpendings()
        {
            InitializeComponent();
            db = new FinancialCrmDbEntities();
            conString = db.Database.Connection.ConnectionString;
        }
        void CategoryList()
        {
            cmbCategory.DataSource = _categoryManager.TGetAll();
            cmbCategory.DisplayMember = "CatogoryName";
            cmbCategory.ValueMember = "CategoyId";
        }
        void SpendingList()
        {
            var values = _spendingManager.GetSpendingListWithCategory()
                .Select(s => new
                {
                    s.SpendingId,
                    s.CategoryId,
                    s.SpendingDate,
                    s.SpendingAmount,
                    s.SpendingTitle,
                    CategoryName = s.Categories != null ? s.Categories.CatogoryName : "Kategori Yok"
                }).ToList();

            dataGridView1.DataSource = values;
        }
     
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedValue != null && int.TryParse(cmbCategory.SelectedValue.ToString(), out int selectedCategoryId))
            {
                FilterSpendingsByCategory(selectedCategoryId);
            }
        }
        void FilterSpendingsByCategory(int categoryId)
        {
            var filtered = _spendingManager.GetSpendingListWithCategory()
                .Where(s => s.CategoryId == categoryId)
                .Select(s => new
                {
                    s.SpendingId,
                    s.CategoryId,
                    s.SpendingDate,
                    s.SpendingAmount,
                    s.SpendingTitle,
                    CategoryName = s.Categories != null ? s.Categories.CatogoryName : "Kategori Yok"
                })
                .ToList();

            dataGridView1.DataSource = filtered;
        }
        private void FrmSpendings_Load(object sender, EventArgs e)
        {

            SpendingList();
            CategoryList();
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;

        }

        private void btnOdemeList_Click(object sender, EventArgs e)
        {
            SpendingList();
        }

        private void btnYeniOdeme_Click(object sender, EventArgs e)
        {
            //if (cmbCategory.SelectedValue == null)
            //{
            //    MessageBox.Show("Lütfen bir kategori seçin!");
            //    return;
            //}
            //int secilenKategoriID = Convert.ToInt32(cmbCategory.SelectedValue);

            //string title = txtHarcamaBaslik.Text;
            //decimal amount = decimal.Parse(txtHarcamaMiktar.Text);
            //DateTime tarih = new DateTime();
            //tarih = DateTime.Parse(txtTarih.Text);


            //Spendings sp = new Spendings();
            //sp.SpendingTitle= title;
            //sp.SpendingAmount= amount;
            //sp.SpendingDate = tarih;
            //sp.CategoryId = secilenKategoriID;
            //db.Spendings.Add(sp);
            //db.SaveChanges();
            //MessageBox.Show("Harcama Başarılı Bir Şekilde Eklendi", "Ödeme & Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //SpendingList();

            Spendings sp = new Spendings
            {
                SpendingTitle = txtHarcamaBaslik.Text,
                SpendingAmount = decimal.Parse(txtHarcamaMiktar.Text),
                SpendingDate = DateTime.Parse(txtTarih.Text),
                CategoryId = Convert.ToInt32(cmbCategory.SelectedValue)
            };

            _spendingManager.TInsert(sp);
            MessageBox.Show("Harcama eklendi.");
            SpendingList();
        }

        private void btnOdemeSil_Click(object sender, EventArgs e)
        {
            //int id = int.Parse(txtHarcamaId.Text);
            //var removeValue = db.Spendings.Find(id);
            //db.Spendings.Remove(removeValue);
            //db.SaveChanges();
            //MessageBox.Show("Harcama Başarılı Bir Şekilde Silindi", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //SpendingList();

            int id = int.Parse(txtHarcamaId.Text);
            var entity = _spendingManager.TGetById(id);
            _spendingManager.TDelete(id);
            MessageBox.Show("Harcama Başarılı Bir Şekilde Silindi", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SpendingList();
        }

        private void btnGuncelleme_Click(object sender, EventArgs e)
        {
            //if (cmbCategory.SelectedValue == null)
            //{
            //    MessageBox.Show("Lütfen bir kategori seçin!");
            //    return;
            //}
            //int secilenKategoriID = Convert.ToInt32(cmbCategory.SelectedValue);
            //string title = txtHarcamaBaslik.Text;
            //int id = int.Parse(txtHarcamaId.Text);
            //decimal amount = decimal.Parse(txtHarcamaMiktar.Text);
            //DateTime tarih = new DateTime();
            //tarih = DateTime.Parse(txtTarih.Text);


            //var values = db.Spendings.Find(id);

            //values.SpendingTitle = title;
            //values.SpendingDate = tarih;
            //values.SpendingAmount = amount;
            //values.CategoryId = secilenKategoriID;

            //db.SaveChanges();
            //MessageBox.Show("Harcama Başarılı Bir Şekilde Güncellendi", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //SpendingList();

            int id = int.Parse(txtHarcamaId.Text);
            var sp = _spendingManager.TGetById(id);
            sp.SpendingTitle = txtHarcamaBaslik.Text;
            sp.SpendingAmount = decimal.Parse(txtHarcamaMiktar.Text);
            sp.SpendingDate = DateTime.Parse(txtTarih.Text);
            sp.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue);

            _spendingManager.TUpdate(sp);
            MessageBox.Show("Harcama Başarılı Bir Şekilde Güncellendi", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SpendingList();
        }
        #region butonlar
        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();
        }

        private void btnBankForm_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
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

        private void button7_Click(object sender, EventArgs e)
        {
            FrmSettings frm=new FrmSettings();
            frm.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmBankTransactions frm = new FrmBankTransactions();
            frm.Show();
            this.Hide();
        }
        #endregion

        #region önceki kodlar
        //void SpendingList1()
        //{
        //    try
        //    {
        //        var values = db.Spendings
        //   //.Include(s => s.Categories)
        //   .Select(s => new
        //   {
        //       s.SpendingId,
        //       s.CategoryId,
        //       s.SpendingDate,
        //       s.SpendingAmount,
        //       s.SpendingTitle,
        //       CategoryName = s.Categories != null ? s.Categories.CatogoryName : "Kategori Yok"
        //   })
        //   .ToList();

        //        dataGridView1.DataSource = values;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Veri çekme hatası: " + ex.Message);
        //    }
        //}

        //void CategoryList1()
        //{
        //    try
        //    {
        //        using (FinancialCrmDbEntities db = new FinancialCrmDbEntities())
        //        {
        //            var kategoriler = db.Categories
        //                                .Select(k => new { k.CategoyId, k.CatogoryName })
        //                                .ToList();

        //            cmbCategory.DataSource = kategoriler;
        //            cmbCategory.DisplayMember = "CatogoryName";
        //            cmbCategory.ValueMember = "CategoyId";
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Veri çekme hatası: " + ex.Message);
        //    }
        //}

        #endregion
    }
}
