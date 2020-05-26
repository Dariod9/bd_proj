namespace BD_Proj
{
    partial class AddCasa
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
            this.label1 = new System.Windows.Forms.Label();
            this.morada_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.submit_bt = new System.Windows.Forms.Button();
            this.cancel_bt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cidade_textbox = new System.Windows.Forms.TextBox();
            this.descricao_textbox = new System.Windows.Forms.TextBox();
            this.max_hab_comboBox = new System.Windows.Forms.ComboBox();
            this.n_quartos_comboBox = new System.Windows.Forms.ComboBox();
            this.condominio_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Morada";
            // 
            // morada_textbox
            // 
            this.morada_textbox.Location = new System.Drawing.Point(25, 29);
            this.morada_textbox.Name = "morada_textbox";
            this.morada_textbox.Size = new System.Drawing.Size(231, 22);
            this.morada_textbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número de quartos";
            // 
            // submit_bt
            // 
            this.submit_bt.Location = new System.Drawing.Point(358, 205);
            this.submit_bt.Name = "submit_bt";
            this.submit_bt.Size = new System.Drawing.Size(75, 23);
            this.submit_bt.TabIndex = 4;
            this.submit_bt.Text = "Submit";
            this.submit_bt.UseVisualStyleBackColor = true;
            this.submit_bt.Click += new System.EventHandler(this.submit_bt_Click);
            // 
            // cancel_bt
            // 
            this.cancel_bt.Location = new System.Drawing.Point(265, 205);
            this.cancel_bt.Name = "cancel_bt";
            this.cancel_bt.Size = new System.Drawing.Size(75, 23);
            this.cancel_bt.TabIndex = 5;
            this.cancel_bt.Text = "Cancel";
            this.cancel_bt.UseVisualStyleBackColor = true;
            this.cancel_bt.Click += new System.EventHandler(this.cancel_bt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Número máximo de habitantes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descrição";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Condomínio";
            // 
            // cidade_textbox
            // 
            this.cidade_textbox.Location = new System.Drawing.Point(25, 94);
            this.cidade_textbox.Name = "cidade_textbox";
            this.cidade_textbox.Size = new System.Drawing.Size(100, 22);
            this.cidade_textbox.TabIndex = 10;
            // 
            // descricao_textbox
            // 
            this.descricao_textbox.Location = new System.Drawing.Point(25, 163);
            this.descricao_textbox.Name = "descricao_textbox";
            this.descricao_textbox.Size = new System.Drawing.Size(211, 22);
            this.descricao_textbox.TabIndex = 12;
            // 
            // max_hab_comboBox
            // 
            this.max_hab_comboBox.FormattingEnabled = true;
            this.max_hab_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.max_hab_comboBox.Location = new System.Drawing.Point(316, 94);
            this.max_hab_comboBox.Name = "max_hab_comboBox";
            this.max_hab_comboBox.Size = new System.Drawing.Size(121, 24);
            this.max_hab_comboBox.TabIndex = 14;
            // 
            // n_quartos_comboBox
            // 
            this.n_quartos_comboBox.FormattingEnabled = true;
            this.n_quartos_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.n_quartos_comboBox.Location = new System.Drawing.Point(316, 29);
            this.n_quartos_comboBox.Name = "n_quartos_comboBox";
            this.n_quartos_comboBox.Size = new System.Drawing.Size(121, 24);
            this.n_quartos_comboBox.TabIndex = 15;
            // 
            // condominio_comboBox
            // 
            this.condominio_comboBox.FormattingEnabled = true;
            this.condominio_comboBox.Items.AddRange(new object[] {
            "3520750724"});
            this.condominio_comboBox.Location = new System.Drawing.Point(316, 163);
            this.condominio_comboBox.Name = "condominio_comboBox";
            this.condominio_comboBox.Size = new System.Drawing.Size(121, 24);
            this.condominio_comboBox.TabIndex = 16;
            // 
            // AddCasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 239);
            this.Controls.Add(this.condominio_comboBox);
            this.Controls.Add(this.n_quartos_comboBox);
            this.Controls.Add(this.max_hab_comboBox);
            this.Controls.Add(this.descricao_textbox);
            this.Controls.Add(this.cidade_textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancel_bt);
            this.Controls.Add(this.submit_bt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.morada_textbox);
            this.Controls.Add(this.label1);
            this.Name = "AddCasa";
            this.Text = "AddCasa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox morada_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submit_bt;
        private System.Windows.Forms.Button cancel_bt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cidade_textbox;
        private System.Windows.Forms.TextBox descricao_textbox;
        private System.Windows.Forms.ComboBox max_hab_comboBox;
        private System.Windows.Forms.ComboBox n_quartos_comboBox;
        private System.Windows.Forms.ComboBox condominio_comboBox;
    }
}