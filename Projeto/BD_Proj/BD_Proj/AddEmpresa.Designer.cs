namespace BD_Proj
{
    partial class AddEmpresa
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
            this.nome_textBox = new System.Windows.Forms.TextBox();
            this.nif_textBox = new System.Windows.Forms.TextBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.contacto_textBox = new System.Windows.Forms.TextBox();
            this.nome_label = new System.Windows.Forms.Label();
            this.nif_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.contacto_label = new System.Windows.Forms.Label();
            this.add_bt = new System.Windows.Forms.Button();
            this.cancel_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nome_textBox
            // 
            this.nome_textBox.Location = new System.Drawing.Point(30, 52);
            this.nome_textBox.Name = "nome_textBox";
            this.nome_textBox.Size = new System.Drawing.Size(192, 22);
            this.nome_textBox.TabIndex = 0;
            // 
            // nif_textBox
            // 
            this.nif_textBox.Location = new System.Drawing.Point(30, 133);
            this.nif_textBox.Name = "nif_textBox";
            this.nif_textBox.Size = new System.Drawing.Size(192, 22);
            this.nif_textBox.TabIndex = 1;
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(335, 52);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(206, 22);
            this.email_textBox.TabIndex = 2;
            // 
            // contacto_textBox
            // 
            this.contacto_textBox.Location = new System.Drawing.Point(335, 133);
            this.contacto_textBox.Name = "contacto_textBox";
            this.contacto_textBox.Size = new System.Drawing.Size(206, 22);
            this.contacto_textBox.TabIndex = 3;
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(27, 18);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(125, 17);
            this.nome_label.TabIndex = 4;
            this.nome_label.Text = "Nome da Empresa";
            // 
            // nif_label
            // 
            this.nif_label.AutoSize = true;
            this.nif_label.Location = new System.Drawing.Point(27, 101);
            this.nif_label.Name = "nif_label";
            this.nif_label.Size = new System.Drawing.Size(29, 17);
            this.nif_label.TabIndex = 5;
            this.nif_label.Text = "NIF";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(332, 18);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(42, 17);
            this.email_label.TabIndex = 6;
            this.email_label.Text = "Email";
            // 
            // contacto_label
            // 
            this.contacto_label.AutoSize = true;
            this.contacto_label.Location = new System.Drawing.Point(332, 101);
            this.contacto_label.Name = "contacto_label";
            this.contacto_label.Size = new System.Drawing.Size(64, 17);
            this.contacto_label.TabIndex = 7;
            this.contacto_label.Text = "Contacto";
            // 
            // add_bt
            // 
            this.add_bt.Location = new System.Drawing.Point(480, 221);
            this.add_bt.Name = "add_bt";
            this.add_bt.Size = new System.Drawing.Size(88, 23);
            this.add_bt.TabIndex = 8;
            this.add_bt.Text = "Adicionar";
            this.add_bt.UseVisualStyleBackColor = true;
            this.add_bt.Click += new System.EventHandler(this.add_bt_Click);
            // 
            // cancel_bt
            // 
            this.cancel_bt.Location = new System.Drawing.Point(383, 221);
            this.cancel_bt.Name = "cancel_bt";
            this.cancel_bt.Size = new System.Drawing.Size(91, 23);
            this.cancel_bt.TabIndex = 9;
            this.cancel_bt.Text = "Cancelar";
            this.cancel_bt.UseVisualStyleBackColor = true;
            this.cancel_bt.Click += new System.EventHandler(this.cancel_bt_Click);
            // 
            // AddEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 256);
            this.Controls.Add(this.cancel_bt);
            this.Controls.Add(this.add_bt);
            this.Controls.Add(this.contacto_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.nif_label);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.contacto_textBox);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.nif_textBox);
            this.Controls.Add(this.nome_textBox);
            this.Name = "AddEmpresa";
            this.Text = "AddEmpresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nome_textBox;
        private System.Windows.Forms.TextBox nif_textBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.TextBox contacto_textBox;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.Label nif_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label contacto_label;
        private System.Windows.Forms.Button add_bt;
        private System.Windows.Forms.Button cancel_bt;
    }
}