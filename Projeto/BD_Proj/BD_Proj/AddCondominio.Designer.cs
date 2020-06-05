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
            this.label2 = new System.Windows.Forms.Label();
            this.gerente_comboBox = new System.Windows.Forms.ComboBox();
            this.num_fical_TextBox = new System.Windows.Forms.TextBox();
            this.addCond_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.gerentes_listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número Fiscal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gerente";
            // 
            // gerente_comboBox
            // 
            this.gerente_comboBox.FormattingEnabled = true;
            this.gerente_comboBox.Location = new System.Drawing.Point(36, 137);
            this.gerente_comboBox.Name = "gerente_comboBox";
            this.gerente_comboBox.Size = new System.Drawing.Size(160, 24);
            this.gerente_comboBox.TabIndex = 2;
            // 
            // num_fical_TextBox
            // 
            this.num_fical_TextBox.Location = new System.Drawing.Point(36, 57);
            this.num_fical_TextBox.Name = "num_fical_TextBox";
            this.num_fical_TextBox.Size = new System.Drawing.Size(134, 22);
            this.num_fical_TextBox.TabIndex = 3;
            // 
            // addCond_button
            // 
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
            this.cancel_button.Location = new System.Drawing.Point(281, 270);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(85, 23);
            this.cancel_button.TabIndex = 5;
            this.cancel_button.Text = "Cancelar";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // gerentes_listBox
            // 
            this.gerentes_listBox.FormattingEnabled = true;
            this.gerentes_listBox.ItemHeight = 16;
            this.gerentes_listBox.Location = new System.Drawing.Point(247, 12);
            this.gerentes_listBox.Name = "gerentes_listBox";
            this.gerentes_listBox.Size = new System.Drawing.Size(236, 228);
            this.gerentes_listBox.TabIndex = 6;
            // 
            // AddCondominio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 303);
            this.Controls.Add(this.gerentes_listBox);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.addCond_button);
            this.Controls.Add(this.num_fical_TextBox);
            this.Controls.Add(this.gerente_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCondominio";
            this.Text = "AddCondominio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox gerente_comboBox;
        private System.Windows.Forms.TextBox num_fical_TextBox;
        private System.Windows.Forms.Button addCond_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.ListBox gerentes_listBox;
    }
}