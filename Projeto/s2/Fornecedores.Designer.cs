namespace s2
{
    partial class Fornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fornecedores));
            this.btnEncomenda = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fornecedorcombo = new System.Windows.Forms.ComboBox();
            this.materiaprimatxt = new System.Windows.Forms.TextBox();
            this.nfaxtxt = new System.Windows.Forms.TextBox();
            this.enderecotxt = new System.Windows.Forms.TextBox();
            this.ninftxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.verfornbtn = new System.Windows.Forms.Button();
            this.listenc = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.okbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEncomenda
            // 
            this.btnEncomenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncomenda.Location = new System.Drawing.Point(59, 254);
            this.btnEncomenda.Name = "btnEncomenda";
            this.btnEncomenda.Size = new System.Drawing.Size(120, 47);
            this.btnEncomenda.TabIndex = 52;
            this.btnEncomenda.Text = "Encomendar";
            this.btnEncomenda.UseVisualStyleBackColor = true;
            this.btnEncomenda.Click += new System.EventHandler(this.btnEncomenda_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Matéria Prima:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Engravers MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(521, 25);
            this.label4.TabIndex = 50;
            this.label4.Text = "Encomendar a um fornecedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Selecionar Fornecedor:";
            // 
            // fornecedorcombo
            // 
            this.fornecedorcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fornecedorcombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fornecedorcombo.FormattingEnabled = true;
            this.fornecedorcombo.Location = new System.Drawing.Point(59, 112);
            this.fornecedorcombo.Name = "fornecedorcombo";
            this.fornecedorcombo.Size = new System.Drawing.Size(271, 28);
            this.fornecedorcombo.TabIndex = 48;
            this.fornecedorcombo.SelectedIndexChanged += new System.EventHandler(this.fornecedorcombo_SelectedIndexChanged);
            // 
            // materiaprimatxt
            // 
            this.materiaprimatxt.Enabled = false;
            this.materiaprimatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materiaprimatxt.Location = new System.Drawing.Point(59, 212);
            this.materiaprimatxt.Name = "materiaprimatxt";
            this.materiaprimatxt.ReadOnly = true;
            this.materiaprimatxt.Size = new System.Drawing.Size(188, 26);
            this.materiaprimatxt.TabIndex = 66;
            // 
            // nfaxtxt
            // 
            this.nfaxtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nfaxtxt.Location = new System.Drawing.Point(619, 121);
            this.nfaxtxt.Name = "nfaxtxt";
            this.nfaxtxt.Size = new System.Drawing.Size(142, 22);
            this.nfaxtxt.TabIndex = 67;
            // 
            // enderecotxt
            // 
            this.enderecotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecotxt.Location = new System.Drawing.Point(635, 186);
            this.enderecotxt.Name = "enderecotxt";
            this.enderecotxt.Size = new System.Drawing.Size(126, 22);
            this.enderecotxt.TabIndex = 68;
            // 
            // ninftxt
            // 
            this.ninftxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ninftxt.Location = new System.Drawing.Point(619, 155);
            this.ninftxt.Name = "ninftxt";
            this.ninftxt.Size = new System.Drawing.Size(142, 22);
            this.ninftxt.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(530, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 70;
            this.label1.Text = "Endereço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(530, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 71;
            this.label2.Text = "Nº de FAX:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(530, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 72;
            this.label6.Text = "Nº Inf. Fiscal:";
            // 
            // verfornbtn
            // 
            this.verfornbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verfornbtn.Location = new System.Drawing.Point(633, 267);
            this.verfornbtn.Name = "verfornbtn";
            this.verfornbtn.Size = new System.Drawing.Size(128, 34);
            this.verfornbtn.TabIndex = 73;
            this.verfornbtn.Text = "Ver Fornecedores registados";
            this.verfornbtn.UseVisualStyleBackColor = true;
            this.verfornbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // listenc
            // 
            this.listenc.FormattingEnabled = true;
            this.listenc.Location = new System.Drawing.Point(533, 307);
            this.listenc.Name = "listenc";
            this.listenc.Size = new System.Drawing.Size(228, 108);
            this.listenc.TabIndex = 74;
            this.listenc.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(491, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 75;
            this.label7.Text = "Outros dados:";
            // 
            // cancelbtn
            // 
            this.cancelbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelbtn.Image = ((System.Drawing.Image)(resources.GetObject("cancelbtn.Image")));
            this.cancelbtn.Location = new System.Drawing.Point(729, 421);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(32, 25);
            this.cancelbtn.TabIndex = 76;
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // okbtn
            // 
            this.okbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okbtn.Location = new System.Drawing.Point(691, 421);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(32, 25);
            this.okbtn.TabIndex = 77;
            this.okbtn.Text = "OK";
            this.okbtn.UseVisualStyleBackColor = true;
            this.okbtn.Click += new System.EventHandler(this.okbtn_Click);
            // 
            // Fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.okbtn);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listenc);
            this.Controls.Add(this.verfornbtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ninftxt);
            this.Controls.Add(this.enderecotxt);
            this.Controls.Add(this.nfaxtxt);
            this.Controls.Add(this.materiaprimatxt);
            this.Controls.Add(this.btnEncomenda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fornecedorcombo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Fornecedores";
            this.Size = new System.Drawing.Size(820, 449);
            this.Load += new System.EventHandler(this.Fornecedores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEncomenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox fornecedorcombo;
        private System.Windows.Forms.TextBox materiaprimatxt;
        private System.Windows.Forms.TextBox nfaxtxt;
        private System.Windows.Forms.TextBox enderecotxt;
        private System.Windows.Forms.TextBox ninftxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button verfornbtn;
        private System.Windows.Forms.ListBox listenc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button okbtn;
    }
}
