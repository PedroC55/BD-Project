namespace s2
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.NomeEmpresa1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.listabtn = new System.Windows.Forms.Button();
            this.NomeEmpresa = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.fornecedores1 = new s2.Fornecedores();
            this.encomenda1 = new s2.Encomenda();
            this.userControl11 = new s2.UserControl1();
            this.userControl31 = new s2.UserControl3();
            this.userControl21 = new s2.UserControl2();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.NomeEmpresa1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 569);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // NomeEmpresa1
            // 
            this.NomeEmpresa1.BackColor = System.Drawing.SystemColors.GrayText;
            this.NomeEmpresa1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NomeEmpresa1.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeEmpresa1.Location = new System.Drawing.Point(28, 44);
            this.NomeEmpresa1.Name = "NomeEmpresa1";
            this.NomeEmpresa1.Size = new System.Drawing.Size(155, 34);
            this.NomeEmpresa1.TabIndex = 9;
            this.NomeEmpresa1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NomeEmpresa1.TextChanged += new System.EventHandler(this.NomeEmpresa1_TextChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::s2.Properties.Resources.share;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(28, 394);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 52);
            this.button4.TabIndex = 8;
            this.button4.Text = "Fornecedores";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::s2.Properties.Resources.parcela1;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(28, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 52);
            this.button3.TabIndex = 7;
            this.button3.Text = "Encomendas";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::s2.Properties.Resources.banheiro_publico;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(28, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 52);
            this.button2.TabIndex = 6;
            this.button2.Text = "Produtos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::s2.Properties.Resources.Clients_icon__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(28, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Clientes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(390, 44);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(89, 32);
            this.Addbtn.TabIndex = 7;
            this.Addbtn.Text = "Adicionar";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // listabtn
            // 
            this.listabtn.Location = new System.Drawing.Point(294, 44);
            this.listabtn.Name = "listabtn";
            this.listabtn.Size = new System.Drawing.Size(90, 32);
            this.listabtn.TabIndex = 6;
            this.listabtn.Text = "Lista";
            this.listabtn.UseVisualStyleBackColor = true;
            this.listabtn.Click += new System.EventHandler(this.Lista_Click);
            // 
            // NomeEmpresa
            // 
            this.NomeEmpresa.AutoSize = true;
            this.NomeEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NomeEmpresa.Location = new System.Drawing.Point(52, 73);
            this.NomeEmpresa.Name = "NomeEmpresa";
            this.NomeEmpresa.Size = new System.Drawing.Size(0, 33);
            this.NomeEmpresa.TabIndex = 9;
            this.NomeEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NomeEmpresa.Click += new System.EventHandler(this.label1_Click);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(3, 528);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 38);
            this.button5.TabIndex = 10;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_2);
            // 
            // fornecedores1
            // 
            this.fornecedores1.BackColor = System.Drawing.Color.Gray;
            this.fornecedores1.Location = new System.Drawing.Point(294, 92);
            this.fornecedores1.Margin = new System.Windows.Forms.Padding(2);
            this.fornecedores1.Name = "fornecedores1";
            this.fornecedores1.Size = new System.Drawing.Size(820, 449);
            this.fornecedores1.TabIndex = 15;
            // 
            // encomenda1
            // 
            this.encomenda1.BackColor = System.Drawing.Color.Gray;
            this.encomenda1.Location = new System.Drawing.Point(294, 92);
            this.encomenda1.Margin = new System.Windows.Forms.Padding(4);
            this.encomenda1.Name = "encomenda1";
            this.encomenda1.Size = new System.Drawing.Size(820, 449);
            this.encomenda1.TabIndex = 14;
            this.encomenda1.Load += new System.EventHandler(this.encomenda1_Load);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(294, 92);
            this.userControl11.Margin = new System.Windows.Forms.Padding(4);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(820, 452);
            this.userControl11.TabIndex = 13;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load_1);
            // 
            // userControl31
            // 
            this.userControl31.BackColor = System.Drawing.Color.Gray;
            this.userControl31.Location = new System.Drawing.Point(294, 92);
            this.userControl31.Margin = new System.Windows.Forms.Padding(4);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(832, 429);
            this.userControl31.TabIndex = 12;
            this.userControl31.Load += new System.EventHandler(this.userControl31_Load);
            // 
            // userControl21
            // 
            this.userControl21.Location = new System.Drawing.Point(294, 92);
            this.userControl21.Margin = new System.Windows.Forms.Padding(4);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(651, 452);
            this.userControl21.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1180, 582);
            this.Controls.Add(this.fornecedores1);
            this.Controls.Add(this.encomenda1);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.userControl31);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.NomeEmpresa);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.listabtn);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button listabtn;
        private System.Windows.Forms.Label NomeEmpresa;
        private System.Windows.Forms.TextBox NomeEmpresa1;
        private UserControl2 userControl21;
        private UserControl3 userControl31;
        private UserControl1 userControl11;
        private Encomenda encomenda1;
        private Fornecedores fornecedores1;
        private System.Windows.Forms.Button button5;
    }
}

