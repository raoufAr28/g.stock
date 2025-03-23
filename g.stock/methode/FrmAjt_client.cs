using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace g.stock.methode
{
    public partial class FrmAjt_client : Form
    {
      
        public FrmAjt_client()
        {
            InitializeComponent();
        }
        private string connectionString;

        private DataGridView dataGridView1 = new DataGridView();

        
        private void LoadData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection("your_connection_string"))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Clients", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données: " + ex.Message);
            }
        }


        private void FrmAj_client_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsauvgarder_Click(object sender, EventArgs e)
        {
            try
            {
                connectionString = "Data Source=DESKTOP-CB1FV86\\SQLEXPRESS;Initial Catalog=GESTION_DE_STOCK;Integrated Security=True;Encrypt=false";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO table_client (Nom_Client, Prenom_Client, Telephone_Client, Adress_Client, Email_Client, Ville_Client) VALUES (@Nom, @Prenom, @Telephone, @Adresse, @Email, @Ville)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nom", txtNom.Text);
                        cmd.Parameters.AddWithValue("@Prenom", txtPrenom.Text);
                        cmd.Parameters.AddWithValue("@Telephone", txtTelephone.Text);
                        cmd.Parameters.AddWithValue("@Adresse", txtAdresse.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Ville", txtVille.Text);
                        

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Client ajouté avec succès !");
                LoadData(); // تحديث البيانات بعد الإضافة
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {

        }
    }
}
