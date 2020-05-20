namespace BD_Proj
{
    partial class Casas
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
            this.lb_casas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_casas
            // 
            this.lb_casas.AutoSize = true;
            this.lb_casas.Location = new System.Drawing.Point(371, 221);
            this.lb_casas.Name = "lb_casas";
            this.lb_casas.Size = new System.Drawing.Size(45, 17);
            this.lb_casas.TabIndex = 0;
            this.lb_casas.Text = "casas";
            // 
            // Casas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_casas);
            this.Name = "Casas";
            this.Text = "Casas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_casas;
    }
}