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
            this.condominio_label = new System.Windows.Forms.Label();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.orcamento_textBox = new System.Windows.Forms.TextBox();
            this.orcamento_label = new System.Windows.Forms.Label();
            this.condominio_comboBox = new System.Windows.Forms.ComboBox();
            this.ini_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fim_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.data_fim_label = new System.Windows.Forms.Label();
            this.data_ini_label = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.empresa_comboBox = new System.Windows.Forms.ComboBox();
            this.empresa_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ok_bt
            // 
            this.ok_bt.Location = new System.Drawing.Point(488, 211);
            this.ok_bt.Name = "ok_bt";
            this.ok_bt.Size = new System.Drawing.Size(75, 23);
            this.ok_bt.TabIndex = 0;
            this.ok_bt.Text = "OK";
            this.ok_bt.UseVisualStyleBackColor = true;
            this.ok_bt.Click += new System.EventHandler(this.ok_bt_Click);
            // 
            // cancel_bt
            // 
            this.cancel_bt.Location = new System.Drawing.Point(389, 211);
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
            // condominio_label
            // 
            this.condominio_label.AutoSize = true;
            this.condominio_label.Location = new System.Drawing.Point(395, 31);
            this.condominio_label.Name = "condominio_label";
            this.condominio_label.Size = new System.Drawing.Size(86, 17);
            this.condominio_label.TabIndex = 6;
            this.condominio_label.Text = "Condominio:";
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
            this.orcamento_textBox.Location = new System.Drawing.Point(136, 193);
            this.orcamento_textBox.Name = "orcamento_textBox";
            this.orcamento_textBox.Size = new System.Drawing.Size(125, 22);
            this.orcamento_textBox.TabIndex = 10;
            // 
            // orcamento_label
            // 
            this.orcamento_label.AutoSize = true;
            this.orcamento_label.Location = new System.Drawing.Point(26, 193);
            this.orcamento_label.Name = "orcamento_label";
            this.orcamento_label.Size = new System.Drawing.Size(104, 17);
            this.orcamento_label.TabIndex = 20;
            this.orcamento_label.Text = "Orçamento (€):";
            // 
            // condominio_comboBox
            // 
            this.condominio_comboBox.FormattingEnabled = true;
            this.condominio_comboBox.Location = new System.Drawing.Point(389, 60);
            this.condominio_comboBox.Name = "condominio_comboBox";
            this.condominio_comboBox.Size = new System.Drawing.Size(162, 24);
            this.condominio_comboBox.TabIndex = 23;
            // 
            // ini_dateTimePicker
            // 
            this.ini_dateTimePicker.Location = new System.Drawing.Point(120, 83);
            this.ini_dateTimePicker.Name = "ini_dateTimePicker";
            this.ini_dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.ini_dateTimePicker.TabIndex = 24;
            // 
            // fim_dateTimePicker
            // 
            this.fim_dateTimePicker.Location = new System.Drawing.Point(120, 140);
            this.fim_dateTimePicker.Name = "fim_dateTimePicker";
            this.fim_dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.fim_dateTimePicker.TabIndex = 25;
            // 
            // data_fim_label
            // 
            this.data_fim_label.AutoSize = true;
            this.data_fim_label.Location = new System.Drawing.Point(26, 140);
            this.data_fim_label.Name = "data_fim_label";
            this.data_fim_label.Size = new System.Drawing.Size(68, 17);
            this.data_fim_label.TabIndex = 26;
            this.data_fim_label.Text = "Data Fim:";
            // 
            // data_ini_label
            // 
            this.data_ini_label.AutoSize = true;
            this.data_ini_label.Location = new System.Drawing.Point(26, 83);
            this.data_ini_label.Name = "data_ini_label";
            this.data_ini_label.Size = new System.Drawing.Size(78, 17);
            this.data_ini_label.TabIndex = 27;
            this.data_ini_label.Text = "Data Início:";
            // 
            // empresa_comboBox
            // 
            this.empresa_comboBox.FormattingEnabled = true;
            this.empresa_comboBox.Location = new System.Drawing.Point(389, 133);
            this.empresa_comboBox.Name = "empresa_comboBox";
            this.empresa_comboBox.Size = new System.Drawing.Size(162, 24);
            this.empresa_comboBox.TabIndex = 28;
            // 
            // empresa_label
            // 
            this.empresa_label.AutoSize = true;
            this.empresa_label.Location = new System.Drawing.Point(395, 113);
            this.empresa_label.Name = "empresa_label";
            this.empresa_label.Size = new System.Drawing.Size(68, 17);
            this.empresa_label.TabIndex = 29;
            this.empresa_label.Text = "Empresa:";
            // 
            // AddObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 246);
            this.Controls.Add(this.empresa_label);
            this.Controls.Add(this.empresa_comboBox);
            this.Controls.Add(this.data_ini_label);
            this.Controls.Add(this.data_fim_label);
            this.Controls.Add(this.fim_dateTimePicker);
            this.Controls.Add(this.ini_dateTimePicker);
            this.Controls.Add(this.condominio_comboBox);
            this.Controls.Add(this.orcamento_label);
            this.Controls.Add(this.orcamento_textBox);
            this.Controls.Add(this.id_textBox);
            this.Controls.Add(this.condominio_label);
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
        private System.Windows.Forms.Label condominio_label;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.TextBox orcamento_textBox;
        private System.Windows.Forms.Label orcamento_label;
        private System.Windows.Forms.ComboBox condominio_comboBox;
        private System.Windows.Forms.DateTimePicker ini_dateTimePicker;
        private System.Windows.Forms.DateTimePicker fim_dateTimePicker;
        private System.Windows.Forms.Label data_fim_label;
        private System.Windows.Forms.Label data_ini_label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox empresa_comboBox;
        private System.Windows.Forms.Label empresa_label;
    }
}