namespace KutuphaneOtomasyonu
{
    partial class FindForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataFindScreen = new System.Windows.Forms.DataGridView();
            this.lblFind = new System.Windows.Forms.Label();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataFindScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // dataFindScreen
            // 
            this.dataFindScreen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFindScreen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataFindScreen.Location = new System.Drawing.Point(0, 82);
            this.dataFindScreen.Name = "dataFindScreen";
            this.dataFindScreen.Size = new System.Drawing.Size(830, 399);
            this.dataFindScreen.TabIndex = 2;
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Location = new System.Drawing.Point(215, 31);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(50, 13);
            this.lblFind.TabIndex = 3;
            this.lblFind.Text = "Kitap Ara";
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(271, 31);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(304, 20);
            this.tbFind.TabIndex = 4;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(581, 29);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Ara";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(805, -1);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(25, 30);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.Text = "?";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 481);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.lblFind);
            this.Controls.Add(this.dataFindScreen);
            this.Name = "FindForm";
            this.Text = "Arama Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.dataFindScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataFindScreen;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAdmin;

    }
}

