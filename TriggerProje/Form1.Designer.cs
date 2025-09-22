namespace TriggerProje
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtyazar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsayfa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtyayınevı = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttur = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblkitapadet = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.groupBox1.Controls.Add(this.btnsil);
            this.groupBox1.Controls.Add(this.btnekle);
            this.groupBox1.Controls.Add(this.txttur);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtyayınevı);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtsayfa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtyazar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 424);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(130, 35);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(226, 26);
            this.txtid.TabIndex = 1;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(130, 81);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(226, 26);
            this.txtad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "AD:";
            // 
            // txtyazar
            // 
            this.txtyazar.Location = new System.Drawing.Point(130, 128);
            this.txtyazar.Name = "txtyazar";
            this.txtyazar.Size = new System.Drawing.Size(226, 26);
            this.txtyazar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "YAZAR:";
            // 
            // txtsayfa
            // 
            this.txtsayfa.Location = new System.Drawing.Point(130, 176);
            this.txtsayfa.Name = "txtsayfa";
            this.txtsayfa.Size = new System.Drawing.Size(226, 26);
            this.txtsayfa.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "SAYFA:";
            // 
            // txtyayınevı
            // 
            this.txtyayınevı.Location = new System.Drawing.Point(130, 226);
            this.txtyayınevı.Name = "txtyayınevı";
            this.txtyayınevı.Size = new System.Drawing.Size(226, 26);
            this.txtyayınevı.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "YAYINEVİ:";
            // 
            // txttur
            // 
            this.txttur.Location = new System.Drawing.Point(130, 272);
            this.txttur.Name = "txttur";
            this.txttur.Size = new System.Drawing.Size(226, 26);
            this.txttur.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "TÜR:";
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Tan;
            this.btnekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnekle.Location = new System.Drawing.Point(130, 320);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(97, 34);
            this.btnekle.TabIndex = 12;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Tan;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.Location = new System.Drawing.Point(259, 320);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(97, 34);
            this.btnsil.TabIndex = 13;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(435, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(783, 339);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(777, 314);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.OldLace;
            this.groupBox3.Controls.Add(this.lblkitapadet);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(438, 357);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(777, 79);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label7.Location = new System.Drawing.Point(42, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kitap Adedi :";
            // 
            // lblkitapadet
            // 
            this.lblkitapadet.AutoSize = true;
            this.lblkitapadet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkitapadet.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblkitapadet.Location = new System.Drawing.Point(210, 33);
            this.lblkitapadet.Name = "lblkitapadet";
            this.lblkitapadet.Size = new System.Drawing.Size(27, 29);
            this.lblkitapadet.TabIndex = 1;
            this.lblkitapadet.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1230, 448);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.TextBox txttur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtyayınevı;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsayfa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtyazar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblkitapadet;
        private System.Windows.Forms.Label label7;
    }
}

