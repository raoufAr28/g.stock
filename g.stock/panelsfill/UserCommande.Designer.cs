namespace g.stock.panelsfill
{
    partial class UserCommande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCommande));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gESTION_DE_STOCKDataSet3 = new g.stock.GESTION_DE_STOCKDataSet3();
            this.tablecommandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_commandeTableAdapter = new g.stock.GESTION_DE_STOCKDataSet3TableAdapters.table_commandeTableAdapter();
            this.iDCommandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCommandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_DE_STOCKDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablecommandeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Constantia", 13.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(502, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "Date fin :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Constantia", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Date Debut :";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(738, 604);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(236, 35);
            this.button5.TabIndex = 23;
            this.button5.Text = "     Imprimer Commande";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(686, 248);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(247, 22);
            this.dateTimePicker2.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(686, 128);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 22);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(31, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 32);
            this.button3.TabIndex = 19;
            this.button3.Text = "          Ajouter";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCommandeDataGridViewTextBoxColumn,
            this.dateCommandeDataGridViewTextBoxColumn,
            this.montantTotalDataGridViewTextBoxColumn,
            this.iDClientDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tablecommandeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(417, 542);
            this.dataGridView1.TabIndex = 26;
            // 
            // gESTION_DE_STOCKDataSet3
            // 
            this.gESTION_DE_STOCKDataSet3.DataSetName = "GESTION_DE_STOCKDataSet3";
            this.gESTION_DE_STOCKDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablecommandeBindingSource
            // 
            this.tablecommandeBindingSource.DataMember = "table_commande";
            this.tablecommandeBindingSource.DataSource = this.gESTION_DE_STOCKDataSet3;
            // 
            // table_commandeTableAdapter
            // 
            this.table_commandeTableAdapter.ClearBeforeFill = true;
            // 
            // iDCommandeDataGridViewTextBoxColumn
            // 
            this.iDCommandeDataGridViewTextBoxColumn.DataPropertyName = "ID_Commande";
            this.iDCommandeDataGridViewTextBoxColumn.HeaderText = "ID_Commande";
            this.iDCommandeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCommandeDataGridViewTextBoxColumn.Name = "iDCommandeDataGridViewTextBoxColumn";
            this.iDCommandeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateCommandeDataGridViewTextBoxColumn
            // 
            this.dateCommandeDataGridViewTextBoxColumn.DataPropertyName = "Date_Commande";
            this.dateCommandeDataGridViewTextBoxColumn.HeaderText = "Date_Commande";
            this.dateCommandeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateCommandeDataGridViewTextBoxColumn.Name = "dateCommandeDataGridViewTextBoxColumn";
            this.dateCommandeDataGridViewTextBoxColumn.Width = 125;
            // 
            // montantTotalDataGridViewTextBoxColumn
            // 
            this.montantTotalDataGridViewTextBoxColumn.DataPropertyName = "Montant_Total";
            this.montantTotalDataGridViewTextBoxColumn.HeaderText = "Montant_Total";
            this.montantTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.montantTotalDataGridViewTextBoxColumn.Name = "montantTotalDataGridViewTextBoxColumn";
            this.montantTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDClientDataGridViewTextBoxColumn
            // 
            this.iDClientDataGridViewTextBoxColumn.DataPropertyName = "ID_Client";
            this.iDClientDataGridViewTextBoxColumn.HeaderText = "ID_Client";
            this.iDClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDClientDataGridViewTextBoxColumn.Name = "iDClientDataGridViewTextBoxColumn";
            this.iDClientDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDClientDataGridViewTextBoxColumn.Width = 125;
            // 
            // UserCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button3);
            this.Name = "UserCommande";
            this.Size = new System.Drawing.Size(1017, 661);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_DE_STOCKDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablecommandeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCommandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCommandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tablecommandeBindingSource;
        private GESTION_DE_STOCKDataSet3 gESTION_DE_STOCKDataSet3;
        private GESTION_DE_STOCKDataSet3TableAdapters.table_commandeTableAdapter table_commandeTableAdapter;
    }
}
