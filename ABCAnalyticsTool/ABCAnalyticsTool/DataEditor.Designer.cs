namespace ABCAnalyticsTool
{
    partial class DataEditor
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
            this.Save = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.Evaluate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.outputBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupedDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupedDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bezeichnungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mengeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mengeProzentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anteilMengeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wertDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wertProzentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anteilWertDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupedDataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupedDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(12, 12);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 0;
            this.Save.Text = "Speichern";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(93, 12);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 23);
            this.Load.TabIndex = 1;
            this.Load.Text = "Laden";
            this.Load.UseVisualStyleBackColor = true;
            // 
            // Evaluate
            // 
            this.Evaluate.Location = new System.Drawing.Point(174, 12);
            this.Evaluate.Name = "Evaluate";
            this.Evaluate.Size = new System.Drawing.Size(75, 23);
            this.Evaluate.TabIndex = 2;
            this.Evaluate.Text = "Auswerten";
            this.Evaluate.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.bezeichnungDataGridViewTextBoxColumn,
            this.mengeDataGridViewTextBoxColumn,
            this.mengeProzentDataGridViewTextBoxColumn,
            this.anteilMengeDataGridViewTextBoxColumn,
            this.wertDataGridViewTextBoxColumn,
            this.wertProzentDataGridViewTextBoxColumn,
            this.anteilWertDataGridViewTextBoxColumn,
            this.kategorieDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.outputBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(954, 420);
            this.dataGridView1.TabIndex = 3;
            // 
            // outputBindingSource
            // 
            this.outputBindingSource.DataSource = typeof(Domain.Output);
            // 
            // groupedDataBindingSource1
            // 
            this.groupedDataBindingSource1.DataSource = typeof(Domain.GroupedData);
            // 
            // dataBindingSource
            // 
            this.dataBindingSource.DataSource = typeof(Domain.Data);
            // 
            // groupedDataBindingSource
            // 
            this.groupedDataBindingSource.DataSource = typeof(Domain.GroupedData);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bezeichnungDataGridViewTextBoxColumn
            // 
            this.bezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn.HeaderText = "Bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn.Name = "bezeichnungDataGridViewTextBoxColumn";
            this.bezeichnungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mengeDataGridViewTextBoxColumn
            // 
            this.mengeDataGridViewTextBoxColumn.DataPropertyName = "Menge";
            this.mengeDataGridViewTextBoxColumn.HeaderText = "Menge";
            this.mengeDataGridViewTextBoxColumn.Name = "mengeDataGridViewTextBoxColumn";
            this.mengeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mengeProzentDataGridViewTextBoxColumn
            // 
            this.mengeProzentDataGridViewTextBoxColumn.DataPropertyName = "MengeProzent";
            this.mengeProzentDataGridViewTextBoxColumn.HeaderText = "MengeProzent";
            this.mengeProzentDataGridViewTextBoxColumn.Name = "mengeProzentDataGridViewTextBoxColumn";
            this.mengeProzentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anteilMengeDataGridViewTextBoxColumn
            // 
            this.anteilMengeDataGridViewTextBoxColumn.DataPropertyName = "AnteilMenge";
            this.anteilMengeDataGridViewTextBoxColumn.HeaderText = "AnteilMenge";
            this.anteilMengeDataGridViewTextBoxColumn.Name = "anteilMengeDataGridViewTextBoxColumn";
            this.anteilMengeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wertDataGridViewTextBoxColumn
            // 
            this.wertDataGridViewTextBoxColumn.DataPropertyName = "Wert";
            this.wertDataGridViewTextBoxColumn.HeaderText = "Wert";
            this.wertDataGridViewTextBoxColumn.Name = "wertDataGridViewTextBoxColumn";
            this.wertDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wertProzentDataGridViewTextBoxColumn
            // 
            this.wertProzentDataGridViewTextBoxColumn.DataPropertyName = "WertProzent";
            this.wertProzentDataGridViewTextBoxColumn.HeaderText = "WertProzent";
            this.wertProzentDataGridViewTextBoxColumn.Name = "wertProzentDataGridViewTextBoxColumn";
            this.wertProzentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anteilWertDataGridViewTextBoxColumn
            // 
            this.anteilWertDataGridViewTextBoxColumn.DataPropertyName = "AnteilWert";
            this.anteilWertDataGridViewTextBoxColumn.HeaderText = "AnteilWert";
            this.anteilWertDataGridViewTextBoxColumn.Name = "anteilWertDataGridViewTextBoxColumn";
            this.anteilWertDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kategorieDataGridViewTextBoxColumn
            // 
            this.kategorieDataGridViewTextBoxColumn.DataPropertyName = "Kategorie";
            this.kategorieDataGridViewTextBoxColumn.HeaderText = "Kategorie";
            this.kategorieDataGridViewTextBoxColumn.Name = "kategorieDataGridViewTextBoxColumn";
            this.kategorieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DataEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 473);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Evaluate);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Save);
            this.Name = "DataEditor";
            this.Text = "DataEditor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupedDataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupedDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Evaluate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataBindingSource;
        private System.Windows.Forms.BindingSource groupedDataBindingSource;
        private System.Windows.Forms.BindingSource groupedDataBindingSource1;
        private System.Windows.Forms.BindingSource outputBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mengeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mengeProzentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anteilMengeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wertDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wertProzentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anteilWertDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorieDataGridViewTextBoxColumn;
    }
}