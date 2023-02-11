using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace s2
{
    public partial class UserControl1 : UserControl
    {
        private int currentClient;

        string stringconnection = @"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=p8g5;Persist Security Info=True;User ID=p8g5;Password=marinheiroMC5";
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            gencombo.Items.Add("M");
            gencombo.Items.Add("F");

            okbtn.Hide();
            cancelbtn.Hide();

            using (SqlConnection con = new SqlConnection(stringconnection))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PF.CLIENTE WHERE PF.CLIENTE.Nome_Empresa='Ctesi'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                listClientes.Items.Clear();

                while (reader.Read())
                {
                    Cliente C = new Cliente();
                    C.Nome = reader["Nome"].ToString();
                    C.Endereço = reader["Endereço"].ToString();
                    C.Nº_CC = reader["Nº_CC"].ToString();
                    C.Género = reader["Género"].ToString();
                    C.Email = reader["Email"].ToString();
                    C.Nome_Empresa = reader["Nome_Empresa"].ToString();
                    listClientes.Items.Add(C);

                }
                con.Close();

                currentClient = 0;
                ShowContact();

                con.Open();
                SqlCommand cemp = new SqlCommand("SELECT * FROM PF.EMPRESA", con);
                SqlDataReader reademp = cemp.ExecuteReader();

                while (reademp.Read())
                {
                    Empresa E = new Empresa();
                    E.Nome = reademp["Nome"].ToString();
                    empresacombo.Items.Add(E);
                }
                con.Close();
            }

        }

        private void listclients_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listclients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClientesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            int lcount;

            if (ClientesList.SelectedItems.Count >= 0 )
            {
                for (lcount = 0; lcount <= ClientesList.Items.Count - 1; lcount++)
                {
                    if (ClientesList.Items[lcount].Selected == true)
                    {
                        currentClient = lcount;
                        break;
                    }
                }
                ShowContact();
            }
            */


        }

        private void UpdateClient(Cliente C)
        {
            int rows = 0;

            using (SqlConnection con = new SqlConnection(stringconnection))
            {
                con.Open();
                string s = "PF.UpdateCliente";
                SqlCommand cmd = new SqlCommand(s, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nome", C.Nome);
                cmd.Parameters.AddWithValue("@Endereço", C.Endereço);
                cmd.Parameters.AddWithValue("@Nº_CC", C.Nº_CC);
                cmd.Parameters.AddWithValue("@Género", C.Género);
                cmd.Parameters.AddWithValue("@Email", C.Email);
                cmd.Parameters.AddWithValue("@Nome_Empresa", C.Nome_Empresa);

                try
                {
                    rows = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Failed to update contact in database. \n ERROR MESSAGE: \n" + ex.Message);
                }
                finally
                {
                    if (rows == 1)
                        MessageBox.Show("Update OK");
                    else
                        MessageBox.Show("Update NOT OK");

                    con.Close();
                }

            }
        }

        public void ShowContact()
        {
            if (listClientes.Items.Count == 0 | currentClient < 0)
                return;

            Cliente cliente = new Cliente();
            cliente = (Cliente)listClientes.Items[currentClient];

            txtnome.Text = cliente.Nome;
            txtendereço.Text = cliente.Endereço;
            txtncc.Text = cliente.Nº_CC;
            gencombo.Text = cliente.Género;
            txtemail.Text = cliente.Email;
            empresacombo.Text = cliente.Nome_Empresa;

        }

        private void listClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listClientes.SelectedIndex >= 0)
            {
                currentClient = listClientes.SelectedIndex;
                ShowContact();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentClient = listClientes.SelectedIndex;
            if (currentClient < 0)
            {
                MessageBox.Show("Por favor selecione um cliente a editar!");
            }
            else 
            {
                UnlockTXT();

                apgbtn.Hide();
                updatebtn.Hide();
                okbtn.Show();
                cancelbtn.Show();

                listClientes.Enabled = false;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtendereço_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SaveClient();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            okbtn.Hide();
            apgbtn.Show();
            updatebtn.Show();
            listClientes.Enabled = true;

            LockTXT();
        }

        private bool SaveClient()
        {
            Cliente client = new Cliente();
            try
            {
                client.Nome = txtnome.Text;
                client.Endereço = txtendereço.Text;
                client.Nº_CC = txtncc.Text;
                client.Género = gencombo.Text;
                client.Email = txtemail.Text;
                client.Nome_Empresa = empresacombo.Text;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            UpdateClient(client);
            listClientes.Items[currentClient] = client;
            return true;
        }

            public void UnlockTXT()
        {
            
            txtendereço.ReadOnly = false;
            txtncc.ReadOnly = false;
            txtemail.ReadOnly = false;
            gencombo.Enabled = true;
            empresacombo.Enabled = true;
        }

        public void LockTXT()
        {
            txtnome.ReadOnly = true;
            txtendereço.ReadOnly = true;
            txtncc.ReadOnly = true;
            txtemail.ReadOnly = true;
            gencombo.Enabled = false;
            empresacombo.Enabled = false;
        }

        public void ClearFields()
        {
            txtnome.Text = "";
            txtendereço.Text = "";
            txtncc.Text = "";
            txtemail.Text = "";
            gencombo.Text = "";
            empresacombo.Text = "";
        }

        private void apgbtn_Click(object sender, EventArgs e)
        {
            currentClient = listClientes.SelectedIndex;
            if (currentClient < 0)
            {
                MessageBox.Show("Por favor selecione um cliente para eliminar!");
            }
            else
            {
                using (SqlConnection con = new SqlConnection(stringconnection))
                {
                    con.Open();
                    string s = "DELETE PF.CLIENTE WHERE Nome=@Nome";
                    SqlCommand cmd = new SqlCommand(s, con);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Nome", txtnome.Text);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Failed to delete contact in database. \n ERROR MESSAGE: \n" + ex.Message);
                    }

                    finally
                    {
                        con.Close();
                    }
                    listClientes.Items.RemoveAt(listClientes.SelectedIndex);
                    ClearFields();
                }
            }
            
               
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(stringconnection))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PF.CLIENTE WHERE PF.CLIENTE.Nome_Empresa='Ctesi'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                listClientes.Items.Clear();

                while (reader.Read())
                {
                    Cliente C = new Cliente();
                    C.Nome = reader["Nome"].ToString();
                    C.Endereço = reader["Endereço"].ToString();
                    C.Nº_CC = reader["Nº_CC"].ToString();
                    C.Género = reader["Género"].ToString();
                    C.Email = reader["Email"].ToString();
                    C.Nome_Empresa = reader["Nome_Empresa"].ToString();
                    listClientes.Items.Add(C);

                }
                con.Close();
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            listClientes.Enabled = true;
            okbtn.Hide();
            cancelbtn.Hide();
            updatebtn.Show();
            apgbtn.Show();
            LockTXT();
        }
    }
}
