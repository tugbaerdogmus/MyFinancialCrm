using MyFinancialCrm.BusinessLayer;
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
    public partial class FrmLogin : Form
    {
        private UserService _userService = new UserService();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName=txtUserName.Text;
            string userPasword=txtUserPassword.Text;

            if (_userService.ValidateUser(userName, userPasword))
            {
                MessageBox.Show("Giriş Başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmDashboard frmDashboard = new FrmDashboard();
                frmDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
