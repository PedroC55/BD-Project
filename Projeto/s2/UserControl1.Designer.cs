namespace s2
{
    partial class UserControl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.listclients = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtendereço = new System.Windows.Forms.TextBox();
            this.txtncc = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.listClientes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gencombo = new System.Windows.Forms.ComboBox();
            this.updatebtn = new System.Windows.Forms.Button();
            this.apgbtn = new System.Windows.Forms.Button();
            this.empresacombo = new System.Windows.Forms.ComboBox();
            this.okbtn = new System.Windows.Forms.Button();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listclients)).BeginInit();
            this.SuspendLayout();
            // 
            // listclients
            // 
            this.listclients.BackgroundColor = System.Drawing.Color.Gray;
            this.listclients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listclients.Location = new System.Drawing.Point(0, 0);
            this.listclients.Name = "listclients";
            this.listclients.RowHeadersWidth = 51;
            this.listclients.Size = new System.Drawing.Size(820, 449);
            this.listclients.TabIndex = 0;
            this.listclients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listclients_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clientes:";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(504, 94);
            this.txtnome.Name = "txtnome";
            this.txtnome.ReadOnly = true;
            this.txtnome.Size = new System.Drawing.Size(189, 26);
            this.txtnome.TabIndex = 16;
            // 
            // txtendereço
            // 
            this.txtendereço.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtendereço.Location = new System.Drawing.Point(504, 133);
            this.txtendereço.Name = "txtendereço";
            this.txtendereço.ReadOnly = true;
            this.txtendereço.Size = new System.Drawing.Size(189, 26);
            this.txtendereço.TabIndex = 17;
            this.txtendereço.TextChanged += new System.EventHandler(this.txtendereço_TextChanged);
            // 
            // txtncc
            // 
            this.txtncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtncc.Location = new System.Drawing.Point(504, 172);
            this.txtncc.Name = "txtncc";
            this.txtncc.ReadOnly = true;
            this.txtncc.Size = new System.Drawing.Size(116, 26);
            this.txtncc.TabIndex = 18;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(504, 250);
            this.txtemail.Name = "txtemail";
            this.txtemail.ReadOnly = true;
            this.txtemail.Size = new System.Drawing.Size(270, 26);
            this.txtemail.TabIndex = 20;
            // 
            // listClientes
            // 
            this.listClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listClientes.FormattingEnabled = true;
            this.listClientes.ItemHeight = 16;
            this.listClientes.Location = new System.Drawing.Point(28, 49);
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(268, 388);
            this.listClientes.TabIndex = 22;
            this.listClientes.SelectedIndexChanged += new System.EventHandler(this.listClientes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Endereço:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nº de CC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(393, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Género:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(393, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(587, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Empresa:";
            // 
            // gencombo
            // 
            this.gencombo.Enabled = false;
            this.gencombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gencombo.FormattingEnabled = true;
            this.gencombo.Location = new System.Drawing.Point(504, 213);
            this.gencombo.Name = "gencombo";
            this.gencombo.Size = new System.Drawing.Size(41, 24);
            this.gencombo.TabIndex = 29;
            this.gencombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // updatebtn
            // 
            this.updatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatebtn.Location = new System.Drawing.Point(458, 352);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(127, 34);
            this.updatebtn.TabIndex = 30;
            this.updatebtn.Text = "Atualizar Cliente ";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // apgbtn
            // 
            this.apgbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apgbtn.Location = new System.Drawing.Point(591, 352);
            this.apgbtn.Name = "apgbtn";
            this.apgbtn.Size = new System.Drawing.Size(127, 34);
            this.apgbtn.TabIndex = 31;
            this.apgbtn.Text = "Apagar ";
            this.apgbtn.UseVisualStyleBackColor = true;
            this.apgbtn.Click += new System.EventHandler(this.apgbtn_Click);
            // 
            // empresacombo
            // 
            this.empresacombo.Enabled = false;
            this.empresacombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empresacombo.FormattingEnabled = true;
            this.empresacombo.Location = new System.Drawing.Point(677, 213);
            this.empresacombo.Name = "empresacombo";
            this.empresacombo.Size = new System.Drawing.Size(97, 24);
            this.empresacombo.TabIndex = 32;
            // 
            // okbtn
            // 
            this.okbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okbtn.Location = new System.Drawing.Point(591, 323);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(57, 23);
            this.okbtn.TabIndex = 33;
            this.okbtn.Text = "OK";
            this.okbtn.UseVisualStyleBackColor = true;
            this.okbtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // refreshbtn
            // 
            this.refreshbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshbtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshbtn.Image")));
            this.refreshbtn.Location = new System.Drawing.Point(275, 26);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(21, 21);
            this.refreshbtn.TabIndex = 34;
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelbtn.Location = new System.Drawing.Point(528, 323);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(57, 23);
            this.cancelbtn.TabIndex = 35;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.okbtn);
            this.Controls.Add(this.empresacombo);
            this.Controls.Add(this.apgbtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.gencombo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listClientes);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtncc);
            this.Controls.Add(this.txtendereço);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listclients);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(820, 452);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listclients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listclients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtendereço;
        private System.Windows.Forms.TextBox txtncc;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.ListBox listClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox gencombo;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button apgbtn;
        private System.Windows.Forms.ComboBox empresacombo;
        private System.Windows.Forms.Button okbtn;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Button cancelbtn;
    }
}
