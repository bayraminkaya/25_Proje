namespace Proje6
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proje6DataSet = new Proje6.Proje6DataSet();
            this.proje6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proje6TableAdapter = new Proje6.Proje6DataSetTableAdapters.Proje6TableAdapter();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDSOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aD1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIYATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje6DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje6BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adDataGridViewTextBoxColumn,
            this.aDSOYADDataGridViewTextBoxColumn,
            this.aD1DataGridViewTextBoxColumn,
            this.fIYATDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.proje6BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // proje6DataSet
            // 
            this.proje6DataSet.DataSetName = "Proje6DataSet";
            this.proje6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proje6BindingSource
            // 
            this.proje6BindingSource.DataMember = "Proje6";
            this.proje6BindingSource.DataSource = this.proje6DataSet;
            // 
            // proje6TableAdapter
            // 
            this.proje6TableAdapter.ClearBeforeFill = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // aDSOYADDataGridViewTextBoxColumn
            // 
            this.aDSOYADDataGridViewTextBoxColumn.DataPropertyName = "ADSOYAD";
            this.aDSOYADDataGridViewTextBoxColumn.HeaderText = "ADSOYAD";
            this.aDSOYADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aDSOYADDataGridViewTextBoxColumn.Name = "aDSOYADDataGridViewTextBoxColumn";
            this.aDSOYADDataGridViewTextBoxColumn.Width = 125;
            // 
            // aD1DataGridViewTextBoxColumn
            // 
            this.aD1DataGridViewTextBoxColumn.DataPropertyName = "AD1";
            this.aD1DataGridViewTextBoxColumn.HeaderText = "AD1";
            this.aD1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aD1DataGridViewTextBoxColumn.Name = "aD1DataGridViewTextBoxColumn";
            this.aD1DataGridViewTextBoxColumn.Width = 125;
            // 
            // fIYATDataGridViewTextBoxColumn
            // 
            this.fIYATDataGridViewTextBoxColumn.DataPropertyName = "FIYAT";
            this.fIYATDataGridViewTextBoxColumn.HeaderText = "FIYAT";
            this.fIYATDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIYATDataGridViewTextBoxColumn.Name = "fIYATDataGridViewTextBoxColumn";
            this.fIYATDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje6DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje6BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Proje6DataSet proje6DataSet;
        private System.Windows.Forms.BindingSource proje6BindingSource;
        private Proje6DataSetTableAdapters.Proje6TableAdapter proje6TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDSOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aD1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIYATDataGridViewTextBoxColumn;
    }
}

