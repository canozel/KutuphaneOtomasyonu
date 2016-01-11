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
            this.gbMember = new System.Windows.Forms.GroupBox();
            this.btnMemberList = new System.Windows.Forms.Button();
            this.tbMemberPhone = new System.Windows.Forms.TextBox();
            this.tbMemberTC = new System.Windows.Forms.TextBox();
            this.btnMemberDelete = new System.Windows.Forms.Button();
            this.btnMemberEdit = new System.Windows.Forms.Button();
            this.btnMemberAdd = new System.Windows.Forms.Button();
            this.tbMemberAdress = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.cbMemberGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.tbMemberEmail = new System.Windows.Forms.TextBox();
            this.tbMemberLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbMemberFirstName = new System.Windows.Forms.TextBox();
            this.gbDeposit = new System.Windows.Forms.GroupBox();
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
            this.btnListDeposit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.gbBook.SuspendLayout();
            this.gbMember.SuspendLayout();
            this.gbDeposit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(0, 397);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1197, 223);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // gbBook
            // 
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
            this.gbBook.Location = new System.Drawing.Point(55, 2);
            this.gbBook.Name = "gbBook";
            this.gbBook.Size = new System.Drawing.Size(360, 389);
            this.gbBook.TabIndex = 1;
            this.gbBook.TabStop = false;
            this.gbBook.Text = "Kitaplar";
            // 
            // btnBookList
            // 
            this.btnBookList.Location = new System.Drawing.Point(17, 360);
            this.btnBookList.Name = "btnBookList";
            this.btnBookList.Size = new System.Drawing.Size(75, 23);
            this.btnBookList.TabIndex = 35;
            this.btnBookList.Text = "Listele";
            this.btnBookList.UseVisualStyleBackColor = true;
            this.btnBookList.Click += new System.EventHandler(this.btnBookList_Click);
            // 
            // btnBookDelete
            // 
            this.btnBookDelete.Enabled = false;
            this.btnBookDelete.Location = new System.Drawing.Point(258, 360);
            this.btnBookDelete.Name = "btnBookDelete";
            this.btnBookDelete.Size = new System.Drawing.Size(75, 23);
            this.btnBookDelete.TabIndex = 34;
            this.btnBookDelete.Text = "Sil";
            this.btnBookDelete.UseVisualStyleBackColor = true;
            this.btnBookDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBookEdit
            // 
            this.btnBookEdit.Enabled = false;
            this.btnBookEdit.Location = new System.Drawing.Point(177, 360);
            this.btnBookEdit.Name = "btnBookEdit";
            this.btnBookEdit.Size = new System.Drawing.Size(75, 23);
            this.btnBookEdit.TabIndex = 33;
            this.btnBookEdit.Text = "Düzenle";
            this.btnBookEdit.UseVisualStyleBackColor = true;
            this.btnBookEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.Location = new System.Drawing.Point(96, 360);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(75, 23);
            this.btnBookAdd.TabIndex = 32;
            this.btnBookAdd.Text = "Ekle";
            this.btnBookAdd.UseVisualStyleBackColor = true;
            this.btnBookAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbBookDesc
            // 
            this.tbBookDesc.Location = new System.Drawing.Point(100, 273);
            this.tbBookDesc.Multiline = true;
            this.tbBookDesc.Name = "tbBookDesc";
            this.tbBookDesc.Size = new System.Drawing.Size(233, 77);
            this.tbBookDesc.TabIndex = 31;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(30, 276);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(50, 13);
            this.lblDesc.TabIndex = 30;
            this.lblDesc.Text = "Açıklama";
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(222, 235);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(64, 13);
            this.lblPage.TabIndex = 29;
            this.lblPage.Text = "Sayfa Sayısı";
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Location = new System.Drawing.Point(30, 235);
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
            this.cbBookLang.Location = new System.Drawing.Point(100, 231);
            this.cbBookLang.Name = "cbBookLang";
            this.cbBookLang.Size = new System.Drawing.Size(116, 21);
            this.cbBookLang.TabIndex = 27;
            // 
            // lblPublised
            // 
            this.lblPublised.AutoSize = true;
            this.lblPublised.Location = new System.Drawing.Point(28, 193);
            this.lblPublised.Name = "lblPublised";
            this.lblPublised.Size = new System.Drawing.Size(64, 13);
            this.lblPublised.TabIndex = 26;
            this.lblPublised.Text = "Yayım Tarihi";
            // 
            // dtpBookPublised
            // 
            this.dtpBookPublised.Location = new System.Drawing.Point(100, 193);
            this.dtpBookPublised.Name = "dtpBookPublised";
            this.dtpBookPublised.Size = new System.Drawing.Size(233, 20);
            this.dtpBookPublised.TabIndex = 25;
            // 
            // lblPubliser
            // 
            this.lblPubliser.AutoSize = true;
            this.lblPubliser.Location = new System.Drawing.Point(28, 153);
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
            this.cbBookPublisher.Location = new System.Drawing.Point(100, 150);
            this.cbBookPublisher.Name = "cbBookPublisher";
            this.cbBookPublisher.Size = new System.Drawing.Size(233, 21);
            this.cbBookPublisher.TabIndex = 23;
            // 
            // cbBookAuthor
            // 
            this.cbBookAuthor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBookAuthor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBookAuthor.FormattingEnabled = true;
            this.cbBookAuthor.Location = new System.Drawing.Point(100, 111);
            this.cbBookAuthor.Name = "cbBookAuthor";
            this.cbBookAuthor.Size = new System.Drawing.Size(233, 21);
            this.cbBookAuthor.TabIndex = 22;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(28, 114);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(34, 13);
            this.lblAuthor.TabIndex = 21;
            this.lblAuthor.Text = "Yazar";
            // 
            // tbBookPage
            // 
            this.tbBookPage.Location = new System.Drawing.Point(292, 232);
            this.tbBookPage.Name = "tbBookPage";
            this.tbBookPage.Size = new System.Drawing.Size(41, 20);
            this.tbBookPage.TabIndex = 20;
            // 
            // tbBookISBN
            // 
            this.tbBookISBN.Location = new System.Drawing.Point(100, 68);
            this.tbBookISBN.Name = "tbBookISBN";
            this.tbBookISBN.Size = new System.Drawing.Size(233, 20);
            this.tbBookISBN.TabIndex = 19;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(28, 71);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 18;
            this.lblISBN.Text = "ISBN";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 13);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Kitap Adı";
            // 
            // tbBookName
            // 
            this.tbBookName.Location = new System.Drawing.Point(100, 28);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(233, 20);
            this.tbBookName.TabIndex = 16;
            // 
            // gbMember
            // 
            this.gbMember.Controls.Add(this.btnMemberList);
            this.gbMember.Controls.Add(this.tbMemberPhone);
            this.gbMember.Controls.Add(this.tbMemberTC);
            this.gbMember.Controls.Add(this.btnMemberDelete);
            this.gbMember.Controls.Add(this.btnMemberEdit);
            this.gbMember.Controls.Add(this.btnMemberAdd);
            this.gbMember.Controls.Add(this.tbMemberAdress);
            this.gbMember.Controls.Add(this.lblAdress);
            this.gbMember.Controls.Add(this.lblEmail);
            this.gbMember.Controls.Add(this.lblPhone);
            this.gbMember.Controls.Add(this.lblTC);
            this.gbMember.Controls.Add(this.cbMemberGender);
            this.gbMember.Controls.Add(this.lblGender);
            this.gbMember.Controls.Add(this.tbMemberEmail);
            this.gbMember.Controls.Add(this.tbMemberLastName);
            this.gbMember.Controls.Add(this.lblLastName);
            this.gbMember.Controls.Add(this.lblFirstName);
            this.gbMember.Controls.Add(this.tbMemberFirstName);
            this.gbMember.Location = new System.Drawing.Point(421, 2);
            this.gbMember.Name = "gbMember";
            this.gbMember.Size = new System.Drawing.Size(360, 389);
            this.gbMember.TabIndex = 2;
            this.gbMember.TabStop = false;
            this.gbMember.Text = "Üyeler";
            // 
            // btnMemberList
            // 
            this.btnMemberList.Location = new System.Drawing.Point(16, 360);
            this.btnMemberList.Name = "btnMemberList";
            this.btnMemberList.Size = new System.Drawing.Size(75, 23);
            this.btnMemberList.TabIndex = 36;
            this.btnMemberList.Text = "Listele";
            this.btnMemberList.UseVisualStyleBackColor = true;
            this.btnMemberList.Click += new System.EventHandler(this.btnMemberList_Click);
            // 
            // tbMemberPhone
            // 
            this.tbMemberPhone.Location = new System.Drawing.Point(101, 193);
            this.tbMemberPhone.Name = "tbMemberPhone";
            this.tbMemberPhone.Size = new System.Drawing.Size(233, 20);
            this.tbMemberPhone.TabIndex = 55;
            // 
            // tbMemberTC
            // 
            this.tbMemberTC.Location = new System.Drawing.Point(101, 150);
            this.tbMemberTC.Name = "tbMemberTC";
            this.tbMemberTC.Size = new System.Drawing.Size(233, 20);
            this.tbMemberTC.TabIndex = 54;
            // 
            // btnMemberDelete
            // 
            this.btnMemberDelete.Enabled = false;
            this.btnMemberDelete.Location = new System.Drawing.Point(259, 360);
            this.btnMemberDelete.Name = "btnMemberDelete";
            this.btnMemberDelete.Size = new System.Drawing.Size(75, 23);
            this.btnMemberDelete.TabIndex = 53;
            this.btnMemberDelete.Text = "Sil";
            this.btnMemberDelete.UseVisualStyleBackColor = true;
            this.btnMemberDelete.Click += new System.EventHandler(this.btnMemberDelete_Click);
            // 
            // btnMemberEdit
            // 
            this.btnMemberEdit.Enabled = false;
            this.btnMemberEdit.Location = new System.Drawing.Point(178, 360);
            this.btnMemberEdit.Name = "btnMemberEdit";
            this.btnMemberEdit.Size = new System.Drawing.Size(75, 23);
            this.btnMemberEdit.TabIndex = 52;
            this.btnMemberEdit.Text = "Düzenle";
            this.btnMemberEdit.UseVisualStyleBackColor = true;
            this.btnMemberEdit.Click += new System.EventHandler(this.btnMemberEdit_Click);
            // 
            // btnMemberAdd
            // 
            this.btnMemberAdd.Location = new System.Drawing.Point(97, 360);
            this.btnMemberAdd.Name = "btnMemberAdd";
            this.btnMemberAdd.Size = new System.Drawing.Size(75, 23);
            this.btnMemberAdd.TabIndex = 51;
            this.btnMemberAdd.Text = "Ekle";
            this.btnMemberAdd.UseVisualStyleBackColor = true;
            this.btnMemberAdd.Click += new System.EventHandler(this.btnMemberAdd_Click);
            // 
            // tbMemberAdress
            // 
            this.tbMemberAdress.Location = new System.Drawing.Point(101, 273);
            this.tbMemberAdress.Multiline = true;
            this.tbMemberAdress.Name = "tbMemberAdress";
            this.tbMemberAdress.Size = new System.Drawing.Size(233, 77);
            this.tbMemberAdress.TabIndex = 50;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(31, 276);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(34, 13);
            this.lblAdress.TabIndex = 49;
            this.lblAdress.Text = "Adres";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(29, 232);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 48;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(29, 193);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(43, 13);
            this.lblPhone.TabIndex = 45;
            this.lblPhone.Text = "Telefon";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(29, 153);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(21, 13);
            this.lblTC.TabIndex = 43;
            this.lblTC.Text = "TC";
            // 
            // cbMemberGender
            // 
            this.cbMemberGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMemberGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMemberGender.FormattingEnabled = true;
            this.cbMemberGender.Location = new System.Drawing.Point(101, 111);
            this.cbMemberGender.Name = "cbMemberGender";
            this.cbMemberGender.Size = new System.Drawing.Size(233, 21);
            this.cbMemberGender.TabIndex = 41;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(29, 114);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(43, 13);
            this.lblGender.TabIndex = 40;
            this.lblGender.Text = "Cinsiyet";
            // 
            // tbMemberEmail
            // 
            this.tbMemberEmail.Location = new System.Drawing.Point(101, 232);
            this.tbMemberEmail.Name = "tbMemberEmail";
            this.tbMemberEmail.Size = new System.Drawing.Size(233, 20);
            this.tbMemberEmail.TabIndex = 39;
            // 
            // tbMemberLastName
            // 
            this.tbMemberLastName.Location = new System.Drawing.Point(101, 68);
            this.tbMemberLastName.Name = "tbMemberLastName";
            this.tbMemberLastName.Size = new System.Drawing.Size(233, 20);
            this.tbMemberLastName.TabIndex = 38;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(29, 71);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(43, 13);
            this.lblLastName.TabIndex = 37;
            this.lblLastName.Text = "Soy Adı";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(31, 31);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(22, 13);
            this.lblFirstName.TabIndex = 36;
            this.lblFirstName.Text = "Adı";
            // 
            // tbMemberFirstName
            // 
            this.tbMemberFirstName.Location = new System.Drawing.Point(101, 28);
            this.tbMemberFirstName.Name = "tbMemberFirstName";
            this.tbMemberFirstName.Size = new System.Drawing.Size(233, 20);
            this.tbMemberFirstName.TabIndex = 35;
            // 
            // gbDeposit
            // 
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
            this.gbDeposit.Location = new System.Drawing.Point(787, 2);
            this.gbDeposit.Name = "gbDeposit";
            this.gbDeposit.Size = new System.Drawing.Size(360, 389);
            this.gbDeposit.TabIndex = 2;
            this.gbDeposit.TabStop = false;
            this.gbDeposit.Text = "Emanet";
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
            this.btnFindMember.Location = new System.Drawing.Point(245, 66);
            this.btnFindMember.Name = "btnFindMember";
            this.btnFindMember.Size = new System.Drawing.Size(75, 23);
            this.btnFindMember.TabIndex = 62;
            this.btnFindMember.Text = "Üye Ara";
            this.btnFindMember.UseVisualStyleBackColor = true;
            this.btnFindMember.Click += new System.EventHandler(this.btnFindMember_Click);
            // 
            // btnFindBook
            // 
            this.btnFindBook.Location = new System.Drawing.Point(245, 26);
            this.btnFindBook.Name = "btnFindBook";
            this.btnFindBook.Size = new System.Drawing.Size(75, 23);
            this.btnFindBook.TabIndex = 61;
            this.btnFindBook.Text = "Kitap Ara";
            this.btnFindBook.UseVisualStyleBackColor = true;
            this.btnFindBook.Click += new System.EventHandler(this.btnFindBook_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(279, 327);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
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
            this.tbFindMember.Location = new System.Drawing.Point(6, 68);
            this.tbFindMember.Name = "tbFindMember";
            this.tbFindMember.Size = new System.Drawing.Size(233, 20);
            this.tbFindMember.TabIndex = 56;
            // 
            // tbFindBook
            // 
            this.tbFindBook.Location = new System.Drawing.Point(6, 28);
            this.tbFindBook.Name = "tbFindBook";
            this.tbFindBook.Size = new System.Drawing.Size(233, 20);
            this.tbFindBook.TabIndex = 55;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1153, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(44, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnListDeposit
            // 
            this.btnListDeposit.Location = new System.Drawing.Point(155, 327);
            this.btnListDeposit.Name = "btnListDeposit";
            this.btnListDeposit.Size = new System.Drawing.Size(118, 23);
            this.btnListDeposit.TabIndex = 68;
            this.btnListDeposit.Text = "Emanetleri Listele";
            this.btnListDeposit.UseVisualStyleBackColor = true;
            this.btnListDeposit.Click += new System.EventHandler(this.btnListDeposit_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 620);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbDeposit);
            this.Controls.Add(this.gbMember);
            this.Controls.Add(this.gbBook);
            this.Controls.Add(this.dataGridView);
            this.Name = "AdminPanel";
            this.Text = "Yönetici Paneli";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.gbBook.ResumeLayout(false);
            this.gbBook.PerformLayout();
            this.gbMember.ResumeLayout(false);
            this.gbMember.PerformLayout();
            this.gbDeposit.ResumeLayout(false);
            this.gbDeposit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox gbBook;
        private System.Windows.Forms.GroupBox gbMember;
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
        private System.Windows.Forms.TextBox tbMemberTC;
        private System.Windows.Forms.Button btnMemberDelete;
        private System.Windows.Forms.Button btnMemberEdit;
        private System.Windows.Forms.Button btnMemberAdd;
        private System.Windows.Forms.TextBox tbMemberAdress;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.ComboBox cbMemberGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox tbMemberEmail;
        private System.Windows.Forms.TextBox tbMemberLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbMemberFirstName;
        private System.Windows.Forms.DateTimePicker dtpDepositDate;
        private System.Windows.Forms.Button btnFindMember;
        private System.Windows.Forms.Button btnFindBook;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.TextBox tbDepositMemberName;
        private System.Windows.Forms.TextBox tbDepositBookName;
        private System.Windows.Forms.TextBox tbFindMember;
        private System.Windows.Forms.TextBox tbFindBook;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox tbMemberPhone;
        private System.Windows.Forms.Button btnBookList;
        private System.Windows.Forms.Button btnMemberList;
        private System.Windows.Forms.Button btnSelectMember;
        private System.Windows.Forms.Button btnSelectBook;
        private System.Windows.Forms.Button btnListDeposit;
    }
}