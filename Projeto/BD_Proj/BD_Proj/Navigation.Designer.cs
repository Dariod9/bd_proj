namespace BD_Proj
{
    partial class Navigation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Navigation));
            this.casasBt = new System.Windows.Forms.Button();
            this.inquilinoBt = new System.Windows.Forms.Button();
            this.menuLabel = new System.Windows.Forms.Label();
            this.navpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.condominio_bt = new System.Windows.Forms.Button();
            this.contratos_bt = new System.Windows.Forms.Button();
            this.empresa_bt = new System.Windows.Forms.Button();
            this.obras_bt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.navpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // casasBt
            // 
            this.casasBt.Location = new System.Drawing.Point(12, 41);
            this.casasBt.Name = "casasBt";
            this.casasBt.Size = new System.Drawing.Size(96, 23);
            this.casasBt.TabIndex = 0;
            this.casasBt.Text = "Casas";
            this.casasBt.UseVisualStyleBackColor = true;
            this.casasBt.Click += new System.EventHandler(this.casasBt_Click);
            // 
            // inquilinoBt
            // 
            this.inquilinoBt.Location = new System.Drawing.Point(12, 79);
            this.inquilinoBt.Name = "inquilinoBt";
            this.inquilinoBt.Size = new System.Drawing.Size(96, 44);
            this.inquilinoBt.TabIndex = 1;
            this.inquilinoBt.Text = "Dados Pessoais";
            this.inquilinoBt.UseVisualStyleBackColor = true;
            this.inquilinoBt.Click += new System.EventHandler(this.inquilinoBt_Click);
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Location = new System.Drawing.Point(12, 9);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(43, 17);
            this.menuLabel.TabIndex = 2;
            this.menuLabel.Text = "Menu";
            // 
            // navpanel
            // 
            this.navpanel.Controls.Add(this.label1);
            this.navpanel.Controls.Add(this.label2);
            this.navpanel.Controls.Add(this.pictureBox1);
            this.navpanel.Controls.Add(this.button1);
            this.navpanel.Location = new System.Drawing.Point(114, 12);
            this.navpanel.Name = "navpanel";
            this.navpanel.Size = new System.Drawing.Size(798, 497);
            this.navpanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dário Matos (89288) e Pedro Almeida (89205)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Projeto de Base de Dados";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(182, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 314);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 90);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check Connection to DB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // condominio_bt
            // 
            this.condominio_bt.Location = new System.Drawing.Point(11, 136);
            this.condominio_bt.Name = "condominio_bt";
            this.condominio_bt.Size = new System.Drawing.Size(97, 23);
            this.condominio_bt.TabIndex = 1;
            this.condominio_bt.Text = "Condominios";
            this.condominio_bt.UseVisualStyleBackColor = true;
            this.condominio_bt.Click += new System.EventHandler(this.condominio_bt_Click);
            // 
            // contratos_bt
            // 
            this.contratos_bt.Location = new System.Drawing.Point(11, 177);
            this.contratos_bt.Name = "contratos_bt";
            this.contratos_bt.Size = new System.Drawing.Size(93, 23);
            this.contratos_bt.TabIndex = 5;
            this.contratos_bt.Text = "Contratos";
            this.contratos_bt.UseVisualStyleBackColor = true;
            this.contratos_bt.Click += new System.EventHandler(this.contratos_bt_Click);
            // 
            // empresa_bt
            // 
            this.empresa_bt.Location = new System.Drawing.Point(11, 219);
            this.empresa_bt.Name = "empresa_bt";
            this.empresa_bt.Size = new System.Drawing.Size(93, 34);
            this.empresa_bt.TabIndex = 6;
            this.empresa_bt.Text = "Empresas";
            this.empresa_bt.UseVisualStyleBackColor = true;
            this.empresa_bt.Click += new System.EventHandler(this.empresa_bt_Click);
            // 
            // obras_bt
            // 
            this.obras_bt.Location = new System.Drawing.Point(15, 259);
            this.obras_bt.Name = "obras_bt";
            this.obras_bt.Size = new System.Drawing.Size(75, 23);
            this.obras_bt.TabIndex = 7;
            this.obras_bt.Text = "Obras";
            this.obras_bt.UseVisualStyleBackColor = true;
            this.obras_bt.Click += new System.EventHandler(this.obras_bt_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 483);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "fecha";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 522);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.obras_bt);
            this.Controls.Add(this.empresa_bt);
            this.Controls.Add(this.contratos_bt);
            this.Controls.Add(this.condominio_bt);
            this.Controls.Add(this.navpanel);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.inquilinoBt);
            this.Controls.Add(this.casasBt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Navigation";
            this.Text = "Navigation";
            this.navpanel.ResumeLayout(false);
            this.navpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button casasBt;
        private System.Windows.Forms.Button inquilinoBt;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Panel navpanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button condominio_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button contratos_bt;
        private System.Windows.Forms.Button empresa_bt;
        private System.Windows.Forms.Button obras_bt;
        private System.Windows.Forms.Button button2;
    }
}