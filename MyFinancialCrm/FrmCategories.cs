using MyFinancialCrm.BusinessLayer.Concrete;
using MyFinancialCrm.DataAccessLayer.EntityFramework;
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
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private CategoriesManager _catManager = new CategoriesManager(new EfCategoriesDal());

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            var values = _catManager.TGetAll();
            dataGridView1.DataSource = values;
        }
        private void btnOdemeList_Click(object sender, EventArgs e)
        {
            var values = _catManager.TGetAll();
            dataGridView1.DataSource = values;
        }

        private void btnYeniOdeme_Click(object sender, EventArgs e)
        {
            //string title = txtKategoriBaslik.Text;

            //Categories ctr = new Categories();
            //ctr.CatogoryName = title;

            //db.Categories.Add(ctr);
            //db.SaveChanges();
            //MessageBox.Show("Kategori Başarılı Bir Şekilde Eklendi", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //var values = db.Categories.ToList();
            //dataGridView1.DataSource = values;

            ////
            string title = txtKategoriBaslik.Text;

            Categories newCategory = new Categories
            {
                CatogoryName = title
            };

            _catManager.TInsert(newCategory);

            MessageBox.Show("Kategori Başarılı Bir Şekilde Eklendi", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Listeyi yenile
            var values = _catManager.TGetAll();
            dataGridView1.DataSource = values;
        }

        private void btnOdemeSil_Click(object sender, EventArgs e)
        {
            //int id = int.Parse(txtKategoriId.Text);
            //var removeValue = db.Categories.Find(id);
            //db.Categories.Remove(removeValue);
            //db.SaveChanges();
            //MessageBox.Show("Kategori Başarılı Bir Şekilde Silindi", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //var values = db.Categories.ToList();
            //dataGridView1.DataSource = values;

            if (int.TryParse(txtKategoriId.Text, out int id))
            {
                _catManager.TDelete(id); // sadece ID gönderiyorsun

                MessageBox.Show("Kategori Başarılı Bir Şekilde Silindi", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var values = _catManager.TGetAll(); // doğrudan Business Layer'dan çekiyoruz
                dataGridView1.DataSource = values;
            }
            else
            {
                MessageBox.Show("Geçerli bir Kategori ID giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelleme_Click(object sender, EventArgs e)
        {
            //string title = txtKategoriBaslik.Text;
            //int id = int.Parse(txtKategoriId.Text);

            //var values = db.Categories.Find(id);

            //values.CatogoryName = title;
            //db.SaveChanges();
            //MessageBox.Show("Kategori Başarılı Bir Şekilde Güncellendi", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //var values2 = db.Categories.ToList();
            //dataGridView1.DataSource = values2;

            if (int.TryParse(txtKategoriId.Text, out int id))
            {
                Categories category = new Categories()
                {
                    CategoyId = id,
                    CatogoryName = txtKategoriBaslik.Text
                };

                _catManager.TUpdate(category);

                MessageBox.Show("Kategori güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var values = _catManager.TGetAll();
                dataGridView1.DataSource = values;
            }
            else
            {
                MessageBox.Show("Geçerli bir ID giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBankForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnBilssForm_Click(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
