namespace BD_Proj
{
    partial class addContrato
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
            this.button_addRenda = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_addRenda
            // 
            this.button_addRenda.Location = new System.Drawing.Point(169, 206);
            this.button_addRenda.Name = "button_addRenda";
            this.button_addRenda.Size = new System.Drawing.Size(134, 56);
            this.button_addRenda.TabIndex = 0;
            this.button_addRenda.Text = "Contrato de Renda";
            this.button_addRenda.UseVisualStyleBackColor = true;
            this.button_addRenda.Click += new System.EventHandler(this.button_addRenda_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(490, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "Contrato de Condomínio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de Contrato";
            // 
            // addContrato
            // 
            this.ClientSize = new System.Drawing.Size(796, 391);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_addRenda);
            this.Name = "addContrato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

     
        private System.Windows.Forms.Button button_addRenda;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}