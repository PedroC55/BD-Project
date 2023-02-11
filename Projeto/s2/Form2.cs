using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s2
{
    public partial class Form2 : Form
    {
        public string Yourcomboboxitem // make public property 
        {
            get {return escolhaempresa.SelectedItem.ToString(); }
            set { escolhaempresa.Items.Add(value) ; }

        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (escolhaempresa.SelectedIndex > -1)
            {
                escolhaempresa.SelectedItem = this.Yourcomboboxitem;
                Form1 f1 = new Form1(this);
                f1.ShowDialog();
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void escolhaempresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
