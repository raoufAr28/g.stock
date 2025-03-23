using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace g.stock.panelsfill
{
    public partial class UserCategorie : UserControl
    {

        public UserCategorie()
        {
            InitializeComponent();
        }
        private string connectionString;

        private void LoadCategories() 
        { 

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnajoutercategorie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomCategorie.Text))
            {
                MessageBox.Show("Veuillez entrer un nom de catégorie.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = "Data Source=DESKTOP-CB1FV86\\SQLEXPRESS;Initial Catalog=GESTION_DE_STOCK;Integrated Security=True;";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO table_categorie (Nom_Categorie) VALUES (@nom)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@nom", txtNomCategorie.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Catégorie ajoutée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ✅ تحديث الـ DataGridView مباشرة بعد الإضافة
                LoadCategories();

                // ✅ مسح الحقل بعد الإضافة
                txtNomCategorie.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserCategorie_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-CB1FV86\\SQLEXPRESS;Initial Catalog=GESTION_DE_STOCK;Integrated Security=True;"))
                {
                    con.Open();
                    string query = "SELECT * FROM table_categorie"; // تأكد من صحة اسم الجدول

                    using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewCategorie.DataSource = dt;
                        dataGridViewCategorie.Refresh(); // تحديث DataGridView
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء تحميل البيانات: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

