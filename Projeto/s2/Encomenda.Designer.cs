namespace s2
{
    partial class Encomenda
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
            this.prodlist = new System.Windows.Forms.CheckedListBox();
            this.clientcombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEncomenda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.transcombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEndereço = new System.Windows.Forms.TextBox();
            this.rdbPre = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.datapicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txthora = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // prodlist
            // 
            this.prodlist.FormattingEnabled = true;
            this.prodlist.Location = new System.Drawing.Point(78, 181);
            this.prodlist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prodlist.Name = "prodlist";
            this.prodlist.Size = new System.Drawing.Size(360, 310);
            this.prodlist.TabIndex = 1;
            this.prodlist.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // clientcombo
            // 
            this.clientcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientcombo.FormattingEnabled = true;
            this.clientcombo.Location = new System.Drawing.Point(78, 102);
            this.clientcombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clientcombo.Name = "clientcombo";
            this.clientcombo.Size = new System.Drawing.Size(360, 24);
            this.clientcombo.TabIndex = 2;
            this.clientcombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.clientcombo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Selecionar Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Engravers MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(391, 31);
            this.label4.TabIndex = 25;
            this.label4.Text = "Criar Encomenda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Selecionar Produtos:";
            // 
            // btnEncomenda
            // 
            this.btnEncomenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncomenda.Location = new System.Drawing.Point(678, 438);
            this.btnEncomenda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEncomenda.Name = "btnEncomenda";
            this.btnEncomenda.Size = new System.Drawing.Size(169, 62);
            this.btnEncomenda.TabIndex = 31;
            this.btnEncomenda.Text = "Encomendar";
            this.btnEncomenda.UseVisualStyleBackColor = true;
            this.btnEncomenda.Click += new System.EventHandler(this.btnEncomenda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(579, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Selecionar Transportadora:";
            // 
            // transcombo
            // 
            this.transcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transcombo.FormattingEnabled = true;
            this.transcombo.Location = new System.Drawing.Point(585, 102);
            this.transcombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.transcombo.Name = "transcombo";
            this.transcombo.Size = new System.Drawing.Size(360, 24);
            this.transcombo.TabIndex = 32;
            this.transcombo.SelectedIndexChanged += new System.EventHandler(this.transcombo_SelectedIndexChanged);
            this.transcombo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.transcombo_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(579, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Endereço de destino:";
            // 
            // txtEndereço
            // 
            this.txtEndereço.Enabled = false;
            this.txtEndereço.Location = new System.Drawing.Point(585, 245);
            this.txtEndereço.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEndereço.Name = "txtEndereço";
            this.txtEndereço.Size = new System.Drawing.Size(360, 22);
            this.txtEndereço.TabIndex = 36;
            // 
            // rdbPre
            // 
            this.rdbPre.AutoSize = true;
            this.rdbPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPre.Location = new System.Drawing.Point(587, 181);
            this.rdbPre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbPre.Name = "rdbPre";
            this.rdbPre.Size = new System.Drawing.Size(229, 24);
            this.rdbPre.TabIndex = 37;
            this.rdbPre.TabStop = true;
            this.rdbPre.Text = "Usar Endereço predefinido";
            this.rdbPre.UseVisualStyleBackColor = true;
            this.rdbPre.CheckedChanged += new System.EventHandler(this.rdbPre_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(587, 213);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(158, 24);
            this.radioButton2.TabIndex = 38;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Inserir Endereço:";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // datapicker
            // 
            this.datapicker.Location = new System.Drawing.Point(666, 337);
            this.datapicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datapicker.Name = "datapicker";
            this.datapicker.Size = new System.Drawing.Size(279, 22);
            this.datapicker.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(579, 337);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 40;
            this.label6.Text = "Data:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(579, 377);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Hora de envio:";
            // 
            // txthora
            // 
            this.txthora.Location = new System.Drawing.Point(754, 379);
            this.txthora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(191, 22);
            this.txthora.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Gray;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(579, 302);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 25);
            this.label8.TabIndex = 43;
            this.label8.Text = "Nº Encomenda:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Gray;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(859, 407);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "(ex. 00:00:00)";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(754, 302);
            this.txtnumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(191, 22);
            this.txtnumero.TabIndex = 46;
            // 
            // Encomenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txthora);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.datapicker);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rdbPre);
            this.Controls.Add(this.txtEndereço);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transcombo);
            this.Controls.Add(this.btnEncomenda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clientcombo);
            this.Controls.Add(this.prodlist);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Encomenda";
            this.Size = new System.Drawing.Size(1093, 553);
            this.Load += new System.EventHandler(this.Encomenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox prodlist;
        private System.Windows.Forms.ComboBox clientcombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEncomenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox transcombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEndereço;
        private System.Windows.Forms.RadioButton rdbPre;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DateTimePicker datapicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txthora;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtnumero;
    }
}
