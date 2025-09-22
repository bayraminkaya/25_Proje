namespace ResimÜzerineYazı
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnrenksec = new System.Windows.Forms.Button();
            this.btnresimsec = new System.Windows.Forms.Button();
            this.btnyazdır = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmetin = new System.Windows.Forms.TextBox();
            this.txtboyut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnrenksec
            // 
            this.btnrenksec.Location = new System.Drawing.Point(12, 91);
            this.btnrenksec.Name = "btnrenksec";
            this.btnrenksec.Size = new System.Drawing.Size(209, 33);
            this.btnrenksec.TabIndex = 5;
            this.btnrenksec.Text = "Renk Seç";
            this.btnrenksec.UseVisualStyleBackColor = true;
            this.btnrenksec.Click += new System.EventHandler(this.btnrenksec_Click);
            // 
            // btnresimsec
            // 
            this.btnresimsec.Location = new System.Drawing.Point(12, 28);
            this.btnresimsec.Name = "btnresimsec";
            this.btnresimsec.Size = new System.Drawing.Size(209, 33);
            this.btnresimsec.TabIndex = 1;
            this.btnresimsec.Text = "Resim Seç";
            this.btnresimsec.UseVisualStyleBackColor = true;
            this.btnresimsec.Click += new System.EventHandler(this.btnresimsec_Click);
            // 
            // btnyazdır
            // 
            this.btnyazdır.Location = new System.Drawing.Point(12, 152);
            this.btnyazdır.Name = "btnyazdır";
            this.btnyazdır.Size = new System.Drawing.Size(209, 33);
            this.btnyazdır.TabIndex = 2;
            this.btnyazdır.Text = "Yazdır";
            this.btnyazdır.UseVisualStyleBackColor = true;
            this.btnyazdır.Click += new System.EventHandler(this.btnyazdır_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(12, 214);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(209, 33);
            this.btnkaydet.TabIndex = 1;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Metin:";
            // 
            // txtmetin
            // 
            this.txtmetin.Location = new System.Drawing.Point(66, 271);
            this.txtmetin.Name = "txtmetin";
            this.txtmetin.Size = new System.Drawing.Size(155, 26);
            this.txtmetin.TabIndex = 5;
            // 
            // txtboyut
            // 
            this.txtboyut.Location = new System.Drawing.Point(66, 313);
            this.txtboyut.Name = "txtboyut";
            this.txtboyut.Size = new System.Drawing.Size(155, 26);
            this.txtboyut.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Boyut:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(327, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(487, 311);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnkaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(210)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(886, 363);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtboyut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmetin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnyazdır);
            this.Controls.Add(this.btnresimsec);
            this.Controls.Add(this.btnrenksec);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnrenksec;
        private System.Windows.Forms.Button btnresimsec;
        private System.Windows.Forms.Button btnyazdır;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmetin;
        private System.Windows.Forms.TextBox txtboyut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

