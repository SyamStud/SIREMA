using SIREMA.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIREMA.Interface
{
    public partial class Login : Form
    {
        private User user = new User();

        public Login()
        {
            InitializeComponent();
        }

        private void UsernameTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void usernameTxt_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            if (user.login(usernameTxt.Text, passwordTxt.Text))
            {
                Dashboard dashboard = new Dashboard(usernameTxt.Text);

                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password Salah", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void passwordTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                loginBtn.PerformClick();
            }
        }
    }
}