using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace KutuphaneOtomasyonu {
    public partial class AdminPanel : Form {
        BooksController books_controller;
        DepositController deposit_controller;
        MemberController member_controller;

        public AdminPanel() {
            InitializeComponent();
            books_controller = new BooksController();
            deposit_controller = new DepositController();
            member_controller = new MemberController();

            cbBookLang.Items.Add("Türkçe");
            cbBookLang.Items.Add("İngilizce");

            cbBookAuthor.DisplayMember = "name";
            cbBookAuthor.ValueMember = "id";
            cbBookAuthor.DataSource = books_controller.getAuthors();

            cbBookPublisher.DisplayMember = "name";
            cbBookPublisher.ValueMember = "id";
            cbBookPublisher.DataSource = books_controller.getPubliser();


       }

        // Anasayfaya dönüş.
        private void btnBack_Click(object sender, EventArgs e) {
            FindForm frm = new FindForm();
            frm.Show();
            this.Hide();
        }

        // DataGridView'in yenilenmesini sağlar.
        void reflesh(String getMethod) {
             dataGridView.DataSource = books_controller.getBooks();
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

        private void btnClear_Click(object sender, EventArgs e) {
            tbBookName.Clear();
            tbBookISBN.Clear();
            tbBookPage.Clear();
            tbBookDesc.Clear();
        }

        // DataGridView'de tıklanılan verileri kutucuklara aktarma.
        private void btnSelected_Click(object sender, EventArgs e) {
            tbBookISBN.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            tbBookName.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            dtpBookPublised.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
            tbBookPage.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            cbBookLang.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            tbBookDesc.Text = dataGridView.CurrentRow.Cells[7].Value.ToString();
            cbBookAuthor.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            btnBookEdit.Enabled = true;
            btnBookDelete.Enabled = true;
        }

        #endregion

        #region Deposit
        private String selectedBookID;
        private String selectedMemberID;

        // Kitap Ara
        private void btnFindBook_Click(object sender, EventArgs e) {
           dataGridView.DataSource = books_controller.BookFind(tbFindBook.Text);
        }

        // Üye Ara
        private void btnFindMember_Click(object sender, EventArgs e) {
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
        }

        // Emanetleri listele
        private void btnListDeposit_Click(object sender, EventArgs e) {
            dataGridView.DataSource =  deposit_controller.getDeposits();
        }

        // Compenetleri temizle
        private void button4_Click(object sender, EventArgs e) {
            tbDepositBookName.Clear();
            tbDepositMemberName.Clear();
            tbFindBook.Clear();
            tbFindMember.Clear();
        }
        
        #endregion

        private void btnBack_Click_1(object sender, EventArgs e) {
            FindForm frm = new FindForm();
            frm.Show();
            this.Hide();
        }

        private void btnGoMember_Click(object sender, EventArgs e) {
            MemberView frm = new MemberView();
            frm.Show();
            this.Hide();
        }

        private void btnExcel_Click(object sender, EventArgs e) {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet) workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dataGridView.Columns.Count; j++) {
                Range myRange = (Range) sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dataGridView.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dataGridView.Rows.Count; i++) {
                for (int j = 0; j < dataGridView.Columns.Count; j++) {

                    Range myRange = (Range) sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dataGridView[j, i].Value == null ? "" : dataGridView[j, i].Value;
                    myRange.Select();
                }
            }
        }

        private void btnOverdue_Click(object sender, EventArgs e) {
            dataGridView.DataSource = deposit_controller.getOverdueBooks();
        }
    }
}
