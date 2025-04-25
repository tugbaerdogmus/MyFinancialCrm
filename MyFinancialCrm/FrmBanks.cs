using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MyFinancialCrm.BusinessLayer.Abstract;
using MyFinancialCrm.BusinessLayer.Concrete;
using MyFinancialCrm.DataAccessLayer.EntityFramework;
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
        private BankManager _bankManager = new BankManager(new EfBankDal());
        private readonly BankProcessManager _processManager = new BankProcessManager(new EfBankProcessDal());
        private readonly IBankProcessService _processService = new BankProcessManager(new EfBankProcessDal());


        private void FrmBanks_Load(object sender, EventArgs e)
        {
            //var ziraatBankBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankBalance).FirstOrDefault();


            var ziraatBankBalance = _bankManager.TGetBankL("Ziraat Bankası").FirstOrDefault();
            if (ziraatBankBalance != null)
            {
                lblZiraatBankasiBalance.Text = $"{ziraatBankBalance.BankBalance} ₺";
            }
            var vakifBankBalance = _bankManager.TGetBankL("Vakıfbank").FirstOrDefault();
            if (vakifBankBalance != null)
            {
                lblvakifBankasiBalance.Text = $"{vakifBankBalance.BankBalance} ₺";
            }
            var isBankBalance = _bankManager.TGetBankL("İş Bankası").FirstOrDefault();
            if (isBankBalance != null)
            {
                lblisBankasiBalance.Text = $"{isBankBalance.BankBalance} ₺";
            }


            #region Banka hareketleri
            //var bankProcess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            //lblBankProcess1.Text = bankProcess1.Description;
            //label2.Text = " Ücret:" + bankProcess1.Amount;
            //label5.Text = " Tarih:" + bankProcess1.ProcessDate;


            var latestProcesses = _processService.GetProcessListWithBank().Take(5).ToList();

            List<Label> descLabels = new List<Label> { lblBankProcess1, lblBankProcess2, lblBankProcess3, lblBankProcess4, lblBankProcess5 };
            List<Label> amountLabels = new List<Label> { label2, label6, label8, label10, label16 };
            List<Label> dateLabels = new List<Label> { label5, label7, label9, label11, label17 };

            for (int i = 0; i < latestProcesses.Count; i++)
            {
                descLabels[i].Text = $"{latestProcesses[i].Banks.BankTitle} / {latestProcesses[i].Description}";
                amountLabels[i].Text = " Ücret: " + latestProcesses[i].Amount?.ToString("C2");
                dateLabels[i].Text = " Tarih: " + latestProcesses[i].ProcessDate?.ToShortDateString();
            }
            #endregion
        }

        #region butonlar 
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
        #endregion
    }
}
