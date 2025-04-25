using System;
using System.Linq;
using System.Windows.Forms;
using MyFinancialCrm.EntityLayer.Models;

namespace MyFinancialCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db=new FinancialCrmDbEntities();
     

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            var ziraatBankBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankBalance).FirstOrDefault();
            var vakifBankBalance = db.Banks.Where(x => x.BankTitle == "Vakıfbank").Select(y => y.BankBalance).FirstOrDefault();
            var isBankBalance = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance).FirstOrDefault();

            lblZiraatBankasiBalance.Text = ziraatBankBalance.ToString() + " ₺";
            lblvakifBankasiBalance.Text = vakifBankBalance.ToString() + " ₺";
            lblisBankasiBalance.Text = isBankBalance.ToString() + " ₺";

            #region Banka hareketleri
            var bankProcess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text = bankProcess1.Description;
            label2.Text = " Ücret:" + bankProcess1.Amount;
            label5.Text = " Tarih:" + bankProcess1.ProcessDate;

            var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = bankProcess2.Description;
            label6.Text = " Ücret:" + bankProcess2.Amount;
            label7.Text = " Tarih:" + bankProcess2.ProcessDate;

            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = bankProcess3.Description;
            label8.Text = " Ücret:" + bankProcess3.Amount;
            label9.Text = " Tarih:" + bankProcess3.ProcessDate;

            var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = bankProcess4.Description;
            label10.Text = " Ücret:" + bankProcess4.Amount;
            label11.Text = " Tarih:" + bankProcess4.ProcessDate;

            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = bankProcess5.Description;
            label16.Text = " Ücret:" + bankProcess5.Amount;
            label17.Text = " Tarih:" + bankProcess5.ProcessDate;
            #endregion
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmBilling frm=new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void frmDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
