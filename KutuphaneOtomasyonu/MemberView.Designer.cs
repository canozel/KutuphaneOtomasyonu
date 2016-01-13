namespace KutuphaneOtomasyonu {
    partial class MemberView {
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.gbMember = new System.Windows.Forms.GroupBox();
            this.btnSelected = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNewPassAgain = new System.Windows.Forms.TextBox();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.tbOldPass = new System.Windows.Forms.TextBox();
            this.lblMemberName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.gbMember.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(0, 432);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(752, 223);
            this.dataGridView.TabIndex = 5;
            // 
            // gbMember
            // 
            this.gbMember.Controls.Add(this.btnSelected);
            this.gbMember.Controls.Add(this.btnClear);
            this.gbMember.Controls.Add(this.groupBox1);
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
            this.gbMember.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbMember.Location = new System.Drawing.Point(0, 0);
            this.gbMember.Name = "gbMember";
            this.gbMember.Size = new System.Drawing.Size(403, 432);
            this.gbMember.TabIndex = 6;
            this.gbMember.TabStop = false;
            this.gbMember.Text = "Üyeler";
            // 
            // btnSelected
            // 
            this.btnSelected.Enabled = false;
            this.btnSelected.Location = new System.Drawing.Point(226, 389);
            this.btnSelected.Name = "btnSelected";
            this.btnSelected.Size = new System.Drawing.Size(108, 23);
            this.btnSelected.TabIndex = 57;
            this.btnSelected.Text = "Seçileni Aktar";
            this.btnSelected.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(123, 389);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 23);
            this.btnClear.TabIndex = 56;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(409, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 398);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnMemberList
            // 
            this.btnMemberList.Location = new System.Drawing.Point(32, 389);
            this.btnMemberList.Name = "btnMemberList";
            this.btnMemberList.Size = new System.Drawing.Size(85, 23);
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
            this.btnMemberDelete.Location = new System.Drawing.Point(226, 360);
            this.btnMemberDelete.Name = "btnMemberDelete";
            this.btnMemberDelete.Size = new System.Drawing.Size(108, 23);
            this.btnMemberDelete.TabIndex = 53;
            this.btnMemberDelete.Text = "Sil";
            this.btnMemberDelete.UseVisualStyleBackColor = true;
            this.btnMemberDelete.Click += new System.EventHandler(this.btnMemberDelete_Click);
            // 
            // btnMemberEdit
            // 
            this.btnMemberEdit.Enabled = false;
            this.btnMemberEdit.Location = new System.Drawing.Point(123, 360);
            this.btnMemberEdit.Name = "btnMemberEdit";
            this.btnMemberEdit.Size = new System.Drawing.Size(97, 23);
            this.btnMemberEdit.TabIndex = 52;
            this.btnMemberEdit.Text = "Düzenle";
            this.btnMemberEdit.UseVisualStyleBackColor = true;
            this.btnMemberEdit.Click += new System.EventHandler(this.btnMemberEdit_Click);
            // 
            // btnMemberAdd
            // 
            this.btnMemberAdd.Location = new System.Drawing.Point(32, 360);
            this.btnMemberAdd.Name = "btnMemberAdd";
            this.btnMemberAdd.Size = new System.Drawing.Size(85, 23);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMemberName);
            this.groupBox2.Controls.Add(this.btnChangePass);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbNewPassAgain);
            this.groupBox2.Controls.Add(this.tbNewPass);
            this.groupBox2.Controls.Add(this.tbOldPass);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(403, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 432);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şifre Değiştirme";
            // 
            // btnChangePass
            // 
            this.btnChangePass.Location = new System.Drawing.Point(57, 276);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(75, 23);
            this.btnChangePass.TabIndex = 56;
            this.btnChangePass.Text = "Değiştir";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Yeni Paralo Tekrar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Yeni Parola";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Eski Parola";
            // 
            // tbNewPassAgain
            // 
            this.tbNewPassAgain.Location = new System.Drawing.Point(57, 232);
            this.tbNewPassAgain.Name = "tbNewPassAgain";
            this.tbNewPassAgain.Size = new System.Drawing.Size(233, 20);
            this.tbNewPassAgain.TabIndex = 58;
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(57, 167);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.Size = new System.Drawing.Size(233, 20);
            this.tbNewPass.TabIndex = 57;
            // 
            // tbOldPass
            // 
            this.tbOldPass.Location = new System.Drawing.Point(57, 107);
            this.tbOldPass.Name = "tbOldPass";
            this.tbOldPass.Size = new System.Drawing.Size(233, 20);
            this.tbOldPass.TabIndex = 56;
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(192, 16);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(0, 13);
            this.lblMemberName.TabIndex = 62;
            // 
            // MemberView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 655);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbMember);
            this.Controls.Add(this.dataGridView);
            this.Name = "MemberView";
            this.Text = "Üye Paneli";
            this.Load += new System.EventHandler(this.MemberView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.gbMember.ResumeLayout(false);
            this.gbMember.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox gbMember;
        private System.Windows.Forms.Button btnMemberList;
        private System.Windows.Forms.TextBox tbMemberPhone;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNewPassAgain;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.TextBox tbOldPass;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSelected;
        private System.Windows.Forms.Label lblMemberName;
    }
}