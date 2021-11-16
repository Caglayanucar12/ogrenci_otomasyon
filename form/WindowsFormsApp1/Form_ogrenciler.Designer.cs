namespace WindowsFormsApp1
{
    partial class Form_ogrenciler
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ogrencisil = new System.Windows.Forms.Button();
            this.btn_ogrguncelle = new System.Windows.Forms.Button();
            this.btn_ogrekle = new System.Windows.Forms.Button();
            this.dtp_kayittarihi = new System.Windows.Forms.DateTimePicker();
            this.dtp_dogumtarihi = new System.Windows.Forms.DateTimePicker();
            this.cb_ogrbolum = new System.Windows.Forms.ComboBox();
            this.tb_ogrsoyadi = new System.Windows.Forms.TextBox();
            this.tb_ogradi = new System.Windows.Forms.TextBox();
            this.tb_tckimlikno = new System.Windows.Forms.TextBox();
            this.tb_ogrno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 246);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_ogrencisil);
            this.groupBox1.Controls.Add(this.btn_ogrguncelle);
            this.groupBox1.Controls.Add(this.btn_ogrekle);
            this.groupBox1.Controls.Add(this.dtp_kayittarihi);
            this.groupBox1.Controls.Add(this.dtp_dogumtarihi);
            this.groupBox1.Controls.Add(this.cb_ogrbolum);
            this.groupBox1.Controls.Add(this.tb_ogrsoyadi);
            this.groupBox1.Controls.Add(this.tb_ogradi);
            this.groupBox1.Controls.Add(this.tb_tckimlikno);
            this.groupBox1.Controls.Add(this.tb_ogrno);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 174);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ogrencisil
            // 
            this.btn_ogrencisil.Location = new System.Drawing.Point(525, 135);
            this.btn_ogrencisil.Name = "btn_ogrencisil";
            this.btn_ogrencisil.Size = new System.Drawing.Size(75, 23);
            this.btn_ogrencisil.TabIndex = 5;
            this.btn_ogrencisil.Text = "Sil";
            this.btn_ogrencisil.UseVisualStyleBackColor = true;
            this.btn_ogrencisil.Click += new System.EventHandler(this.btn_ogrencisil_Click);
            // 
            // btn_ogrguncelle
            // 
            this.btn_ogrguncelle.Location = new System.Drawing.Point(444, 135);
            this.btn_ogrguncelle.Name = "btn_ogrguncelle";
            this.btn_ogrguncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_ogrguncelle.TabIndex = 5;
            this.btn_ogrguncelle.Text = "Güncelle";
            this.btn_ogrguncelle.UseVisualStyleBackColor = true;
            this.btn_ogrguncelle.Click += new System.EventHandler(this.btn_ogrguncelle_Click);
            // 
            // btn_ogrekle
            // 
            this.btn_ogrekle.Location = new System.Drawing.Point(363, 137);
            this.btn_ogrekle.Name = "btn_ogrekle";
            this.btn_ogrekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ogrekle.TabIndex = 5;
            this.btn_ogrekle.Text = "Ekle";
            this.btn_ogrekle.UseVisualStyleBackColor = true;
            this.btn_ogrekle.Click += new System.EventHandler(this.btn_ogrekle_Click);
            // 
            // dtp_kayittarihi
            // 
            this.dtp_kayittarihi.Location = new System.Drawing.Point(478, 77);
            this.dtp_kayittarihi.Name = "dtp_kayittarihi";
            this.dtp_kayittarihi.Size = new System.Drawing.Size(200, 22);
            this.dtp_kayittarihi.TabIndex = 4;
            // 
            // dtp_dogumtarihi
            // 
            this.dtp_dogumtarihi.Location = new System.Drawing.Point(478, 49);
            this.dtp_dogumtarihi.Name = "dtp_dogumtarihi";
            this.dtp_dogumtarihi.Size = new System.Drawing.Size(200, 22);
            this.dtp_dogumtarihi.TabIndex = 4;
            // 
            // cb_ogrbolum
            // 
            this.cb_ogrbolum.FormattingEnabled = true;
            this.cb_ogrbolum.Location = new System.Drawing.Point(166, 134);
            this.cb_ogrbolum.Name = "cb_ogrbolum";
            this.cb_ogrbolum.Size = new System.Drawing.Size(160, 24);
            this.cb_ogrbolum.TabIndex = 3;
            // 
            // tb_ogrsoyadi
            // 
            this.tb_ogrsoyadi.Location = new System.Drawing.Point(166, 105);
            this.tb_ogrsoyadi.Name = "tb_ogrsoyadi";
            this.tb_ogrsoyadi.Size = new System.Drawing.Size(160, 22);
            this.tb_ogrsoyadi.TabIndex = 2;
            this.tb_ogrsoyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ogrsoyadi_KeyPress);
            // 
            // tb_ogradi
            // 
            this.tb_ogradi.Location = new System.Drawing.Point(166, 77);
            this.tb_ogradi.Name = "tb_ogradi";
            this.tb_ogradi.Size = new System.Drawing.Size(160, 22);
            this.tb_ogradi.TabIndex = 2;
            this.tb_ogradi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ogradi_KeyPress);
            // 
            // tb_tckimlikno
            // 
            this.tb_tckimlikno.Location = new System.Drawing.Point(478, 105);
            this.tb_tckimlikno.Name = "tb_tckimlikno";
            this.tb_tckimlikno.Size = new System.Drawing.Size(200, 22);
            this.tb_tckimlikno.TabIndex = 1;
            this.tb_tckimlikno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_tckimlikno_KeyPress);
            // 
            // tb_ogrno
            // 
            this.tb_ogrno.Location = new System.Drawing.Point(166, 49);
            this.tb_ogrno.Name = "tb_ogrno";
            this.tb_ogrno.Size = new System.Drawing.Size(160, 22);
            this.tb_ogrno.TabIndex = 1;
            this.tb_ogrno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ogrno_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bölümü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "TC Kimlik No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kayıt Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Öğrenci Numarası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doğum Tarihi";
            // 
            // Form_ogrenciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_ogrenciler";
            this.Text = "Öğrenci Yönetimi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ogrencisil;
        private System.Windows.Forms.Button btn_ogrguncelle;
        private System.Windows.Forms.Button btn_ogrekle;
        private System.Windows.Forms.DateTimePicker dtp_kayittarihi;
        private System.Windows.Forms.DateTimePicker dtp_dogumtarihi;
        private System.Windows.Forms.ComboBox cb_ogrbolum;
        private System.Windows.Forms.TextBox tb_ogrsoyadi;
        private System.Windows.Forms.TextBox tb_ogradi;
        private System.Windows.Forms.TextBox tb_tckimlikno;
        private System.Windows.Forms.TextBox tb_ogrno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}