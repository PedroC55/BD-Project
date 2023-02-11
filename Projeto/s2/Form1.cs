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
    public partial class Form1 : Form
    {
        string stringconnection = @"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=p8g5;Persist Security Info=True;User ID=p8g5;Password=marinheiroMC5";
/*        public string txtText // make public property 
        {
            get { return NomeEmpresa1.Text; }
            set { NomeEmpresa1.Text = value; }

        }*/
        public Form1()
        {
            InitializeComponent();
        }
        private Form2 mainForm = null;
        public Form1(Form callingForm)
        {
            mainForm = callingForm as Form2;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listabtn.Hide();
            Addbtn.Hide();
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            encomenda1.Hide();
            fornecedores1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            listabtn.Hide();
            Addbtn.Hide();
            userControl31.Hide();
            encomenda1.Hide();
            fornecedores1.Hide();
            NomeEmpresa1.Text = this.mainForm.Yourcomboboxitem;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listabtn.Show();
            Addbtn.Show();
            userControl11.Show();
            userControl21.Hide();
            userControl31.Hide();
            encomenda1.Hide();
            fornecedores1.Hide();
        }

        private void Lista_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl21.Hide();
            encomenda1.Hide();

            //using (SqlConnection sqlCon = new SqlConnection(stringconnection))
            //{
            //    sqlCon.Open();
            //    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM PF.CLIENTE", sqlCon);
            //    DataTable dt = new DataTable();
            //    adapter.Fill(dt);
            //    
            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Show();
            encomenda1.Hide();


        }

        private void userControl21_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Show();
            encomenda1.Hide();
            fornecedores1.Hide();
            listabtn.Hide();
            Addbtn.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NomeEmpresa1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void userControl31_Load(object sender, EventArgs e)
        {

        }

        private void CriarProd_Click(object sender, EventArgs e)
        {
            userControl31.Hide();
        }

        private void Listaprod_Click(object sender, EventArgs e)
        {
            userControl31.Show();


            
        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            encomenda1.Show();
            fornecedores1.Hide();
            listabtn.Hide();
            Addbtn.Hide();
        }

        private void encomenda1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            Form2 nextForm = new Form2();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
    }
}
