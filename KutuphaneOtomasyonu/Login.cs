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
        MemberController member_controller;

        public Login() {
            InitializeComponent();
            member_controller = new MemberController();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (member_controller.passwordControl(tbMember.Text, tbPassword.Text)) {
                AdminPanel frm = new AdminPanel();
                frm.Show();
                this.Hide();
            } else {
                MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre!", "BİLGİLENDİRME");
            }
        }
    }
}
