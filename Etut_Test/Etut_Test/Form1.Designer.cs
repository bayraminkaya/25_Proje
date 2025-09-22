namespace Etut_Test
{
    partial class Form1
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
            this.btnolustur = new System.Windows.Forms.Button();
            this.msksaat = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbogretmen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.msktarih = new System.Windows.Forms.MaskedTextBox();
            this.cmbders = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtetut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtogrenci = new System.Windows.Forms.TextBox();
            this.btndetay = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.msktelefon = new System.Windows.Forms.MaskedTextBox();
            this.btnogrenciekle = new System.Windows.Forms.Button();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtsınıf = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtders = new System.Windows.Forms.TextBox();
            this.btndersekle = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnfotograf = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtogretmenad = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtogretmensoyad = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbogretmenders = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnogretmenekle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnolustur);
            this.groupBox1.Controls.Add(this.msksaat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbogretmen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.msktarih);
            this.groupBox1.Controls.Add(this.cmbders);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnolustur
            // 
            this.btnolustur.Location = new System.Drawing.Point(112, 211);
            this.btnolustur.Name = "btnolustur";
            this.btnolustur.Size = new System.Drawing.Size(121, 41);
            this.btnolustur.TabIndex = 1;
            this.btnolustur.Text = "Etüt Oluştur";
            this.btnolustur.UseVisualStyleBackColor = true;
            this.btnolustur.Click += new System.EventHandler(this.btnolustur_Click);
            // 
            // msksaat
            // 
            this.msksaat.Location = new System.Drawing.Point(112, 168);
            this.msksaat.Mask = "00:00";
            this.msksaat.Name = "msksaat";
            this.msksaat.Size = new System.Drawing.Size(121, 22);
            this.msksaat.TabIndex = 6;
            this.msksaat.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Saat : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tarih : ";
            // 
            // cmbogretmen
            // 
            this.cmbogretmen.FormattingEnabled = true;
            this.cmbogretmen.Location = new System.Drawing.Point(112, 76);
            this.cmbogretmen.Name = "cmbogretmen";
            this.cmbogretmen.Size = new System.Drawing.Size(121, 24);
            this.cmbogretmen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğretmen : ";
            // 
            // msktarih
            // 
            this.msktarih.Location = new System.Drawing.Point(112, 125);
            this.msktarih.Mask = "00/00/0000";
            this.msktarih.Name = "msktarih";
            this.msktarih.Size = new System.Drawing.Size(121, 22);
            this.msktarih.TabIndex = 1;
            this.msktarih.ValidatingType = typeof(System.DateTime);
            // 
            // cmbders
            // 
            this.cmbders.FormattingEnabled = true;
            this.cmbders.Location = new System.Drawing.Point(112, 31);
            this.cmbders.Name = "cmbders";
            this.cmbders.Size = new System.Drawing.Size(121, 24);
            this.cmbders.TabIndex = 1;
            this.cmbders.SelectedIndexChanged += new System.EventHandler(this.cmbders_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ders : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtetut);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtogrenci);
            this.groupBox2.Controls.Add(this.btndetay);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(391, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 179);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // txtetut
            // 
            this.txtetut.Location = new System.Drawing.Point(148, 36);
            this.txtetut.Name = "txtetut";
            this.txtetut.Size = new System.Drawing.Size(136, 22);
            this.txtetut.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Etüt ID: ";
            // 
            // txtogrenci
            // 
            this.txtogrenci.Location = new System.Drawing.Point(148, 79);
            this.txtogrenci.Name = "txtogrenci";
            this.txtogrenci.Size = new System.Drawing.Size(136, 22);
            this.txtogrenci.TabIndex = 8;
            // 
            // btndetay
            // 
            this.btndetay.Location = new System.Drawing.Point(148, 125);
            this.btndetay.Name = "btndetay";
            this.btndetay.Size = new System.Drawing.Size(136, 44);
            this.btndetay.TabIndex = 7;
            this.btndetay.Text = "Etüt Ver";
            this.btndetay.UseVisualStyleBackColor = true;
            this.btndetay.Click += new System.EventHandler(this.btndetay_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Öğrenci : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1099, 215);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.msktelefon);
            this.groupBox3.Controls.Add(this.btnogrenciekle);
            this.groupBox3.Controls.Add(this.txtmail);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtsınıf);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtad);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtsoyad);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(763, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(348, 281);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // msktelefon
            // 
            this.msktelefon.Location = new System.Drawing.Point(148, 145);
            this.msktelefon.Name = "msktelefon";
            this.msktelefon.Size = new System.Drawing.Size(136, 22);
            this.msktelefon.TabIndex = 17;
            // 
            // btnogrenciekle
            // 
            this.btnogrenciekle.Location = new System.Drawing.Point(148, 231);
            this.btnogrenciekle.Name = "btnogrenciekle";
            this.btnogrenciekle.Size = new System.Drawing.Size(136, 35);
            this.btnogrenciekle.TabIndex = 11;
            this.btnogrenciekle.Text = "Öğrenci Ekle";
            this.btnogrenciekle.UseVisualStyleBackColor = true;
            this.btnogrenciekle.Click += new System.EventHandler(this.btnogrenciekle_Click);
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(148, 187);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(136, 22);
            this.txtmail.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Mail : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Telefon : ";
            // 
            // txtsınıf
            // 
            this.txtsınıf.Location = new System.Drawing.Point(148, 105);
            this.txtsınıf.Name = "txtsınıf";
            this.txtsınıf.Size = new System.Drawing.Size(136, 22);
            this.txtsınıf.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Sınıf  : ";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(148, 21);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(136, 22);
            this.txtad.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ad : ";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(148, 64);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(136, 22);
            this.txtsoyad.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Soyad : ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtders);
            this.groupBox4.Controls.Add(this.btndersekle);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(391, 197);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(353, 96);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // txtders
            // 
            this.txtders.Location = new System.Drawing.Point(94, 35);
            this.txtders.Name = "txtders";
            this.txtders.Size = new System.Drawing.Size(117, 22);
            this.txtders.TabIndex = 8;
            // 
            // btndersekle
            // 
            this.btndersekle.Location = new System.Drawing.Point(230, 27);
            this.btndersekle.Name = "btndersekle";
            this.btndersekle.Size = new System.Drawing.Size(100, 39);
            this.btndersekle.TabIndex = 7;
            this.btndersekle.Text = "Ders Ekle";
            this.btndersekle.UseVisualStyleBackColor = true;
            this.btndersekle.Click += new System.EventHandler(this.btndersekle_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Ders Adı : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 193);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnfotograf);
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Location = new System.Drawing.Point(1117, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(258, 281);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            // 
            // btnfotograf
            // 
            this.btnfotograf.Location = new System.Drawing.Point(71, 223);
            this.btnfotograf.Name = "btnfotograf";
            this.btnfotograf.Size = new System.Drawing.Size(136, 35);
            this.btnfotograf.TabIndex = 18;
            this.btnfotograf.Text = "Fotoğraf Yükle";
            this.btnfotograf.UseVisualStyleBackColor = true;
            this.btnfotograf.Click += new System.EventHandler(this.btnfotograf_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnogretmenekle);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.cmbogretmenders);
            this.groupBox6.Controls.Add(this.txtogretmenad);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.txtogretmensoyad);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Location = new System.Drawing.Point(1117, 299);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(348, 224);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            // 
            // txtogretmenad
            // 
            this.txtogretmenad.Location = new System.Drawing.Point(148, 21);
            this.txtogretmenad.Name = "txtogretmenad";
            this.txtogretmenad.Size = new System.Drawing.Size(136, 22);
            this.txtogretmenad.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(52, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 16);
            this.label16.TabIndex = 9;
            this.label16.Text = "Ad : ";
            // 
            // txtogretmensoyad
            // 
            this.txtogretmensoyad.Location = new System.Drawing.Point(148, 64);
            this.txtogretmensoyad.Name = "txtogretmensoyad";
            this.txtogretmensoyad.Size = new System.Drawing.Size(136, 22);
            this.txtogretmensoyad.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(29, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 16);
            this.label17.TabIndex = 2;
            this.label17.Text = "Soyad : ";
            // 
            // cmbogretmenders
            // 
            this.cmbogretmenders.FormattingEnabled = true;
            this.cmbogretmenders.Location = new System.Drawing.Point(148, 104);
            this.cmbogretmenders.Name = "cmbogretmenders";
            this.cmbogretmenders.Size = new System.Drawing.Size(136, 24);
            this.cmbogretmenders.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Ders : ";
            // 
            // btnogretmenekle
            // 
            this.btnogretmenekle.Location = new System.Drawing.Point(101, 158);
            this.btnogretmenekle.Name = "btnogretmenekle";
            this.btnogretmenekle.Size = new System.Drawing.Size(136, 35);
            this.btnogretmenekle.TabIndex = 19;
            this.btnogretmenekle.Text = "Öğretmen Ekle";
            this.btnogretmenekle.UseVisualStyleBackColor = true;
            this.btnogretmenekle.Click += new System.EventHandler(this.btnogretmenekle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1464, 538);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnolustur;
        private System.Windows.Forms.MaskedTextBox msksaat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbogretmen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox msktarih;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btndetay;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtogrenci;
        private System.Windows.Forms.TextBox txtetut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtsınıf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox msktelefon;
        private System.Windows.Forms.Button btnogrenciekle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtders;
        private System.Windows.Forms.Button btndersekle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnfotograf;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnogretmenekle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbogretmenders;
        private System.Windows.Forms.TextBox txtogretmenad;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtogretmensoyad;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

