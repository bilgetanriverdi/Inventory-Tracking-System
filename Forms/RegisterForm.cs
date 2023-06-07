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
using System.Xml.Linq;

namespace KücükPrensManagment.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        UserBusiness userBusiness = new UserBusiness();
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new DemirbasDbEntities1())
                {

                    userBusiness.Add(new Users
                    {
                        UserName = txtUser.Text,
                        UserPassword = txtPassword.Text

                    });
                    db.SaveChanges();
                    MessageBox.Show("Kayıt Başarılı!");
                    LoginForm loginForm = new LoginForm();
                    this.Hide();
                    loginForm.Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
            }
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }
    }
}
