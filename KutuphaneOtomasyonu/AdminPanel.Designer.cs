namespace KutuphaneOtomasyonu {
    partial class AdminPanel {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.gbBook = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSelected = new System.Windows.Forms.Button();
            this.btnBookList = new System.Windows.Forms.Button();
            this.btnBookDelete = new System.Windows.Forms.Button();
            this.btnBookEdit = new System.Windows.Forms.Button();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.tbBookDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.lblLang = new System.Windows.Forms.Label();
            this.cbBookLang = new System.Windows.Forms.ComboBox();
            this.lblPublised = new System.Windows.Forms.Label();
            this.dtpBookPublised = new System.Windows.Forms.DateTimePicker();
            this.lblPubliser = new System.Windows.Forms.Label();
            this.cbBookPublisher = new System.Windows.Forms.ComboBox();
            this.cbBookAuthor = new System.Windows.Forms.ComboBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.tbBookPage = new System.Windows.Forms.TextBox();
            this.tbBookISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.gbDeposit = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnOverdue = new System.Windows.Forms.Button();
            this.btnListDeposit = new System.Windows.Forms.Button();
            this.btnSelectMember = new System.Windows.Forms.Button();
            this.btnSelectBook = new System.Windows.Forms.Button();
            this.dtpDepositDate = new System.Windows.Forms.DateTimePicker();
            this.btnFindMember = new System.Windows.Forms.Button();
            this.btnFindBook = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.tbDepositMemberName = new System.Windows.Forms.TextBox();
            this.tbDepositBookName = new System.Windows.Forms.TextBox();
            this.tbFindMember = new System.Windows.Forms.TextBox();
            this.tbFindBook = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGoMember = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.gbBook.SuspendLayout();
            this.gbDeposit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(0, 436);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(989, 243);
            this.dataGridView.TabIndex = 0;
            // 
            // gbBook
            // 
            this.gbBook.Controls.Add(this.btnClear);
            this.gbBook.Controls.Add(this.btnSelected);
            this.gbBook.Controls.Add(this.btnBookList);
            this.gbBook.Controls.Add(this.btnBookDelete);
            this.gbBook.Controls.Add(this.btnBookEdit);
            this.gbBook.Controls.Add(this.btnBookAdd);
            this.gbBook.Controls.Add(this.tbBookDesc);
            this.gbBook.Controls.Add(this.lblDesc);
            this.gbBook.Controls.Add(this.lblPage);
            this.gbBook.Controls.Add(this.lblLang);
            this.gbBook.Controls.Add(this.cbBookLang);
            this.gbBook.Controls.Add(this.lblPublised);
            this.gbBook.Controls.Add(this.dtpBookPublised);
            this.gbBook.Controls.Add(this.lblPubliser);
            this.gbBook.Controls.Add(this.cbBookPublisher);
            this.gbBook.Controls.Add(this.cbBookAuthor);
            this.gbBook.Controls.Add(this.lblAuthor);
            this.gbBook.Controls.Add(this.tbBookPage);
            this.gbBook.Controls.Add(this.tbBookISBN);
            this.gbBook.Controls.Add(this.lblISBN);
            this.gbBook.Controls.Add(this.lblName);
            this.gbBook.Controls.Add(this.tbBookName);
            this.gbBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbBook.Location = new System.Drawing.Point(0, 0);
            this.gbBook.Name = "gbBook";
            this.gbBook.Size = new System.Drawing.Size(446, 436);
            this.gbBook.TabIndex = 1;
            this.gbBook.TabStop = false;
            this.gbBook.Text = "Kitaplar";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(294, 360);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 23);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSelected
            // 
            this.btnSelected.Location = new System.Drawing.Point(177, 360);
            this.btnSelected.Name = "btnSelected";
            this.btnSelected.Size = new System.Drawing.Size(111, 23);
            this.btnSelected.TabIndex = 36;
            this.btnSelected.Text = "Seçileni Aktar";
            this.btnSelected.UseVisualStyleBackColor = true;
            this.btnSelected.Click += new System.EventHandler(this.btnSelected_Click);
            // 
            // btnBookList
            // 
            this.btnBookList.Location = new System.Drawing.Point(73, 360);
            this.btnBookList.Name = "btnBookList";
            this.btnBookList.Size = new System.Drawing.Size(98, 23);
            this.btnBookList.TabIndex = 35;
            this.btnBookList.Text = "Listele";
            this.btnBookList.UseVisualStyleBackColor = true;
            this.btnBookList.Click += new System.EventHandler(this.btnBookList_Click);
            // 
            // btnBookDelete
            // 
            this.btnBookDelete.Enabled = false;
            this.btnBookDelete.Location = new System.Drawing.Point(294, 389);
            this.btnBookDelete.Name = "btnBookDelete";
            this.btnBookDelete.Size = new System.Drawing.Size(79, 23);
            this.btnBookDelete.TabIndex = 34;
            this.btnBookDelete.Text = "Sil";
            this.btnBookDelete.UseVisualStyleBackColor = true;
            this.btnBookDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBookEdit
            // 
            this.btnBookEdit.Enabled = false;
            this.btnBookEdit.Location = new System.Drawing.Point(177, 389);
            this.btnBookEdit.Name = "btnBookEdit";
            this.btnBookEdit.Size = new System.Drawing.Size(111, 23);
            this.btnBookEdit.TabIndex = 33;
            this.btnBookEdit.Text = "Düzenle";
            this.btnBookEdit.UseVisualStyleBackColor = true;
            this.btnBookEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.Location = new System.Drawing.Point(73, 389);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(98, 23);
            this.btnBookAdd.TabIndex = 32;
            this.btnBookAdd.Text = "Ekle";
            this.btnBookAdd.UseVisualStyleBackColor = true;
            this.btnBookAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbBookDesc
            // 
            this.tbBookDesc.Location = new System.Drawing.Point(140, 273);
            this.tbBookDesc.Multiline = true;
            this.tbBookDesc.Name = "tbBookDesc";
            this.tbBookDesc.Size = new System.Drawing.Size(233, 77);
            this.tbBookDesc.TabIndex = 31;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(70, 276);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(50, 13);
            this.lblDesc.TabIndex = 30;
            this.lblDesc.Text = "Açıklama";
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(262, 235);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(64, 13);
            this.lblPage.TabIndex = 29;
            this.lblPage.Text = "Sayfa Sayısı";
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Location = new System.Drawing.Point(70, 235);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(19, 13);
            this.lblLang.TabIndex = 28;
            this.lblLang.Text = "Dil";
            // 
            // cbBookLang
            // 
            this.cbBookLang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBookLang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBookLang.FormattingEnabled = true;
            this.cbBookLang.Location = new System.Drawing.Point(140, 231);
            this.cbBookLang.Name = "cbBookLang";
            this.cbBookLang.Size = new System.Drawing.Size(116, 21);
            this.cbBookLang.TabIndex = 27;
            // 
            // lblPublised
            // 
            this.lblPublised.AutoSize = true;
            this.lblPublised.Location = new System.Drawing.Point(68, 193);
            this.lblPublised.Name = "lblPublised";
            this.lblPublised.Size = new System.Drawing.Size(64, 13);
            this.lblPublised.TabIndex = 26;
            this.lblPublised.Text = "Yayım Tarihi";
            // 
            // dtpBookPublised
            // 
            this.dtpBookPublised.Location = new System.Drawing.Point(140, 193);
            this.dtpBookPublised.Name = "dtpBookPublised";
            this.dtpBookPublised.Size = new System.Drawing.Size(233, 20);
            this.dtpBookPublised.TabIndex = 25;
            // 
            // lblPubliser
            // 
            this.lblPubliser.AutoSize = true;
            this.lblPubliser.Location = new System.Drawing.Point(68, 153);
            this.lblPubliser.Name = "lblPubliser";
            this.lblPubliser.Size = new System.Drawing.Size(51, 13);
            this.lblPubliser.TabIndex = 24;
            this.lblPubliser.Text = "Yayın Evi";
            // 
            // cbBookPublisher
            // 
            this.cbBookPublisher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBookPublisher.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBookPublisher.FormattingEnabled = true;
            this.cbBookPublisher.Location = new System.Drawing.Point(140, 150);
            this.cbBookPublisher.Name = "cbBookPublisher";
            this.cbBookPublisher.Size = new System.Drawing.Size(233, 21);
            this.cbBookPublisher.TabIndex = 23;
            // 
            // cbBookAuthor
            // 
            this.cbBookAuthor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBookAuthor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBookAuthor.FormattingEnabled = true;
            this.cbBookAuthor.Location = new System.Drawing.Point(140, 111);
            this.cbBookAuthor.Name = "cbBookAuthor";
            this.cbBookAuthor.Size = new System.Drawing.Size(233, 21);
            this.cbBookAuthor.TabIndex = 22;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(68, 114);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(34, 13);
            this.lblAuthor.TabIndex = 21;
            this.lblAuthor.Text = "Yazar";
            // 
            // tbBookPage
            // 
            this.tbBookPage.Location = new System.Drawing.Point(332, 232);
            this.tbBookPage.Name = "tbBookPage";
            this.tbBookPage.Size = new System.Drawing.Size(41, 20);
            this.tbBookPage.TabIndex = 20;
            // 
            // tbBookISBN
            // 
            this.tbBookISBN.Location = new System.Drawing.Point(140, 68);
            this.tbBookISBN.Name = "tbBookISBN";
            this.tbBookISBN.Size = new System.Drawing.Size(233, 20);
            this.tbBookISBN.TabIndex = 19;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(68, 71);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 18;
            this.lblISBN.Text = "ISBN";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(70, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 13);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Kitap Adı";
            // 
            // tbBookName
            // 
            this.tbBookName.Location = new System.Drawing.Point(140, 28);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(233, 20);
            this.tbBookName.TabIndex = 16;
            // 
            // gbDeposit
            // 
            this.gbDeposit.Controls.Add(this.button4);
            this.gbDeposit.Controls.Add(this.btnOverdue);
            this.gbDeposit.Controls.Add(this.btnListDeposit);
            this.gbDeposit.Controls.Add(this.btnSelectMember);
            this.gbDeposit.Controls.Add(this.btnSelectBook);
            this.gbDeposit.Controls.Add(this.dtpDepositDate);
            this.gbDeposit.Controls.Add(this.btnFindMember);
            this.gbDeposit.Controls.Add(this.btnFindBook);
            this.gbDeposit.Controls.Add(this.btnDeposit);
            this.gbDeposit.Controls.Add(this.tbDepositMemberName);
            this.gbDeposit.Controls.Add(this.tbDepositBookName);
            this.gbDeposit.Controls.Add(this.tbFindMember);
            this.gbDeposit.Controls.Add(this.tbFindBook);
            this.gbDeposit.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbDeposit.Location = new System.Drawing.Point(446, 0);
            this.gbDeposit.Name = "gbDeposit";
            this.gbDeposit.Size = new System.Drawing.Size(402, 436);
            this.gbDeposit.TabIndex = 2;
            this.gbDeposit.TabStop = false;
            this.gbDeposit.Text = "Emanet";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(40, 360);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 23);
            this.button4.TabIndex = 38;
            this.button4.Text = "Temizle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnOverdue
            // 
            this.btnOverdue.Location = new System.Drawing.Point(208, 360);
            this.btnOverdue.Name = "btnOverdue";
            this.btnOverdue.Size = new System.Drawing.Size(146, 23);
            this.btnOverdue.TabIndex = 69;
            this.btnOverdue.Text = "Gecikenler";
            this.btnOverdue.UseVisualStyleBackColor = true;
            this.btnOverdue.Click += new System.EventHandler(this.btnOverdue_Click);
            // 
            // btnListDeposit
            // 
            this.btnListDeposit.Location = new System.Drawing.Point(40, 327);
            this.btnListDeposit.Name = "btnListDeposit";
            this.btnListDeposit.Size = new System.Drawing.Size(162, 23);
            this.btnListDeposit.TabIndex = 68;
            this.btnListDeposit.Text = "Emanetleri Listele";
            this.btnListDeposit.UseVisualStyleBackColor = true;
            this.btnListDeposit.Click += new System.EventHandler(this.btnListDeposit_Click);
            // 
            // btnSelectMember
            // 
            this.btnSelectMember.Location = new System.Drawing.Point(40, 230);
            this.btnSelectMember.Name = "btnSelectMember";
            this.btnSelectMember.Size = new System.Drawing.Size(75, 23);
            this.btnSelectMember.TabIndex = 67;
            this.btnSelectMember.Text = "Üye Seç";
            this.btnSelectMember.UseVisualStyleBackColor = true;
            this.btnSelectMember.Click += new System.EventHandler(this.btnSelectMember_Click);
            // 
            // btnSelectBook
            // 
            this.btnSelectBook.Location = new System.Drawing.Point(40, 193);
            this.btnSelectBook.Name = "btnSelectBook";
            this.btnSelectBook.Size = new System.Drawing.Size(75, 23);
            this.btnSelectBook.TabIndex = 66;
            this.btnSelectBook.Text = "Kitap Seç";
            this.btnSelectBook.UseVisualStyleBackColor = true;
            this.btnSelectBook.Click += new System.EventHandler(this.btnSelectBook_Click);
            // 
            // dtpDepositDate
            // 
            this.dtpDepositDate.Location = new System.Drawing.Point(121, 276);
            this.dtpDepositDate.Name = "dtpDepositDate";
            this.dtpDepositDate.Size = new System.Drawing.Size(233, 20);
            this.dtpDepositDate.TabIndex = 63;
            // 
            // btnFindMember
            // 
            this.btnFindMember.Location = new System.Drawing.Point(279, 66);
            this.btnFindMember.Name = "btnFindMember";
            this.btnFindMember.Size = new System.Drawing.Size(75, 23);
            this.btnFindMember.TabIndex = 62;
            this.btnFindMember.Text = "Üye Ara";
            this.btnFindMember.UseVisualStyleBackColor = true;
            this.btnFindMember.Click += new System.EventHandler(this.btnFindMember_Click);
            // 
            // btnFindBook
            // 
            this.btnFindBook.Location = new System.Drawing.Point(279, 26);
            this.btnFindBook.Name = "btnFindBook";
            this.btnFindBook.Size = new System.Drawing.Size(75, 23);
            this.btnFindBook.TabIndex = 61;
            this.btnFindBook.Text = "Kitap Ara";
            this.btnFindBook.UseVisualStyleBackColor = true;
            this.btnFindBook.Click += new System.EventHandler(this.btnFindBook_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(208, 327);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(146, 23);
            this.btnDeposit.TabIndex = 59;
            this.btnDeposit.Text = "Emanet Ver";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // tbDepositMemberName
            // 
            this.tbDepositMemberName.Location = new System.Drawing.Point(121, 231);
            this.tbDepositMemberName.Name = "tbDepositMemberName";
            this.tbDepositMemberName.Size = new System.Drawing.Size(233, 20);
            this.tbDepositMemberName.TabIndex = 58;
            // 
            // tbDepositBookName
            // 
            this.tbDepositBookName.Location = new System.Drawing.Point(121, 196);
            this.tbDepositBookName.Name = "tbDepositBookName";
            this.tbDepositBookName.Size = new System.Drawing.Size(233, 20);
            this.tbDepositBookName.TabIndex = 57;
            // 
            // tbFindMember
            // 
            this.tbFindMember.Location = new System.Drawing.Point(40, 68);
            this.tbFindMember.Name = "tbFindMember";
            this.tbFindMember.Size = new System.Drawing.Size(233, 20);
            this.tbFindMember.TabIndex = 56;
            // 
            // tbFindBook
            // 
            this.tbFindBook.Location = new System.Drawing.Point(40, 28);
            this.tbFindBook.Name = "tbFindBook";
            this.tbFindBook.Size = new System.Drawing.Size(233, 20);
            this.tbFindBook.TabIndex = 55;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(854, 111);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 60);
            this.btnBack.TabIndex = 70;
            this.btnBack.Text = "<- Çıkış";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // btnGoMember
            // 
            this.btnGoMember.Location = new System.Drawing.Point(854, 26);
            this.btnGoMember.Name = "btnGoMember";
            this.btnGoMember.Size = new System.Drawing.Size(128, 63);
            this.btnGoMember.TabIndex = 71;
            this.btnGoMember.Text = "Üyelik";
            this.btnGoMember.UseVisualStyleBackColor = true;
            this.btnGoMember.Click += new System.EventHandler(this.btnGoMember_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(854, 360);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(128, 61);
            this.btnExcel.TabIndex = 72;
            this.btnExcel.Text = "Excel\'e Aktar";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(989, 679);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnGoMember);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbDeposit);
            this.Controls.Add(this.gbBook);
            this.Controls.Add(this.dataGridView);
            this.Name = "AdminPanel";
            this.Text = "Yönetici Paneli";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.gbBook.ResumeLayout(false);
            this.gbBook.PerformLayout();
            this.gbDeposit.ResumeLayout(false);
            this.gbDeposit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox gbBook;
        private System.Windows.Forms.GroupBox gbDeposit;
        private System.Windows.Forms.TextBox tbBookDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.ComboBox cbBookLang;
        private System.Windows.Forms.Label lblPublised;
        private System.Windows.Forms.DateTimePicker dtpBookPublised;
        private System.Windows.Forms.Label lblPubliser;
        private System.Windows.Forms.ComboBox cbBookPublisher;
        private System.Windows.Forms.ComboBox cbBookAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox tbBookPage;
        private System.Windows.Forms.TextBox tbBookISBN;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbBookName;
        private System.Windows.Forms.Button btnBookDelete;
        private System.Windows.Forms.Button btnBookEdit;
        private System.Windows.Forms.Button btnBookAdd;
        private System.Windows.Forms.DateTimePicker dtpDepositDate;
        private System.Windows.Forms.Button btnFindMember;
        private System.Windows.Forms.Button btnFindBook;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.TextBox tbDepositMemberName;
        private System.Windows.Forms.TextBox tbDepositBookName;
        private System.Windows.Forms.TextBox tbFindMember;
        private System.Windows.Forms.TextBox tbFindBook;
        private System.Windows.Forms.Button btnBookList;
        private System.Windows.Forms.Button btnSelectMember;
        private System.Windows.Forms.Button btnSelectBook;
        private System.Windows.Forms.Button btnListDeposit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSelected;
        private System.Windows.Forms.Button btnOverdue;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnGoMember;
        private System.Windows.Forms.Button btnExcel;
    }
}