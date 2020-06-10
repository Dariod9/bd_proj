namespace BD_Proj
{
    partial class addPessoa
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
            this.addProp = new System.Windows.Forms.Button();
            this.addInq = new System.Windows.Forms.Button();
            this.addFiador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(254, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Classe de utilizador";
            // 
            // addProp
            // 
            this.addProp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProp.Location = new System.Drawing.Point(74, 121);
            this.addProp.Name = "addProp";
            this.addProp.Size = new System.Drawing.Size(144, 52);
            this.addProp.TabIndex = 1;
            this.addProp.Text = "Proprietário";
            this.addProp.UseVisualStyleBackColor = true;
            this.addProp.Click += new System.EventHandler(this.addProp_Click);
            // 
            // addInq
            // 
            this.addInq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addInq.Location = new System.Drawing.Point(281, 121);
            this.addInq.Name = "addInq";
            this.addInq.Size = new System.Drawing.Size(128, 52);
            this.addInq.TabIndex = 2;
            this.addInq.Text = "Inquilino";
            this.addInq.UseVisualStyleBackColor = true;
            this.addInq.Click += new System.EventHandler(this.addInq_Click);
            // 
            // addFiador
            // 
            this.addFiador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFiador.Location = new System.Drawing.Point(485, 121);
            this.addFiador.Name = "addFiador";
            this.addFiador.Size = new System.Drawing.Size(135, 52);
            this.addFiador.TabIndex = 3;
            this.addFiador.Text = "Fiador";
            this.addFiador.UseVisualStyleBackColor = true;
            this.addFiador.Click += new System.EventHandler(this.addFiador_Click);
            // 
            // addPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 240);
            this.Controls.Add(this.addFiador);
            this.Controls.Add(this.addInq);
            this.Controls.Add(this.addProp);
            this.Controls.Add(this.label1);
            this.Name = "addPessoa";
            this.Text = "Adicionar Pessoa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addProp;
        private System.Windows.Forms.Button addInq;
        private System.Windows.Forms.Button addFiador;
    }
}