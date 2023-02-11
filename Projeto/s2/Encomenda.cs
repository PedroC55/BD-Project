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
    public partial class Encomenda : UserControl
    {
        private int currentClient;

        string stringconnection = @"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=p8g5;Persist Security Info=True;User ID=p8g5;Password=marinheiroMC5";
        public Encomenda()
        {
            InitializeComponent();
        }
        private Form2 mainForm = null;
        public Encomenda(Form callingForm)
        {
            mainForm = callingForm as Form2;
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Encomenda_Load(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(stringconnection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PF.PRODUTO", con);
                SqlDataReader reader = cmd.ExecuteReader();
                prodlist.Items.Clear();



                while (reader.Read())
                {
                    Produto prod = new Produto();
                    prod.Código = reader["Código"].ToString();
                    prod.Nome = reader["Nome"].ToString();
                    //prodlist.Items.Add(reader["Código"].ToString() + "         " + reader["Nome"].ToString());
                    prodlist.Items.Add(prod);

                }
                con.Close();


            }

            using (SqlConnection con = new SqlConnection(stringconnection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PF.TRANSPORTADORA", con);
                SqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {

                    transcombo.Items.Add(reader["Nome"].ToString());


                }
                con.Close();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clientcombo.SelectedIndex >= 0)
            {
                currentClient = clientcombo.SelectedIndex;
                ShowContact();
            }
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            using (SqlConnection con = new SqlConnection(stringconnection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PF.CLIENTE WHERE PF.CLIENTE.Nome_Empresa='Ctesi'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                clientcombo.Items.Clear();

                while (reader.Read())
                {
                    Cliente c = new Cliente();
                    c.Nome = reader["Nome"].ToString();
                    c.Nº_CC = reader["Nº_CC"].ToString();
                    c.Endereço = reader["Endereço"].ToString();
                    clientcombo.Items.Add(c);

                }
                con.Close();

                currentClient = 0;
                ShowContact();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtEndereço.Enabled = true;
            txtEndereço.Text = "";
        }

        private void rdbPre_CheckedChanged(object sender, EventArgs e)
        {
            txtEndereço.Enabled=false;
        }

        private void transcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void transcombo_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnEncomenda_Click(object sender, EventArgs e)
        {
            if (prodlist.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Tem de adicionar produtos à encomenda");
            }
            else 
            {
                using (SqlConnection con = new SqlConnection(stringconnection))
                {
                    con.Open();
                    string s = "PF.AdicionarEnvio";
                    SqlCommand cmd = new SqlCommand(s, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Hora", txthora.Text.ToString());
                    cmd.Parameters.AddWithValue("@Destino", txtEndereço.Text.ToString());
                    cmd.Parameters.AddWithValue("@Nº_de_encomendas", "1");
                    cmd.Parameters.AddWithValue("@Nome_Transportadora", transcombo.Text.ToString());

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to add order in database. \n ERROR MESSAGE: \n" + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }

                }


                using (SqlConnection con = new SqlConnection(stringconnection))
                {
                    con.Open();
                    string s = "PF.AdicionarEncomenda";
                    SqlCommand cmd = new SqlCommand(s, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Número", txtnumero.Text.ToString());
                    cmd.Parameters.AddWithValue("@Data", datapicker.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Hora_Envio", txthora.Text.ToString());
                    cmd.Parameters.AddWithValue("@Endereço", txtEndereço.Text.ToString());
                    cmd.Parameters.AddWithValue("@Nome_Empresa", "Ctesi");
                    cmd.Parameters.AddWithValue("@Nome_Cliente", clientcombo.Text.ToString());

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Encomenda adicionada com sucesso.");
                        ClearFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to add order in database. \n ERROR MESSAGE: \n" + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }

                }

                

                
            }

            
        }

        private void ClearFields() {
            txtEndereço.Text = "";
            txthora.Text = "";
            txtnumero.Text = "";
            clientcombo.SelectedIndex = -1;
            transcombo.SelectedIndex = -1;

            foreach (int i in prodlist.CheckedIndices)
            {
                prodlist.SetItemCheckState(i, CheckState.Unchecked);
            }

        }

        private void ShowContact() 
        {
            if (clientcombo.Items.Count == 0 | currentClient < 0)
                return;

            Cliente cliente = new Cliente();
            cliente = (Cliente)clientcombo.Items[currentClient];

            txtEndereço.Text = cliente.Endereço;
        }
    }
}
