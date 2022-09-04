using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullanici.Text == "calisan"&& txtSifre.Text=="123")
            {


                CalisanMenuForm menu = new CalisanMenuForm();
                

                menu.Show();

                this.Hide();

                MessageBox.Show("Giriş başarılı!");


            }
            else if (txtKullanici.Text == "yonetici" && txtSifre.Text == "123")
            {
                MenuForm menu = new MenuForm();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
            }
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
