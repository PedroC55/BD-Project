using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace s2
{
    public partial class UserControl4 : UserControl
    {
        string stringconnection = @"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=p8g5;Persist Security Info=True;User ID=p8g5;Password=marinheiroMC5";

        public UserControl4()
        {
            InitializeComponent();
        }

        private void UserControl4_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(stringconnection))
            {
                con.Open();
                //string s = "select PF.AdicionarCliente(@Nome, @Endereço, @Nº_CC, @Género, @Email, @Nome_Empresa)";
                string s = "PF.AdicionarProduto";
                SqlCommand cmd = new SqlCommand(s, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Código", txtcodigo.Text.ToString());
                cmd.Parameters.AddWithValue("@Nome", txtnome.Text.ToString());
                cmd.Parameters.AddWithValue("@Preço", txtpreço.Text.ToString());
                cmd.Parameters.AddWithValue("@Taxa_de_IVA", "23");
                cmd.Parameters.AddWithValue("@Nº_em_stock", txtstock.Text.ToString());
                cmd.Parameters.AddWithValue("@Nome_Empresa", "Ctesi");
                cmd.Parameters.AddWithValue("@Tipo_Categoria", catcombo.Text.ToString());

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto adicionado com sucesso.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to add product in database. \n ERROR MESSAGE: \n" + ex.Message);
                }
                finally
                {
                    con.Close();
                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControl4_Load_1(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(stringconnection))
            {
                con.Open();
                SqlCommand cemp = new SqlCommand("SELECT * FROM PF.CATEGORIA", con);
                SqlDataReader read = cemp.ExecuteReader();

                while (read.Read())
                {
                    Categoria C = new Categoria();
                    C.Tipo = read["Tipo"].ToString();
                    catcombo.Items.Add(C);
                }
                con.Close();
            }
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
