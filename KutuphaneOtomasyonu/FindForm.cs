using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class FindForm : Form
    {
        BooksController books_controller;
        public FindForm()
        {
            InitializeComponent();
            books_controller = new BooksController();
            dataFindScreen.DataSource = books_controller.getBooks();
        }

        private void btnFind_Click(object sender, EventArgs e) {
            dataFindScreen.DataSource = books_controller.BookFind(tbFind.Text);
        }

        private void btnAdmin_Click(object sender, EventArgs e) {
                Login frm = new Login();
                frm.Show();
                this.Hide();
        }
    }
}
