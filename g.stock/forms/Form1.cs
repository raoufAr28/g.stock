using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using g.stock.panelsfill;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace g.stock
{
    public partial class Form1 : Form
    {
        private bool dragging = false;
        private Point startPoint;
        public Form1()
        {
            InitializeComponent();
            panel2.MouseDown += Panel2_MouseDown;
            panel2.MouseMove += Panel2_MouseMove;
            panel2.MouseUp += Panel2_MouseUp;
        }
        private void LoadUserControlclient()
        {
            panelfill.Controls.Clear();

            UserClient Uclient = new UserClient();

            Uclient.Dock = DockStyle.Fill;

            panelfill.Controls.Add(Uclient);
        }
        private void LoadUserControlproduit()
        {
            panelfill.Controls.Clear();

            UserProduit Uproduit = new UserProduit();

            Uproduit.Dock = DockStyle.Fill;

            panelfill.Controls.Add(Uproduit);
        }
        private void LoadUserControlcommande()
        {
            panelfill.Controls.Clear();

            UserCommande Ucommande = new UserCommande();

            Ucommande.Dock = DockStyle.Fill;

            panelfill.Controls.Add(Ucommande);
        }
        private void LoadUserControlcategorie()
        {
            panelfill.Controls.Clear();

            UserCategorie Ucommande = new UserCategorie();

            Ucommande.Dock = DockStyle.Fill;

            panelfill.Controls.Add(Ucommande);
        }
        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            LoadUserControlcategorie();
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Recherche")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black; // تغيير اللون للنص الحقيقي
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Recherche";
                textBox1.ForeColor = Color.Gray; // إعادة لون النص الوهمي
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadUserControlclient();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadUserControlproduit();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadUserControlcommande();
        }
        private void panelfill_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
