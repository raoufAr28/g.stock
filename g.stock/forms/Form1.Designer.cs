namespace g.stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnprofile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnutilisateur = new System.Windows.Forms.Button();
            this.btnemployee = new System.Windows.Forms.Button();
            this.btncommande = new System.Windows.Forms.Button();
            this.btnproduit = new System.Windows.Forms.Button();
            this.btncategorie = new System.Windows.Forms.Button();
            this.btnclient = new System.Windows.Forms.Button();
            this.panelfill = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelfill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnprofile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(243, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 82);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(568, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(346, 1);
            this.panel3.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(568, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 15);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Recherche";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.MouseEnter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.MouseLeave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(972, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "raouf";
            // 
            // btnprofile
            // 
            this.btnprofile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnprofile.FlatAppearance.BorderSize = 0;
            this.btnprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprofile.Image = ((System.Drawing.Image)(resources.GetObject("btnprofile.Image")));
            this.btnprofile.Location = new System.Drawing.Point(956, 7);
            this.btnprofile.Name = "btnprofile";
            this.btnprofile.Size = new System.Drawing.Size(74, 51);
            this.btnprofile.TabIndex = 0;
            this.btnprofile.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnutilisateur);
            this.panel1.Controls.Add(this.btnemployee);
            this.panel1.Controls.Add(this.btncommande);
            this.panel1.Controls.Add(this.btnproduit);
            this.panel1.Controls.Add(this.btncategorie);
            this.panel1.Controls.Add(this.btnclient);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 770);
            this.panel1.TabIndex = 0;
            // 
            // btnlogout
            // 
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Image = ((System.Drawing.Image)(resources.GetObject("btnlogout.Image")));
            this.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.Location = new System.Drawing.Point(1, 720);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(240, 50);
            this.btnlogout.TabIndex = 6;
            this.btnlogout.Text = "          log out";
            this.btnlogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // btnutilisateur
            // 
            this.btnutilisateur.FlatAppearance.BorderSize = 0;
            this.btnutilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnutilisateur.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnutilisateur.Image = ((System.Drawing.Image)(resources.GetObject("btnutilisateur.Image")));
            this.btnutilisateur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnutilisateur.Location = new System.Drawing.Point(0, 453);
            this.btnutilisateur.Name = "btnutilisateur";
            this.btnutilisateur.Size = new System.Drawing.Size(240, 50);
            this.btnutilisateur.TabIndex = 5;
            this.btnutilisateur.Text = "          Utilisateur";
            this.btnutilisateur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnutilisateur.UseVisualStyleBackColor = true;
            // 
            // btnemployee
            // 
            this.btnemployee.FlatAppearance.BorderSize = 0;
            this.btnemployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnemployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemployee.Image = ((System.Drawing.Image)(resources.GetObject("btnemployee.Image")));
            this.btnemployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnemployee.Location = new System.Drawing.Point(0, 397);
            this.btnemployee.Name = "btnemployee";
            this.btnemployee.Size = new System.Drawing.Size(240, 50);
            this.btnemployee.TabIndex = 4;
            this.btnemployee.Text = "          Employee";
            this.btnemployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnemployee.UseVisualStyleBackColor = true;
            // 
            // btncommande
            // 
            this.btncommande.FlatAppearance.BorderSize = 0;
            this.btncommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncommande.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncommande.Image = ((System.Drawing.Image)(resources.GetObject("btncommande.Image")));
            this.btncommande.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncommande.Location = new System.Drawing.Point(0, 341);
            this.btncommande.Name = "btncommande";
            this.btncommande.Size = new System.Drawing.Size(240, 50);
            this.btncommande.TabIndex = 3;
            this.btncommande.Text = "          Commande";
            this.btncommande.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncommande.UseVisualStyleBackColor = true;
            this.btncommande.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnproduit
            // 
            this.btnproduit.FlatAppearance.BorderSize = 0;
            this.btnproduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproduit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproduit.Image = ((System.Drawing.Image)(resources.GetObject("btnproduit.Image")));
            this.btnproduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproduit.Location = new System.Drawing.Point(0, 285);
            this.btnproduit.Name = "btnproduit";
            this.btnproduit.Size = new System.Drawing.Size(240, 50);
            this.btnproduit.TabIndex = 2;
            this.btnproduit.Text = "          Produit";
            this.btnproduit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproduit.UseVisualStyleBackColor = true;
            this.btnproduit.Click += new System.EventHandler(this.button3_Click);
            // 
            // btncategorie
            // 
            this.btncategorie.FlatAppearance.BorderSize = 0;
            this.btncategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncategorie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategorie.Image = ((System.Drawing.Image)(resources.GetObject("btncategorie.Image")));
            this.btncategorie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncategorie.Location = new System.Drawing.Point(0, 229);
            this.btncategorie.Name = "btncategorie";
            this.btncategorie.Size = new System.Drawing.Size(240, 50);
            this.btncategorie.TabIndex = 1;
            this.btncategorie.Text = "          Categorie";
            this.btncategorie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncategorie.UseVisualStyleBackColor = true;
            this.btncategorie.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnclient
            // 
            this.btnclient.FlatAppearance.BorderSize = 0;
            this.btnclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclient.Image = ((System.Drawing.Image)(resources.GetObject("btnclient.Image")));
            this.btnclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclient.Location = new System.Drawing.Point(0, 173);
            this.btnclient.Name = "btnclient";
            this.btnclient.Size = new System.Drawing.Size(240, 50);
            this.btnclient.TabIndex = 0;
            this.btnclient.Text = "          Client";
            this.btnclient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclient.UseVisualStyleBackColor = true;
            this.btnclient.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelfill
            // 
            this.panelfill.BackColor = System.Drawing.Color.White;
            this.panelfill.Controls.Add(this.label2);
            this.panelfill.Controls.Add(this.pictureBox1);
            this.panelfill.Location = new System.Drawing.Point(252, 94);
            this.panelfill.Name = "panelfill";
            this.panelfill.Size = new System.Drawing.Size(1017, 661);
            this.panelfill.TabIndex = 2;
            this.panelfill.Paint += new System.Windows.Forms.PaintEventHandler(this.panelfill_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Mistral", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(359, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 46);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gestion de Stock";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(252, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(519, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1277, 770);
            this.Controls.Add(this.panelfill);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelfill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnclient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnemployee;
        private System.Windows.Forms.Button btncommande;
        private System.Windows.Forms.Button btnproduit;
        private System.Windows.Forms.Button btncategorie;
        private System.Windows.Forms.Button btnutilisateur;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnprofile;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelfill;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

