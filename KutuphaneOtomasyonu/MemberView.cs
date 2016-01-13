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
    public partial class MemberView : Form {
        MemberController member_controller;

        public MemberView() {
            InitializeComponent();
            member_controller = new MemberController();

            cbMemberGender.Items.Add("Erkek");
            cbMemberGender.Items.Add("Kadın");

            lblMemberName.Text = "Giriş yapan: " + MemberController.current_user["first_name"];
        }

        public void reflesh() {
            dataGridView.DataSource = member_controller.getMembers();
            dataGridView.Columns["password"].Visible = false;
        }

        // Üye ekleme
        private void btnMemberAdd_Click(object sender, EventArgs e) {
            if (tbMemberFirstName.Text != "" && tbMemberLastName.Text!= "" && cbMemberGender.Text != "" && tbMemberTC.Text != "" && tbMemberPhone.Text != "" 
                && tbMemberEmail.Text != "" && tbMemberAdress.Text != "") {
                    member_controller.memberAdd(tbMemberFirstName.Text, tbMemberLastName.Text, cbMemberGender.Text, tbMemberTC.Text, tbMemberPhone.Text,
                tbMemberEmail.Text, tbMemberAdress.Text);
                    reflesh();
            } else {
                MessageBox.Show("Eksik girdiniz!", "BİLGİLENDİRME");
            }
        }

        // Üye Güncelleme
        private void btnMemberEdit_Click(object sender, EventArgs e) {
            String member_id = dataGridView.CurrentRow.Cells[0].Value.ToString();
            if (tbMemberFirstName.Text != "" && tbMemberLastName.Text!= "" && cbMemberGender.Text != "" && tbMemberTC.Text != "" && tbMemberPhone.Text != "" 
                && tbMemberEmail.Text != "" && tbMemberAdress.Text != "") {
                if (member_controller.updateMember(member_id, tbMemberFirstName.Text, tbMemberLastName.Text, cbMemberGender.Text, tbMemberPhone.Text, tbMemberTC.Text,
                    tbMemberEmail.Text, tbMemberAdress.Text))
                    MessageBox.Show("Başarıyla güncellendi.");
                reflesh();
            } else {
                MessageBox.Show("Eksik girdiniz!", "BİLGİLENDİRME");
            }
        }

        // Üye Silme
        private void btnMemberDelete_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Silmek istediğnize emin misiniz ? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) {
                if (member_controller.deleteMember(dataGridView.CurrentRow.Cells[0].Value.ToString()))
                    MessageBox.Show("Başarıyla silindi.");
                reflesh();
            }
        }

        // Listeleme
        private void btnMemberList_Click(object sender, EventArgs e) {
            reflesh();
        }

        // Companentleri temizleme
        private void btnClear_Click(object sender, EventArgs e) {
            tbMemberFirstName.Clear();
            tbMemberLastName.Clear();
            tbMemberTC.Clear();
            tbMemberPhone.Clear();
            tbMemberEmail.Clear();
            tbMemberAdress.Clear();
        }

        // Şifre Değiştirme
        private void btnChangePass_Click(object sender, EventArgs e) {
            if (tbNewPass.Text.Equals(tbNewPassAgain.Text) && member_controller.passwordControl(MemberController.current_user["TC"], tbOldPass.Text))
                if (member_controller.updatePassword(tbNewPass.Text))
                    MessageBox.Show("Başarıyla Güncelledi", "Bilgilendirme");
                else
                    MessageBox.Show("Bir Hata ile Karşılaşıldı", "Uyarı!");
        }

        private void MemberView_Load(object sender, EventArgs e) {
            AdminPanel frm = new AdminPanel();
            frm.Show();
            this.Hide();
        }
    }
}
