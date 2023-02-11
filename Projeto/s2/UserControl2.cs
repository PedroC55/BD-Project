using System;
using System.Text.RegularExpressions;
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
    public partial class UserControl2 : UserControl
    {
        string stringconnection = @"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=p8g5;Persist Security Info=True;User ID=p8g5;Password=marinheiroMC5";

        private static Regex email_validation()
        {
            string pattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
            + "@"
            + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }
        static Regex validate_emailaddress = email_validation();
        public UserControl2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if ((sender as TextBox).Text.Count(Char.IsDigit) >= 9)
                e.Handled = true;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(stringconnection))
            {
                con.Open();
                //string s = "select PF.AdicionarCliente(@Nome, @Endereço, @Nº_CC, @Género, @Email, @Nome_Empresa)";
                string s = "PF.AdicionarCliente";
                SqlCommand cmd = new SqlCommand(s, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nome", ClientName.Text.ToString());
                cmd.Parameters.AddWithValue("@Endereço", Address.Text.ToString());
                cmd.Parameters.AddWithValue("@Nº_CC", nCC.Text.ToString());
                if (Male.Checked == true)
                    cmd.Parameters.AddWithValue("@Género", Male.Text.ToString());
                if (Female.Checked == true)
                    cmd.Parameters.AddWithValue("@Género", Female.Text.ToString());
                cmd.Parameters.AddWithValue("@Email", email.Text.ToString());
                cmd.Parameters.AddWithValue("@Nome_Empresa", "Ctesi");

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente adicionado com sucesso.");
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to add client in database. \n ERROR MESSAGE: \n" + ex.Message);
                }
                finally
                {
                    con.Close();
                }

            }

            
  

        }

        private void ClearFields()
        {
            ClientName.Text = "";
            Address.Text = "";
            email.Text = "";
            nCC.Text = "";
            Male.Checked = false;
            Female.Checked = false;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void nCC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
