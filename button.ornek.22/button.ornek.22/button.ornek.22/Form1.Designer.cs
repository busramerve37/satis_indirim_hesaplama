namespace button.ornek._22
{
    partial class Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.İslemSecin = new System.ComponentModel.BackgroundWorker();
            this.rbIndirimYok = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb30 = new System.Windows.Forms.RadioButton();
            this.rb40 = new System.Windows.Forms.RadioButton();
            this.lblFiyatGir = new System.Windows.Forms.Label();
            this.lblOdenecek = new System.Windows.Forms.Label();
            this.txtFiyatGir = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb40);
            this.groupBox1.Controls.Add(this.rb30);
            this.groupBox1.Controls.Add(this.rb5);
            this.groupBox1.Controls.Add(this.rbIndirimYok);
            this.groupBox1.Location = new System.Drawing.Point(8, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem Seçin";
            // 
            // rbIndirimYok
            // 
            this.rbIndirimYok.AutoSize = true;
            this.rbIndirimYok.Location = new System.Drawing.Point(19, 41);
            this.rbIndirimYok.Name = "rbIndirimYok";
            this.rbIndirimYok.Size = new System.Drawing.Size(74, 17);
            this.rbIndirimYok.TabIndex = 0;
            this.rbIndirimYok.TabStop = true;
            this.rbIndirimYok.Text = "İndirimYok";
            this.rbIndirimYok.UseVisualStyleBackColor = true;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(19, 76);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(72, 17);
            this.rb5.TabIndex = 1;
            this.rb5.TabStop = true;
            this.rb5.Text = "%5 İndirim";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // rb30
            // 
            this.rb30.AutoSize = true;
            this.rb30.Location = new System.Drawing.Point(19, 114);
            this.rb30.Name = "rb30";
            this.rb30.Size = new System.Drawing.Size(78, 17);
            this.rb30.TabIndex = 2;
            this.rb30.TabStop = true;
            this.rb30.Text = "%30 İndirim";
            this.rb30.UseVisualStyleBackColor = true;
            // 
            // rb40
            // 
            this.rb40.AutoSize = true;
            this.rb40.Location = new System.Drawing.Point(19, 149);
            this.rb40.Name = "rb40";
            this.rb40.Size = new System.Drawing.Size(77, 17);
            this.rb40.TabIndex = 3;
            this.rb40.TabStop = true;
            this.rb40.Text = "%40 indirim";
            this.rb40.UseVisualStyleBackColor = true;
            // 
            // lblFiyatGir
            // 
            this.lblFiyatGir.AutoSize = true;
            this.lblFiyatGir.Location = new System.Drawing.Point(228, 29);
            this.lblFiyatGir.Name = "lblFiyatGir";
            this.lblFiyatGir.Size = new System.Drawing.Size(53, 13);
            this.lblFiyatGir.TabIndex = 1;
            this.lblFiyatGir.Text = "Fiyat Girin";
            // 
            // lblOdenecek
            // 
            this.lblOdenecek.AutoSize = true;
            this.lblOdenecek.Location = new System.Drawing.Point(228, 176);
            this.lblOdenecek.Name = "lblOdenecek";
            this.lblOdenecek.Size = new System.Drawing.Size(51, 13);
            this.lblOdenecek.TabIndex = 2;
            this.lblOdenecek.Text = "Öd⁬necek";
            // 
            // txtFiyatGir
            // 
            this.txtFiyatGir.Location = new System.Drawing.Point(300, 21);
            this.txtFiyatGir.Name = "txtFiyatGir";
            this.txtFiyatGir.Size = new System.Drawing.Size(100, 20);
            this.txtFiyatGir.TabIndex = 3;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(360, 80);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(85, 73);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 417);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtFiyatGir);
            this.Controls.Add(this.lblOdenecek);
            this.Controls.Add(this.lblFiyatGir);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb40;
        private System.Windows.Forms.RadioButton rb30;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rbIndirimYok;
        private System.ComponentModel.BackgroundWorker İslemSecin;
        private System.Windows.Forms.Label lblFiyatGir;
        private System.Windows.Forms.Label lblOdenecek;
        private System.Windows.Forms.TextBox txtFiyatGir;
        private System.Windows.Forms.Button btnHesapla;
    }
}

