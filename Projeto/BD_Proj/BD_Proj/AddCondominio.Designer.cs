namespace BD_Proj
{
    partial class AddCondominio
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
            this.num_fical_TextBox = new System.Windows.Forms.TextBox();
            this.addCond_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.gerentes_listBox = new System.Windows.Forms.ListBox();
            this.name_cond_label = new System.Windows.Forms.Label();
            this.nome_cond_textBox = new System.Windows.Forms.TextBox();
            this.add_nome_cond_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número Fiscal";
            // 
            // num_fical_TextBox
            // 
            this.num_fical_TextBox.Location = new System.Drawing.Point(261, 77);
            this.num_fical_TextBox.Name = "num_fical_TextBox";
            this.num_fical_TextBox.Size = new System.Drawing.Size(134, 22);
            this.num_fical_TextBox.TabIndex = 3;
            // 
            // addCond_button
            // 
            this.addCond_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addCond_button.Location = new System.Drawing.Point(399, 270);
            this.addCond_button.Name = "addCond_button";
            this.addCond_button.Size = new System.Drawing.Size(84, 23);
            this.addCond_button.TabIndex = 4;
            this.addCond_button.Text = "Adicionar";
            this.addCond_button.UseVisualStyleBackColor = true;
            this.addCond_button.Click += new System.EventHandler(this.addCond_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel_button.Location = new System.Drawing.Point(300, 270);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(85, 23);
            this.cancel_button.TabIndex = 5;
            this.cancel_button.Text = "Cancelar";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // gerentes_listBox
            // 
            this.gerentes_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerentes_listBox.FormattingEnabled = true;
            this.gerentes_listBox.ItemHeight = 18;
            this.gerentes_listBox.Location = new System.Drawing.Point(0, 36);
            this.gerentes_listBox.Name = "gerentes_listBox";
            this.gerentes_listBox.Size = new System.Drawing.Size(213, 256);
            this.gerentes_listBox.TabIndex = 6;
            // 
            // name_cond_label
            // 
            this.name_cond_label.AutoSize = true;
            this.name_cond_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_cond_label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.name_cond_label.Location = new System.Drawing.Point(256, 9);
            this.name_cond_label.Name = "name_cond_label";
            this.name_cond_label.Size = new System.Drawing.Size(189, 25);
            this.name_cond_label.TabIndex = 7;
            this.name_cond_label.Text = "Nome Condominio";
            // 
            // nome_cond_textBox
            // 
            this.nome_cond_textBox.Location = new System.Drawing.Point(261, 144);
            this.nome_cond_textBox.Name = "nome_cond_textBox";
            this.nome_cond_textBox.Size = new System.Drawing.Size(158, 22);
            this.nome_cond_textBox.TabIndex = 8;
            // 
            // add_nome_cond_label
            // 
            this.add_nome_cond_label.AutoSize = true;
            this.add_nome_cond_label.Location = new System.Drawing.Point(258, 123);
            this.add_nome_cond_label.Name = "add_nome_cond_label";
            this.add_nome_cond_label.Size = new System.Drawing.Size(127, 17);
            this.add_nome_cond_label.TabIndex = 9;
            this.add_nome_cond_label.Text = "Nome Condominio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gerente:";
            // 
            // AddCondominio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 303);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add_nome_cond_label);
            this.Controls.Add(this.nome_cond_textBox);
            this.Controls.Add(this.name_cond_label);
            this.Controls.Add(this.gerentes_listBox);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.addCond_button);
            this.Controls.Add(this.num_fical_TextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddCondominio";
            this.Text = "AddCondominio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num_fical_TextBox;
        private System.Windows.Forms.Button addCond_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.ListBox gerentes_listBox;
        private System.Windows.Forms.Label name_cond_label;
        private System.Windows.Forms.TextBox nome_cond_textBox;
        private System.Windows.Forms.Label add_nome_cond_label;
        private System.Windows.Forms.Label label2;
    }
}