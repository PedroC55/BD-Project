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
    public partial class UserControl3 : UserControl
    {
        private int currentProduct;
        private String i;

        string stringconnection = @"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=p8g5;Persist Security Info=True;User ID=p8g5;Password=marinheiroMC5";

        public UserControl3()
        {
            InitializeComponent();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            panel1.Hide();


            using (SqlConnection con = new SqlConnection(stringconnection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PF.PRODUTO", con);
                SqlDataReader reader = cmd.ExecuteReader();
                listProd.Items.Clear();

                List<Produto> produtos = null;


                while (reader.Read())
                {
                    Produto prod = new Produto();

                    ListViewItem item = new ListViewItem(reader["Código"].ToString());
                    prod.Código = reader["Código"].ToString();

                    item.SubItems.Add(reader["Nome"].ToString());
                    prod.Nome = reader["Nome"].ToString();

                    item.SubItems.Add(reader["Preço"].ToString());
                    prod.Preço = reader["Preço"].ToString();

                    
    

                    listProd.Items.Add(item);
                    i = item.ToString();

                    //MessageBox.Show(item.ToString());

                    item.SubItems.Add(reader["Taxa_de_IVA"].ToString());
                    prod.Taxa_de_IVA = reader["Taxa_de_Iva"].ToString();
                    item.SubItems.Add(reader["Nº_em_stock"].ToString());
                    prod.Nº_em_Stock = reader["Nº_em_Stock"].ToString();
                    prod.Nome_Empresa = reader["Nome_Empresa"].ToString();
                    item.SubItems.Add(reader["Tipo_Categoria"].ToString());
                    prod.Tipo_Categoria = reader["Tipo_categoria"].ToString();
                }
                con.Close();

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

        private void AddProd_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void ProdutosLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            ProdutDetails p = new ProdutDetails();
            p.Show();

        }

        private void listProd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CriarProd_Click(object sender, EventArgs e)
        {
            panel1.Show();
            CriarProd.Hide();
        }

        private void Listaprod_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            CriarProd.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
                    ClearFields();
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

            using (SqlConnection con = new SqlConnection(stringconnection))
            {
                con.Open();
                SqlCommand cmdprod = new SqlCommand("SELECT * FROM PF.PRODUTO", con);
                SqlDataReader reader = cmdprod.ExecuteReader();
                listProd.Items.Clear();

                while (reader.Read())
                {
                    Produto prod = new Produto();

                    ListViewItem item = new ListViewItem(reader["Código"].ToString());
                    prod.Código = reader["Código"].ToString();

                    item.SubItems.Add(reader["Nome"].ToString());
                    prod.Nome = reader["Nome"].ToString();

                    item.SubItems.Add(reader["Preço"].ToString());
                    prod.Preço = reader["Preço"].ToString();

                    item.SubItems.Add(reader["Taxa_de_IVA"].ToString());
                    prod.Taxa_de_IVA = reader["Taxa_de_Iva"].ToString();
                    item.SubItems.Add(reader["Nº_em_stock"].ToString());
                    prod.Nº_em_Stock = reader["Nº_em_Stock"].ToString();
                    prod.Nome_Empresa = reader["Nome_Empresa"].ToString();
                    item.SubItems.Add(reader["Tipo_Categoria"].ToString());
                    prod.Tipo_Categoria = reader["Tipo_categoria"].ToString();

                    listProd.Items.Add(item);
                }
                con.Close();
            }
        }

        private void ClearFields()
        {
            txtnome.Text = "";
            txtcodigo.Text = "";
            txtpreço.Text = "";
            txtstock.Text = "";
            catcombo.Text = "";
        }

        private void apgbtn_Click(object sender, EventArgs e)
        {
            currentProduct = listProd.SelectedItems.Count;
            if (currentProduct <= 0)
            {
                MessageBox.Show("Por favor selecione um Produto para eliminar!");
            }
            else
            {
                using (SqlConnection con = new SqlConnection(stringconnection))
                {
                    con.Open();
                    string s = "DELETE PF.PRODUTO WHERE Código=@Código";
                    SqlCommand cmd = new SqlCommand(s, con);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Código", listProd.SelectedItems[0].Text);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Produto removido com sucesso.");
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Failed to delete contact in database. \n ERROR MESSAGE: \n" + ex.Message);
                    }

                    finally
                    {
                        con.Close();
                    }


                    listProd.SelectedItems[0].Remove();



                }
            }
        }
    }
}
