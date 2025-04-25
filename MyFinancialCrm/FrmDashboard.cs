using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinancialCrm.BusinessLayer.Abstract;
using MyFinancialCrm.BusinessLayer.Concrete;
using MyFinancialCrm.DataAccessLayer.EntityFramework;
using MyFinancialCrm.EntityLayer.Models;

namespace MyFinancialCrm
{
    public partial class FrmDashboard : Form
    {
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        int count = 0;
        private BankManager _bankManager = new BankManager(new EfBankDal());
        private readonly IBankService _bankService = new BankManager(new EfBankDal());


        public FrmDashboard()
        {
            InitializeComponent();
            _bankService = new BankManager(new EfBankDal());
        }



        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            lblTotalBalance.Text = _bankService.GetTotalBankBalance().ToString();

            // Son banka işlemi
            lbGelenHavaleBalance.Text = _bankService.GetLastBankProcessAmount().ToString();
            lblHavaleKisi.Text = _bankService.GetLastBankProcessDate()?.ToString() ?? "Yok";

            // Chart1: Bankalar
            chart1.Series.Clear();
            var series1 = chart1.Series.Add("Banka Bakiyeleri");
            var bankChartData = _bankService.GetBankChartData();
            foreach (var (title, balance) in bankChartData)
            {
                series1.Points.AddXY(title, balance);
            }

            // Chart2: Faturalar
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Faturalar");
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            var billChartData = _bankService.GetBillChartData();
            foreach (var (title, amount) in billChartData)
            {
                series2.Points.AddXY(title, amount);
            }
            #region önceki kodlar
            //var lastBankProcessAmount = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).Select(y => y.Amount).FirstOrDefault();
            //var lastBankProcessDate = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).Select(y => y.ProcessDate).FirstOrDefault();
            //lbGelenHavaleBalance.Text= lastBankProcessAmount.ToString();
            //lblHavaleKisi.Text= lastBankProcessDate.ToString();

            //#region Chart1
            //var bankData = db.Banks.Select(x => new
            //{
            //    x.BankTitle,
            //    x.BankBalance
            //}).ToList();
            //chart1.Series.Clear();
            //var series = chart1.Series.Add("Series1");
            //foreach(var item in bankData)
            //{
            //    series.Points.AddXY(item.BankTitle, item.BankBalance);
            //}
            //#endregion

            //#region Chart2
            //var billData = db.Bills.Select(x => new
            //{
            //    x.BillTitle,
            //    x.BillAmount
            //}).ToList();
            //chart2.Series.Clear();
            //var series2 = chart2.Series.Add("Faturalar");
            //series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            //foreach (var item in billData)
            //{
            //    series2.Points.AddXY(item.BillTitle, item.BillAmount);
            //}
            //#endregion
            //#region Chart3
            //#endregion
            #endregion
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if(count % 4 == 1)
            {
                var elektirikFaturasi = db.Bills.Where(x => x.BillTitle == "Elektirik Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Elektirik Faturası";
                lblBillAmount.Text = elektirikFaturasi.ToString() +" ₺";
            }
            if (count % 4 == 2)
            {
                var doğalFaturasi = db.Bills.Where(x => x.BillTitle == "Doğalgaz Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Doğalgaz Faturası";
                lblBillAmount.Text = doğalFaturasi.ToString() + " ₺";
            }
            if (count % 4 == 3)
            {
                var suFaturasi = db.Bills.Where(x => x.BillTitle == "Su Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Su Faturası";
                lblBillAmount.Text = suFaturasi.ToString() + " ₺";
            }
            if (count % 4 == 0)
            {
                var internetFaturasi = db.Bills.Where(x => x.BillTitle == "İnternet Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "İnternet Faturası";
                lblBillAmount.Text = internetFaturasi.ToString() + " ₺";
            }
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        #region butonlar
        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
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

        private void button8_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Close();
        }
        private void btnBankForm_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
