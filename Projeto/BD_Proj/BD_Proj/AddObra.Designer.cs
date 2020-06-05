namespace BD_Proj
{
    partial class AddObra
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
            this.ok_bt = new System.Windows.Forms.Button();
            this.cancel_bt = new System.Windows.Forms.Button();
            this.id_label = new System.Windows.Forms.Label();
            this.dia_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.condominio_label = new System.Windows.Forms.Label();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.orcamento_textBox = new System.Windows.Forms.TextBox();
            this.dia_comboBox = new System.Windows.Forms.ComboBox();
            this.mes_comboBox = new System.Windows.Forms.ComboBox();
            this.ano_comboBox = new System.Windows.Forms.ComboBox();
            this.anof_comboBox = new System.Windows.Forms.ComboBox();
            this.mesf_comboBox = new System.Windows.Forms.ComboBox();
            this.diaf_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.orcamento_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.condominio_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ok_bt
            // 
            this.ok_bt.Location = new System.Drawing.Point(522, 296);
            this.ok_bt.Name = "ok_bt";
            this.ok_bt.Size = new System.Drawing.Size(75, 23);
            this.ok_bt.TabIndex = 0;
            this.ok_bt.Text = "OK";
            this.ok_bt.UseVisualStyleBackColor = true;
            this.ok_bt.Click += new System.EventHandler(this.ok_bt_Click);
            // 
            // cancel_bt
            // 
            this.cancel_bt.Location = new System.Drawing.Point(421, 296);
            this.cancel_bt.Name = "cancel_bt";
            this.cancel_bt.Size = new System.Drawing.Size(77, 23);
            this.cancel_bt.TabIndex = 1;
            this.cancel_bt.Text = "Cancelar";
            this.cancel_bt.UseVisualStyleBackColor = true;
            this.cancel_bt.Click += new System.EventHandler(this.cancel_bt_Click);
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(26, 29);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(25, 17);
            this.id_label.TabIndex = 2;
            this.id_label.Text = "ID:";
            // 
            // dia_label
            // 
            this.dia_label.AutoSize = true;
            this.dia_label.Location = new System.Drawing.Point(103, 71);
            this.dia_label.Name = "dia_label";
            this.dia_label.Size = new System.Drawing.Size(29, 17);
            this.dia_label.TabIndex = 3;
            this.dia_label.Text = "Dia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mês";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ano";
            // 
            // condominio_label
            // 
            this.condominio_label.AutoSize = true;
            this.condominio_label.Location = new System.Drawing.Point(492, 43);
            this.condominio_label.Name = "condominio_label";
            this.condominio_label.Size = new System.Drawing.Size(82, 17);
            this.condominio_label.TabIndex = 6;
            this.condominio_label.Text = "Condominio";
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(64, 26);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(125, 22);
            this.id_textBox.TabIndex = 7;
            // 
            // orcamento_textBox
            // 
            this.orcamento_textBox.Location = new System.Drawing.Point(142, 236);
            this.orcamento_textBox.Name = "orcamento_textBox";
            this.orcamento_textBox.Size = new System.Drawing.Size(125, 22);
            this.orcamento_textBox.TabIndex = 10;
            // 
            // dia_comboBox
            // 
            this.dia_comboBox.AutoCompleteCustomSource.AddRange(new string[] {
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
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dia_comboBox.FormattingEnabled = true;
            this.dia_comboBox.Location = new System.Drawing.Point(106, 100);
            this.dia_comboBox.Name = "dia_comboBox";
            this.dia_comboBox.Size = new System.Drawing.Size(58, 24);
            this.dia_comboBox.TabIndex = 11;
            // 
            // mes_comboBox
            // 
            this.mes_comboBox.AutoCompleteCustomSource.AddRange(new string[] {
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
            "12"});
            this.mes_comboBox.FormattingEnabled = true;
            this.mes_comboBox.Location = new System.Drawing.Point(200, 100);
            this.mes_comboBox.Name = "mes_comboBox";
            this.mes_comboBox.Size = new System.Drawing.Size(58, 24);
            this.mes_comboBox.TabIndex = 12;
            // 
            // ano_comboBox
            // 
            this.ano_comboBox.FormattingEnabled = true;
            this.ano_comboBox.Location = new System.Drawing.Point(287, 100);
            this.ano_comboBox.Name = "ano_comboBox";
            this.ano_comboBox.Size = new System.Drawing.Size(79, 24);
            this.ano_comboBox.TabIndex = 13;
            // 
            // anof_comboBox
            // 
            this.anof_comboBox.FormattingEnabled = true;
            this.anof_comboBox.Location = new System.Drawing.Point(287, 177);
            this.anof_comboBox.Name = "anof_comboBox";
            this.anof_comboBox.Size = new System.Drawing.Size(79, 24);
            this.anof_comboBox.TabIndex = 19;
            // 
            // mesf_comboBox
            // 
            this.mesf_comboBox.AutoCompleteCustomSource.AddRange(new string[] {
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
            "12"});
            this.mesf_comboBox.FormattingEnabled = true;
            this.mesf_comboBox.Location = new System.Drawing.Point(200, 177);
            this.mesf_comboBox.Name = "mesf_comboBox";
            this.mesf_comboBox.Size = new System.Drawing.Size(58, 24);
            this.mesf_comboBox.TabIndex = 18;
            // 
            // diaf_comboBox
            // 
            this.diaf_comboBox.AutoCompleteCustomSource.AddRange(new string[] {
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
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.diaf_comboBox.FormattingEnabled = true;
            this.diaf_comboBox.Location = new System.Drawing.Point(106, 177);
            this.diaf_comboBox.Name = "diaf_comboBox";
            this.diaf_comboBox.Size = new System.Drawing.Size(58, 24);
            this.diaf_comboBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ano";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mês";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Dia";
            // 
            // orcamento_label
            // 
            this.orcamento_label.AutoSize = true;
            this.orcamento_label.Location = new System.Drawing.Point(22, 239);
            this.orcamento_label.Name = "orcamento_label";
            this.orcamento_label.Size = new System.Drawing.Size(104, 17);
            this.orcamento_label.TabIndex = 20;
            this.orcamento_label.Text = "Orçamento (€):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Data início:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Data fim:";
            // 
            // condominio_comboBox
            // 
            this.condominio_comboBox.FormattingEnabled = true;
            this.condominio_comboBox.Location = new System.Drawing.Point(442, 71);
            this.condominio_comboBox.Name = "condominio_comboBox";
            this.condominio_comboBox.Size = new System.Drawing.Size(132, 24);
            this.condominio_comboBox.TabIndex = 23;
            // 
            // AddObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 331);
            this.Controls.Add(this.condominio_comboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.orcamento_label);
            this.Controls.Add(this.anof_comboBox);
            this.Controls.Add(this.mesf_comboBox);
            this.Controls.Add(this.diaf_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ano_comboBox);
            this.Controls.Add(this.mes_comboBox);
            this.Controls.Add(this.dia_comboBox);
            this.Controls.Add(this.orcamento_textBox);
            this.Controls.Add(this.id_textBox);
            this.Controls.Add(this.condominio_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dia_label);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.cancel_bt);
            this.Controls.Add(this.ok_bt);
            this.Name = "AddObra";
            this.Text = "AddObra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_bt;
        private System.Windows.Forms.Button cancel_bt;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label dia_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label condominio_label;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.TextBox orcamento_textBox;
        private System.Windows.Forms.ComboBox dia_comboBox;
        private System.Windows.Forms.ComboBox mes_comboBox;
        private System.Windows.Forms.ComboBox ano_comboBox;
        private System.Windows.Forms.ComboBox anof_comboBox;
        private System.Windows.Forms.ComboBox mesf_comboBox;
        private System.Windows.Forms.ComboBox diaf_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label orcamento_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox condominio_comboBox;
    }
}