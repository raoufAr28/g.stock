namespace g.stock.panelsfill
{
    partial class UserCategorie
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCategorie));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCategorie = new System.Windows.Forms.DataGridView();
            this.iDCategorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCategorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablecategorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gESTION_DE_STOCKDataSet = new g.stock.GESTION_DE_STOCKDataSet();
            this.table_categorieTableAdapter = new g.stock.GESTION_DE_STOCKDataSetTableAdapters.table_categorieTableAdapter();
            this.txtNomCategorie = new System.Windows.Forms.TextBox();
            this.btnajoutercategorie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablecategorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_DE_STOCKDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(71, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 2);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Gestion des Categories";
            // 
            // dataGridViewCategorie
            // 
            this.dataGridViewCategorie.AutoGenerateColumns = false;
            this.dataGridViewCategorie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategorie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCategorieDataGridViewTextBoxColumn,
            this.nomCategorieDataGridViewTextBoxColumn});
            this.dataGridViewCategorie.DataSource = this.tablecategorieBindingSource;
            this.dataGridViewCategorie.Location = new System.Drawing.Point(87, 215);
            this.dataGridViewCategorie.Name = "dataGridViewCategorie";
            this.dataGridViewCategorie.RowHeadersWidth = 51;
            this.dataGridViewCategorie.RowTemplate.Height = 24;
            this.dataGridViewCategorie.Size = new System.Drawing.Size(358, 423);
            this.dataGridViewCategorie.TabIndex = 16;
            // 
            // iDCategorieDataGridViewTextBoxColumn
            // 
            this.iDCategorieDataGridViewTextBoxColumn.DataPropertyName = "ID_Categorie";
            this.iDCategorieDataGridViewTextBoxColumn.HeaderText = "ID_Categorie";
            this.iDCategorieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCategorieDataGridViewTextBoxColumn.Name = "iDCategorieDataGridViewTextBoxColumn";
            this.iDCategorieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomCategorieDataGridViewTextBoxColumn
            // 
            this.nomCategorieDataGridViewTextBoxColumn.DataPropertyName = "Nom_Categorie";
            this.nomCategorieDataGridViewTextBoxColumn.HeaderText = "Nom_Categorie";
            this.nomCategorieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomCategorieDataGridViewTextBoxColumn.Name = "nomCategorieDataGridViewTextBoxColumn";
            // 
            // tablecategorieBindingSource
            // 
            this.tablecategorieBindingSource.DataMember = "table_categorie";
            this.tablecategorieBindingSource.DataSource = this.gESTION_DE_STOCKDataSet;
            // 
            // gESTION_DE_STOCKDataSet
            // 
            this.gESTION_DE_STOCKDataSet.DataSetName = "GESTION_DE_STOCKDataSet";
            this.gESTION_DE_STOCKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_categorieTableAdapter
            // 
            this.table_categorieTableAdapter.ClearBeforeFill = true;
            // 
            // txtNomCategorie
            // 
            this.txtNomCategorie.Location = new System.Drawing.Point(186, 101);
            this.txtNomCategorie.Multiline = true;
            this.txtNomCategorie.Name = "txtNomCategorie";
            this.txtNomCategorie.Size = new System.Drawing.Size(286, 32);
            this.txtNomCategorie.TabIndex = 17;
            this.txtNomCategorie.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnajoutercategorie
            // 
            this.btnajoutercategorie.BackColor = System.Drawing.Color.White;
            this.btnajoutercategorie.FlatAppearance.BorderSize = 0;
            this.btnajoutercategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajoutercategorie.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajoutercategorie.ForeColor = System.Drawing.Color.Black;
            this.btnajoutercategorie.Image = ((System.Drawing.Image)(resources.GetObject("btnajoutercategorie.Image")));
            this.btnajoutercategorie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajoutercategorie.Location = new System.Drawing.Point(25, 101);
            this.btnajoutercategorie.Name = "btnajoutercategorie";
            this.btnajoutercategorie.Size = new System.Drawing.Size(155, 32);
            this.btnajoutercategorie.TabIndex = 18;
            this.btnajoutercategorie.Text = "          Ajouter";
            this.btnajoutercategorie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajoutercategorie.UseVisualStyleBackColor = false;
            this.btnajoutercategorie.Click += new System.EventHandler(this.btnajoutercategorie_Click);
            // 
            // UserCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnajoutercategorie);
            this.Controls.Add(this.txtNomCategorie);
            this.Controls.Add(this.dataGridViewCategorie);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "UserCategorie";
            this.Size = new System.Drawing.Size(1017, 661);
            this.Load += new System.EventHandler(this.UserCategorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablecategorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_DE_STOCKDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCategorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCategorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tablecategorieBindingSource;
        private GESTION_DE_STOCKDataSet gESTION_DE_STOCKDataSet;
        private GESTION_DE_STOCKDataSetTableAdapters.table_categorieTableAdapter table_categorieTableAdapter;
        private System.Windows.Forms.TextBox txtNomCategorie;
        private System.Windows.Forms.Button btnajoutercategorie;
    }
}
