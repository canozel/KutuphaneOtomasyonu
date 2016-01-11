using System;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu {
    public partial class AdminPanel : Form {
        BooksController books_controller;
        MemberController member_controller;
        DepositController deposit_controller;

        String show = "books";

        public AdminPanel() {
            InitializeComponent();
            books_controller = new BooksController();
            member_controller = new MemberController();
            deposit_controller = new DepositController();

            cbBookLang.Items.Add("Türkçe");
            cbBookLang.Items.Add("İngilizce");

            cbBookAuthor.DisplayMember = "name";
            cbBookAuthor.ValueMember = "id";
            cbBookAuthor.DataSource = books_controller.getAuthors();

            cbBookPublisher.DisplayMember = "name";
            cbBookPublisher.ValueMember = "id";
            cbBookPublisher.DataSource = books_controller.getPubliser();

            cbMemberGender.Items.Add("Erkek");
            cbMemberGender.Items.Add("Kadın");
       }

        // Anasayfaya dönüş.
        private void btnBack_Click(object sender, EventArgs e) {
            FindForm frm = new FindForm();
            frm.Show();
            this.Hide();
        }

        // DataGridView'in yenilenmesini sağlar.
        void reflesh(String getMethod) {
            if (getMethod.Equals("books")){
                show = "books";
                dataGridView.DataSource = books_controller.getBooks();
            }else if (getMethod.Equals("members")){
                show = "members";
                dataGridView.DataSource = member_controller.getMembers();
            }
        }

        // DataGridView'de tıklanılan verileri kutucuklara aktarma.
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (show.Equals("books")) {
                tbBookISBN.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
                tbBookName.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
                dtpBookPublised.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
                tbBookPage.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
                cbBookLang.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
                tbBookDesc.Text = dataGridView.CurrentRow.Cells[7].Value.ToString();
                cbBookAuthor.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
                btnBookEdit.Enabled = true;
                btnBookDelete.Enabled = true;
            } else if (show.Equals("members")) {
                tbMemberFirstName.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
                tbMemberLastName.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
                cbMemberGender.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
                tbMemberPhone.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
                tbMemberTC.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
                tbMemberEmail.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
                tbMemberAdress.Text = dataGridView.CurrentRow.Cells[7].Value.ToString();
                btnMemberEdit.Enabled = true;
                btnMemberDelete.Enabled = true;
            }
        }

        #region Books
        // Yeni kitap ekleme
        private void btnAdd_Click(object sender, EventArgs e) {
            if (tbBookISBN.Text != "" && dtpBookPublised.Text!= "" && tbBookName.Text != "" && tbBookPage.Text != "" && cbBookLang.Text != "" && tbBookDesc.Text != "") {
                books_controller.BookAdd(tbBookISBN.Text, tbBookName.Text, dtpBookPublised.Value.Date.ToString("dd-MM-yyyy"),
                    tbBookPage.Text, cbBookLang.Text, tbBookDesc.Text, cbBookAuthor.SelectedValue.ToString(), cbBookAuthor.SelectedValue.ToString());
                reflesh("books");
            } else {
                MessageBox.Show("Eksik girdiniz!", "BİLGİLENDİRME");
            }
        }

        // Kitap Güncelleme
        private void btnEdit_Click(object sender, EventArgs e) {
            String book_id = dataGridView.CurrentRow.Cells[0].Value.ToString();
            if (tbBookISBN.Text != "" && dtpBookPublised.Text!= "" && tbBookName.Text != "" && tbBookPage.Text != "" && cbBookLang.Text != "" && tbBookDesc.Text != "") {
                if (books_controller.updateBook(book_id, tbBookISBN.Text, tbBookName.Text, dtpBookPublised.Value.Date.ToString("dd-MM-yyyy"),
                    tbBookPage.Text, cbBookLang.Text, tbBookDesc.Text, cbBookPublisher.SelectedValue.ToString(), cbBookAuthor.SelectedValue.ToString()))
                    MessageBox.Show("Başarıyla güncellendi.");
                reflesh("books");
            } else {
                MessageBox.Show("Eksik girdiniz!", "BİLGİLENDİRME");
            }
        }

        // Kitap silme.
        private void btnDelete_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Silmek istediğnize emin misiniz ? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) {
                if (books_controller.deleteBook(dataGridView.CurrentRow.Cells[0].Value.ToString()))
                    MessageBox.Show("Başarıyla silindi.");
                reflesh("books");
            }
        }

        // Kitapları listeleme
        private void btnBookList_Click(object sender, EventArgs e) {
            reflesh("books");
        }
        #endregion

        #region Members
        // Yeni üye ekleme.
        private void btnMemberAdd_Click(object sender, EventArgs e) {
            if (tbMemberFirstName.Text != "" && tbMemberLastName.Text!= "" && cbMemberGender.Text != "" && tbMemberTC.Text != "" && tbMemberPhone.Text != "" 
                && tbMemberEmail.Text != "" && tbMemberAdress.Text != "") {
                    member_controller.memberAdd(tbMemberFirstName.Text, tbMemberLastName.Text, cbMemberGender.Text,
                    tbMemberTC.Text, tbMemberPhone.Text, tbMemberEmail.Text, tbMemberAdress.Text);
                reflesh("members");
            } else {
                MessageBox.Show("Eksik girdiniz!", "BİLGİLENDİRME");
            }
        }

        // Üye güncelleme
        private void btnMemberEdit_Click(object sender, EventArgs e) {
            String member_id = dataGridView.CurrentRow.Cells[0].Value.ToString();
            if (tbMemberFirstName.Text != "" && tbMemberLastName.Text!= "" && cbMemberGender.Text != "" && tbMemberTC.Text != "" && tbMemberPhone.Text != "" 
                && tbMemberEmail.Text != "" && tbMemberAdress.Text != "") {
                if (member_controller.updateMember(member_id, tbMemberFirstName.Text, tbMemberLastName.Text, cbMemberGender.Text, tbMemberPhone.Text, tbMemberTC.Text,
                    tbMemberEmail.Text, tbMemberAdress.Text))
                    MessageBox.Show("Başarıyla güncellendi.");
                reflesh("members");
            } else {
                MessageBox.Show("Eksik girdiniz!", "BİLGİLENDİRME");
            }
        }

        // Üye silme
        private void btnMemberDelete_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Silmek istediğnize emin misiniz ? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) {
                if (member_controller.deleteMember(dataGridView.CurrentRow.Cells[0].Value.ToString()))
                    MessageBox.Show("Başarıyla silindi.");
                reflesh("members");
            }
        }

        // Üye listeleme
        private void btnMemberList_Click(object sender, EventArgs e) {
            reflesh("members");
        }
        #endregion

        #region Deposit
        private String selectedBookID;
        private String selectedMemberID;

        // Kitap Ara
        private void btnFindBook_Click(object sender, EventArgs e) {
           show = "books";
           dataGridView.DataSource = books_controller.BookFind(tbFindBook.Text);
        }

        // Üye Ara
        private void btnFindMember_Click(object sender, EventArgs e) {
            show = "members";
            dataGridView.DataSource = member_controller.memberFind(tbFindMember.Text);
        }

        // Tablodan kitap seç
        private void btnSelectBook_Click(object sender, EventArgs e) {
            selectedBookID = dataGridView.CurrentRow.Cells[0].Value.ToString();
            tbDepositBookName.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
        }

        // Tablodan üye seç
        private void btnSelectMember_Click(object sender, EventArgs e) {
            selectedMemberID = dataGridView.CurrentRow.Cells[0].Value.ToString();
            tbDepositMemberName.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
        }

        // Emanet ver.
        private void btnDeposit_Click(object sender, EventArgs e) {
            deposit_controller.addDeposit(selectedMemberID, selectedBookID, dtpDepositDate.Value.Date.ToString("dd-MM-yyyy"));
            dataGridView.DataSource =  deposit_controller.getDeposits();
            show = "deposit";
        }

        // Emanetleri listele
        private void btnListDeposit_Click(object sender, EventArgs e) {
            dataGridView.DataSource =  deposit_controller.getDeposits();
            show = "deposit";
        }
        
        #endregion
    }
}
