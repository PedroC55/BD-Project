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
    public partial class Fornecedores : UserControl
    {
        private int currentforn;
        private int currentForn;
        string stringconnection = @"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=p8g5;Persist Security Info=True;User ID=p8g5;Password=marinheiroMC5";
        public Fornecedores()
        {
            InitializeComponent();
        }

        private void fornecedorcombo_MouseClick(object sender, MouseEventArgs e)
        {   
            
        }

        private void Fornecedores_Load(object sender, EventArgs e)
        {
            cancelbtn.Hide();
            listenc.Hide();
            okbtn.Hide();

            using (SqlConnection con = new SqlConnection(stringconnection))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PF.FORNECEDOR ", con);
                SqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    Fornecedor f = new Fornecedor();
                    f.Nome = reader["Nome"].ToString();
                    f.Endereço = reader["Endereço"].ToString();
                    f.Nºfax = reader["Nº_FAX"].ToString();
                    f.Nºid_fiscal = reader["Nº_Inf_fiscal"].ToString();
                    f.Mat_Prima = reader["Qualidade_mat"].ToString();
                    fornecedorcombo.Items.Add(f);
                }
                con.Close();

                currentForn = 0;
                ShowContact();


            }
       
            ClearFields();
            LockTXT();

        }

        private void fornecedorcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fornecedorcombo.SelectedIndex >= 0)
            {
                currentForn = fornecedorcombo.SelectedIndex;
                ShowContact();
            }


        }
       
        private void listClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fornecedorcombo.SelectedIndex >= 0)
            {
                currentForn = fornecedorcombo.SelectedIndex;
                
            }
        }

        private void btnEncomenda_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(stringconnection))
            {
                con.Open();
                string s = "PF.AdicionarFornEmpre";
                SqlCommand cmd = new SqlCommand(s, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nome_Fornecedor", fornecedorcombo.Text.ToString());
                cmd.Parameters.AddWithValue("@Nome_Empresa", "Ctesi");
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

        public void ShowContact()
        {
            if (fornecedorcombo.Items.Count == 0 | currentForn < 0)
                return;

            Fornecedor f = new Fornecedor();
            f = (Fornecedor)fornecedorcombo.Items[currentForn];

            nfaxtxt.Text = f.Nºfax;
            enderecotxt.Text = f.Endereço;
            ninftxt.Text = f.Nºid_fiscal;
            materiaprimatxt.Text = f.Mat_Prima;

        }

        public void ClearFields() {
            fornecedorcombo.SelectedIndex = -1;
            enderecotxt.Text = "";
            materiaprimatxt.Text = "";
            nfaxtxt.Text = "";
            ninftxt.Text = "";
        }

        public void LockTXT() 
        {
            enderecotxt.Enabled = false;
            nfaxtxt.Enabled = false;
            ninftxt.Enabled = false;
        }

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fornecedorcombo.Enabled = false;
            listenc.Show();
            cancelbtn.Show();
            okbtn.Show();
            btnEncomenda.Enabled = false;

            using (SqlConnection con = new SqlConnection(stringconnection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PF.fornece", con);
                SqlDataReader reader = cmd.ExecuteReader();
                listenc.Items.Clear();

                while (reader.Read())
                {
                    fornece s = new fornece();
                    s.Nome_Forn = reader["Nome_Fornecedor"].ToString();
                    s.Nome_Emp = reader["Nome_Empresa"].ToString();
                    listenc.Items.Add(s);

                }
                con.Close();

            }
        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            fornecedorcombo.Enabled = true;
            okbtn.Hide();
            listenc.Hide();
            cancelbtn.Hide();
            btnEncomenda.Enabled = true;
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            currentforn = listenc.SelectedIndex;
            if (currentforn < 0)
            {
                MessageBox.Show("Por favor selecione um fornecedor registado para eliminar!");
            }
            else
            {
                using (SqlConnection con = new SqlConnection(stringconnection))
                {
                    con.Open();
                    string s = "DELETE PF.fornece WHERE Nome_Fornecedor=@Nome_Fornecedor";
                    SqlCommand cmd = new SqlCommand(s, con);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Nome_Fornecedor", listenc.SelectedItem.ToString());

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Fornecedor com encomenda eliminado!");
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Failed to delete provider in database. \n ERROR MESSAGE: \n" + ex.Message);
                    }

                    finally
                    {
                        con.Close();
                    }
                    listenc.Items.RemoveAt(listenc.SelectedIndex);
                    
                }
            }
        }
    }
}
