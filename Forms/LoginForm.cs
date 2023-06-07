using KücükPrens.Business.Concrete;
using KücükPrensEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KücükPrensManagment.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        UserBusiness userBusiness = new UserBusiness();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var db = new DemirbasDbEntities1())
            {
                var user = db.Users.Where(u => u.UserName == txtUserName.Text && u.UserPassword == txtPass.Text).FirstOrDefault();
                if (user != null)
                {
                    MainForm mainMenu = new MainForm();
                    this.Hide();
                    mainMenu.Show();
                }
                else
                {
                    MessageBox.Show("HATA: Kullanıcı Bulunamadı!");
                }
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.Show();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
