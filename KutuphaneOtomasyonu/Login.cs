using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu {
    public partial class Login : Form {
        //FIXME 
        // verilerin veri tabanından çekilmesi gerekiyor. geçici olarak dursunlar.
        String USER = "vtys";
        String PASS = "vtys";

        public Login() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (tbMember.Text == USER && tbPassword.Text == PASS) {
                AdminPanel frm = new AdminPanel();
                frm.Show();
                this.Hide();
            } else {
                MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre!", "BİLGİLENDİRME");
            }
        }
    }
}
