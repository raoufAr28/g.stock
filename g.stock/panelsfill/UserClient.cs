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
using g.stock.methode;
using MetroFramework;

namespace g.stock.panelsfill
{
    public partial class UserClient : UserControl
    {
        private MetroColorStyle Style;

       
        public UserClient()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnajouterclient_Click(object sender, EventArgs e)
        {
            FrmAjt_client client = new FrmAjt_client();
            client.ShowDialog();
            

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserClient_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Server=DESKTOP-CB1FV86\\SQLEXPRESS;Database=GESTION_DE_STOCK;Integrated Security=True;"))
                {
                    con.Open(); 
                    string query = "SELECT * FROM table_client"; // استبدل table_client باسم جدول العملاء لديك

                    using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewClient.DataSource = dt; // تعيين البيانات في DataGridView
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

