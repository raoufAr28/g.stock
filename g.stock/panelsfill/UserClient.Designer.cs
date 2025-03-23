namespace g.stock.panelsfill
{
    partial class UserClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserClient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsupprimerclient = new System.Windows.Forms.Button();
            this.btnmodifieclient = new System.Windows.Forms.Button();
            this.btnajouterclient = new System.Windows.Forms.Button();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.iDClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableclientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gESTION_DE_STOCKDataSet5 = new g.stock.GESTION_DE_STOCKDataSet5();
            this.table_clientTableAdapter = new g.stock.GESTION_DE_STOCKDataSet5TableAdapters.table_clientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableclientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_DE_STOCKDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(36, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 2);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Gestion des Clients";
            // 
            // btnsupprimerclient
            // 
            this.btnsupprimerclient.BackColor = System.Drawing.Color.White;
            this.btnsupprimerclient.FlatAppearance.BorderSize = 0;
            this.btnsupprimerclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsupprimerclient.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimerclient.ForeColor = System.Drawing.Color.Black;
            this.btnsupprimerclient.Image = ((System.Drawing.Image)(resources.GetObject("btnsupprimerclient.Image")));
            this.btnsupprimerclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsupprimerclient.Location = new System.Drawing.Point(392, 106);
            this.btnsupprimerclient.Name = "btnsupprimerclient";
            this.btnsupprimerclient.Size = new System.Drawing.Size(222, 32);
            this.btnsupprimerclient.TabIndex = 11;
            this.btnsupprimerclient.Text = "         Supprimer";
            this.btnsupprimerclient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsupprimerclient.UseVisualStyleBackColor = false;
            // 
            // btnmodifieclient
            // 
            this.btnmodifieclient.BackColor = System.Drawing.Color.White;
            this.btnmodifieclient.FlatAppearance.BorderSize = 0;
            this.btnmodifieclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodifieclient.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifieclient.ForeColor = System.Drawing.Color.Black;
            this.btnmodifieclient.Image = ((System.Drawing.Image)(resources.GetObject("btnmodifieclient.Image")));
            this.btnmodifieclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodifieclient.Location = new System.Drawing.Point(620, 106);
            this.btnmodifieclient.Name = "btnmodifieclient";
            this.btnmodifieclient.Size = new System.Drawing.Size(222, 32);
            this.btnmodifieclient.TabIndex = 10;
            this.btnmodifieclient.Text = "          Modifier";
            this.btnmodifieclient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodifieclient.UseVisualStyleBackColor = false;
            // 
            // btnajouterclient
            // 
            this.btnajouterclient.BackColor = System.Drawing.Color.White;
            this.btnajouterclient.FlatAppearance.BorderSize = 0;
            this.btnajouterclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouterclient.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouterclient.ForeColor = System.Drawing.Color.Black;
            this.btnajouterclient.Image = ((System.Drawing.Image)(resources.GetObject("btnajouterclient.Image")));
            this.btnajouterclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajouterclient.Location = new System.Drawing.Point(164, 106);
            this.btnajouterclient.Name = "btnajouterclient";
            this.btnajouterclient.Size = new System.Drawing.Size(222, 32);
            this.btnajouterclient.TabIndex = 9;
            this.btnajouterclient.Text = "          Ajouter";
            this.btnajouterclient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajouterclient.UseVisualStyleBackColor = false;
            this.btnajouterclient.Click += new System.EventHandler(this.btnajouterclient_Click);
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AutoGenerateColumns = false;
            this.dataGridViewClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDClientDataGridViewTextBoxColumn,
            this.nomClientDataGridViewTextBoxColumn,
            this.prenomClientDataGridViewTextBoxColumn,
            this.telephoneClientDataGridViewTextBoxColumn,
            this.adressClientDataGridViewTextBoxColumn,
            this.emailClientDataGridViewTextBoxColumn,
            this.villeClientDataGridViewTextBoxColumn});
            this.dataGridViewClient.DataSource = this.tableclientBindingSource;
            this.dataGridViewClient.Location = new System.Drawing.Point(36, 179);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.RowHeadersWidth = 51;
            this.dataGridViewClient.RowTemplate.Height = 24;
            this.dataGridViewClient.Size = new System.Drawing.Size(934, 379);
            this.dataGridViewClient.TabIndex = 14;
            this.dataGridViewClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // iDClientDataGridViewTextBoxColumn
            // 
            this.iDClientDataGridViewTextBoxColumn.DataPropertyName = "ID_Client";
            this.iDClientDataGridViewTextBoxColumn.HeaderText = "ID_Client";
            this.iDClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDClientDataGridViewTextBoxColumn.Name = "iDClientDataGridViewTextBoxColumn";
            this.iDClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomClientDataGridViewTextBoxColumn
            // 
            this.nomClientDataGridViewTextBoxColumn.DataPropertyName = "Nom_Client";
            this.nomClientDataGridViewTextBoxColumn.HeaderText = "Nom_Client";
            this.nomClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomClientDataGridViewTextBoxColumn.Name = "nomClientDataGridViewTextBoxColumn";
            // 
            // prenomClientDataGridViewTextBoxColumn
            // 
            this.prenomClientDataGridViewTextBoxColumn.DataPropertyName = "Prenom_Client";
            this.prenomClientDataGridViewTextBoxColumn.HeaderText = "Prenom_Client";
            this.prenomClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prenomClientDataGridViewTextBoxColumn.Name = "prenomClientDataGridViewTextBoxColumn";
            // 
            // telephoneClientDataGridViewTextBoxColumn
            // 
            this.telephoneClientDataGridViewTextBoxColumn.DataPropertyName = "Telephone_Client";
            this.telephoneClientDataGridViewTextBoxColumn.HeaderText = "Telephone_Client";
            this.telephoneClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telephoneClientDataGridViewTextBoxColumn.Name = "telephoneClientDataGridViewTextBoxColumn";
            // 
            // adressClientDataGridViewTextBoxColumn
            // 
            this.adressClientDataGridViewTextBoxColumn.DataPropertyName = "Adress_Client";
            this.adressClientDataGridViewTextBoxColumn.HeaderText = "Adress_Client";
            this.adressClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adressClientDataGridViewTextBoxColumn.Name = "adressClientDataGridViewTextBoxColumn";
            // 
            // emailClientDataGridViewTextBoxColumn
            // 
            this.emailClientDataGridViewTextBoxColumn.DataPropertyName = "Email_Client";
            this.emailClientDataGridViewTextBoxColumn.HeaderText = "Email_Client";
            this.emailClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailClientDataGridViewTextBoxColumn.Name = "emailClientDataGridViewTextBoxColumn";
            // 
            // villeClientDataGridViewTextBoxColumn
            // 
            this.villeClientDataGridViewTextBoxColumn.DataPropertyName = "Ville_Client";
            this.villeClientDataGridViewTextBoxColumn.HeaderText = "Ville_Client";
            this.villeClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.villeClientDataGridViewTextBoxColumn.Name = "villeClientDataGridViewTextBoxColumn";
            // 
            // tableclientBindingSource
            // 
            this.tableclientBindingSource.DataMember = "table_client";
            this.tableclientBindingSource.DataSource = this.gESTION_DE_STOCKDataSet5;
            // 
            // gESTION_DE_STOCKDataSet5
            // 
            this.gESTION_DE_STOCKDataSet5.DataSetName = "GESTION_DE_STOCKDataSet5";
            this.gESTION_DE_STOCKDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_clientTableAdapter
            // 
            this.table_clientTableAdapter.ClearBeforeFill = true;
            // 
            // UserClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridViewClient);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsupprimerclient);
            this.Controls.Add(this.btnmodifieclient);
            this.Controls.Add(this.btnajouterclient);
            this.Name = "UserClient";
            this.Size = new System.Drawing.Size(1017, 661);
            this.Load += new System.EventHandler(this.UserClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableclientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_DE_STOCKDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsupprimerclient;
        private System.Windows.Forms.Button btnmodifieclient;
        private System.Windows.Forms.Button btnajouterclient;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tableclientBindingSource;
        private GESTION_DE_STOCKDataSet5 gESTION_DE_STOCKDataSet5;
        private GESTION_DE_STOCKDataSet5TableAdapters.table_clientTableAdapter table_clientTableAdapter;
    }
}
